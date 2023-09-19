using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
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
                StreamReader doc = new StreamReader("./data.json");
                string line;
                line = doc.ReadLine();

                while (line != null)
                {
                    dogs.Add(line.Replace(",", "").Replace("\"", ""));

                    line = doc.ReadLine();
                }
                doc.Close();
            } catch (Exception ex)
            {

                File.Create("data.txt").Close();

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

            readDocData();

                //if (!dogs.Contains(dog))
                //{

                    Dog kutya = new Dog(name, age, color);

                    dogs.Add(kutya.ToString());

                    JArray dogJsonItem = new JArray(dogs); //Convert newEvent to JArray.

                    JObject jsonObject = JObject.Parse(File.ReadAllText("./data.json"));

                    JArray jsonDogs = jsonObject["dogs"].Value<JArray>();

                    dogJsonItem.Add(jsonObject); //Insert new JArray object.

                    StreamWriter doc = new StreamWriter("./data.json", append: true);

                    doc.WriteLine(JsonConvert.SerializeObject(jsonDogs, Formatting.Indented));

                    doc.Close();
                //} else
                //{

                    //label1.Text = "Ez a kutya (" + dog.Trim() + ") már létezik a listában";

                    //Task.Delay(3000).ContinueWith(t =>
                    //{
                    //    label1.Text = "";
                    //});

            //}
            resetDataBox();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string text = textBox2.Text;
            string[] deleteDogs = text.Split(',');

            foreach (string dogForDelete in deleteDogs)
            {
                if (!dogs.Contains(dogForDelete.Trim()))
                {
                    label2.Text = "Nem létezik ilyen kutya (" + dogForDelete + ") a listában.";

                    Task.Delay(3000).ContinueWith(t =>
                    {
                        label2.Text = "";
                    });

                } else
                {
                    File.WriteAllText("./data.txt", string.Empty);
                    StreamWriter doc = new StreamWriter("./data.json", append: true);
                    dogs.Remove(dogForDelete.Trim());

                    foreach (string dog in dogs)
                    {
                        doc.WriteLine(dog);
                    };
                    doc.Close();
                }
            }

            textBox2.Text = "";


            resetDataBox();
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
    }
}
