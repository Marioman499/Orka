using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Insta
{
    class Target
    {
        private string Profile_Url;
        private string name;

        public string getUrl()
        {
            return Profile_Url;
        }
        public string GetName()
        {
            return name;
        }
        public void setUrl(string _Url)
        {
            Profile_Url = _Url;
        }
        public void SetName(string _name)
        {
            name = _name;
        }


    }
}
