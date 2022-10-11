using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports_Team
{
    class Program
    {
        static void Main(string[] args)
        {
            OneDayTeam team = new OneDayTeam();
            while (true)
            {
                Console.WriteLine("Enter \n1:To Add Player \n2:To Remove Player by Id \n3.Get Player By Id \n4.Get Player by Name \n5.Get All Players:\n6.exit menu");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 6)
                {
                    break;
                }
                Player player = new Player();
                switch (a)
                {
                    case 1:                     
                        Console.WriteLine("enter player id");
                        player.id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter player name");
                        player.name = Console.ReadLine();
                        Console.WriteLine("enter player age");
                        player.age = Convert.ToInt32(Console.ReadLine());
                        team.Add(player);
                        break;
                    case 2:
                        Console.WriteLine("enter player id you want to remove");
                        int id = Convert.ToInt32(Console.ReadLine());
                        team.Remove(id);
                        break;
                    case 3:
                        Console.WriteLine("enter player id you want to find");
                        int id1 = Convert.ToInt32(Console.ReadLine());
                        player = team.GetPlayerById(id1);
                        break;
                    case 4:
                        Console.WriteLine("enter player name you want to find");
                        player = team.GetPlayerByName(Console.ReadLine());
                        break;
                    case 5:
                        team.GetAllPlayers();
                        break;               
                    default:
                        Console.WriteLine("-----enter a valid option-----");
                        break;
                }
            }
        }
    }
}
