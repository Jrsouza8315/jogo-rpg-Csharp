namespace jogo_RPG_C#.src.Entities
{

    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
            return this.name + "Lançou Magia";
    }

        public string Attack (int Bonus){

            if (Bonus > 6)
            {
                return this.Name + " Lançou Magia super efetiva com bonus de " + Bonus;
            }else{
                return this.Name + "Lançou magia com força fraca com bonus de" + Bonus;
            }

            
        }
}