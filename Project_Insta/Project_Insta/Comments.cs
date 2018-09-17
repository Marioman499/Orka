using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Insta
{
    class Comments
    {
        private string Comment;

        public Comments()
        {
            Comment = "YES";
        }
        public Comments(string _Comment)
        {
            Comment = _Comment;
        }
        public string GetComment()
        {
            return Comment;
        }
        public void SetComment(string _com)
        {
            Comment = _com;
        }
    }
}
