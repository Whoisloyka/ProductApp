using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Persistance.Context;
using ProductApp.Persistance.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Persistance
{
    public static class ServiceRegistration
    {
        /* Normalde WebApi katmanında StartUp.cs'te Persistence katmanındaki ApplicationDbContext'i register etmemiz gerekirdi fakat biz burda bir tane metot yazıcaz ve bu registration işleminden burası sorumlu olucak.
         StartUp.cs'te sadece buradaki registration işlemini çağıracağız. */

        public static void AddPersistenceServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ApplicationDbContext>(opt => opt.UseInMemoryDatabase("memoryDb"));

            serviceCollection.AddTransient<IProductRepository, ProductRepository>();

        }
    
    
    
    }
}
