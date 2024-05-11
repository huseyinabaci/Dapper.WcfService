using Dapper.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.WcfService
{
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        Task<IEnumerable<Product>> GetAllProductsAsync();

        [OperationContract]
        Task<Product> GetProductByIdAsync(int id);

        [OperationContract]
        Task<bool> AddProductAsync(Product product);

        [OperationContract]
        Task<bool> DeleteProductAsync(int id);

        [OperationContract]
        Task<bool> UpdateProductAsync(Product product);
    }
}
