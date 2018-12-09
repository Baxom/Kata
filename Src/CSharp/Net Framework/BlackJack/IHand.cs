using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Katas_project.BlackJack
{
    public interface IHand
    {
        ICard FirstCard { get; }
        ICard SecondCard { get; }

        int Points { get; }
        void AddCard(ICard card);

        bool IsBlackJack { get; }
        bool IsLosingHand { get; }
    }
}
