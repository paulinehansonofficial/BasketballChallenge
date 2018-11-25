using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

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
        public string FirstName { get; set; }
	    public string LastName { get; set; }

	    public double TotalSpend { get; set; }
	    public MemberStatus Status { get; set; }
		
        public ICollection<MemberGame> GamesPlayed { get; set; }
    }

    public class MemberRole : IdentityRole
    {}
}