using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_seventhAssignment_GYGY2023.Yanlış_Tasarım
{
    public interface IMessage
    {
        IList<String> ToAddresses { get; set; }
        string MessageBody { get; set; }
        string Subject { get; set; }
        bool Send();
    }
}
