using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_eighthAssignment_GYGY2023.Doğru_Tasarım
{
    public class Stock
    {
        private IFinder f { get; set; }
        private IRenderer r { get; set; }

        public Stock(IFinder f, IRenderer r)
        {
            this.f = f;
            this.r = r;
        }

        public void DisplayStockInfo(string name)
        {
            r.Display(f.Find(name));
        }
    }
}
