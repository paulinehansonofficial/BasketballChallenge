using System;
using System.Collections.Generic;

namespace final_challenge.Models
{
    public class Game
    {
        public int GameId { get; set;}
        public DateTime Date { get; set; }

        public double CourtFee { get; set; }
        
	    public Member PaidBy { get; set; }
	    public string Location { get; set; }

        public ICollection<MemberGame> Players { get; set; }

    }
}