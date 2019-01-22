using Microsoft.Extensions.Caching.Memory;

namespace Pluralsight.DesignPatterns.Proxy.CachedRepository
{
    public class CachedRepository : OrderRepository
    {
        private IMemoryCache cache;

        public CachedRepository(IMemoryCache cache)
        {
            this.cache = cache;
        }

        public override Order GetOrder(int id)
        {
            string cacheKey = "OrderEntity-" + id;
            var entity = cache.Get(cacheKey) as Order;

            if (entity == null)
            {
                entity = base.GetOrder(id);
                var cacheItem = new CacheItem(cacheKey, entity);
                cache.CreateEntry(cacheItem);
            }

            return entity;
        }
    }
}
