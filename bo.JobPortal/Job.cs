using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bo.JobPortal.Data
{
    public class Job
    {

        public string Title { get; set; }
        public string Education { get; set; }
        public string Location { get; set; }
        public int? Experience { get; set; }
        public string SkillSet { get; set; }
        public string Description { get; set; }
        public string CompanyName { get; set; }
    }
    public class Error
    {
        public string ErrorMessage { get; set; }
        public Exception Exception { get; set; }

    }
}
