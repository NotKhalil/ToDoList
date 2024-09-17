using System.Text.RegularExpressions;
using System.Xml.Linq;
using UserManagement.Domain.Extensions;
using UserManagement.Domain.Models;

namespace UserManagement.Domain.Validation
{
    public class UserValidator
    {
        public bool IsValid(User user) {
            if(user.Name.HasNoValue()) return false;
            if(user.Name.Length > 25 || user.Name.Length < 3) return false;

            if(user.Phone.HasNoValue()) return false;
            if(!user.Phone.MatchRegex(@"^[0 - 9\-\+]{ 9,15}$")) return false;

            if(user.Email.HasNoValue()) return false;
            if(!user.Email.MatchRegex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$")) return false;

            if(user.Password.HasNoValue()) return false;
            if(user.Password.Length < 5 || user.Password.Length > 20) return false;

            return true;
        }
    }
}
