﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;
using System.ComponentModel;


namespace Qumbu_Community_Health_Care_Center.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    
    public string FirstName { get; set; }
   
    public string LastName { get; set; }
    
    public DateTime DateOfBirth { get; set; }
    public string Gender { get; set; }
    
    public string Address { get; set; }
    
    public string City { get; set; }
    public string Role { get; set; }
    
    public int MobileNumber { get; set; }

}

