namespace ProjetoPOO.src.Entities
{
    public class Ninja:Hero
    {
        public Ninja(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Arma = "Artes Marciais";
        }
    }
}