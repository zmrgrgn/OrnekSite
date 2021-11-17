using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrnekSite.Models
{
    public class StateModel
    {
        public int UrunSayısı { get; set; }
        public int SiparisSayısı { get; set; }
        public int BekleyenSiparisSayısı { get; set; }
        public int TamamlananSiparisSayısı { get; set; }
        public int KargolananSiparisSayısı { get; set; }
        public int PaketlenenSiparisSayısı { get; set; }
    }
}