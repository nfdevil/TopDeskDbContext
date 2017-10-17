using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Topsisobjectclass
    {
        public Topsisobjectclass()
        {
            InverseParent = new HashSet<Topsisobjectclass>();
            Topsisobject = new HashSet<Topsisobject>();
        }

        public string Class { get; set; }
        public Guid? Parentid { get; set; }
        public int Hasname { get; set; }
        public int Hascaption { get; set; }
        public int Hasdescription { get; set; }
        public int Hasdeviceid { get; set; }
        public Guid Id { get; set; }
        public DateTime? Datwijzig { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid? Uidaanmk { get; set; }
        public DateTime? Dataanmk { get; set; }
        public bool Scan { get; set; }
        public int Hasadaptertype { get; set; }
        public int Hasbusnum { get; set; }
        public int Hasbustype { get; set; }
        public int Hasdevicetype { get; set; }
        public int Hasdrive { get; set; }
        public int Hashardwaretype { get; set; }
        public int Hasmacaddress { get; set; }
        public int Hasmanufacturer { get; set; }
        public int Hasmodel { get; set; }
        public int Hasmonitormanufacturer { get; set; }
        public int Haspointingtype { get; set; }
        public int Hasportname { get; set; }
        public int Hasprimarybustype { get; set; }
        public int Hasproductname { get; set; }
        public int Hassecondarybustype { get; set; }
        public int Hassize { get; set; }
        public int Hasendingaddress { get; set; }
        public int Hasstartingaddress { get; set; }
        public int Hasfreespace { get; set; }
        public int Hasadapterram { get; set; }
        public int Hasfilesystem { get; set; }
        public int Haslayout { get; set; }
        public int Hasmaxbaudratetophone { get; set; }
        public int Hasserialnumber { get; set; }
        public int Hasversion { get; set; }
        public int Hasmaxclockspeed { get; set; }
        public int Hascurrentclockspeed { get; set; }

        public Topsisobjectclass Parent { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public ICollection<Topsisobjectclass> InverseParent { get; set; }
        public ICollection<Topsisobject> Topsisobject { get; set; }
    }
}
