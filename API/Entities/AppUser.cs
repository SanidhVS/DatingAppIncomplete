﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; } //Naming convention for Entity framework(PK)

        public string UserName { get; set; } //Pascal Case naming convention
    }
}
