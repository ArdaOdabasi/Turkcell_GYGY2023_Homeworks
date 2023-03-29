using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_seventhAssignment_GYGY2023.Doğru_Tasarım
{
    public class SmtpMessage : IEmailMessage
    {
        public string MessageBody { get; set; }
        public string Subject { get; set; }
        public IList<String> BccAddresses { get; set; }
        public IList<String> ToAddresses { get; set; }
        public bool Send()
        {
            // Gönderme işlemi
            return true;
        }
    }
}
