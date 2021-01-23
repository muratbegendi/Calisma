using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //İndividual = Gerçek
    //İnheritance = Miras (:Müşteri)
    class GercekMusteri : Musteri
    {
      
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TcNo { get; set; }
    }
}
