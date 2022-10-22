using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharicCommon.Data.Models
{
    public class TaskState
    {
        public DateTime Time_Start { get; set; }
        public DateTime Time_Onboard { get; set; }
        public DateTime Time_UnBoard { get; set; }
        public DateTime Time_End { get; set; }
    }
}
