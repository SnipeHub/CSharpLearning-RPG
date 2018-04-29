using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine; // The name of our namespace Engine, which links to it (Player.cs). This is where our Player Class is located.

namespace SuperAdventure
{
    public partial class SuperAdventure : Form // this class is what connects all the window controls to the code
    {
        private Player _player; // Variable _player is a private variable. Scott likes to name his private variables with underscore "_"

        public SuperAdventure()
        {
            InitializeComponent();

            _player = new Player(10, 10, 20, 0, 1); // have a look at Player.cs to see where this is coming from

            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();

        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNorth_Click(object sender, EventArgs e) // to get this button code generated, all you need to do is double click on the buttons in the designer view.
        { // we write all our code in these curly brackets to connect to our code, and it will initiate when the player presses this button.

        }

        private void btnWest_Click(object sender, EventArgs e)
        {

        }

        private void btnEast_Click(object sender, EventArgs e)
        {

        }

        private void btnSouth_Click(object sender, EventArgs e)
        {

        }

        private void btnUseWeapon_Click(object sender, EventArgs e)
        {

        }

        private void btnUsePotion_Click(object sender, EventArgs e)
        {

        }
    }
}
