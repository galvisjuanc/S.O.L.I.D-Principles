namespace OpenClose
{
    public class EmployeePartTime : Employee
    {
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