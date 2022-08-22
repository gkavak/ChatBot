using ChatBot.Common.Utils.CrossCuttingConcerns.Caching;
using ChatBot.Common.Utils.CrossCuttingConcerns.Caching.MicrosoftCacheManager;
using ChatBot.Common.Utils.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;


namespace ChatBot.Common.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMemoryCache();
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            serviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>();
        }
    }
}
