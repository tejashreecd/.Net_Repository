﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApproach
{
    public class Dept
    {
        [Key]
        public int Id { set; get; }
        public string Name { set; get; }
        public string Location { set; get; }
        public string ADDURL { set; get; }
    }
}
