﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Domain.Exceptions
{
    public class ValidationFailedException:Exception
    {
        public ValidationFailedException(string errorMessage, Exception innerException) :base(errorMessage, innerException){ }
    }
}
