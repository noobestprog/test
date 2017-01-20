using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace TestProg
{
    [Serializable]
    [XmlRoot("ClassContainer")]
    public class ClassContainer
    {
        public ClassContainer()
        {
            MyContainer = new List<Robotiaga>();
        }

        [XmlArray("Robotiaga")]
        [XmlArrayItem("Robotiaga", typeof(Robotiaga))]
        public List<Robotiaga> MyContainer { get; set; }

        public IEnumerable<Robotiaga> SortList()
            //1  public List<Robotiaga> SortList(List<Robotiaga> ml)
        {
            // ml.Sort(delegate(Robotiaga r1, Robotiaga r2) { return r1.MonthSalary().CompareTo(r2.MonthSalary()); });
            /*      var sortedList = ml.OrderByDescending(o => o.MonthSalary()).ToList();
            return sortedList;*/
            var sortedList = from element in MyContainer
                orderby element.MonthSalary() descending, element.Name
                select element;


            //1   return (List<Robotiaga>) sortedList;
            return sortedList;
        }

        public void ShowListNamesAndSalaries()
        {
            SortList();
            if (MyContainer.Capacity ==0) Console.WriteLine("List is empty");
            foreach (var r in MyContainer)
                Console.WriteLine("{0} has a {1} salary", r.Name, r.MonthSalary());
        }

        public void ShowFirstFiveNames()
        {
            SortList();
            if (MyContainer.Capacity < 5)
            {
                foreach (var robotiaga in MyContainer)
                    Console.WriteLine(robotiaga.Name);
            }
            else
            {
                var firstFiveItems = MyContainer.Take(5);
                foreach (var r in firstFiveItems)
                    Console.WriteLine(r.Name);
            }
        }

        public void ShowLastThreeNames()
        {
            SortList();
            if (MyContainer.Capacity < 3)
            {
                foreach (var robotiaga in MyContainer)
                    Console.WriteLine(robotiaga.Name);
            }
            else
            {
                var lastThreeItems = Enumerable.Reverse(MyContainer).Take(3).Reverse().ToList();
                foreach (var r in lastThreeItems)
                    Console.WriteLine(r.Name);
            }
        }
        public  void ReadFromXML()
        {
               ClassContainer mylist = null;
               var path = "C:\\Users\\Dmytro\\documents\\visual studio 2015\\Projects\\NormalTests\\TestProg\\TestProg\\Input.xml";

               var serializer = new XmlSerializer(typeof(ClassContainer));

               var reader = new StreamReader(path);
               mylist = (ClassContainer)serializer.Deserialize(reader);

               reader.Close();
           

        }
    }
}