using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern_DailyJournalSample
{
    //This is the Abstraction
    public class JournalAbstraction
    {
        JournalImplementation _implementation;
        public JournalAbstraction(JournalImplementation implementation)
        {
            _implementation = implementation;
        }

        public void Add(string message)
        {
            _implementation.Add(message);
        }
        public void Add(string friend, string message)
        {
            _implementation.Add(friend, message);
        }
        public void Poke(string who)
        {
            _implementation.Poke(who);
        }
    }
}
