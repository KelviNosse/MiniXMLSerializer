using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Serializer.Logic;

namespace Serializer.Tests
{
    [TestClass]
    public class SerializerTests
    {
        //Tests for Numeric Values
        [TestMethod]
        public void Serialize_Int()
        {
            var serializer = new XmlSerializer(2);
            int number = 3;
            var xml = serializer.Serialize(number);
            Assert.AreEqual("<?xml version='2.0'?>\n<int>3</int>", xml, "Can't Serialize Int");

        }
        [TestMethod]
        public void Serialize_UInt()
        {
            var serializer = new XmlSerializer(2);
            uint number = 3;
            var xml = serializer.Serialize(number);
            Assert.AreEqual("<?xml version='2.0'?>\n<uint>3</uint>", xml, "Can't Serialize UInt");

        }

        [TestMethod]
        public void Serialize_Long()
        {
            var serializer = new XmlSerializer(2);
            long number = 3302;
            var xml = serializer.Serialize(number);
            Assert.AreEqual("<?xml version='2.0'?>\n<long>3302</long>", xml, "Can't Serialize Long");

        }

        [TestMethod]
        public void Serialize_ULong()
        {
            var serializer = new XmlSerializer(2);
            ulong number = 332;
            var xml = serializer.Serialize(number);
            Assert.AreEqual("<?xml version='2.0'?>\n<ulong>332</ulong>", xml, "Can't Serialize ULong");

        }

        [TestMethod]
        public void Serialize_Short()
        {
            var serializer = new XmlSerializer(2);
            short number = -3;
            var xml = serializer.Serialize(number);
            Assert.AreEqual("<?xml version='2.0'?>\n<short>-3</short>", xml, "Can't Serialize Short");

        }

        [TestMethod]
        public void Serialize_UShort()
        {
            var serializer = new XmlSerializer(2);
            ushort number = 3;
            var xml = serializer.Serialize(number);
            Assert.AreEqual("<?xml version='2.0'?>\n<ushort>3</ushort>", xml, "Can't Serialize Short");

        }

        [TestMethod]
        public void Serialize_Byte()
        {
            var serializer = new XmlSerializer(2);
            byte number = 2;
            var xml = serializer.Serialize(number);
            Assert.AreEqual("<?xml version='2.0'?>\n<byte>2</byte>", xml, "Can't Serialize Byte");

        }

        [TestMethod]
        public void Serialize_SByte()
        {
            var serializer = new XmlSerializer(2);
            sbyte number = 2;
            var xml = serializer.Serialize(number);
            Assert.AreEqual("<?xml version='2.0'?>\n<sbyte>2</sbyte>", xml, "Can't Serialize SByte");

        }

        [TestMethod]
        public void Serialize_Bool()
        {
            var serializer = new XmlSerializer(2);
            bool number = true;
            var xml = serializer.Serialize(number);
            Assert.AreEqual("<?xml version='2.0'?>\n<bool>True</bool>", xml, "Can't Serialize Bool");

        }

        [TestMethod]
        public void Serialize_Float()
        {
            var serializer = new XmlSerializer(2);
            float number = 200;
            var xml = serializer.Serialize(number);
            Assert.AreEqual("<?xml version='2.0'?>\n<float>200</float>", xml, "Can't Serialize Float");

        }

        [TestMethod]
        public void Serialize_Double()
        {
            var serializer = new XmlSerializer(2);
            double number = 2.5;
            var xml = serializer.Serialize(number);
            Assert.AreEqual("<?xml version='2.0'?>\n<double>2.5</double>", xml, "Can't Serialize Double");

        }

        [TestMethod]
        public void Serialize_Decimal()
        {
            var serializer = new XmlSerializer(2);
            decimal number = 2;
            var xml = serializer.Serialize(number);
            Assert.AreEqual("<?xml version='2.0'?>\n<decimal>2</decimal>", xml, "Can't Serialize Decimal");

        }

        //End of Tests for Simple Numeric Values
        //Tests for Array of Numeric Values
        [TestMethod]
        public void Serialize_Int_Array()
        {
            var serializer = new XmlSerializer(2);
            int[] number = new []{5, 6, 3};
            var xml = serializer.Serialize(number);
            Assert.AreEqual("<?xml version='2.0'?>\n<array>\n<int>5</int>\n<int>6</int>\n<int>3</int>\n</array>", xml, "Can't Serialize Int Array");

        }
        [TestMethod]
        public void Serialize_UInt_Array()
        {
            var serializer = new XmlSerializer(2);
            uint[] number = new uint[] { 5, 6, 3 };
            var xml = serializer.Serialize(number);
            Assert.AreEqual("<?xml version='2.0'?>\n<array>\n<uint>5</uint>\n<uint>6</uint>\n<uint>3</uint>\n</array>", xml, "Can't Serialize UInt Array");

        }

        [TestMethod]
        public void Serialize_Long_Array()
        {
            var serializer = new XmlSerializer(2);
            var xml = serializer.Serialize(new long[]{5,6,3});
            Assert.AreEqual("<?xml version='2.0'?>\n<array>\n<long>5</long>\n<long>6</long>\n<long>3</long>\n</array>", xml, "Can't Serialize Long Array");

        }

        [TestMethod]
        public void Serialize_ULong_Array()
        {
            var serializer = new XmlSerializer(2);
            var xml = serializer.Serialize(new ulong[] { 5, 6, 3 });
            Assert.AreEqual("<?xml version='2.0'?>\n<array>\n<ulong>5</ulong>\n<ulong>6</ulong>\n<ulong>3</ulong>\n</array>", xml, "Can't Serialize ULong Array");

        }

        [TestMethod]
        public void Serialize_Short_Array()
        {
            var serializer = new XmlSerializer(2);
            var xml = serializer.Serialize(new short[]{7,4,3});
            Assert.AreEqual("<?xml version='2.0'?>\n<array>\n<short>7</short>\n<short>4</short>\n<short>3</short>\n</array>", xml, "Can't Serialize Short Array");

        }

        [TestMethod]
        public void Serialize_UShort_Array()
        {
            var serializer = new XmlSerializer(2);
            var xml = serializer.Serialize(new ushort[]{4,5,2});
            Assert.AreEqual("<?xml version='2.0'?>\n<array>\n<ushort>4</ushort>\n<ushort>5</ushort>\n<ushort>2</ushort>\n</array>", xml, "Can't Serialize UShort Array");

        }

        [TestMethod]
        public void Serialize_Byte_Array()
        {
            var serializer = new XmlSerializer(2);
            var xml = serializer.Serialize(new byte[]{3,5,6});
            Assert.AreEqual("<?xml version='2.0'?>\n<array>\n<byte>3</byte>\n<byte>5</byte>\n<byte>6</byte>\n</array>", xml, "Can't Serialize Byte Array");

        }

        [TestMethod]
        public void Serialize_SByte_Array()
        {
            var serializer = new XmlSerializer(2);
            var xml = serializer.Serialize(new sbyte[] { 3, 5, 6 });
            Assert.AreEqual("<?xml version='2.0'?>\n<array>\n<sbyte>3</sbyte>\n<sbyte>5</sbyte>\n<sbyte>6</sbyte>\n</array>", xml, "Can't Serialize SByte Array");

        }

        [TestMethod]
        public void Serialize_Bool_Array()
        {
            var serializer = new XmlSerializer(2);
            var xml = serializer.Serialize(new bool[]{false, true, true});
            Assert.AreEqual("<?xml version='2.0'?>\n<array>\n<bool>False</bool>\n<bool>True</bool>\n<bool>True</bool>\n</array>", xml, "Can't Serialize Bool Array");

        }

        [TestMethod]
        public void Serialize_Float_Array()
        {
            var serializer = new XmlSerializer(2);
            var xml = serializer.Serialize(new float[]{200, 500, 394});
            Assert.AreEqual("<?xml version='2.0'?>\n<array>\n<float>200</float>\n<float>500</float>\n<float>394</float>\n</array>", xml, "Can't Serialize Float Array");

        }

        [TestMethod]
        public void Serialize_Double_Array()
        {
            var serializer = new XmlSerializer(2);
            var xml = serializer.Serialize(new double[]{2.6, 6.3, 9.5});
            Assert.AreEqual("<?xml version='2.0'?>\n<array>\n<double>2.6</double>\n<double>6.3</double>\n<double>9.5</double>\n</array>", xml, "Can't Serialize Double Array");

        }

        [TestMethod]
        public void Serialize_Decimal_Array()
        {
            var serializer = new XmlSerializer(2);
            var xml = serializer.Serialize(new decimal[]{2, 6, 9});
            Assert.AreEqual("<?xml version='2.0'?>\n<array>\n<decimal>2</decimal>\n<decimal>6</decimal>\n<decimal>9</decimal>\n</array>", xml, "Can't Serialize Decimal Array");

        }

        //Tests for Strings
        [TestMethod]
        public void Serialize_String()
        {
            var serializer = new XmlSerializer(2);
            string str = "ponys";
            var xml = serializer.Serialize(str);
            Assert.AreEqual("<?xml version='2.0'?>\n<string>ponys</string>", xml, "Can't Serialize String");
        }

        [TestMethod]
        public void Serialize_String_Array()
        {
            var serializer = new XmlSerializer(2);
            var xml = serializer.Serialize(new string[]{"ponys", "arcoiris", "narwhals"});
            Assert.AreEqual("<?xml version='2.0'?>\n<array>\n<string>ponys</string>\n<string>arcoiris</string>\n<string>narwhals</string>\n</array>", xml, "Can't Serialize String Array");
        }

        //Tests for Date Time

        [TestMethod]
        public void Serialize_DateTime()
        {
            var serializer = new XmlSerializer(2);
            string now = DateTime.Now.ToString();
            var xml = serializer.Serialize(DateTime.Now);
            Assert.AreEqual("<?xml version='2.0'?>\n<DateTime>" + now + "</DateTime>", xml, "Can't Serialize DateTime");
        }

        [TestMethod]
        public void Serialize_DateTime_Array()
        {
            var serializer = new XmlSerializer(2);
            string now = DateTime.Now.ToString();
            string today = DateTime.Today.ToString();
            var xml = serializer.Serialize(new DateTime []{DateTime.Now, DateTime.Today});
            Assert.AreEqual("<?xml version='2.0'?>\n<DateArray>\n<DateTime>" + now + "</DateTime>\n<DateTime>" + today + "</DateTime>\n</DateArray>", xml, "Can't Serialize DateTime Array");
        }

        //Tests for Classes
        [TestMethod]

        public void Serialize_Class()
        {
            var serializer = new XmlSerializer(2);
            var xml = serializer.Serialize(new Person(12, "Hoxton"));
            Assert.AreEqual("<?xml version='2.0'?>\n<Person>\n<Age>\n<int>12</int>\n</Age>\n<Name>\n<string>Hoxton</string>\n</Name>\n</Person>", xml, "Can't Serialize Class");

        }

        [TestMethod]

        public void Serialize_Class_Array()
        {
            var serializer = new XmlSerializer(2);
            var xml = serializer.Serialize(new Person[]{new Person(6, "DogeMan"), new Person(15, "Mario"), new Person(8, "Spidey")});
            Assert.AreEqual("<?xml version='2.0'?>\n<Person>\n<Age>\n<int>6</int>\n</Age>\n<Name>\n<string>DogeMan</string>\n</Name>\n</Person>" +
                            "\n<Person>\n<Age>\n<int>15</int>\n</Age>\n<Name>\n<string>Mario</string>\n</Name>\n</Person>" +
                            "\n<Person>\n<Age>\n<int>8</int>\n</Age>\n<Name>\n<string>Spidey</string>\n</Name>\n</Person>", xml, "Can't Serialize Class");

        }

        [TestMethod]

        public void Serialize_CustomAttribute_Class()
        {
            var serializer = new XmlSerializer(2);
            var xml = serializer.Serialize(new Kitten("Chubi", new Person(20, "DogeMan"), true));
            Assert.AreEqual("<?xml version='2.0'?>\n<Kitten>\n<Name>" +
                            "\n<string>Chubi</string>\n</Name>\n<Owner>\n<Person>" +
                            "\n<Age>\n<int>20</int>\n</Age>\n<Name>\n<string>DogeMan</string>" +
                            "\n</Name>\n</Person>\n</Owner>\n<Hunger>\n<bool>True</bool>\n" +
                            "</Hunger>\n</Kitten>", xml, "Can't Serialize Class");

        }

        [TestMethod]

        public void Serialize_CustomAttribute_Class_Array()
        {
            var serializer = new XmlSerializer(2);
            var xml = serializer.Serialize(new Kitten[]
            {
                new Kitten("Chubi", new Person(20, "DogeMan"), true),
                new Kitten("Mimi", new Person(12, "Goku"), false),
                new Kitten("Darker", new Person(30, "Batman"), true)
            });
            Assert.AreEqual("<?xml version='2.0'?>\n<Kitten>" +
                            "\n<Name>\n<string>Chubi</string>" +
                            "\n</Name>\n<Owner>\n<Person>\n<Age>\n<int>20</int>" +
                            "\n</Age>\n<Name>\n<string>DogeMan</string>" +
                            "\n</Name>\n</Person>\n</Owner>\n<Hunger>" +
                            "\n<bool>True</bool>\n</Hunger>" +
                            "\n</Kitten>\n<Kitten>\n<Name>\n<string>Mimi</string>\n</Name>\n<Owner>" +
                            "\n<Person>\n<Age>\n<int>12</int>\n</Age>" +
                            "\n<Name>\n<string>Goku</string>\n</Name>\n</Person>" +
                            "\n</Owner>\n<Hunger>\n<bool>False</bool>\n</Hunger>" +
                            "\n</Kitten>\n<Kitten>\n<Name>\n<string>Darker</string>" +
                            "\n</Name>\n<Owner>\n<Person>\n<Age>\n<int>30</int>\n</Age>" +
                            "\n<Name>\n<string>Batman</string>\n</Name>\n</Person>" +
                            "\n</Owner>\n<Hunger>\n<bool>True</bool>\n</Hunger>\n</Kitten>", xml, "Can't Serialize Class");

        }

    }
}
