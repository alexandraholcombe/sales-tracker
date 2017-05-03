using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SalesTracker.Models
{
    public class User : IdentityUser
    {
        public override bool Equals(System.Object otherUser)
        {
            if (!(otherUser is User))
            {
                return false;
            }
            else
            {
                User newUser = (User)otherUser;
                return this.Id.Equals(newUser.Id);
            }
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
        
        //void DeleteAll()
        //{

        //}
    }
}
