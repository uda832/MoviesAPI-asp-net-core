﻿using System;
using System.Collections.Generic;

namespace MoviesAPI
{
    public partial class Actor
    {
        public Actor() { }

        public ushort ActorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
