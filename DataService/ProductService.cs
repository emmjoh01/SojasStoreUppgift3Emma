using DAL;
using DAL.Models;
using DataService.DTOs;
using DataService.DTOS;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService
{
    public class ProductService
    {
        public List<ProductStatusDTO> GetProductsCountAndStatus()
        {
            List<ProductStatusDTO> productDTOs = new List<ProductStatusDTO>();
            using (var data = new StoreContext())
            {
                var products = data.Products;

                string productStatus = "Ingen status";

                foreach (var product in products)
                {
                    if (product.AmountInStore > 3) productStatus = "OK";
                    else if (product.AmountInStore <= 3 && product.AmountInStore >= 1) productStatus = "Snart slut";
                    else if (product.AmountInStore < 1) productStatus = "Slut";

                    productDTOs.Add(new ProductStatusDTO() { ProductName = product.Name, ProductCount = product.AmountInStore, ProductStatus = productStatus });
                }
            }

            return productDTOs;
        }
        public List<ProductCountDTO> GetProductsInDepartments(string departmentName, int productCount)
        {
            List<ProductCountDTO> productCountDTOs = new List<ProductCountDTO>();
            productCountDTOs.Clear();

            List<int> productIds = new List<int>();

            int departmentId = -1;

            using (var data = new StoreContext())
            {
                var products = data.Products;

                var department = data.Departments.FirstOrDefault(d => d.Name == departmentName);
                
                if (department is null)
                {
                    throw new Exception($"Avdelning med namn {departmentName} finns inte.");
                }
                else
                {
                    departmentId = department.DepartmentId;
                }

                productIds.AddRange(
                    (from dp in data.DepartmentProducts
                     where dp.DepartmentId == departmentId
                     select dp.ProductId).ToList());

                foreach (var productId in productIds)
                {
                    var product = data.Products.First(p => p.ProductId == productId);
                    if (product.AmountInStore <= productCount)
                    {
                        productCountDTOs.Add(new ProductCountDTO { ProductCount = product.AmountInStore, ProductName = product.Name });
                    }
                    
                }
               
            }

            return productCountDTOs;

        }
        public ProductCountDTO UpdateProduct(UpdateProductDTO updateProductDTO)
        {
            ProductCountDTO productCountDTO = new ProductCountDTO();
            using (var data = new StoreContext())
            {

                var product = data.Products.First(p => p.ProductId == updateProductDTO.ProductId);
                product.AmountInStore = updateProductDTO.NewCount;
                data.SaveChanges();

                productCountDTO.ProductName = product.Name;
                productCountDTO.ProductCount = product.AmountInStore;

            }
            return productCountDTO;
        }
    }
}
