using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApp1
{
    public partial class Kutyaszar : Form
    {
        public Kutyaszar()
        {
            InitializeComponent();

        }

        List<string> dogs = new List<string>()
            {};


        class Dog
        {
            public string Name;
            public int Age;
            public string Color;

            public Dog(string name, int age, string color)
            {
                Name = name;
                Age = age;
                Color = color;
            }

        }

        public void readDocData()
        {
            try
            {
                dogs.Clear();
                StreamReader doc = new StreamReader("./data.txt");
                string line;
                line = doc.ReadLine();

                while (line != null)
                {
                    dogs.Add(line/*.Replace(",", "").Replace("\"", "")*/);


                    line = doc.ReadLine();
                }
                doc.Close();
            } catch (Exception ex)
            {
                File.Create("data.txt").Close();
                readLabel.Text = ex.Message + "\n Új fájl létrehozva!";
            }
        }

        public void resetDataBox()
        {
            textBox.Text = "";
            readDocData();

            foreach (string dog in dogs)
            {
                textBox.Text += dog + " ";
            }
            dogCount.Text = "Összesen " + dogs.Count.ToString() + " kutya.";
        }

        public void addJsonData()
        {
            string text = jsonBox.Text;

            string[] datas = text.Split(' ');

            StreamWriter doc = new StreamWriter("./data.txt", append: true);


            foreach (string data in datas)
            {
                dogs.Add(data);
                doc.WriteLine(data);

            }
            doc.Close();
            jsonBox.Text = "";
            resetDataBox();
        }

        public void removeDogs()
        {
            string text = textBox2.Text;
            if(text != "")
            {
                string[] deleteDogs = text.Split(',');

                var file = File.Create("tempfile.txt");
                file.Close();

                foreach (string dogForDelete in deleteDogs)
                {
                    //StreamReader doc = new StreamReader("./data.txt");

                    var lines = File.ReadLines("./data.txt");
                    foreach (var line in lines)
                    {
                        if (!line.Contains(dogForDelete.Trim()))
                        {
                            StreamWriter tempDoc = new StreamWriter("./tempfile.txt", append: true);

                            tempDoc.WriteLine(line);
                            tempDoc.Close();
                        }
                    }
                    File.Delete("./data.txt");

                    System.IO.File.Move("tempfile.txt", "data.txt");
                }

                textBox2.Text = "";
            }


            resetDataBox();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetDataBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            string name = textBox_name.Text.Trim();
            int age = Convert.ToInt32(textBox_age.Text.Trim());
            string color = textBox_color.Text.Trim();
            Dog dog = new Dog(name, age, color);
            var dogJson = JsonConvert.SerializeObject(dog);


            readDocData();

            if (!dogs.Contains(dogJson))
                {
                    dogs.Add(dogJson);

                //JArray dogJsonItem = new JArray(dogs); //Convert newEvent to JArray.

                //JObject jsonObject = JObject.Parse(File.ReadAllText("./data.json"));

                //JArray jsonDogs = jsonObject["dogs"].Value<JArray>();

                //dogJsonItem.Add(jsonObject); //Insert new JArray object.

                    StreamWriter doc = new StreamWriter("./data.txt", append: true);

                    doc.WriteLine(dogJson + ",");

                    doc.Close();
                } else
                {

                    label1.Text = "Ez a kutya (" + dog + ") már létezik a listában";

                    Task.Delay(3000).ContinueWith(t =>
                    {
                        label1.Text = "";
                    });
            }
            resetDataBox();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            removeDogs();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            readDocData();
            resetDataBox();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void jsonButton_Click(object sender, EventArgs e)
        {
            addJsonData();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void egerle(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

     }
}
