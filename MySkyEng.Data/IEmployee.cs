using System;
using System.Collections.Generic;
using System.Text;

namespace MySkyEng.Data
{
    public interface IEmployee : IEntity, IPerson
    {
        int Experience { get; set; }
    }
}
