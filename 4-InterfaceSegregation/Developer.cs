namespace InterfaceSegregation
{
      //la clase Developer implementa la interfaz IActivities
      public class Developer : IWorkingActivities, IDeveloperActivities
      {
            public Developer()
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

            public void Develop()
            {
                  Console.WriteLine("I'm developing the functionalities required");
            }

      }
}