﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public class UserDto
    {
        public int Id { get; init; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
