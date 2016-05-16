using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter_Test
{
    public static class NumberManager
    {
        public static int getNewNum()
        {
            //Path to number file
            string path = "C:\\Users\\Chris Gungaloo\\Documents\\Visual Studio 2015\\Projects\\Twitter_Test\\Twitter_Test\\NumCount.txt";
            string numString = System.IO.File.ReadAllText(path);
            Console.WriteLine(numString);
            int currentNum = Int32.Parse(numString);
            currentNum++;
            System.IO.StreamWriter file = new System.IO.StreamWriter(path);
            file.Write("");
            file.Write(currentNum);
            file.Close();
            return currentNum;
        }
    }
}
