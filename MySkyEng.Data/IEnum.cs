using System;
using System.Collections.Generic;
using System.Text;

namespace MySkyEng.Data
{
    public interface IEnum : IEntity
    {
        string Title { get; set; }
    }
}
