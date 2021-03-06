﻿using System;
using System.Collections.Generic;

#nullable disable

namespace gamespace_api.Models
{
    public partial class Status
    {
        public Status()
        {
            Bugs = new HashSet<Bug>();
            Games = new HashSet<Game>();
            Reviews = new HashSet<Review>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Bug> Bugs { get; set; }
        public virtual ICollection<Game> Games { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
