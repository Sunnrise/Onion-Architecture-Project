using OnionAPI.Application.Bases;
using OnionAPI.Application.Features.Exceptions;
using OnionAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Application.Features.Rules
{
    public class ProductRules: BaseRules
    {
        public Task ProductTitleMustNotBeSame(IList<Product>products, string requestTitle)
        {
            if(products.Any(x=>x.Title== requestTitle)) // check if title is already exist
            {
                throw new ProductTitleMustNotBeSameException();
            }
            else
            {
                return Task.CompletedTask;
            }
            

        }
    }
}
