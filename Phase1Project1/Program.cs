using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Project1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            OneDayTeam team = new OneDayTeam();
            while (true)
            {
                Console.WriteLine("1:Add Player\n2:Remove Player by Id \n3:Get Player By Id\n4:Get Player by Name\n5:Get All Players\n6:Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Player Id: ");
                        int playerId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Player Name: ");
                        string playerName = Console.ReadLine();
                        Console.Write("Enter Player Age: ");
                        int playerAge = Convert.ToInt32(Console.ReadLine());

                        Player newPlayer = new Player { PlayerId = playerId, PlayerName = playerName, PlayerAge = playerAge };
                        team.Add(newPlayer);
                        break;

                    case 2:
                        Console.Write("Enter Player Id to remove: ");
                        int idToRemove = Convert.ToInt32(Console.ReadLine());
                        team.Remove(idToRemove);
                        break;

                    case 3:
                        Console.Write("Enter Player Id to get details: ");
                        int idToGet = Convert.ToInt32(Console.ReadLine());
                        Player playerById = team.GetPlayerById(idToGet);
                        Console.WriteLine(playerById != null ? $"Player Details: Id: {playerById.PlayerId}, Name: {playerById.PlayerName}, Age: {playerById.PlayerAge}\n" : "Player not found.\n");
                        break;

                    case 4:
                        Console.Write("Enter Player Name to get details: ");
                        string nameToGet = Console.ReadLine();
                        Player playerByName = team.GetPlayerByName(nameToGet);
                        Console.WriteLine(playerByName != null ? $"Player Details: Id: {playerByName.PlayerId}, Name: {playerByName.PlayerName}, Age: {playerByName.PlayerAge}\n" : "Player not found.");
                        break;

                    case 5:
                        var allPlayers = team.GetAllPlayers();
                        Console.WriteLine("All Players in the Team:");
                        foreach (var player in allPlayers)
                        {
                            Console.WriteLine($"Id: {player.PlayerId}, Name: {player.PlayerName}, Age: {player.PlayerAge}\n");
                        }
                        break;

                    case 6:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}

