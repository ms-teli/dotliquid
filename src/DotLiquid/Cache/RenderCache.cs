using System;
using System.Collections.Generic;
using System.Text;

namespace DotLiquid.Cache
{
    public class RenderCache
    {
        private static readonly Dictionary<string, string> memCache = new Dictionary<string, string>();

        public bool TryGetValue(string cacheToken, out string value)
        {
            return memCache.TryGetValue(cacheToken, out value);
        }

        public void Add(string cacheToken, string cacheValue)
        {
            memCache.Add(cacheToken, cacheValue); 
        }
    }
}
