using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAFinalProj.Models
{
    public class Sensor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Fields> Fields { get; set; }
    }
}
