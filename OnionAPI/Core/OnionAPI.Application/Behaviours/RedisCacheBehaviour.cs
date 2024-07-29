using MediatR;
using OnionAPI.Application.Interfaces.RedisCache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Application.Behaviours
{
    public class RedisCacheBehaviour<TRequest,TResponse>:IPipelineBehavior<TRequest, TResponse>
    {
        private readonly IRedisCacheService _redisCacheService;

        public RedisCacheBehaviour(IRedisCacheService redisCacheService)
        {
            _redisCacheService = redisCacheService;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            if(request is ICachableQuery query)
            {
                var cacheKey = query.CacheKey;
                var cacheTime = query.CacheTime;

                var cachedData= await _redisCacheService.GetAsync<TResponse>(cacheKey);
                if (cachedData != null)
                {
                    return cachedData;
                }
                var response = await next();
                if(response is not null)
                    await _redisCacheService.SetAsync(cacheKey, response, DateTime.Now.AddMinutes(cacheTime));
                return response;
            }
            return await next();
        }
    }
}
