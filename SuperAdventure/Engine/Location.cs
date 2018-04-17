using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Location(int id, string name, string description) // Our constructor code. We also declare our datatypes here in the brackets
        {
            ID = id; // here we make the paramters lower case and obvious names so we know that these are paremeters and what there doing.
            Name = name; // The value on the right of the equal sign gets assigned to the property or variable on the left.
            Description = description;
        }
    }
}
