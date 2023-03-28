﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactionTimeApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<ReactionTest> ReationTest { get; set; }
    }
}
