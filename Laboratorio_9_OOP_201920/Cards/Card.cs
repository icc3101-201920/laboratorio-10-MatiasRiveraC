using Laboratorio_9_OOP_201920.Enums;
using Laboratorio_9_OOP_201920.Interfaces;
using System;
using System.Collections.Generic;

namespace Laboratorio_9_OOP_201920.Cards
{
    [Serializable]
    public abstract class Card : ICharacteristics
    {
        //Atributos
        protected string name;
        protected EnumType type;
        protected EnumEffect effect;

        //Constructor
        public Card()
        {

        }

        //Propiedades
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public EnumType Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }
        public EnumEffect CardEffect
        {
            get
            {
                return this.effect;
            }
            set
            {
                this.effect = value;
            }
        }

        public abstract List<string> GetCharacteristics();
    }
}
