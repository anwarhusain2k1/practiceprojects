using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports_Team
{
    public class OneDayTeam : Player, Ioperation
    {
        public static List<Player> oneDayTeam = new List<Player>();
        public OneDayTeam() { }
        public void Add(Player player)
        {
            if (oneDayTeam.Count < 11) { oneDayTeam.Add(player); }
            else { Console.WriteLine("========= player can't add team full ========="); }
            
        }
        public void GetAllPlayers()
        {
            Console.WriteLine("Id\t Player_name\t Age");
            foreach (Player player in oneDayTeam)
            {
                Console.WriteLine(player.id+"\t"+player.name+ "\t" + player.age);
            }
            Console.WriteLine("======end of list======");
        }

        public Player GetPlayerById(int playerId)
        {
            for (int i = 0; i < oneDayTeam.Count; i++)
            {
                Player player = oneDayTeam[i];
                if (player.id == playerId)
                {
                    
                    Console.WriteLine("========= "+player.id + "\t" + player.name + "\t" + player.age +" =========");
                    return player;
                }
            }
            return null;
        }

        public Player GetPlayerByName(string playerName)
        {
            for (int i = 0; i < oneDayTeam.Count; i++)
            {
                Player player = oneDayTeam[i];
                if (player.name == playerName)
                {
                    Console.WriteLine("========== "+ player.id + "\t" + player.name + "\t" + player.age +" ==========");
                    return player;
                }
                
            }
            return null;
        }

        public void Remove(int playerId)
        {
            for (int i = 0; i < oneDayTeam.Count; i++)
            {
                Player player = oneDayTeam[i];
                if (player.id == playerId)
                {
                    oneDayTeam.Remove(player);
                    Console.WriteLine("==========player removed=========+");
                    break;
                }
            }
            
        }
    }
            
}
