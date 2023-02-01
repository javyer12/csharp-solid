namespace OpenClose
{
      // EmployeeFullTime: Employees esto significa que EmployeeFullTime hereda de 
      //Employees, que es una clase abstracta.
      public class EmployeeContractor : Employees
      {
            public EmployeeContractor(string fullname, int hoursWorked)
            {
                  Fullname = fullname;
                  HoursWorked = hoursWorked;
            }

            public override decimal CalculateSalaryMonthly()
            {
                  decimal hourValue = 10000M;
                  decimal salary = hourValue * HoursWorked;

                  return salary;
            }

      }
}