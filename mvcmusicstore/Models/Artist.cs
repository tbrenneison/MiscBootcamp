﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcmusicstore.Models
{
    public class Artist
    {
        public virtual int ArtistId { get; set; }
        public virtual string Name { get; set; }
    }
}