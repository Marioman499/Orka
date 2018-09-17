using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Insta
{
    class BotPool
    {
        private List<Bot> Bot_Pool;

        public bool SearchPool(Bot _bot)
        {
            for (int i = 0; i < Bot_Pool.Capacity; i++)
            {
                if (_bot.GetId() == Bot_Pool[i].GetId())
                {
                    return true;
                }
                else
                {

                }
            }
            return false;
        }
        public void Generate()
        {

        }
    }
}
