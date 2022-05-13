using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DesignPatterns_Part1
{
    class Clock
    {

        private static Clock instance;
        public DateTime time;
        private static readonly object key = new object();

        public Clock()
        {
            time = DateTime.Now;
        }

        public static Clock GetInstance()
        {
            if (instance == null)
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new Clock();
                    }
                }
            }
            return instance;
        }
        public DateTime GetTime()

        {
            return time;
        }
    }
}
