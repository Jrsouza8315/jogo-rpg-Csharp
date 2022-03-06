using System;

namespace jogo_RPG_C#.src.Entities
{
    public abstract class Hero
    {

        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = level;
            this.HeroType = HeroType;
        }

        public Arus (){

        }

        public string Name; 
        public int level;
        public string HeroType;

        public override string ToString(){
            return this.name + " " + this.Level + " " + this.HeroType;
        }
        
        public virtual string Attack(){
            return this.name + "Lançou Magia!";
        }
    }
}