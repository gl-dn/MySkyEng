using System;
using System.Collections.Generic;
using System.Text;

namespace MySkyEng.Data.Entities
{
    public class Student : IPerson
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

        public string LevelOfLanguage { get; set; }

        public long CourseId { get; set; }
        public virtual Course Course { get; set; }

        public long IntroductoryLessonId { get; set; }
        public virtual IntroductoryLesson IntroductoryLesson { get; set; }

        public string Login { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
