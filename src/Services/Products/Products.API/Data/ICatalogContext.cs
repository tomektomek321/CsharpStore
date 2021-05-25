using MongoDB.Driver;
using Products.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products.API.Data {
    public interface ICatalogContext {

        IMongoCollection<Product> Products { get; }

    }
}
