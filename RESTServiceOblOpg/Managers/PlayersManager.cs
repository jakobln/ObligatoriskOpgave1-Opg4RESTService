using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTestsOblOpg;

namespace RESTServiceOblOpg.Managers
{
    public class PlayersManager
    {
        private static int _nextId = 1;
        private static readonly List<FootballPlayer> Data = new List<FootballPlayer>
        {
            new FootballPlayer (_nextId++, "Anders", 500, 1),
            new FootballPlayer (_nextId++, "Peter", 3000, 2)
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers
        };

        public List<FootballPlayer> GetAll()
        {
            return new List<FootballPlayer>(Data);
            // copy constructor
            // Callers should no get a reference to the Data object, but rather get a copy
        }

        public FootballPlayer GetById(int id)
        {
            return Data.Find(footballplayer => footballplayer.Id == id);
        }

        public FootballPlayer Add(FootballPlayer newFootballPlayer)
        {
            newFootballPlayer.Id = _nextId++;
            Data.Add(newFootballPlayer);
            return newFootballPlayer;
        }

        public FootballPlayer Delete(int id)
        {
            FootballPlayer footballplayer = Data.Find(footballplayer1 => footballplayer1.Id == id);
            if (footballplayer == null) return null;
            Data.Remove(footballplayer);
            return footballplayer;
        }

        public FootballPlayer Update(int id, FootballPlayer updates)
        {
            FootballPlayer footballplayer = Data.Find(footballplayer1 => footballplayer1.Id == id);
            if (footballplayer == null) return null;
            footballplayer.Name = updates.Name;
            footballplayer.Price = updates.Price;
            footballplayer.ShirtNumber = updates.ShirtNumber;
            return footballplayer;
        }
    }
}
