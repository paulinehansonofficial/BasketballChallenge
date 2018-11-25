using System;

namespace final_challenge.Models
{
    public class MemberGame
    {
        public int MemberGameId { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }

        public string Id { get; set; }
        public Member Member { get; set; }

    }
}