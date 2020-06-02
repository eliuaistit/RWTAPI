
using AllianceCRM.Insurance;
using NexsourceCRM.Demography;
using System;

namespace AllianceCRM.Security
{
    public class User : BaseEntity
    {
        public Person Person { get; set; }
        public string EmailSignature { get; set; }
        public Comment[] Comments { get; set; }
        public Roles[] Roles { get; set; }
        public Departments[] Departments { get; set; }
        public BusinessUnit BusinessUnit { get; set; }
        public ProfilePhoto ProfilePhoto { get; set; }
        public string Email { get; set; }
        public string EmailPassword { get; set; }
        public object ExtensionNumber { get; set; }
        public int TempReference { get; set; }
        public string Username { get; set; }
        public Guid Password { get; set; }

    }

}
