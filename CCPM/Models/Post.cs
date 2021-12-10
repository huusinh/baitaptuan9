using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCPM.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string Tittle { get; set; }

        public DateTime Datasubmitted { get; set; }
        public bool Status { get; set; }
    }
}
