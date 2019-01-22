namespace Pluralsight.DesignPatterns.Proxy.CachedRepository
{
    internal class CacheItem
    {
        private string cacheKey;
        private Order entity;

        public CacheItem(string cacheKey, Order entity)
        {
            this.cacheKey = cacheKey;
            this.entity = entity;
        }
    }
}