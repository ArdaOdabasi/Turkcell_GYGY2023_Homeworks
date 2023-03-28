using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_sixthAssignment_GYGY2023.Yanlış_Tasarım
{
    public class Ciz
    {
        public enum enCemberTur
        {
            enDortgen,
            enCember
        }

        private enCemberTur cemberTuru;
        private Dortgen dortgen;
        private Cember cember;

        public Ciz(enCemberTur tur)
        {
            this.cemberTuru = tur;
            this.dortgen = new Dortgen();
            this.cember = new Cember();
        }

        private void CemberCiz()
        {
            this.cember.Ciz();
        }

        private void DortgenCiz()
        {
            this.dortgen.Ciz();
        }

        public void SekilCiz()
        {
            switch (this.cemberTuru)
            {
                case enCemberTur.enDortgen:
                    DortgenCiz();
                    break;
                case enCemberTur.enCember:
                    CemberCiz();
                    break;
                default:
                    break;
            }
        }
    }
}
