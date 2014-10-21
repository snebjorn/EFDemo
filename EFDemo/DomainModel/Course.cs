using System.Collections.Generic;

namespace EFDemo.DomainModel
{
    public class Course
    {
        public Course()
        {
            // initialize to avoid null pointer exceptions
            Students = new HashSet<Student>();
        }

        // this is the primary key
        public int Id { get; set; }
        
        // scalar property
        public string Name { get; set; }

        // navigation property
        // remember the virtual keyword
        public virtual ICollection<Student> Students { get; set; }
    }
}
