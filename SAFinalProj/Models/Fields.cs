using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAFinalProj.Models
{
    public class Fields
    {
        public DateTime TimeStamp { get; set; }
        public Decimal Weight { get; set; }
        public Decimal BMI { get; set; }
        public int CaloriesIn { get; set; }
        public int CaloriesBurned { get; set; }
        public int Steps { get; set; }
        public int MinutesAsleep { get; set; }
        public int MinutesAwake { get; set; }
        // Grams
        public int FatConsumed { get; set; }
        // Grams
        public int FiberConsumed { get; set; }
        // Grams
        public int CarbsConsumed { get; set; }
        // Milligrams 
        public int SodiumConsumed { get; set; }
        // Grams
        public int ProteinConsumed { get; set; }
        // Fluid ounces
        public int WaterConsumed { get; set; }
    }

}
