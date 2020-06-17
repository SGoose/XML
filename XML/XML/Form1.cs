using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace XML
{
    public partial class Form1 : Form
    {
        XmlSerializer xs;
        List<Student_class> ls;
        public Form1()
        {
            InitializeComponent();
        
            xs = new XmlSerializer(typeof(List<Student_class>));
            ls = new List<Student_class>();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            FileStream fs = new FileStream("C:/Users/User/source/repos/XML/Lab1.xml", FileMode.Create, FileAccess.Write);
            Student_class sc = new Student_class();
            sc.name = name.Text;
            sc.work = Work.Text;
            sc.Adress = Adress.Text;
            sc.workNumber = WorkNumb.Text; 
            sc.Number = TNumb.Text;

            ls.Add(sc);
            xs.Serialize(fs, ls);
            fs.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)  
        {
            FileStream fs = new FileStream("C:/Users/User/source/repos/XML/Lab1.xml", FileMode.Open, FileAccess.Read);
            ls = (List<Student_class>)xs.Deserialize(fs);

            dataGridView1.DataSource = ls;
            fs.Close();
        }
    }
}
