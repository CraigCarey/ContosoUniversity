using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Student
    {
        // Primary key column, by default : ID or classnameID
        public int ID { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // navigation property. Holds other entities that are related to this entity
        // defined as virtual to allow for lazy loading: initialization is deferred until object is needed
        // ICollection is an interface that represents a collection, it allows for iteration and modification
        // IEnumerable doesn't allow for modification
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}