using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class BlogManager : IBlogServive
    {
        IBlogDal _blogdal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogdal = blogDal;
        }
        public void BlogAdd(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void BlogDelete(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void BlogUptade(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogsListWithCategory()
        {
            return _blogdal.GetListWithCategory();
        }

        public Blog GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogByID(int id)
        {
            return _blogdal.GetListAll(x => x.BlogID == id);
        }

        public List<Blog> GetList()
        {
            return _blogdal.GetListAll();
        }
    }
}
