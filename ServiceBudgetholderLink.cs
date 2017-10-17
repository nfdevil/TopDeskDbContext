using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ServiceBudgetholderLink
    {
        public Guid Unid { get; set; }
        public Guid Serviceid { get; set; }
        public Guid Budgetholderid { get; set; }
        public string Bespokememo { get; set; }
        public DateTime? Importdate { get; set; }
        public string Importid { get; set; }
        public int Importtype { get; set; }

        public Budgethouder Budgetholder { get; set; }
        public Dnodienst Service { get; set; }
    }
}
