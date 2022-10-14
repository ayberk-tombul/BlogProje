using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IBlogServive
    {
        void BlogAdd(Blog blog);
        void BlogDelete(Blog blog);
        void BlogUptade(Blog blog);
        List<Blog> GetList();
        Blog GetById(int id);

        List<Blog> GetBlogsListWithCategory();
    }
}
