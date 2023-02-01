namespace OpenClose
{
      public class EmployeePartTime : Employees
      {
            public EmployeePartTime(string fullname, int hoursWorked)
            {
                  Fullname = fullname;
                  HoursWorked = hoursWorked;
            }

            public override decimal CalculateSalaryMonthly()
            {
                  decimal hourValue = 20000M;
                  decimal salary = hourValue * HoursWorked;
                  if (HoursWorked > 160)
                  {
                        decimal effortCompensation = 5000M;
                        int extraDays = HoursWorked - 160;
                        return salary += effortCompensation * extraDays;
                  }
                  return salary;
            }
      }
}