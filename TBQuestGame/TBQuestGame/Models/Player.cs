using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame.Models
{
    /// <summary>
    /// Player Class
    /// </summary>
    public class Player : Character
    {
        #region ENUMS

        public enum TitleName { Adventurer, ClanLeader, Superior }

        #endregion

        #region FIELDS

        private int _lives;
        private int _health;
        private int _experience;
        private TitleName _title;
        private object _player;
        private List<string> _messages;

        #endregion

        #region PROPERTIES

        public int Lives
        {
            get { return _lives; }
            set { _lives = value; }
        }

        public TitleName Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }

        public int Experience
        {
            get { return _experience; }
            set { _experience = value; }
        }

        #endregion

        #region CONSTRUCTORS


        #endregion

        #region METHODS

        ///// <summary>
        ///// override the default greeting in the Character class to include the title
        ///// set the proper article based on the title
        ///// </summary>

        public override string DefaultGreeting()
        {
            string article = "a";

            List<string> vowels = new List<string>() { "A", "E", "I", "O", "U" };

            if (vowels.Contains(_title.ToString().Substring(0, 1))) ;
            {
                article = "an";
            }

            return $"Hello, my name is {_name} and I am {article} {_title} for the Quest Game.";
        }

        #endregion

        #region EVENTS



        #endregion

    }
}
