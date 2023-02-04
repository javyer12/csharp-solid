namespace InterfaceSegregation
{
      // como en c# no se puede heredar de multiples clases, entonces en una interfaz podemos hacer que implemente de otras interfaces
      public interface IActivities : IWorkingActivities, IDesignActivities, IDeveloperActivities, ITestActivities
      {

      }
}