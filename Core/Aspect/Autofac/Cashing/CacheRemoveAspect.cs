using Core.Utilities.Interceptors;
using System;
using System.Collections.Generic;
using System.Text;
using Core.CrossCuttingConcerns.Cashing;
using Core.Utilities.IoC;
using Castle.DynamicProxy;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Aspect.Autofac.Cashing
{
    public class CacheRemoveAspect : MethodInterception
    {
        private string _pattern;
        private ICasheManager _cacheManager;

        public CacheRemoveAspect(string pattern)
        {
            _pattern = pattern;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICasheManager>();
        }

        protected override void OnSuccess(IInvocation invocation)
        {
            _cacheManager.RemoveByPattern(_pattern);
        }
    }
}
