using System;
using System.Collections.Generic;
using System.Text;

namespace MySkyEng.Data.Entities
{
    public class SimpleLesson : ILesson
    {
        public long Id { get; set; }
        public string TopicName { get; set; }
        public double Duration { get; set; }
        public DateTime? Start { get; set; }
        public bool Completed { get; set; }
    }
}
