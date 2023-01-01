using System;
using System.Collections.Generic;

namespace BridgeDesignPattern_DailyJournalSample
{
    class Program
    {
        static void Main(string[] args)
        {
            DailyJournal me = new DailyJournal("sara");
            me.Add(" Hello world ");
            me.Add(" Today, I have spent a really busy day ");

            var roya = new JournalAbstraction(new ShareJournal("roya"));
            roya.Poke("sara");
            roya.Add("sara", "How is everything going?");
            roya.Add("Hello there! I have started to write on ShareJournal");

            me.Poke("roya daily journal");
            me.Add("roya daily journal", "hey there , everythins is fine but you shoul not belive that !");

            roya.Poke("sara");
            roya.Add("sara", "i know but why my frind?");

            Console.ReadKey();
        }
    }
}
