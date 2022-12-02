﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebebul.Core.DTOs
{
    public class CategoryWithUsersDto : CategoryDto
    {
        public List<UserDto> Users { get; set; }
    }
}
