using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CCPM.Models;
namespace CCPM.Controllers
{
    public class PostsController : Controller
    {
        public IActionResult Index()
        {
            List<Post>
    posts = new List<Post>
        ();
            posts.Add(new Post
            {
                Id = 321564,
                Datasubmitted = DateTime.Parse("13/2/2001"),
                Tittle = "3453431",
                Status = true,

            });

            posts.Add(new Post
            {
                Id = 321564,
                Datasubmitted = DateTime.Parse("13/2/2001"),
                Tittle = "3453431",
                Status = true,
            });

            posts.Add(new Post
            {
                Id = 321564,
                Datasubmitted = DateTime.Parse("13/2/2001"),
                Tittle = "3453431",
                Status = true,
            });

            return View(posts);
        }
    }
}


