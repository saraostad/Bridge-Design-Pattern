using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern_DailyJournalSample
{
    //This is the ConcreteImplementor1
    public class ShareJournal : JournalImplementation
    {
        DailyJournal _myDailyJournal;
        string _name;
        static int _users;

        public ShareJournal(string name)
        {
            _name = name;
            _users++;
            _myDailyJournal = new DailyJournal(_name + " daily journal");
        }

        public void Add(string message)
        {
            _myDailyJournal.Add(message);
        }

        public void Add(string friend, string message)
        {
            _myDailyJournal.Add(friend, _name + " said:" + message);
        }

        public void Poke(string who)
        {
            _myDailyJournal.Poke(who);
        }
    }
}
