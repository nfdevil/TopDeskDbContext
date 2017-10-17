using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class CartContents
    {
        public Guid Id { get; set; }
        public Guid CartId { get; set; }
        public Guid ItemId { get; set; }

        public Carts Cart { get; set; }
    }
}
