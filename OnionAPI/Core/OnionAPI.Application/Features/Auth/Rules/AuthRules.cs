using OnionAPI.Application.Bases;
using OnionAPI.Application.Features.Auth.Exceptions;
using OnionAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Application.Features.Auth.Rules
{
    public class AuthRules : BaseRules
    {
        public Task UserShouldNotBeExist(User? user)
        {
            if (user != null)
            {
                throw new UserAlreadyExistException();

            }
            return Task.CompletedTask;
        }
    }
}