namespace DLL_Library_NET_Project.Business
{
    public class ActionScenario
    {
        public int ordre { get; set; }
        public virtual Action Action { get; set; }
        public virtual Scenario Scenario { get; set; }
    }
}