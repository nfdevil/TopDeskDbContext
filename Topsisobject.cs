using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Topsisobject
    {
        public Topsisobject()
        {
            InverseParent = new HashSet<Topsisobject>();
        }

        public Guid? Classid { get; set; }
        public Guid? Parentid { get; set; }
        public string Cimname { get; set; }
        public string Cimdescription { get; set; }
        public string Cimdeviceid { get; set; }
        public Guid Id { get; set; }
        public DateTime? Datwijzig { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid? Uidaanmk { get; set; }
        public DateTime? Dataanmk { get; set; }
        public string Cimadaptertype { get; set; }
        public int? Cimbusnum { get; set; }
        public int? Cimbustype { get; set; }
        public string Cimdrive { get; set; }
        public string Cimhardwaretype { get; set; }
        public string Cimmacaddress { get; set; }
        public string Cimmanufacturer { get; set; }
        public string Cimmodel { get; set; }
        public string Cimmonitormanufacturer { get; set; }
        public int? Cimpointingtype { get; set; }
        public string Cimportname { get; set; }
        public string Cimprimarybustype { get; set; }
        public string Cimproductname { get; set; }
        public string Cimsecondarybustype { get; set; }
        public long? Cimsize { get; set; }
        public string Path { get; set; }
        public int? Cimendingaddress { get; set; }
        public int? Cimstartingaddress { get; set; }
        public string Cimhotfixid { get; set; }
        public string Cimdevicetype { get; set; }
        public long? Cimfreespace { get; set; }
        public long? Cimadapterram { get; set; }
        public string Cimfilesystem { get; set; }
        public string Cimlayout { get; set; }
        public long? Cimmaxbaudratetophone { get; set; }
        public string Cimserialnumber { get; set; }
        public string Cimversion { get; set; }
        public string Ldkcodepage { get; set; }
        public string Cimcaption { get; set; }
        public Guid Groupid { get; set; }
        public long? Cimmaxclockspeed { get; set; }
        public long? Cimcurrentclockspeed { get; set; }
        public string Cimcsdversion { get; set; }
        public long? Cimcapacity { get; set; }
        public string Cimdevicelocator { get; set; }
        public int? Cimspeed { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Topsisobjectclass Class { get; set; }
        public Topsisgroup Group { get; set; }
        public Topsisobject Parent { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public ICollection<Topsisobject> InverseParent { get; set; }
    }
}
