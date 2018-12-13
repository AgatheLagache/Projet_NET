namespace DLL_Library_NET_Project.Business
{
    public class Recette
    {
        public int id { get; set; }
        public string intitule { get; set; }
        public double prix { get; set; }
        public int temps_prepa { get; set; }
        public int temps_cuiss { get; set; }
        public int temps_repos { get; set; }
        public virtual TypeRecette TypeRecette { get; set; }
    }
}