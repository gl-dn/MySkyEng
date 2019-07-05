using System;
using System.Collections.Generic;
using System.Text;

namespace MySkyEng.Data
{
    public interface ILesson : IEntity
    {
        string TopicName { get; set; }
        double Duration { get; set; }
        DateTime? Start { get; set; }
        bool Completed { get; set; }
    }
}
