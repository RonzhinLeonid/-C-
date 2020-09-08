using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Les4Exercise4
{
    struct Account
    {

        public static bool Autorization(string userLogin, string userPassword)
        {
            string[,] arr = ReadFile("LoginPass.txt");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (userLogin.ToLower() == arr[i,0] && userPassword == arr[i, 1])
                {
                    return true;
                }
            }
            return false;
        }

        public static string[,] ReadFile(string path)
        {
            string[,] arr = new string[3,2];
            int i = 0;
            StreamReader sr = new StreamReader(path);
            while (!sr.EndOfStream)
            {
                var temp = sr.ReadLine().Split('\t');
                for (int j = 0; j < temp.Length; j++)
                {
                    arr[i,j] = temp[j];
                }
                i++;
            }
            sr.Close();
            return arr;
        }
    }
}
