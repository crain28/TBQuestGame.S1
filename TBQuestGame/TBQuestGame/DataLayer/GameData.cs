using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGame.Models;

/// <summary>
/// Game Data Class
/// </summary>
namespace TBQuestGame.DataLayer
{
    class GameData
    {
        public static Player PlayerData()
        {
            return new Player()
            {
                Id = 1,
                Name = "Zane",
                Age = 20,
                Title = Player.TitleName.Adventurer,
                Clan = Character.ClanType.HalfHuman,
                Health = 100,
                Lives = 3,
                Experience = 0,
                LocationId = 0

            };
            
        }

        internal static List<string> InitialMessages()
        {
            return new List<string>()
            {
                "You have been hired by the Angel Clan to participate in the latest challenge for the quest game project. " +
                "Your challenge is to explore the forest of Yelma and report back to the Angel Clan on your discoveries." +
                "The forest of Yelma is know to be full of demons and beasts plotting to attack wondering Adventurers"
            };
        }

    }
}
