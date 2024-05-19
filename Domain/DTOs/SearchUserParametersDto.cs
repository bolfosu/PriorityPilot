﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    internal class SearchUserParametersDto
    {

        public string? UsernameContains { get; }

        public SearchUserParametersDto(string? usernameContains)
        {
            UsernameContains = usernameContains;
        }
    }
}
