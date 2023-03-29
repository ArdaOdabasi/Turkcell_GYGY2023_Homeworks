using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_sixthAssignment_GYGY2023.Doğru_Tasarım
{
    public class Ciz
    {
        private Sekil sekil;

        public Ciz(Sekil sekil)
        {
            this.sekil = sekil;
        }

        public void SekilCiz()
        {
            this.sekil.Ciz();
        }
    }
}

