namespace TestProg
{
    internal class Worker2 : Robotiaga
    {
        public Worker2(string name)
        {
            Name = name;
        }

        public override double MonthSalary()
        {
            return 4000.0;
        }
    }
}