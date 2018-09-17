using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Insta
{
    class Bot
    {
        private string UserName;

        private string PassWord;

        protected List<Comments> Comment_Log;
        protected Comments Active_Comment;

        public Bot()
        {
            UserName = "oof";
            PassWord = "you goofed";
        }
        public Bot(string user,string pass)
        {
            UserName = user;
            PassWord = PassWord;
        }

        public string GetUser()
        {
            return UserName;
        }
        public string GetPass()
        {
            return PassWord;
        }
        public void SetPass(string NewP)
        {
            PassWord = NewP;
        }
        public void SetUser(string NewU)
        {
            PassWord = NewU;
        }
         
        public void AddComment(Comments Com)
        {

            Comment_Log.Add(Com);
            Active_Comment = Com;
        }

        public void SearchComment(Comments _Com)
        {
            for (int i = 0; i < Comment_Log.Capacity; i++)
            {
               if (_Com.GetComment() == Comment_Log[i].GetComment())
                {

                }
            }
        }


    }
}
