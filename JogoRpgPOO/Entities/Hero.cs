namespace JogoRpgPOO.Entities
{
    public class Hero
    {
        public string Name { get;  set; }
        public int Level { get; set; }
        public string HeroType{ get; set; }

        public Hero(string name, int level , string herotype)
        {
            Name = name;
            Level = level;
            HeroType = herotype;
        }

        public override string ToString()
        {
            return Name + " " + Level + " " + HeroType;
        }

        public virtual string Attack()
        {
            return Name + " " + "Atacou com sua espada";
        }
    }
}
