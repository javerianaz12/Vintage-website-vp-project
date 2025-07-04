using System.Collections.Generic;
using Vintage.Entities;
using Vintage.Interfaces;

namespace Vintage.BLL
{
    public class CategoryBLL
    {
        private readonly ICategoryDAL categoryDAL;

        public CategoryBLL(ICategoryDAL categoryDAL)
        {
            this.categoryDAL = categoryDAL;
        }

        public List<Category> Getcategories()
        {
            return categoryDAL.Getcategories();
        }

        public Category GetcategoryById(int id)
        {
            return categoryDAL.GetcategoryById(id);
        }

        public void Addcategory(Category category)
        {
            categoryDAL.Addcategory(category);
        }

        public void Updatecategory(Category category)
        {
            categoryDAL.Updatecategory(category);
        }

        public void Deletecategory(int id)
        {
            categoryDAL.Deletecategory(id);
        }
    }
}
