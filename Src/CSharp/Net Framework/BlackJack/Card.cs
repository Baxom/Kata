using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Katas_project.BlackJack
{
    public class Card : ICard
    {
        public string Valeur { get; set; }

        public Card(string cardValue)
        {

        }

        public int Points {
            get { return 0; } 
        }
    }
}
