﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoxPlannerApp.Models
{
    public class AppUser : IdentityUser<Guid>
    {
        public int CoolWheaterZone { get; set; }  
    }
}
