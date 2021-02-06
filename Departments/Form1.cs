using System;
using System.Collections.Generic;
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
            chart.Titles.Add("Departments");
            chart.Series["s1"].Points.AddXY("1", "34");
            chart.Series["s1"].Points.AddXY("2", "33");
            chart.Series["s1"].Points.AddXY("3", "23");
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

            // Carga la tabla
            Hashtable temp = manager.getDeps();
            foreach(DictionaryEntry element in temp)
            {
                Department dep = (Department)element.Value;

                List <Municipality> mun = dep.GetMunicipalities();

                foreach(Municipality entry in mun)
                {
                    int n = table.Rows.Add();

                    table.Rows[n].Cells[0].Value = dep.getCode();
                    table.Rows[n].Cells[1].Value = dep.getName();
                    table.Rows[n].Cells[2].Value = entry.GetCode();
                    table.Rows[n].Cells[3].Value = entry.GetName();
                    table.Rows[n].Cells[4].Value = entry.Gettype();

                }

            }
            graphButton.Enabled = true;
            comboBox.Enabled = true;
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
            table.Rows.Clear();
            char letter = comboBox.SelectedItem.ToString()[0];
            Hashtable temp = manager.getDeps();
            foreach (DictionaryEntry element in temp)
            {
                Department dep = (Department)element.Value;
                string name = dep.getName();

                if (name[0].Equals(letter)){
                    List<Municipality> mun = dep.GetMunicipalities();
                    foreach (Municipality entry in mun)
                    {
                        int n = table.Rows.Add();

                        table.Rows[n].Cells[0].Value = dep.getCode();
                        table.Rows[n].Cells[1].Value = dep.getName();
                        table.Rows[n].Cells[2].Value = entry.GetCode();
                        table.Rows[n].Cells[3].Value = entry.GetName();
                        table.Rows[n].Cells[4].Value = entry.Gettype();

                    }
                }

            }
        }
    }
}
