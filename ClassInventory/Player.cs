using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInventory
{
    internal class Player
    {
        public string name = "";
        public string team = "";
        public string position = "";
        public int age = -1;

        public Player(string name, string team, string position, int age)
        {
            Random random = new Random();
            this.name = name;
            this.team = team;
            this.position = position;
            this.age = age;
            this.id = random.Next(1000, 10000);
        }

        public Player()
        {

        }

        // For esay identifiying
        public int id = -1;

        public void setValues(string name, string team, string position, int age)
        {
            Random random = new Random();
            this.name = name;
            this.team = team;
            this.position = position;
            this.age = age;

            this.id = random.Next(1000, 10000);
        }

        public string format()
        {
            return $"Name: {this.name}, Team: {this.team}, Position: {this.position}, Age: {this.age}";
        }
    }
}
