using ProductApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Interfaces.Repository
{
    // IProductRepository'yi nerede generate ediyorsak Product ile ilgili işlemleri de orada yapacağız demektir.
    public interface IProductRepository : IGenericRepositoryAsync<Product>
    {

    }
}
