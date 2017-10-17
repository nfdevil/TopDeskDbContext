using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Ldapsettings
    {
        public Ldapsettings()
        {
            VestigingOtherLdapServerPublicNavigation = new HashSet<Vestiging>();
            VestigingOtherLdapServerSecureNavigation = new HashSet<Vestiging>();
        }

        public Guid Unid { get; set; }
        public string Name { get; set; }
        public bool Useforpublic { get; set; }
        public bool Useforsecure { get; set; }
        public int Port { get; set; }
        public bool Ssl { get; set; }
        public int Sslport { get; set; }
        public int Authenticationmethod { get; set; }
        public string Root { get; set; }
        public bool? Anonymous { get; set; }
        public string Principal { get; set; }
        public string Credentials { get; set; }
        public string Dnmask { get; set; }
        public string Ldapfilter { get; set; }
        public string Server { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public ICollection<Vestiging> VestigingOtherLdapServerPublicNavigation { get; set; }
        public ICollection<Vestiging> VestigingOtherLdapServerSecureNavigation { get; set; }
    }
}
