namespace OpenClose
{
    public class EmployeePartTime : Employee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }

        public EmployeePartTime(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        public override decimal CalculateSalaryMonthly()
        {
            throw new NotImplementedException();
        }
    }
}