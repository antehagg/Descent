using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.Players;
using Descent.Core.Settings;

namespace Descent.Core
{
    public class GameContext
    {
        public ApplicationSettings AppSettings;
        public List<Player> PlayerList { get; set; }

        public GameContext()
        {
            AppSettings = new ApplicationSettings();
            PlayerList = new List<Player>();
        }

        public bool AddPlayer(Player newPlayer)
        {
            if (PlayerList.Count >= AppSettings.Constants.MaxPlayers)
                return false;

            PlayerList.Add(newPlayer);
            return true;
        }
    }
}
