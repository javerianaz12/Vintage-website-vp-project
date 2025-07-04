using Vintage.Entities;
using System.Collections.Generic;
using Vintage.Interfaces;
namespace Vintage.BLL
{
    public class productBLL
    {
        private readonly IProductDAL productDAL;

        public productBLL(IProductDAL ProductDAL)
        {
            this.productDAL = ProductDAL;
        }

        public List<Product> Getproduct()
        {
            return productDAL.Getproduct();
        }

        public void Addproduct(Product product)
        {
            productDAL.Addproduct(product);
        }

        public void Updateproduct(Product product)
        {
            productDAL.Updateproduct(product);
        }

        public void Deleteproduct(int id)
        {
            productDAL.Deleteproduct(id);
        }

        public void Getproductbyid(int id)
        {
            productDAL.Getproductbyid(id);
        }
    }
}
