using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._2
{
    class XmlHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("xml open file");
        }
        public override void Create()
        {
            Console.WriteLine("xml create file");
        }
        public override void Change()
        {
            Console.WriteLine("xml change file");
        }
        public override void Save()
        {
            Console.WriteLine("xml save file");
        }
    }
}
