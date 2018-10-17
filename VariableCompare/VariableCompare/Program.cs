using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            CharCompareString();
            Console.ReadLine();
        }

        private static void CharCompareString()
        {
            string strReciveData = "/12345678901234567890>";
            Console.WriteLine("{0}和{1}的strReciveData[0]比较结果为{2}", '/', strReciveData, '/' == strReciveData[0]);
            Console.WriteLine("字符串{0}和{1}的strReciveData[0]比较结果为{2}", "/", strReciveData, '/' == strReciveData[0]);
            Console.WriteLine("{0}和{1}的strReciveData[22-1]比较结果为{2}", '>', strReciveData, '>' == strReciveData[22 - 1]);
        }
    }
}
