namespace DLL_Library_NET_Project.Business
{
    public class Action
    {
        public int id { get; set; }
        public string description { get; set; }
        public virtual Acteur Acteur { get; set; }
    }
}