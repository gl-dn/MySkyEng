using System;
using System.Collections.Generic;
using System.Text;

namespace MySkyEng.Data.Entities
{
    public class Teacher : IEmployee
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; set; }

        public string ImageUrl { get; set; }

        public string Info { get; set; }

        public long GenderId { get; set; }
        public Gender Gender { get; set; }

        public long CountryId { get; set; }
        public Country Country { get; set; }

        public int Experience { get; set; }

        public virtual IEnumerable<Course> Courses { get; set; }
    }
}
