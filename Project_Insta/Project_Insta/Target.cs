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
        private List<Bot> Linked_Bots = new List<Bot>();
        public Target(string _u, string _nam)
        {
            Profile_Url = _u;
            name = _nam;
        }

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
        public void addLink(Bot _Linker)
        {
            Linked_Bots.Add(_Linker);
        }
        public int GetLinkSize()
        {
            return Linked_Bots.Count;
        }
        public bool SearchLink(string Bot_ID)
        {
            for (int i = 0; i < Linked_Bots.Count; i++)
            {
                if (Linked_Bots[i].GetId() == Bot_ID)
                {
                    return true;
                }
            }
            return false;
        }


    }
}
