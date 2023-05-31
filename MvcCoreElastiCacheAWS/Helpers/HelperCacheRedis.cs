using Microsoft.Extensions.Caching.Distributed;
using StackExchange.Redis;

namespace MvcCoreElastiCacheAWS.Helpers
{
    public class HelperCacheRedis
    {



        string a;
        



        private static Lazy<ConnectionMultiplexer> CreateConnection =
       new Lazy<ConnectionMultiplexer>(() =>
       {
            //AQUI ES DONDE IRA LA CADENA DE CONEXION
           return ConnectionMultiplexer.Connect("cache-coches.9nvvhu.ng.0001.use1.cache.amazonaws.com:6379");
       });

        public static ConnectionMultiplexer Connection
        {
            get { return CreateConnection.Value; }
        }


    }
}
