namespace Liskov
{
    public abstract class Employee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }

        public  Employee(string fullname, int hoursWorked, int ExtraHours)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        public abstract decimal CalculateSalary();
    }
}