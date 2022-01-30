namespace ProjetoPOO.src.Entities
{
    public class Knight:Hero
    {
       public Knight(string Name, int Level, string HeroType)
        {
           this.Name = Name;
           this.Level = Level;
           this.HeroType = HeroType;
           this.Arma = "a Espada"; 
        }
    }
}