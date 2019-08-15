using System.Collections.Generic;

namespace Parcial1_Base.Logic
{
    /// <summary>
    /// Definition for the player's avatar. Players dress up a doll to win the contest.
    /// </summary>
    public class Doll : IClonable<Doll>


    {

        public bool TieneVestido { get; protected set; }


        /// <summary>
        /// The accessories collection.
        /// </summary>
        private List<Accessory> accessories = new List<Accessory>();

        /// <summary>
        /// The doll's name
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Whether the doll can be included in the contest.
        /// </summary>
        public bool CanParticipate { get => false; }

        /// <summary>
        /// The total accessories count worn by the doll.
        /// </summary>
        public int TotalAccessories { get => Accessories.Count; }

        public int BraceletCount { get; protected set; }

        /// <summary>
        /// The total style score, affected by each worn accessory.
        /// </summary>
        public int Style { get; }

        public List<Accessory> Accessories { get => accessories; protected set => accessories = value; }

        public Doll()
        {
        }

        public Doll(string name)
        {
            Name = name;
            BraceletCount = 0;
            Style = 0;
            TieneVestido = false;


        }

        /// <summary>
        /// Removes the given accessory.
        /// </summary>
        /// <param name="a">The accessory to be removed</param>
        /// <returns>True if the accessory was being worn, then removed. False otherwise</returns>
        public bool Remove(Accessory a)
        {
            bool result = false;

            return result;
        }

        /// <summary>
        /// Makes the doll wear the given accessory
        /// </summary>
        /// <param name="a">The accessory to be worn by the doll</param>
        /// <returns>True if the doll successfully wore the accessory. False otherwise</returns>
        public bool Wear(Accessory a)
        {

            Dress vestido = Accessories[0] as Dress;

            bool resultado = false;
            int maxbrace=5;
           
            if (a is Bracelet && TieneVestido== true)
            {

                if(BraceletCount>=maxbrace)
                {
                    resultado=false;
                    
                }
                else
                {   
                    BraceletCount++;
                    Accessories.Add(a);
                    resultado=true;
                }


            }
            if(a is Dress)
            {
                if (TieneVestido == true)
                {
                    resultado=false;
                }

                else
                {
                    TieneVestido = true;
                    Accessories.Add(a);
                }
            }

            if(a is Purse)
            {

            }

            return resultado; 
        }

        /// <summary>
        /// Copies this instance attributes to a new independant one
        /// </summary>
        /// <returns>A new Doll object with the same values of this instance</returns>
        public Doll Copy()
        {
            return new Doll(Name);
        }
    }
}
