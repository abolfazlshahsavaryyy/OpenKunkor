using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenKunkor.Domain.ValueObject.Cohort
{
    //set the own relation for the 
    public class PhoneCoach
    {
        public string PhoneNumber { get; set; } = string.Empty;
        public string CoachUsername { get; set; } = string.Empty;
        public string CoachName { get; set; } = string.Empty;
        public static PhoneCoach Create(string phoneNumber,string coachUsername,string coachName)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(phoneNumber);
            ArgumentException.ThrowIfNullOrWhiteSpace(coachUsername);
            ArgumentException.ThrowIfNullOrWhiteSpace(coachName);
            return new PhoneCoach
            {
                PhoneNumber = phoneNumber,
                CoachUsername = coachUsername,
                CoachName=coachName
            };
        }
    }
}
