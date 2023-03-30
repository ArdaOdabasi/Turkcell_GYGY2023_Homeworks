using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_eighthAssignment_GYGY2023.Yanlış_Tasarım
{
    public class Stock
    {
        public string getInfoAsHTML()
        {
            Finder f = new Finder();
            String info = f.FindQuoteInfo();

            Renderer r = new Renderer();
            return r.RenderQuoteInfo();
        }
    }
}
