﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCPM.Models
{
    public class Account
    {
       public int AccountId { get; set; }
       public string Username { get; set; }
        
       public string  Password { get; set; }
       public bool Status { get; set; }
    }
}
