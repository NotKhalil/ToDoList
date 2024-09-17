using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Domain.Extensions;
using UserManagement.Domain.Models;

namespace UserManagement.Domain.Validation
{
    public class AddressValidator
    {
        public bool IsValid(Address address)
        {
            if(address.Street.HasNoValue()) return false;
            if(address.Street.Length < 5) return false;

            if(address.City.HasNoValue()) return false;

            if(address.ZipCode.HasNoValue()) return false;
            if(!address.ZipCode.MatchRegex("/^([\\d]{2})\\.*([\\d]{3})-*([\\d]{3})/")) return false;

            return true;
        }
    }
}
