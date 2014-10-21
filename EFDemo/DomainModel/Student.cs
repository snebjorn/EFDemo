using System.Collections.Generic;

namespace EFDemo.DomainModel
{
    public class Student
    {
        public Student()
        {
            // initialize to avoid null pointer exceptions
            Courses = new HashSet<Course>();
        }

        // this is the primary key
        public int Id { get; set; }

        // scalar property
        public string Name { get; set; }

        // navigation property
        // remember the virtual keyword
        public virtual ICollection<Course> Courses { get; set; }

        // methods are ignored by EF
        public override string ToString()
        {
            return Id + "\t" + Name;
        }
    }
}
