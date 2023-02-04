namespace InterfaceSegregation
{
      public class Tester : IWorkingActivities, ITestActivities
      {
            public Tester()
            {
            }

            public void Plan()
            {
                  throw new ArgumentException();
            }

            public void Comunicate()
            {
                  throw new ArgumentException();
            }

            public void Test()
            {
                  throw new ArgumentException();
            }
      }
}