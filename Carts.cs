using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Carts
    {
        public Carts()
        {
            CartContents = new HashSet<CartContents>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid UserId { get; set; }

        public Gebruiker User { get; set; }
        public ICollection<CartContents> CartContents { get; set; }
    }
}
