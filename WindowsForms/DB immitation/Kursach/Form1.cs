using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Kursach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                File.AppendAllText(@"C:\Industry.txt", textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + "," + textBox4.Text+","+textBox5.Text+","+ textBox6.Text+'\n');
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox5.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            FileStream file1 = new FileStream(@"D:\Industry.txt", FileMode.OpenOrCreate); //создаем файловый поток
            StreamReader reader = new StreamReader(file1); // создаем «потоковый читатель» и связываем его с файловым потоком
            string q;
            while((q = reader.ReadLine()) != null)
            {
                string[] w = q.Split(',');
                for(int i=0; i<w.Length/5; i++)
                {
                    dataGridView1.Rows.Add(w[0], w[1], w[2], w[3], w[4], w[5]);
                }
            }
            reader.Close(); //закрываем поток

            groupBox3.Visible = true;
        }


        private void button7_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows[0].Cells[0].Value != null)
            {
                System.IO.File.Delete(@"D:\Film.dll");
                FileStream file1 = new FileStream(@"C:\Industry.txt", FileMode.OpenOrCreate); //создаем файловый поток
                StreamWriter reader = new StreamWriter(file1);

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if(dataGridView1.Rows[i].Cells[0].Value != null)
                    {
                        reader.WriteLine(dataGridView1.Rows[i].Cells[0].Value + ", " + dataGridView1.Rows[i].Cells[1].Value + "," + dataGridView1.Rows[i].Cells[2].Value + "," + dataGridView1.Rows[i].Cells[3].Value + "," + dataGridView1.Rows[i].Cells[4].Value + "," + dataGridView1.Rows[i].Cells[5].Value);
                    }
                }
                reader.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку", "Внимание!");
                return;
            }

            int index = dataGridView1.SelectedRows[0].Index;

            if (dataGridView1.Rows[index].Cells[0].Value == null)
            {
                MessageBox.Show("Не все данные введены", "Внимание!");
                return;
            }

            dataGridView1.Rows.RemoveAt(index);

            System.IO.File.Delete(@"C:\Industry.txt");
            FileStream file1 = new FileStream(@"C:\Industry.txt", FileMode.OpenOrCreate); //создаем файловый поток
            StreamWriter reader = new StreamWriter(file1);

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null)
                {
                    reader.WriteLine(dataGridView1.Rows[i].Cells[0].Value + "," + dataGridView1.Rows[i].Cells[1].Value + "," + dataGridView1.Rows[i].Cells[2].Value + "," + dataGridView1.Rows[i].Cells[3].Value + "," + dataGridView1.Rows[i].Cells[4].Value);
                }
            }
            reader.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mp = "";
            int pribl;
            int max = int.MinValue;
            int xgod = Convert.ToInt32(textBox7.Text);
            for(int i=0; i<dataGridView1.RowCount; i++)
            {
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) == xgod)
                {
                    pribl = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) * Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                    if (pribl > max)
                    {
                        max = pribl;
                        mp = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                    }
                }
            }
            listBox1.Items.Add(mp);                   
            
            for (int i = 0; i < 15; i++)
            {
                dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Ascending);
                listBox2.Items.Add(dataGridView1.Rows[i].Cells[0].Value + "\n");
            }
            for (int i = 0; i < 30; i++)
            {
                dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);
                if (dataGridView1.Rows[i].Cells[5].Value != dataGridView1.Rows[i + 1].Cells[5].Value)
                {
                    listBox3.Items.Add(dataGridView1.Rows[i].Cells[0].Value);
                }              
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter_1(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
