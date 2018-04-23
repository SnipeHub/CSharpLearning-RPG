using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class PlayerQuest
    {
        public Quest Details { get; set; }
        public bool IsCompleted { get; set; } // we use bool to store a value of true or false

        public PlayerQuest(Quest details)
        {
            Details = details;
            IsCompleted = false; // until the player finishes a quest, it will store false. Once the quest is complete, we will store a "true" value in there.
        }
    }
}
