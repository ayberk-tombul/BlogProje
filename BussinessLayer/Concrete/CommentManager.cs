using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
	public class CommentManager : ICommentService
	{
		ICommentDal _commentdal;

		public CommentManager(ICommentDal commentdal)
		{
			_commentdal = commentdal;
		}

		public void CommentAdd(Comment comment)
		{
			throw new NotImplementedException();
		}

		public List<Comment> GetList(int id)
		{
			return _commentdal.GetListAll(x => x.BlogID == id);
		}
	}
}
