using BlogProje.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BlogProje.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID = 1,
                    UserName = "Ayberk"
                },
                new UserComment
                {
                    ID= 2,
                    UserName="Mesut"
                },
                new UserComment
                {
                    ID=3,
                    UserName="Merve"
                }
            };
            return View(commentvalues);
        }
    }
}
