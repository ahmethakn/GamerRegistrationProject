using System;
using System.Collections.Generic;
using System.Text;

namespace GamerRegistrationProject.Entities
{
    public class Member
    {
        public long NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DateOfBirth { get; set; }
        public string NickName { get; set; }
        public string Password { get; set; }

    }
}
