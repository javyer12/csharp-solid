using SingleResponsability;

StudentRepository studentRepository = new();

var student = studentRepository.GetAll();
// ExportHelpers exportHelper = new();
// exportHelper.ExportHelper(student, "Students");

ExportHelper<Student> studentExport = new();
studentExport.ExportToCSV(studentRepository.GetAll());
Console.WriteLine("Proceso Completado");