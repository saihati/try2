using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace homework2.Models
{
    public class Section
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int sectionID { get; set; }
        public int sectionNumber { get; set; }
        public int courseNumber { get; set; }
        public String sectionDays { get; set; }
        public DateTime sectionTime { get; set; }


        public virtual ICollection<Course> Courses { get; set; }


    }
}