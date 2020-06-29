using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TrueFalseNew.Models
{
    [Serializable]
    public class Questions
    {        
        public string Question { get; set; }
        public bool TrueFalse { get; set; }
        public Questions()
        {

        }
    }
    class QuestionsDataBase
    {
        public Action  updtable { get; set; } 
        public List<Questions> ql { get; set; } = new List<Questions>();

        public QuestionsDataBase()
        {   

        }
        public static void SaveData(string filename,List<Questions> list)
        {          
            XmlSerializer sr = new XmlSerializer(typeof(List<Questions>));
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            sr.Serialize(fs,list);
            fs.Close();
        }
        public void SaveDataToDatabase(DataGridViewRowCollection d)
        {
            ql.Clear();
            for (var i = 0; i < d.Count-1; i++)
            {
                if (d[i].Cells[0].Value == null) break;
                ql.Add(new Questions() { Question = d[i].Cells[0].Value.ToString(), TrueFalse = (d[i].Cells[1].Value == null || Convert.ToBoolean(d[i].Cells[1].Value) == false) ? false : true });
            }
            SaveData("DB.xml", ql);
            if(ql.Count != 0) ql.Clear();

        }
        public void LoadData()
        {
            if (!File.Exists("DB.xml")) return;
            XmlSerializer sr = new XmlSerializer(typeof(List<Questions>));
            FileStream fs = new FileStream("DB.xml", FileMode.Open, FileAccess.Read);
            ql = (List<Questions>)sr.Deserialize(fs);
            fs.Close();
        }
    }
}