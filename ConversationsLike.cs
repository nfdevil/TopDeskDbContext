using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ConversationsLike
    {
        public Guid Unid { get; set; }
        public Guid Messageid { get; set; }
        public Guid Operatorid { get; set; }

        public ConversationsPost Message { get; set; }
        public Actiedoor Operator { get; set; }
    }
}
