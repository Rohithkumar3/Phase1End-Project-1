using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Project1
{
    public class OneDayTeam : ITeam
    {
        public static List<Player> oneDayTeam = new List<Player>();

        public OneDayTeam()
        {
            oneDayTeam.Capacity = 11;
        }

        public void Add(Player player)
        {
            if (oneDayTeam.Count < oneDayTeam.Capacity)
            {
                oneDayTeam.Add(player);
                Console.WriteLine($"Player {player.PlayerName} added to the team successfully.\n");
            }
            else
            {
                Console.WriteLine("Cannot add more than 11 players to the team.\n");
            }
        }

        public void Remove(int playerId)
        {
            Player playerToRemove = oneDayTeam.FirstOrDefault(p => p.PlayerId == playerId);
            if (playerToRemove != null)
            {
                oneDayTeam.Remove(playerToRemove);
                Console.WriteLine($"Player {playerToRemove.PlayerName} removed from the team successfully.\n");
            }
            else
            {
                Console.WriteLine($"Player with Id {playerId} not found.\n");
            }
        }

        public Player GetPlayerById(int playerId)
        {
            return oneDayTeam.FirstOrDefault(p => p.PlayerId == playerId);
        }

        public Player GetPlayerByName(string playerName)
        {
            return oneDayTeam.FirstOrDefault(p => string.Equals(p.PlayerName, playerName, StringComparison.OrdinalIgnoreCase));
        }

        public List<Player> GetAllPlayers()
        {
            return oneDayTeam;
        }
    }
}

