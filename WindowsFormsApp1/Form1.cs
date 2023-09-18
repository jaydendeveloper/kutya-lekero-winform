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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        List<string> dogs = new List<string>()
            { "ddd", "ass"};


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
                    dogs.Add(line.Replace(",", "").Replace("\"", ""));

                    line = doc.ReadLine();
                }
                doc.Close();
            } catch (Exception ex)
            {

                File.Create("data.txt").Close();

            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            readDocData();

            foreach (string dog in dogs)
            {
                textBox.Text += dog + " ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            string text = textBox1.Text;
            string[] newDogs = text.Split(',');

            readDocData();

            foreach (string dog in newDogs)
            {
                if (!dogs.Contains(dog))
                {
                    StreamWriter doc = new StreamWriter("./data.txt", append: true);
                    doc.WriteLine("\"" + dog.Trim() + "\",");
                    doc.Close();
                } else
                {

                    label1.Text = "Ez a kutya (" + dog.Trim() + ") már létezik a listában";

                    Task.Delay(3000).ContinueWith(t =>
                    {
                        label1.Text = "";
                    });

                }
            }
            readDocData();

            foreach (string dog in dogs)
            {
                textBox.Text += dog + " ";
            }
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
                    StreamWriter doc = new StreamWriter("./data.txt", append: true);
                    dogs.Remove(dogForDelete.Trim());

                    foreach (string dog in dogs)
                    {
                        doc.WriteLine(dog);
                    };
                    doc.Close();
                }
            }

            textBox2.Text = "";


            textBox.Text = "";
            readDocData();

            foreach (string dog in dogs)
            {
                textBox.Text += dog + " ";
            }
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
    }
}
