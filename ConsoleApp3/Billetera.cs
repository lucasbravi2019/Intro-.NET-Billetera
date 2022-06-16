using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Billetera
    {
        public int Billete10 { get; set; }
        public int Billete20 { get; set; }
        public int Billete50 { get; set; }
        public int Billete100 { get; set; }
        public int Billete200 { get; set; }
        public int Billete500 { get; set; }
        public int Billete1000 { get; set; }

        public Billetera(int billete10, int billete20, int billete50, int billete100, int billete200, int billete500, int billete1000)
        {
            Billete10 = billete10;
            Billete20 = billete20;
            Billete50 = billete50;
            Billete100 = billete100;
            Billete200 = billete200;
            Billete500 = billete500;
            Billete1000 = billete1000;
        }

        private Billetera SumarBilleteras(Billetera billetera)
        {
            return new Billetera(
                    billete10: SumarBilletes(this.Billete10, billetera.Billete10),
                    billete20: SumarBilletes(this.Billete20, billetera.Billete20),
                    billete50: SumarBilletes(this.Billete50, billetera.Billete50),
                    billete100: SumarBilletes(this.Billete100, billetera.Billete100),
                    billete200: SumarBilletes(this.Billete200, billetera.Billete200),
                    billete500: SumarBilletes(this.Billete500, billetera.Billete500),
                    billete1000: SumarBilletes(this.Billete1000, billetera.Billete1000)
                );
        }

        private void DejarEnCero(Billetera billetera)
        {
            billetera.Billete10 = 0;
            billetera.Billete20 = 0;
            billetera.Billete50 = 0;
            billetera.Billete100 = 0;
            billetera.Billete200 = 0;
            billetera.Billete500 = 0;
            billetera.Billete1000 = 0;
        }

        private int SumarBilletes(int billete1, int billete2)
        {
            return billete1 + billete2;
        }

        public Billetera CombinarBilleteras(Billetera billetera)
        {
            Billetera billeteraNueva = SumarBilleteras(billetera);
            DejarEnCero(this);
            DejarEnCero(billetera);
            return billeteraNueva;
        }

        public float Total()
        {
            return Billete10 * 10 + Billete20 * 20 + Billete50 * 50 + Billete100 * 100 + Billete200 * 200 + Billete500 * 500 + Billete1000 * 1000; 
        }
    }
}
