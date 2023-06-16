using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class EducationInformation
    {
        [Key]
        public int EducationInformationID { get; set; }
        public string SchoolName { get; set; }
        public string Branch { get; set; }
        public DateTime GraduationDate { get; set; }

    }
}
