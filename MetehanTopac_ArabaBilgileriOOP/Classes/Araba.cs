using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetehanTopac_ArabaBilgileriOOP.Classes
{
    class Araba
    {
        public int ID { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string KapiSayisi { get; set; }
        public int BeygirGucu { get; set; }
        public string ArabaTuru { get; set; }
        public int MaksimumHiz { get; set; }
        public string Cekis { get; set; }
        public double SifirYüzHizlanma { get; set; }
        public double Agirlik { get; set; }
        public int MotorHacmi { get; set; }
    }
}
