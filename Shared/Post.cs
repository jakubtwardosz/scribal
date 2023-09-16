using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scribal.Shared
{
    public class Post
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }

        /*public User Author { get; set; }*/
        public string Content { get; set; }
        public string Title { get; set; }
        public string Excerpt { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;

        /* 
         * To do later
         * 
         * public string CommentStatus { get; set; }
         * public int CommentCount { get; set; }
         * 
         * public DateTime PostModified { get; set; }
         * public string PostType { get; set; }
         */
    }
}
