using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGame.DataLayer;
using TBQuestGame.Models;
using TBQuestGame.BusinessLayer;
using TBQuestGame.PresentationLayer;
using static TBQuestGame.GameSessionViewModel;

namespace TBQuestGame.BusinessLayer
{
    /// <summary>
    /// business logic layer class
    /// manages windows and interacts with the data layer
    /// </summary>
    public class GameBusiness
    {
        GameSessionViewModel _gameSessionViewModel;
        bool _newPlayer = true;
        Player _player = new Player();
        PlayerSetupView _playerSetupView;
        List<string> _messages;

        public GameBusiness()
        {
            SetupPlayer();
            InitializeDataSet();
            InstantiateAndShowView();
        }

        /// <summary>
        /// setup new or existing player
        /// </summary>
        private void SetupPlayer()
        {
            if (_newPlayer)
            {
                _playerSetupView = new PlayerSetupView(_player);
                _playerSetupView.ShowDialog();

                // setup up of game based player properties
                                
                _player.Health = 100;
                _player.Lives = 3;
                _player.Experience = 0;
            }
            else
            {
                _player = GameData.PlayerData();
            }
        }
        
        /// <summary>
        /// initialize data set
        /// </summary>
        private void InitializeDataSet()
        {
            _player = GameData.PlayerData();
            _messages = GameData.InitialMessages();
        }
        
        /// <summary>
        /// create view model with data set
        /// </summary>
        private void InstantiateAndShowView()
        {
            // instantiate the view model and initialize the data set

            _gameSessionViewModel = new GameSessionViewModel(_player,_messages
                //GameData.InitialMessages(),
                //GameData.GameMap(),
                //GameData.InitialGameMapLocation()
                );
            GameSessionView gameSessionView = new GameSessionView(_gameSessionViewModel);

            gameSessionView.DataContext = _gameSessionViewModel;

            gameSessionView.Show();


            _playerSetupView.Close();
        }
    }
}
