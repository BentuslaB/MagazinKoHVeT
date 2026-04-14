using System.Data.SqlTypes;
using System.Diagnostics;
using System.IO;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string[] NameItem = new string[100];
        int[] Price = new int[100];
        string[] DescriptionItem = new string[100];
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ShowValues()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            for (int i = 0; i < count; i++)
            {
                listBox1.Items.Add(NameItem[i]);
                listBox2.Items.Add(Price[i]);
                listBox3.Items.Add(DescriptionItem[i]);
            }
        }
        void SaveFile()
        {
            saveFileDialog1.Title = "Сохранить:";
            saveFileDialog1.FileName = "File.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                FileStream file = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(file);
                for (int i = 0; i < count; i++)
                {
                    listBox1.Items.Add(NameItem[i]);
                    listBox2.Items.Add(Price[i]);
                    listBox3.Items.Add(DescriptionItem[i]);
                }
                writer.Close();
                file.Close();
            }
        }


        void OpenFile()
        {
            openFileDialog1.Title = "Загрузить:";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                FileStream file = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                StreamReader rd = new StreamReader(file);
                while (!rd.EndOfStream)
                {
                    NameItem[count] = rd.ReadLine();
                    Price[count] = int.Parse(rd.ReadLine());
                    DescriptionItem[count] = rd.ReadLine();
                    count++;
                }
                rd.Close();
                file.Close();
                ShowValues();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            NameItem[count] = textBox1.Text;
            Price[count] = int.Parse(textBox2.Text);
            DescriptionItem[count] = textBox3.Text;
            count++;
            label4.Text = "Кол-во:" + count;
            ShowValues();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
