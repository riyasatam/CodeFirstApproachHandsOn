using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movie_HandsOn.Models
{
    public class UserModel
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
     
        
        public int PhoneNo { get; set; }
    }
}
