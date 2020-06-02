using System;

namespace AllianceCRM.Model.Extension
{
    public class Reminder
    {
        public DateTime? SentTime { get; set; }
        public bool sentReminder { get; set; }
        public string State { get; set; }
    }
}
