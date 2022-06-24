using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ZR zr = new ZR();
            JL jl = new JL();
            ZJL zjl = new ZJL();
            zr.SetHandler(jl);
            jl.SetHandler(zjl);
            int n =int.Parse( Console.ReadLine());
            zr.Dohandler(n);
            //Handler handler = jl.GetHandler();
            //handler.Dohandler();
        }

        public class ZR : Handler
        {
            public override void Dohandler(int day)
            {
                if (day<3)
                {
                    Console.WriteLine("主任:我能做");
                }
                else{
                    Console.WriteLine("主任:我干不了,你去找经理吧");
                    this.GetHandler().Dohandler(day);
                    //this.SetHandler(new JL());

                }
                
            }
        }
        public class JL : Handler
        {
            public override void Dohandler(int day)
            {
                if (day < 7)
                {
                    Console.WriteLine("经理:我能做，但是得加钱");
                }
                else
                {
                    Console.WriteLine("经理:我干不了,你去找总经理吧");
                    this.GetHandler().Dohandler(day);
                    //this.SetHandler(new ZJL());

                }
            }
        }
        public class ZJL : Handler
        {
            public override void Dohandler(int day)
            {
                if (day < 30)
                {
                    Console.WriteLine("总经理:你们这些吃干饭的");
                }
                else
                {
                    Console.WriteLine("总经理:没一个能干的，公司倒闭了吧");
                }
            }
        }

        public abstract class Handler
        {
            private Handler handler;

            public void SetHandler(Handler handler)
            {
                this.handler = handler;
            }

            public Handler GetHandler()
            {
                return handler;
            }
            public abstract void Dohandler(int day);


        }
    }
}
