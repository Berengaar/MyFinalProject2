using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Extensions
{
    public static class ServiceCollectionExtensions     //Extension yazmak için class statik olmalıdır.
    {
        //Asp.net uygulamamızın yani apimizin servis bağımlılıklarını eklediğimiz ya da araya girmesini istediğimiz koleksiyonun kendisidir
        //this parametre değil genişletmek istediğim anlamına geliyor
        //İlk yazdığımızdan sonra gelen kısım parametre olur
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection serviceCollection,      //genişletme
            ICoreModule[] modules)      //Parametre
        {
            foreach (var module in modules)
            {
                module.Load(serviceCollection);
            }
            //Core katmanı da dahil olmak üzere ekleyeceğimizbütün injectionları bir araya toplayacağım yapıya döndü
            return ServiceTool.Create(serviceCollection);
        }  
    }
}
