using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Departments
{
    public partial class Form1 : Form
    {
        private Manager manager;
        public Form1()
        {
            manager = new Manager();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (var reader = new StreamReader(openFileDialog1.FileName))
                {
                    String raw = reader.ReadLine();
                    while (raw!=null && flag)
                    {
                        raw = reader.ReadLine();
                        string[] report = raw.Split(',');
                        if (report[0].Equals("Fuente: DANE."))
                        {
                            flag = false;
                        }
                        else
                        {
                            manager.addDepartment(report[2], report[0]);
                            manager.addMunicipality(report[0], report[3], report[1], report[4]);
                        }
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
