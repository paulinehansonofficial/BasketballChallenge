using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace final_challenge.Models
{
        public enum MemberStatus 
    {
        Approved = 1,
        Pending = 2,
        Denied = 3,
        Manager = 4
    }
    public class Member : IdentityUser
    {
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
	    public string LastName { get; set; }

        [DisplayName("Total Paid")]
	    public double TotalSpend { get; set; }
	    public MemberStatus Status { get; set; }
		
        [DisplayName("Games Played")]
        public ICollection<MemberGame> GamesPlayed { get; set; }
    }

    public class MemberRole : IdentityRole
    {}
}