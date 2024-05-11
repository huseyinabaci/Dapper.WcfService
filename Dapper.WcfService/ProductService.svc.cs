using Dapper.Application.Interfaces;
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
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _unitOfWork.Products.GetAllAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _unitOfWork.Products.GetByIdAsync(id);
        }

        public async Task<bool> AddProductAsync(Product product)
        {
            return Convert.ToBoolean(await _unitOfWork.Products.AddAsync(product));
        }

        public async Task<bool> DeleteProductAsync(int id)
        {
            return Convert.ToBoolean(await _unitOfWork.Products.DeleteAsync(id));
        }

        public async Task<bool> UpdateProductAsync(Product product)
        {
            return Convert.ToBoolean(await _unitOfWork.Products.UpdateAsync(product));
        }
    }
}
