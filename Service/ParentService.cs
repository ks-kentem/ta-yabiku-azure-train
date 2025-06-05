namespace WebApplication2.models
{
    public class ParentService
    {
        public virtual string GetGreeting() => "Hello from ParentService";
    }

    public interface IChildService
    {
        string GetGreeting();
    }

    public class ChildService : ParentService, IChildService
    {
        public override string GetGreeting()
        {
            return "Hello from ChildService";
        }
    }
}
