using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TBQuestGame.Models;

namespace TBQuestGame
{
    /// <summary>
    /// view model for the game session view
    /// </summary>
    public class GameSessionViewModel
    {
        #region ENUMS



        #endregion

        #region FIELDS

        private Player _player;
        private List<string> _messages;
        private DateTime _gameStartTime;
        private object v1;
        private object v2;

        #endregion

        #region PROPERTIES

        public Player Player
        {
            get { return _player; }
            set { _player = value; }
        }

        public string MessageDisplay
        {
            get { return FormatMessagesForViewer(); }
        }

        #endregion

        #region CONSTRUCTORS
        
        public GameSessionViewModel(
            Player player,
            List<string> initialMessages)
        {
            _player = player;
            _messages = initialMessages;
            InitializeView();
        }

        public GameSessionViewModel(Player player, List<string> initialMessages, object v1, object v2) : this(player, initialMessages)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        #endregion

        #region METHODS

        /// <summary>
        /// initial setup of the game session view
        /// </summary>
        private void InitializeView()
        {
            _gameStartTime = DateTime.Now;
        }

        /// <summary>
        /// generates a sting of mission messages with time stamp with most current first
        /// </summary>
        /// <returns>string of formated mission messages</returns>
        private string FormatMessagesForViewer()
        {
            List<string> lifoMessages = new List<string>();

            for (int index = 0; index < _messages.Count; index++)
            {
                lifoMessages.Add($" <T:{GameTime().ToString(@"hh\:mm\:ss")}> " + _messages[index]);
            }

            lifoMessages.Reverse();

            return string.Join("\n\n", lifoMessages);
        }

        /// <summary>
        /// running time of game
        /// </summary>
        /// <returns></returns>
        private TimeSpan GameTime()
        {
            return DateTime.Now - _gameStartTime;
        }

        #endregion

        #region EVENTS



        #endregion
    }
}
