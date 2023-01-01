using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern_DailyJournalSample
{
    //This is the ConcreteImplementor2
    public class DailyJournal : JournalImplementation
    {
        static SortedList<string, DailyJournal> community
            = new SortedList<string, DailyJournal>(100);
        string pages;
        string name;
        string gap = "\n\t\t\t\t";

        public DailyJournal(string n)
        {
            name = n;
            community[n] = this;
        }

        public void Add(string s)
        {
            pages += gap + s;
            Console.Write(gap + " ======== " + name + "'s " +
                "Spacebook ========");
            Console.Write(pages);
            Console.WriteLine(gap + "=================================");
        }

        public void Add(string friend, string message)
        {
            community[friend].Add(message);
        }

        public void Poke(string who)
        {
            community[who].pages += gap + "You have been poked";
        }
    }
}
