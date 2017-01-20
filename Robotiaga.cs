namespace TestProg
{
    public abstract class Robotiaga
    {
        [System.Xml.Serialization.XmlElement("Name")]
        public string Name { get; set; }
        [System.Xml.Serialization.XmlElement("sph")]
        public double SalaryPerHour { get; set; }

        public abstract double MonthSalary();
    }
}