using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassInventory
{
    public partial class Form1 : Form
    {
        // Global Variabales go here
        List<Player> playerList = new List<Player>();

        public Form1()
        {
            InitializeComponent();
        }

        private Player getByName(string name)
        {
            foreach (Player player in playerList)
            {
                if (player.name == name)
                {
                    return player;
                }
            }

            return new Player();
        }

        private Player getById(int id)
        {
            foreach (Player player in playerList)
            {
                if (player.id == id)
                {
                    return player;
                }
            }

            return new Player();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int age = 0;
            try {
                age = Convert.ToInt16(this.ageInput.Text);
            } catch (FormatException ex) {
                age = -1;
            }

            if (age <= 0)
            {
                this.displayBox.Text = "Invalid age, must be < 0";

                this.nameInput.Text = "";
                this.ageInput.Text = "";
                this.positionInput.Text = "";
                this.teamInput.Text = "";
                return;
            }

            Player player = new Player(this.nameInput.Text, this.teamInput.Text, this.positionInput.Text, age);

            this.nameInput.Text = "";
            this.ageInput.Text = "";
            this.positionInput.Text = "";
            this.teamInput.Text = "";

            playerList.Add(player);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            foreach (Player player in playerList)
            {
                if (player.name == this.removeInput.Text)
                {
                    playerList.Remove(player);
                    this.removeInput.Text = "";
                    this.displayBox.Text = "";
                    return;
                }
            }

            this.removeInput.Text = "";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // This is to be completed in Part II. You will use 
            // Lambda Expressions. 
            //---------------------------
            Action<string> findPlayer = name =>
            {
                foreach (Player player in playerList)
                {
                    if (player.name == name)
                    {
                        this.label1.Text = player.format();
                        return;
                    }
                }
            };

            findPlayer(this.nameSearchInput.Text);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            foreach (Player player in playerList)
            {
                this.label1.Text += player.format() + "\n\n";
            }
        }
    }
}
