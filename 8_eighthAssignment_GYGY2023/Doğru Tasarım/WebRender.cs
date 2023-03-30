using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_eighthAssignment_GYGY2023.Doğru_Tasarım
{
    public class WebRender : IRenderer
    {
        public void Display(string content)
        {
            Console.WriteLine($"'<b>'{content}'<b>'");
        }
    }
}
