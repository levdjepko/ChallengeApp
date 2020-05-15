using System;
namespace hundredDaysOf.Models
{
    public class Challenge
    {
        public string ChallengeName { get; set; }
        public int ChallengeId { get; set; }

        public Challenge(int id, string name)
        {
            this.ChallengeId = id;
            this.ChallengeName = name;
        }
    }
}
