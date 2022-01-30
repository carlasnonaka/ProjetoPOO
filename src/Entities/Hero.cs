namespace ProjetoPOO.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Arma = "";
        }
        public Hero()
        {
           
        }
        
        public string Name;
        public int Level;
        public string HeroType;
        public string Arma;

        public override string ToString()
        {
            return this.Name + ", no Level: " + this.Level + " sendo um " + this.HeroType;
        }

        public virtual void Poderes(int ataque, int defesa, int bonus)
        {
            System.Console.WriteLine("O Ataque escolhido foi de: " + ataque);
            System.Console.WriteLine("A Defesa escolhida foi de: " + defesa);
            System.Console.WriteLine("O Bônus  escolhido foi de: " + bonus);
        }
        public virtual string Attack() 
        {
            return this.Name + " Atacou com " + this.Arma;
        }

        public virtual string Attack(int Bonus) 
        {
            return this.Name + " atacou com " + this.Arma + " com bônus de " + Bonus + "x !";
        }



    }
}