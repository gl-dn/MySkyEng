using MySkyEng.Data.Entities;
using System;

namespace MySkyEng.Data
{
    public interface IPerson : IEntity
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
        DateTime Birthday { get; set; }

        string ImageUrl { get; set; }

        string Info { get; set; }

        long GenderId { get; set; }
        Gender Gender { get; set; }

        long CountryId { get; set; }
        Country Country { get; set; }
    }
}
