﻿using OnionAPI.Application.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Application.Features.Auth.Exceptions
{
    public class UserAlreadyExistException: BaseException
    {
        public UserAlreadyExistException() : base("User already exist")
        {
        }

    }
}
