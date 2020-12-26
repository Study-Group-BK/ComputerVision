using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

namespace ConsoleApp1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Mat M = new Mat(3, 3,DepthType.Cv8U, 1);
            M.SetTo(new MCvScalar(1));
            Console.Write(M.GetData(0,0));
            Console.ReadLine();
        }
    }
}
