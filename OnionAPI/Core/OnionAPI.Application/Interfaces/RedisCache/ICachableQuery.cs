using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Application.Interfaces.RedisCache
{
    public interface ICachableQuery
    {
        string CacheKey { get; }
        double CacheTime { get; }
    }
}
