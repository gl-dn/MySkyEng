using System;
using System.Collections.Generic;
using System.Text;

namespace MySkyEng.Data.Entities
{
    public class IntroductoryLesson : ILesson
    {
        public long Id { get; set; }
        public string TopicName { get; set; }
        public double Duration { get; set; }
        public DateTime? Start { get; set; }
        public bool Completed { get; set; }

        public long? MethodistId { get; set; }
        public virtual Methodist Methodist { get; set; }
    }
}
