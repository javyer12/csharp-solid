namespace OpenClose
{
      // EmployeeFullTime: Employees esto significa que EmployeeFullTime hereda de 
      //Employees, que es una clase abstracta.
      public class EmployeeFullTime : Employees
      {
            public EmployeeFullTime(string fullname, int hoursWorked)
            {
                  Fullname = fullname;
                  HoursWorked = hoursWorked;
            }

            public override decimal CalculateSalaryMonthly()
            {
                  decimal hourValue = 30000M;
                  decimal salary = hourValue * HoursWorked;

                  return salary;
            }

      }
}