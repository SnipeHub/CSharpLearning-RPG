using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player  // Using public here ensues this class is visible throughout the wole solution
    {
        public int CurrentHitPoints { get; set; }  // Here we create our int named CurrentHitPoints etc
        public int MaximumHitPoints { get; set; }
        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
    }
}
