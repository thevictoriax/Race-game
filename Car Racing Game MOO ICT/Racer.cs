using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace Car_Racing_Game_MOO_ICT
{
    //add icomparable
    public class Racer
    {
        public string Name { get; set; }

        public int Points { get; set; }

        public int Coins { get; set; }

        
        public Racer(string name = "")
        {
            Name = name;
            Points = 0;
            Coins= 0;
        }
        public void AddToFile()
        {
            var all_path = Path.Combine(Directory.GetCurrentDirectory());
            string delete_path = all_path.Substring(all_path.Length - 10);
            string path = all_path.Replace(delete_path, "");

            string file = path + "\\Racers.txt";
            string[] lines = File.ReadAllLines(file);

            using (StreamWriter sw = File.AppendText(file))
            {
                sw.WriteLine($"{Name},{Points},{Coins}");
            }
        }
        public bool AlreadyExists(string name)
        {
            var all_path = Path.Combine(Directory.GetCurrentDirectory());
            string delete_path = all_path.Substring(all_path.Length - 10);
            string path = all_path.Replace(delete_path, "");
            bool nameExists = false;
            string file = path + "\\Racers.txt";
            string[] lines = File.ReadAllLines(file);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length > 0 && parts[0] == Name)
                {
                    nameExists = true;
                    break;
                }
            }
            return nameExists;
        }
        public void renewCoins(string name)
        {
            
            var all_path = Path.Combine(Directory.GetCurrentDirectory());
            string delete_path = all_path.Substring(all_path.Length - 10);
            string path = all_path.Replace(delete_path, "");
            bool nameExists = false;
            string file = path + "\\Racers.txt";
            string[] lines = File.ReadAllLines(file);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length > 0 && parts[0] == Name)
                {
                    Coins = int.Parse(parts[2]);
                }
            }
            //return coins;
        }
    }
}
