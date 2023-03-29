using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_seventhAssignment_GYGY2023.Doğru_Tasarım
{
    public interface IEmailMessage : IMessage
    {
        string Subject { get; set; }
        IList<String> BccAddresses { get; set; }
    }
}
