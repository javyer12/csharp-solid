using OpenClose;

ShowSalaryMonthly(new List<Employees>() {
    new EmployeeFullTime("Pepito Pérez", 160),
    new EmployeeContractor("Rolex Pérez", 60),
    new EmployeePartTime("Manuel Lopera", 180)
});


void ShowSalaryMonthly(List<Employees> employees)
{
      foreach (var employee in employees)
      {
            Console.WriteLine($"Empleado: {employee.Fullname}, Pago: {employee.CalculateSalaryMonthly():C1} ");
      }

}