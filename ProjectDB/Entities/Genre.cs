﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDB.Entities
{
    public class Genre
    {
        public int GenreID { get; set; }
        public string GenreName { get; set; }

        public virtual ICollection<Movies> Movies { get; set; }
    }
}
