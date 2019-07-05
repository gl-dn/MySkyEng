using System;
using System.Collections.Generic;
using System.Text;

namespace MySkyEng.Data.Entities
{
    public class Course : IEntity
    {
        public long Id { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? Complete { get; set; }
        public int Price { get; set; }
        public int NumberOfLessons { get; set; }

        public virtual IEnumerable<SimpleLesson> Lessons { get; set; }

        public long? TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
