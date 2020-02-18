﻿using System;
using System.Collections.Generic;

namespace MoviesAPI
{
    public partial class FilmCategory
    {
        public ushort FilmId { get; set; }
        public byte CategoryId { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual Category Category { get; set; }
        public virtual Film Film { get; set; }
    }
}
