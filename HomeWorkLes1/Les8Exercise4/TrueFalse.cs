using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Les8Exercise4
{
    class TrueFalse
    {
        string fileName;
        List<Spending> list;
        public string FileName
        {
            set { fileName = value; }
        }
        public TrueFalse(string fileName)
        {
            this.fileName = fileName;
            list = new List<Spending>();
        }
        public void Add(string сostItem, decimal sum, int quantity)
        {
            list.Add(new Spending(сostItem, sum, quantity));
        }
        public void Remove(int index)
        {
            if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
        }
        // Индексатор - свойство для доступа к закрытому объекту
        public Spending this[int index]
        {
            get { return list[index]; }
        }
        /// <summary>
        /// Сохранить файл
        /// </summary>
        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Spending>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }
        /// <summary>
        /// Сохранить файл как
        /// </summary>
        /// <param name="fileNameAs"></param>
        public void Save(string fileNameAs)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Spending>));
            Stream fStream = new FileStream(fileNameAs, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }
        public void Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Spending>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = (List<Spending>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }
        public int Count
        {
            get { return list.Count; }
        }

    }
}
