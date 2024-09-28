using System;
using Core.Entities;

namespace Core.Interfaces;

public interface IProductRepository
{
   Task<IReadOnlyList<Product>> GetProductsAsync(string? brand, string? type, string? sort);

   Task<Product?> GetProductByIdAsync(int id);
   Task<IReadOnlyList<string>> GetBrandsAsync();
   Task<IReadOnlyList<string>> GetTypesAsync();
   void AddProuct (Product product);
   void UpdateProduct(Product product);
   void Deleteproduct(Product product);
   bool ProductExist(int id);
   Task<bool> SaveChangesAsync();

}
