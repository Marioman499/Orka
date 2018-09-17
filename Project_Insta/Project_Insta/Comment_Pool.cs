using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Insta
{
    class Comment_Pool : Comments
    {
        private List<Comments> CommentPool;

        public Comments Send_Com()
        {
            return null;
        }
        public bool SearchPool(Comments _com)
        {
            for (int i = 0; i < CommentPool.Capacity; i++)
            {
                if (_com.GetComment() == CommentPool[i].GetComment() )
                {
                    return true;
                }
                else
                {

                }
            }
            return false;
        }
    }
}
