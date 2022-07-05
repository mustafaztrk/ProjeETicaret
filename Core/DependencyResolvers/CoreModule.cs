﻿using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection servicesCollection)
        {
            servicesCollection.AddMemoryCache();//microsoft un sistemi 

            servicesCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            servicesCollection.AddSingleton<ICacheManager, MemoryCacheManager>();

            servicesCollection.AddSingleton<Stopwatch>();

        }
    }
}
