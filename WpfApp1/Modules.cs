using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Modules
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public int HoursperWeek { get; set; }
        public int selfStudyHours { get; set; }
    }
    public class semesterPlan
    {
        public int numnOfHours { get; set; }
        public int numnOfWeeks { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

    }
        
        
        
}
