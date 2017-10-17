using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ActiedoorPicture
    {
        public Guid Unid { get; set; }
        public Guid Pictureid { get; set; }
        public Guid Cardid { get; set; }
        public bool Isfavourite { get; set; }
        public int Rank { get; set; }

        public Actiedoor Card { get; set; }
        public Picture Picture { get; set; }
    }
}
