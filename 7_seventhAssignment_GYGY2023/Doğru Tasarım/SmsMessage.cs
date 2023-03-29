using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_seventhAssignment_GYGY2023.Doğru_Tasarım
{
    public class SmsMessage : IMessage
    {
        public IList<String> ToAddresses { get; set; }
        public string MessageBody { get; set; }
        public bool Send()
        {
            // Gönderme İşlemi
            return true;
        }     
    }
}
