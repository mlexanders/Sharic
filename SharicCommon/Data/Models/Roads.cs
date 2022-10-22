using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharicCommon.Data.Models
{
    public class Road
    {
        public int Road_Id { get; set; }
        public int Source_Point_Id { get; set; }
        public int Target_Point_Id { get; set; }
        public int Distance { get; set; }
    }
}
