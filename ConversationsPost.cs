using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ConversationsPost
    {
        public ConversationsPost()
        {
            ConversationsHide = new HashSet<ConversationsHide>();
            ConversationsLike = new HashSet<ConversationsLike>();
            InverseReplyToNavigation = new HashSet<ConversationsPost>();
        }

        public Guid Unid { get; set; }
        public Guid Operatorid { get; set; }
        public Guid? ReplyTo { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }

        public Actiedoor Operator { get; set; }
        public ConversationsPost ReplyToNavigation { get; set; }
        public ICollection<ConversationsHide> ConversationsHide { get; set; }
        public ICollection<ConversationsLike> ConversationsLike { get; set; }
        public ICollection<ConversationsPost> InverseReplyToNavigation { get; set; }
    }
}
