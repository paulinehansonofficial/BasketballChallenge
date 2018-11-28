using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace final_challenge.Models
{
    public class Game
    {
        public int GameId { get; set;}
        public DateTime Date { get; set; }

        [DisplayName("Court Fee")]
        public double CourtFee { get; set; }

        [DisplayName("Paid By")]
	    public string PaidBy { get; set; }
	    public string Location { get; set; }

        public ICollection<MemberGame> Players { get; set; }

    }
}