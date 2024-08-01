using System.ComponentModel.DataAnnotations;

namespace Reza_Abbasinasl_HW14.Models
{
    public class SubscriptionViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDay { get; set; }
        public int CourseCode { get; set; }
        public string GenderCzheck { get; set; }
        public bool CheckRules { get; set; }
    }
}
