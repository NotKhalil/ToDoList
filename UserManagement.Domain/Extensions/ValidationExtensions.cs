using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserManagement.Domain.Extensions
{
    public static class ValidationExtensions
    {
        public static bool HasValue(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static bool MatchRegex(this string value, string pattern)
        {
            return Regex.IsMatch(value, pattern);
        }
    }
}
