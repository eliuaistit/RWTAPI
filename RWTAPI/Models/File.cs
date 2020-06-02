
using AllianceCRM.Insurance;

namespace NexsourceCRM.Contents
{
    public class File : BaseEntity
    {
        public string SystemFileName { get; set; }
        public string DisplayFileName { get; set; }
        public object FileTitle { get; set; }
        public string FileType { get; set; }
        public string FileLocation { get; set; }
        public Client Client { get; set; }
        public object User { get; set; }
        public object Note { get; set; }
        public int Filesize { get; set; }
        public object FileContent { get; set; }
        public object TempReference { get; set; }

    }

}
