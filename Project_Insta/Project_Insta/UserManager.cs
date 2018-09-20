using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Insta
{
    class UserManager
    {
        private List<Target> Targets = new List<Target>();
        private string user_R;
        //private StreamWriter FileWriter = new StreamWriter("C:\\Users\\hayde\\Project_Orka");


        public void AddTarget(Target _User)
        {
            Targets.Add(_User);
        }

        public void Start()
        {
            
            BotPool Bpool = new BotPool();
            Bpool.Generate();
            Console.Clear();
            Console.WriteLine("Asigning Bots to there respective targets\n");
            //System.Threading.Thread.Sleep(100);

            bool SortingComplete = false;
            while (!SortingComplete)
            {
                for (int i = 0; i < Targets.Count; i++)
                {
                    if (Targets[i].GetLinkSize() < 25)
                    {

                        Bot _temp = Bpool.SendBot();
                        if (_temp != null)
                        {


                            Console.WriteLine("Space Open in [" + Targets[i].GetName());
                            //System.Threading.Thread.Sleep(100);

                            if (Targets[i].SearchLink(_temp.GetId()))
                            {
                                Console.WriteLine("Bot already found inside Target list trying again!\n");
                                //System.Threading.Thread.Sleep(100);
                            }
                            else
                            {
                                Console.WriteLine("Bot [" + _temp.GetId() + "'s] Tracking registered to [" + Targets[i].GetName() + "]" + "'s]\n");
                                //System.Threading.Thread.Sleep(100);
                                Targets[i].addLink(_temp);

                            }

                        }
                    }
                    SortingComplete = true;

                }
                Console.Write("Checking pool size");
                Console.Write(".");
                //System.Threading.Thread.Sleep(500);
                Console.Write(".");
               // System.Threading.Thread.Sleep(500);
                Console.WriteLine(".\n");
               // System.Threading.Thread.Sleep(500);
                if (Bpool.Pool_Size() <= 0)
                {
                    Console.WriteLine("pool size has been reduced to 0\n");
                    //System.Threading.Thread.Sleep(100);
                }
                else
                {
                    Console.WriteLine("Pool Size greater then 0 [" + Bpool.Pool_Size() + "] Bots remaining\n");
                    //System.Threading.Thread.Sleep(100);

                    for (int x = 0; x < Targets.Count; x++)
                    {
                        if (Targets[x].GetLinkSize() < 25)
                        {
                            Console.WriteLine("Slots still open for [" + Targets[x].GetName() + "] Bots remaining [" + (25 - Targets[x].GetLinkSize()) + "]\n");
                            //System.Threading.Thread.Sleep(30);
                            SortingComplete = false;

                        }
                        else
                        {
                            Console.WriteLine("Slots full for [" + Targets[x].GetName() + "]\n");
                        }

                    }
                }
                if (Targets.Count <=0)
                {
                    SortingComplete = true;
                }


            }
            Console.WriteLine("Sorting complete");
            Console.ReadLine();
        }

        public void LoadUsers()
        {
            Int32 count = 0;
             //StreamWriter FileWriter = new StreamWriter("C:\\Users\\hayde\\Desktop\\Project_Orka\\InstaProfiles.txt");
     
            //FileWriter.WriteLine("List_of_active_subs");
            //FileWriter.WriteLine("https://www.instagram.com/hanxhoney/#Hannah");
            //FileWriter.WriteLine("https://www.instagram.com/jimmyw26/#James");
            //FileWriter.WriteLine("https://www.instagram.com/hayden.butler.969/#Hayden");
            //FileWriter.WriteLine("https://www.instagram.com/nawalgno/#Nawal");
            //FileWriter.WriteLine("https://www.instagram.com/hayleyb36/#Hayley");

            //FileWriter.Close();
        string[] splitter;
            StreamReader FileReader = new StreamReader("C:\\Users\\hayde\\Desktop\\Project_Orka\\InstaProfiles.txt");


            Console.WriteLine("Scanning for file");
            //System.Threading.Thread.Sleep(100);
            user_R = FileReader.ReadLine();
            if (user_R == "List_of_active_subs")
            {
                Console.WriteLine("all active Targets");
                while (user_R != null)
                {
                    user_R = FileReader.ReadLine();
                    if (user_R == null)
                    {
                        break;
                    }
                    splitter = user_R.Split('#');
                    Console.WriteLine("Url [" + splitter[0] + "] Name [" + splitter[1] + "]");
                    //System.Threading.Thread.Sleep(10000);
                    Targets.Add(new Target(splitter[0], splitter[1]));
                    count += 1;
                }
            Console.WriteLine("finished file loading Users loaded [" + count + "]" );
                System.Threading.Thread.Sleep(10000);
                //Console.ReadLine();
               
            }
            else
            {
               Console.Write("error missing or wrong file");
                Console.ReadLine();
            }
            //FileReader.Close();
        }




    }
}
