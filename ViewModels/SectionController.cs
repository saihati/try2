using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using homework2.Models;
namespace homework2.ViewModels
{
    public class SectionController
    {
        public class InstructorIndexData
        {
            public IEnumerable<Section> Instructors { get; set; }
            public IEnumerable<Course> Courses { get; set; }
     //       public IEnumerable<Enrollment> Enrollments { get; set; }
        }
    }
}