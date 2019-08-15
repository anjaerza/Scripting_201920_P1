using System.Collections.Generic;

namespace Parcial1_Base.Logic
{
    public class PageantJury
    {
        /// <summary>
        /// The contestants collection.
        /// </summary>
        private List<Doll> contestants = new List<Doll>();

        /// <summary>
        /// Returns the total contestants count for a pageant round.
        /// </summary>
        public int TotalContestants { get => Contestants.Count; }
        public List<Doll> Contestants { get => contestants; set => contestants = value; }

        /// <summary>
        /// Adds a contestant to the pageant.
        /// </summary>
        /// <param name="d"></param>
        /// <returns>True if the contestant could be added, False otherwise</returns>
        public bool AddContestant(Doll d)
        {
            bool result = false;

            if(d.TieneVestido==true)
            {
                Contestants.Add(d);
                result = true;
            }

            return result;
        }

        /// <summary>
        /// Clears the contestants collection
        /// </summary>
        public void ClearContestants()
        {
            Contestants.Clear();
        }

        /// <summary>
        /// Returns the winner of the pageant
        /// </summary>
        /// <returns>The winner Doll</returns>
        public Doll GetWinner()
        {
            Doll winner = null;

            switch (Contestants.Count)
            {
                case 1:
                    // Single contestant is deemed winner, no matter its score.
                    winner = Contestants[0];
                    break;

                default:
                    // Sorts the contestants and return the one with the highest style score.


                    break;
            }

            return winner;
        }
    }
}