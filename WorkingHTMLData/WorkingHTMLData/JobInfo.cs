using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingHTMLData
{
    class JobInfo
    {
        public string JobName { get; set; }
        public string Deadline { get; set; }
        public string EmploymentTerm { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string JobResponsibilities { get; set; }
        public string RequiredQualifications { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }

        public override string ToString()
        {
            return $"{JobName}\n {Type}\n{Location}\n{Category}\n{Deadline}\n{EmploymentTerm}\n\n{Description}\n\n{JobResponsibilities}\n\n{RequiredQualifications}";
        }
    }
}
