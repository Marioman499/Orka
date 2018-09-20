using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Insta
{
    class BotPool
    {
        private List<Bot> Bot_Pool = new List<Bot>();

        public int Pool_Size()
        {
            return Bot_Pool.Count;
        }
        public Bot SendBot(string _id = null)
        {
            Bot temp;
            if (_id == null)
            {
                int _rand;
                Random Rn = new Random();
                if (Bot_Pool.Count >0)
                {
                    _rand = Rn.Next(0, Bot_Pool.Count - 1);
                     temp = Bot_Pool[_rand];
                    Bot_Pool.Remove(Bot_Pool[_rand]);
                    return temp;
                }
                else
                {
                    Console.WriteLine("error botsize is 0");
                    return null;
                }
               
            }
            else
            {
                if (SearchPool(_id))
                {
                    for (int i = 0; i < Bot_Pool.Count; i++)
                    {
                        if (_id == Bot_Pool[i].GetId())
                        {

                            temp = Bot_Pool[i];
                            Bot_Pool.Remove(Bot_Pool[i]);
                            return temp;
                        }
                        else
                        {

                        }
                    }
                }

            }
            return null;

        }

        public bool SearchPool(string Botid)
        {
            for (int i = 0; i < Bot_Pool.Count; i++)
            {
                if (Botid == Bot_Pool[i].GetId())
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
            Console.Clear();
            for (int i = 0; i < 10; i++)
            {
                Random Rand = new Random();
                Int32 id_num = Rand.Next(11111111, (99999999));
                Bot temp = new Bot();
                temp.SetId((id_num.ToString()));
                Console.WriteLine("adding bot with id[" + temp.GetId() + "]");
                Bot_Pool.Add(temp);
              //  System.Threading.Thread.Sleep(40);
                
            }
           // Console.ReadLine();
        }
    }
}
