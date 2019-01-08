using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamAndIOSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Stream stream = IOService.FileToStream(@"C:\\pn_514.png");
            IOService.StreamToFile(@"D:\\pn_514.png", stream);
        }
    }
}
