using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._2
{
    class DocHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("doc open file");
        }
        public override void Create()
        {
            Console.WriteLine("doc create file");
        }
        public override void Change()
        {
            Console.WriteLine("doc change file");
        }
        public override void Save()
        {
            Console.WriteLine("doc save file");
        }
    }
}
