using System;
using System.Collections.Generic;
using System.Text;

namespace GridPage.Models
{
    public class Player
    {
        public string Name { get; set; }
        public int HitPoints { get; set; }
        public int ArmorClass { get; set; }
        public int Perception { get; set; }
        public int Initiative { get; set; }
    }
}
