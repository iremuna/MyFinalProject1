using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    //İş kodları yazılır
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
            
        }
        //Select  *from Categories where CategoryId =3

        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(c => c.CategoryID == categoryId);
            
        }
    }
}
