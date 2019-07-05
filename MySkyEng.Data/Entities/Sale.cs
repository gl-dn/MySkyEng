using System;
using System.Collections.Generic;
using System.Text;

namespace MySkyEng.Data.Entities
{
    public class Sale : IEntity
    {
        public long Id { get; set; }
        public int NewPrice { get; set; }

        public long CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
