using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace TestProg
{
    public static class XmlHelper
    {
        public static ClassContainer ReadFromXML()
        {
            ClassContainer mylist = null;
            var path = "C:\\Users\\Dmytro\\documents\\visual studio 2015\\Projects\\NormalTests\\TestProg\\TestProg\\Input.xml";

            var serializer = new XmlSerializer(typeof(ClassContainer));

            var reader = new StreamReader(path);
            mylist = (ClassContainer) serializer.Deserialize(reader);
            reader.Close();
            return mylist;
        }
    }
}