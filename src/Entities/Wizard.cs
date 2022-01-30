namespace ProjetoPOO.src.Entities
{
    public class Wizard:Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Arma = "Magia";
        }
    }
}