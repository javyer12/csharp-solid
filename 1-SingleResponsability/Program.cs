using SingleResponsability;

StudentRepository studentRepository = new();

var student = studentRepository.GetAll();
// ExportHelpers exportHelper = new();
// exportHelper.ExportHelper(student, "Students");
ExportHelper<Student> studentExport = new();
studentExport.ExportToCSV(student);
Console.WriteLine("Proceso Completado");


// new way with teacher data
TeacherRepository teacherRepository = new();
ExportHelper<Teachers> teacherExport = new();
teacherExport.ExportToCSV(teacherRepository.GetAllTeachers());
Console.WriteLine("Teacher Data Exported");
