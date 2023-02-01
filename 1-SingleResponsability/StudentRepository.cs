
namespace SingleResponsability
{
      public class StudentRepository
      {
            private static FakeStorage<Student> storage;

            public StudentRepository()
            {
                  storage = new();
                  InitData();
            }

            private void InitData()
            {
                  storage.Add(new Student(1, "Pepito Pérez", new List<double>() { 3, 4.5 }));
                  storage.Add(new Student(2, "Mariana Lopera", new List<double>() { 4, 5 }));
                  storage.Add(new Student(3, "José Molina", new List<double>() { 2, 3 }));
                  storage.Add(new Student(4, "José Villafranca", new List<double>() { 21.7, 32 }));
                  storage.Add(new Student(5, "Leo Molina", new List<double>() { 23.2, 3.5 }));
            }

            public IEnumerable<Student> GetAll()
            {
                  return storage.GetAll();
            }
      }
}