using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutuphaneagac_
{
    public class agac
    {
        public string ad;
        public string yaprakturu;
        public string yaprakrengi;
        public int govde;
        public int uzunluk;
        public string yetistigibolge;
        public string meyvevarmi;
        public int yıllikkarbondioksit;

        public virtual void Buyu()
        {
            Console.WriteLine(ad + " ağacı büyüdü.");
            uzunluk = uzunluk + 2;
        }
        public virtual void YaprakDok()
        {
            Console.WriteLine(ad + " ağacı yaprak döktü.");
        }
        public virtual void Kesildi()
        {
            Console.WriteLine(ad + " ağacı kesildi.");
        }
    }
    public class portakal : agac
    {
        public int portakalsayisi;
        public override void YaprakDok()
        {
            Console.WriteLine(ad + " meyve döktü.");
        }
        public override void Buyu()
        {
            Console.WriteLine(ad + " büyüdü.");
            uzunluk = uzunluk + 2;
        }
    }
    public class cam : agac
    {
        public int ignesayisi;
        public override void YaprakDok()
        {
            Console.WriteLine(ad + " iğne döktü.");
        }
        public override void Buyu()
        {
            Console.WriteLine(ad + " büyüdü.");
            uzunluk = uzunluk + 2;
        }
    }
    public class cinar : agac
    {
        public int yapraksayisi;
        public override void YaprakDok()
        {
            Console.WriteLine(ad + " yaprak döktü.");
        }
        public override void Buyu()
        {
            Console.WriteLine(ad + " büyüdü.");
            uzunluk = uzunluk + 2;
        }
    }
}
