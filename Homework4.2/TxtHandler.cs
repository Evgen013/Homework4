using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._2
{
    class TxtHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("txt open file");
        }
        public override void Create()
        {
            Console.WriteLine("txt create file");
        }
        public override void Change()
        {
            Console.WriteLine("txt change file");
        }
        public override void Save()
        {
            Console.WriteLine("txt save file");
        }
    }
}
