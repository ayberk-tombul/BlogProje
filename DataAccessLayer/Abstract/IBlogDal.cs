using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal : IGenericDal<Blog>
    {
        //Bu method sadece ilgili entityye(burda blog entity) ait bir method için yazılır...
        //Yalnız bunu yaptığında ilgili entitynin Entityframework classına gidio implement yapman gerekir!!! 
        List<Blog> GetListWithCategory();
    }
}
