using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Archiefreden
    {
        public Archiefreden()
        {
            Actiedoor = new HashSet<Actiedoor>();
            Bestelaanvraag = new HashSet<Bestelaanvraag>();
            Bestellingen = new HashSet<Bestellingen>();
            Bezoeker = new HashSet<Bezoeker>();
            Campaign = new HashSet<Campaign>();
            Change = new HashSet<Change>();
            ChangeActivitytemplate = new HashSet<ChangeActivitytemplate>();
            ChangeTemplate = new HashSet<ChangeTemplate>();
            Changeactivity = new HashSet<Changeactivity>();
            Changeversion = new HashSet<Changeversion>();
            Configuratie = new HashSet<Configuratie>();
            Dnocontract = new HashSet<Dnocontract>();
            Dnodienst = new HashSet<Dnodienst>();
            Emailbericht = new HashSet<Emailbericht>();
            Gebruiker = new HashSet<Gebruiker>();
            Hardware = new HashSet<Hardware>();
            Incident = new HashSet<Incident>();
            Inventaris = new HashSet<Inventaris>();
            Leverancier = new HashSet<Leverancier>();
            Leveranciercontactpersoon = new HashSet<Leveranciercontactpersoon>();
            Licentie = new HashSet<Licentie>();
            Lmpactivity = new HashSet<Lmpactivity>();
            Lmpscenario = new HashSet<Lmpscenario>();
            Locatie = new HashSet<Locatie>();
            Meeting = new HashSet<Meeting>();
            Netwerkcomponent = new HashSet<Netwerkcomponent>();
            Object = new HashSet<Object>();
            OmActiviteit = new HashSet<OmActiviteit>();
            OmGroepering = new HashSet<OmGroepering>();
            OmReeks = new HashSet<OmReeks>();
            OmSchema = new HashSet<OmSchema>();
            Persoon = new HashSet<Persoon>();
            Persoongroep = new HashSet<Persoongroep>();
            Probleem = new HashSet<Probleem>();
            ProfacboomProject = new HashSet<ProfacboomProject>();
            Projectbeheerdocumenten = new HashSet<Projectbeheerdocumenten>();
            Recurringevent = new HashSet<Recurringevent>();
            Reportaction = new HashSet<Reportaction>();
            Reservation = new HashSet<Reservation>();
            Reservering = new HashSet<Reservering>();
            Servicelevel = new HashSet<Servicelevel>();
            Servicewindow = new HashSet<Servicewindow>();
            Shift = new HashSet<Shift>();
            Software = new HashSet<Software>();
            SsdForm = new HashSet<SsdForm>();
            Survey = new HashSet<Survey>();
            Taskrole = new HashSet<Taskrole>();
            Telefonie = new HashSet<Telefonie>();
            Vestiging = new HashSet<Vestiging>();
            Vrij1object = new HashSet<Vrij1object>();
            Vrij2object = new HashSet<Vrij2object>();
            Vrij3object = new HashSet<Vrij3object>();
            Vrij4object = new HashSet<Vrij4object>();
            Vrij5object = new HashSet<Vrij5object>();
        }

        public int Rang { get; set; }
        public Guid Unid { get; set; }
        public string Bespokememo { get; set; }
        public string Naam { get; set; }
        public int Archief { get; set; }

        public ICollection<Actiedoor> Actiedoor { get; set; }
        public ICollection<Bestelaanvraag> Bestelaanvraag { get; set; }
        public ICollection<Bestellingen> Bestellingen { get; set; }
        public ICollection<Bezoeker> Bezoeker { get; set; }
        public ICollection<Campaign> Campaign { get; set; }
        public ICollection<Change> Change { get; set; }
        public ICollection<ChangeActivitytemplate> ChangeActivitytemplate { get; set; }
        public ICollection<ChangeTemplate> ChangeTemplate { get; set; }
        public ICollection<Changeactivity> Changeactivity { get; set; }
        public ICollection<Changeversion> Changeversion { get; set; }
        public ICollection<Configuratie> Configuratie { get; set; }
        public ICollection<Dnocontract> Dnocontract { get; set; }
        public ICollection<Dnodienst> Dnodienst { get; set; }
        public ICollection<Emailbericht> Emailbericht { get; set; }
        public ICollection<Gebruiker> Gebruiker { get; set; }
        public ICollection<Hardware> Hardware { get; set; }
        public ICollection<Incident> Incident { get; set; }
        public ICollection<Inventaris> Inventaris { get; set; }
        public ICollection<Leverancier> Leverancier { get; set; }
        public ICollection<Leveranciercontactpersoon> Leveranciercontactpersoon { get; set; }
        public ICollection<Licentie> Licentie { get; set; }
        public ICollection<Lmpactivity> Lmpactivity { get; set; }
        public ICollection<Lmpscenario> Lmpscenario { get; set; }
        public ICollection<Locatie> Locatie { get; set; }
        public ICollection<Meeting> Meeting { get; set; }
        public ICollection<Netwerkcomponent> Netwerkcomponent { get; set; }
        public ICollection<Object> Object { get; set; }
        public ICollection<OmActiviteit> OmActiviteit { get; set; }
        public ICollection<OmGroepering> OmGroepering { get; set; }
        public ICollection<OmReeks> OmReeks { get; set; }
        public ICollection<OmSchema> OmSchema { get; set; }
        public ICollection<Persoon> Persoon { get; set; }
        public ICollection<Persoongroep> Persoongroep { get; set; }
        public ICollection<Probleem> Probleem { get; set; }
        public ICollection<ProfacboomProject> ProfacboomProject { get; set; }
        public ICollection<Projectbeheerdocumenten> Projectbeheerdocumenten { get; set; }
        public ICollection<Recurringevent> Recurringevent { get; set; }
        public ICollection<Reportaction> Reportaction { get; set; }
        public ICollection<Reservation> Reservation { get; set; }
        public ICollection<Reservering> Reservering { get; set; }
        public ICollection<Servicelevel> Servicelevel { get; set; }
        public ICollection<Servicewindow> Servicewindow { get; set; }
        public ICollection<Shift> Shift { get; set; }
        public ICollection<Software> Software { get; set; }
        public ICollection<SsdForm> SsdForm { get; set; }
        public ICollection<Survey> Survey { get; set; }
        public ICollection<Taskrole> Taskrole { get; set; }
        public ICollection<Telefonie> Telefonie { get; set; }
        public ICollection<Vestiging> Vestiging { get; set; }
        public ICollection<Vrij1object> Vrij1object { get; set; }
        public ICollection<Vrij2object> Vrij2object { get; set; }
        public ICollection<Vrij3object> Vrij3object { get; set; }
        public ICollection<Vrij4object> Vrij4object { get; set; }
        public ICollection<Vrij5object> Vrij5object { get; set; }
    }
}
