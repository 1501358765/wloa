using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class LogHelper
    {
        static Queue<string> queue = new Queue<string>();

        public static void WirteLog(string msg)
        {
            Task.Run(() => {
                queue.Enqueue(msg);
                //静态成员使用类名共享内存空间
                while (true)
                {
                    if (queue.Count > 0)
                    {
                        string line = queue.Dequeue();
                        log4net.LogManager.GetLogger("error").Error(line);
                    }
                }
            });
        }
    }
}
