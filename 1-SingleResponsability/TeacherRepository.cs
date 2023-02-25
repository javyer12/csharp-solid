namespace SingleResponsability
{
      public class TeacherRepository
      {

            private static FakeStorage<Teachers> storage;

            public TeacherRepository()
            {
                  storage = new(); //investigar new()
                  initData();
            }

            public void initData()
            {
                  storage.Add(new Teachers(1, "Jules Rodriguez", new List<string> { "Math", "chemistry", "Computing" }));
                  storage.Add(new Teachers(2, "Josep Bartomeu", new List<string> { "Spanish", "History" }));
            }

            public IEnumerable<Teachers> GetAllTeachers()
            {
                  return storage.GetAll();
            }
      }

}