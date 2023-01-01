using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern_DailyJournalSample
{
    //This is the Implementor interface
    public interface JournalImplementation
    {
        void Add(string message);
        void Add(string friend, string message);
        void Poke(string who);
    }
}
