namespace OpenClose;
public abstract class Employees
{
      public string Fullname { get; set; }
      public int HoursWorked { get; set; }

      public abstract decimal CalculateSalaryMonthly();
}