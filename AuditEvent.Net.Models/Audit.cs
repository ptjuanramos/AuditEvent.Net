using System;

namespace AuditEvent.Net.Models
{
    public class Audit
    {
        public Guid Id { get; set; }
        public string Actor { get; set; }
        public string Input { get; set; }
        public string Output { get; set; }
    }
}
