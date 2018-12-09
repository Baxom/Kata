using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Katas_project.BlackJack
{
    public class Hand : IHand
    {
        public int Points { get { return FirstCard.Points + SecondCard.Points; } }

        public ICard FirstCard { get; }

        public ICard SecondCard { get; }

        public bool IsBlackJack => throw new NotImplementedException();

        public bool IsLosingHand => throw new NotImplementedException();

        public Hand(ICard firstCard, ICard secondCard)
        {
            FirstCard = firstCard;
            SecondCard = secondCard;
        }

        public void AddCard(ICard card)
        {
            throw new NotImplementedException();
        }
    }
}
