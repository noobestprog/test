namespace TestProg
{
    public class Worker1 : Robotiaga
    {
        public Worker1(string name, double sph)
        {
            Name = name;
            SalaryPerHour = sph;
        }


        public override double MonthSalary()
        {

            return 20.8 * 8 * SalaryPerHour;
        }
    }
}