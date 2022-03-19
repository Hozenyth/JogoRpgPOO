namespace JogoRpgPOO.Entities
{
   public class Wizard : Hero
    {
        public Wizard(string name, int level, string herotype) : base(name, level, herotype)
        {
        }

        public override string Attack()
        {
            return Name + " " + "Atacou com a sua espada";
        }

        public string Attack2( int bonus)
        {
            return Name + " " + "Lançou magia";
        }
    }
}
