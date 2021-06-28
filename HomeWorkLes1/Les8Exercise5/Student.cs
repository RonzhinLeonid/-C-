using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Les8Exercise5
{
    public class Student
    {
        //public string lastName;
        //public string firstName;
        //public string university;
        //public string faculty;
        //public int course;
        //public string department;
        //public int group;
        //public string city;
        //public int age;

        string lastName;
        string firstName;
        string university;
        string faculty;
        int course;
        string department;
        int group;
        string city;
        int age;
        // Конструктор для сериализации 
        public Student()
        {
        }
        // Конструктор
        public Student(string firstName, string lastName, string university, string faculty, string department, int age, int course, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string University
        {
            get { return university; }
            set { university = value; }
        }
        public string Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public int Course
        {
            get { return course; }
            set { course = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Group
        {
            get { return group; }
            set { group = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public static List<Student> ReadCSV(string fileName)
        {
            List<Student> students = new List<Student>();    // Создаем список студентов
            StreamReader sr = new StreamReader(fileName);
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    // Добавляем в список новый экземпляр класса Student
                    students.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                }
                catch (Exception t)
                {
                    Console.WriteLine(t.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                }
            }
            sr.Close();
            return students;
        }
        public static void ConvertXML(string fileName, List<Student> students)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, students);
            fStream.Close();
        }

    }
}
