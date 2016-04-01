using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp;

namespace Serializer.Logic
{
    public class XmlSerializer
    {
        private string _xml;
        private readonly XmlStructure _structure;

        public XmlSerializer(int version)
        {
            _structure = new XmlStructure(version);
            _xml = _structure.InitTag;
        }

        private string GetSimpleTypeName(Object o)
        {
            var provider = new CSharpCodeProvider();
            var typeRef = new CodeTypeReference(o.GetType());
            string typeName = provider.GetTypeOutput(typeRef);

            return typeName;
        }

        private string GetXMLName(object[] attrs, string defaultname)
        {
            foreach (var attr in attrs)
            {
                XmlName xattr = attr as XmlName;

                if (xattr != null) return xattr.Name;
            }

            return defaultname;
        }

        public string SerializeNumber(Object number)
        {
            string typeName = GetSimpleTypeName(number);
            _structure.SetTag(typeName);
            if (number.GetType().IsArray)
            {
                _xml += "\n<array>";
                for (var i = 0; i < ((Array) number).Length; i++)
                {
                    _xml = SerializeNumber(((Array) number).GetValue(i));
                }

                _xml += "\n</array>";
            }
            else
            {
                _xml += "\n" + _structure.Tag.Insert(typeName.Length + 2, number.ToString());

            }
            return _xml;
                
        }

        public string Serialize(Object obj)
        {

                if (IsNumeric(obj) || IsNumericArray(obj))
                    return SerializeNumber(obj);
                else if (obj is string || obj is string[])
                    return SerializeString(obj);
                else if (obj is DateTime || obj is DateTime[])
                    return SerializeDate(obj);
                else if (obj is char || obj is char[])
                    return SerializeChar(obj);
                else if (obj.GetType().IsClass)
                    return SerializeClass(obj);

            return "Can't Serialize";
        }

        private string SerializeClass(object o)
        {
            Type fieldsType = o.GetType();

            FieldInfo[] fields = fieldsType.GetFields();

            try
            {
                if (fieldsType.IsArray)
                {
                    for (int i = 0; i < ((Array) o).Length; i++)
                    {
                        _xml = SerializeClass(((Array) o).GetValue(i));
                    }
                }
                else
                {
                    _xml += "\n<" + fieldsType.Name + ">";
                    for (int i = 0; i < fields.Length; i++)
                    {
                        var attributes = fields[i].GetCustomAttributes(true);
                        _xml += "\n<" + GetXMLName(attributes, fields[i].Name) + ">";
                        _xml = Serialize(fields[i].GetValue(o));
                        _xml += "\n</" + GetXMLName(attributes, fields[i].Name) + ">";
                    }

                    _xml += "\n</" + fieldsType.Name + ">";
                }
                
            }
            catch (NullReferenceException)
            {
                return "Can't Serialize because class " + fieldsType.Name + " has null properties";
            }
            return _xml;

        }

        private string SerializeChar(object o)
        {
            return SerializeString(o);
        }

        private string SerializeDate(object o)
        {
            string typeName = GetSimpleTypeName(o);
            typeName = typeName.Substring(7);
            _structure.SetTag(typeName);
            if (o.GetType().IsArray){
                _xml += "\n<DateArray>";
                for (int i = 0; i < ((Array) o).Length; i++)
                {
                    _xml = SerializeDate(((Array) o).GetValue(i));
                }
            _xml += "\n</DateArray>";
            }
            else
            {
                string datestring = ((DateTime) o).ToString(CultureInfo.CurrentCulture);
                _xml += "\n"+_structure.Tag.Insert(typeName.Length+2, datestring);
            }

            return _xml;
        }

        private string SerializeString(object o)
        {
            string typeName = GetSimpleTypeName(o);
            _structure.SetTag(typeName);
            if (o.GetType().IsArray)
            {
                _xml += "\n<array>";
                for (var i = 0; i < ((Array) o).Length; i++)
                {
                    _xml = SerializeString(((Array) o).GetValue(i));
                }
                _xml += "\n</array>";
            }
            else
            {
                _xml += "\n" + _structure.Tag.Insert(typeName.Length + 2, o.ToString());

            }
           
            return _xml;
        }

        private static bool IsNumeric(Object obj)
        {
            if (obj is int || obj is uint
                || obj is long || obj is ulong
                || obj is double || obj is short
                || obj is ushort || obj is byte
                || obj is sbyte || obj is float
                || obj is decimal || obj is bool)
                return true;

                return false;
        }

        private static bool IsNumericArray(Object obj)
        {
            if (obj is int[] || obj is uint[]
                || obj is long[] || obj is ulong[]
                || obj is double[] || obj is short[]
                || obj is ushort[] || obj is byte[]
                || obj is sbyte[] || obj is float[]
                || obj is decimal[] || obj is bool[])
                return true;

                return false;
        }
    }
}
