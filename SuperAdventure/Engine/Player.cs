using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : LivingCreature // Using public here ensues this class is visible throughout the wole solution
    {
        //public int CurrentHitPoints { get; set; }  These are inherited under LivingCreature.cs
        //public int MaximumHitPoints { get; set; }
        public int Gold { get; set; } // Here we create our int named Gold etc
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }

        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }

        public Player(int currentHitPoints, int maximumHitPoints, int gold, int experiencePoints, int level) : base(currentHitPoints, maximumHitPoints)
        {
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Level = level;

            Inventory = new List<InventoryItem>(); // Here we set the value of the new properties to empty lists, which means we can add items to them later.
            Quests = new List<PlayerQuest>();
        }
    }
}
