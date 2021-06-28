using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Les5Exercise4
{
    class Students
    {
        public string name;
        public string suname;
        public string rating1;
        public string rating2;
        public string rating3;

        public string SunameAndName
        {
            get { return $"{suname} {name}"; }
        }
        public double Score
        {
            get { return ScoreAverage(); }
        }

        public double ScoreAverage()
        {
            return (Convert.ToDouble(rating1) + Convert.ToDouble(rating2) + Convert.ToDouble(rating3)) / 3;
        }

        public static string[,] ReadFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            string[,] arr = new string[Convert.ToInt32(sr.ReadLine()), 5];
            int i = 0;
            
            while (!sr.EndOfStream)
            {
                var temp = sr.ReadLine().Split(' ');
                for (int j = 0; j < temp.Length; j++)
                {
                    arr[i, j] = temp[j];
                }
                i++;
            }
            sr.Close();
            return arr;
        }

        public static void MinScore(Students[] Student)
        {
            Dictionary<string, double> academicPerf = new Dictionary<string, double>();
            for (int i = 0; i < Student.Length; i++)
            {
                academicPerf.Add(Student[i].SunameAndName, Student[i].Score);
            }
            academicPerf = academicPerf.OrderBy(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
            int count = 0;
            double temp = 0;
            foreach (KeyValuePair<string, double> item in academicPerf)
            {
                if (count >= 3 && temp != item.Value) break;
                count++;
                temp = item.Value;
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

        }
    }
}
