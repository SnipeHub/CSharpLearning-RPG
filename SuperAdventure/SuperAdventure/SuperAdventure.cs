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
    public partial class SuperAdventure : Form
    {
        private Player _player; // Variable _player is a private variable. Scott likes to name his private variables with underscore "_"

        public SuperAdventure()
        {
            InitializeComponent();

            //Location location = new Location(1, "Home", "This is your house."); // This is our location object. We no longer need this line as we have created our own in the required classes.
            //location.ID = 1;
            //location.Name = "Home";
            //location.Description = "This is your house.";

            _player = new Player();

            _player.CurrentHitPoints = 10;
            _player.MaximumHitPoints = 10;
            _player.Gold = 20;
            _player.ExperiencePoints = 0;
            _player.Level = 1;

            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();

        }
    }
}
