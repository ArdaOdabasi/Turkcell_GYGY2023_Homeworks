using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_seventhAssignment_GYGY2023.Yanlış_Tasarım
{
    public class SmtpMessage : IMessage
    {
        public string MessageBody { get; set; }
        public string Subject { get; set; }
        public IList<string> ToAddresses { get; set; }

        public bool Send()
        {
            // Gönderme işlemi
            return true;
        }
    }
}
