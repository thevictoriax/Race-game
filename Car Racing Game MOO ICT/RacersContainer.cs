using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Racing_Game_MOO_ICT
{
    public class RacersContainer
    {
        public List<Login> Racers { get; set; }

        public int Length
        {
            get
            {
                return Racers.Count;
            }
        }

        public RacersContainer()
        {
            Racers = new List<Login>();
        }

        public Login this[int index]
        {
            get
            {
                return Racers[index];
            }
            set
            {
                Racers[index] = value;
            }
        }

        public void AddPlayer(Login player)
        {
            Racers.Add(player);
        }

        //public void SortPlayers()
        //{
        //    Racers = Racers.OrderByDescending(p => p.Points).ToList();
        //}

        //public void ReadFromFile()
        //{
        //    var all_path = Path.Combine(Directory.GetCurrentDirectory());
        //    string delete_path = all_path.Substring(all_path.Length - 10);
        //    string path = all_path.Replace(delete_path, "");

        //    string file = path + "\\Racers.txt";
        //    string[] lines = File.ReadAllLines(file);
        //    foreach (var item in lines)
        //    {
        //        Racer player = new Racer();
        //        var line = item.Split(',');
        //        player.Name = line[0];
        //        player.Record = Int32.Parse(line[1]);
        //        player.Coins = Int32.Parse(line[2]);
        //        Racers.Add(player);
        //    }
        //}
    }
}
