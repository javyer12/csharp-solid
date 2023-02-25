namespace SingleResponsability
{
      public class Teachers
      {
            public int id { get; set; }
            public string FullName { get; set; }
            public List<string> Subjects { get; set; }

            public Teachers()
            {
                  this.FullName = string.Empty;
                  this.Subjects = new List<string>();
            }

            public Teachers(int id, string fullName, List<string> subjects)
            {
                  this.id = id;
                  this.FullName = fullName;
                  this.Subjects = subjects;
            }
      }
}