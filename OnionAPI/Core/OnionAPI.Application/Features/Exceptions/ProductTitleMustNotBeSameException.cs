using OnionAPI.Application.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Application.Features.Exceptions
{
    public class ProductTitleMustNotBeSameException: BaseException
    {
        public ProductTitleMustNotBeSameException(): base("This title has already exist"){ }
    }
}
