using System;
using System.Collections.Generic;
using System.Text;

namespace MySkyEng.Data.Entities
{
    public class Country : IEnum
    {
        public long Id { get; set; }
        public string Title { get; set; }
    }
}
