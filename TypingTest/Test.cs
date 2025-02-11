using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace TypingTest
{
    public partial class Test : Form
    {
        static string words = "";
        static int wirds = 100;
        static int time = 30;
        String[] wordBank = { "fart", "was", "awful", "awesome", "terrible", "among", "us"};
        Random rnd = new Random();
        public Test()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
               words = words + wordBank[rnd.Next(0, wordBank.Length)] + " ";
            }
            richTextBox1.Text = words;


        }
        private void Form2_Load(object sender, EventArgs e)
        {
        }
        private void test1_Click(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void checkGme(object sender, KeyEventArgs e)
        {
            String[] wordList = words.Split(' ');
            String[] testList = (textBox1.Text).Split(' ');
            int errors = 0;
            if (e.KeyCode == Keys.Up)
            {
                for (int i = 0; i < wordList.Length; i++)
                {
                    if (wordList[i] != testList[i])
                    {
                        errors++;
                    }

                }
            }
            richTextBox1.Text = errors.ToString();
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
