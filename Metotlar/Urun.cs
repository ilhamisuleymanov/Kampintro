using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    //Property - ozellik
    class Urun
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiati { get; set; }
        public string Aciklama { get; set; }
        //----------StokAdedi----------sonradan elave (buna incapsulation deyirler)
        public int StokAdedi { get; set; }
    }
}
