using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Domain.Extensions;
using UserManagement.Domain.Models;

namespace UserManagement.Domain.Validation
{
    public class TaskValidator
    {
        public bool IsValid(Tasks task)
        {
            if (task.Title.HasNoValue()) return false;

            return true;
        }
    }
}
