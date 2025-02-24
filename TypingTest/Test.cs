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
using System.Drawing.Drawing2D;
namespace TypingTest
{
    public partial class Test : Form
    {

        public class Typer
        {
            public String words = "";
            public int wordCount;
            public int time;
            public String[] wordBank;

            // Constructor
            public Typer(String words, int wordCount, int time, String[] wordBank)
            {
                this.words = words;
                this.wordCount = wordCount;
                this.time = time;
                this.wordBank = wordBank;
            }
        }
        static String[] currentWords = { "fart", "was", "awful", "awesome", "terrible", "among", "us", "You", "Know" };
        Typer thing = new Typer(" ", 35, 35, currentWords);
        Random rnd = new Random();
        public Test()
        {
            
            InitializeComponent();
            thing.words = thing.words.Trim();

            for (int i = 0; i < 5; i++)
            {
               thing.words = thing.words + thing.wordBank[rnd.Next(0, thing.wordBank.Length)] + " ";
                if (i == 4)
                {
                    thing.words = thing.words + thing.wordBank[rnd.Next(0, thing.wordBank.Length)];
                }
            }
            richTextBox1.Text = thing.words;


        }
        private void Form2_Load(object sender, EventArgs e)
        {
        }
        private void test1_Click(object sender, EventArgs e)
        {
        }

       
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void playGame(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] wordList = (richTextBox1.Text).Split(' ');
            String[] preList = (textBox1.Text).Split(' ');
            String[] testList = new string[wordList.Length];
            System.Console.WriteLine(wordList.Length);
            System.Console.WriteLine(preList.Length);
            System.Console.WriteLine(testList.Length);  
            for (int i = 0; i < wordList.Length; i++)
            {
                if (i < preList.Length)
                {
                    testList[i] = preList[i];
                }
                else
                {
                    testList[i] = "wrong";
                }
            }
            int errors = 0;
            for (int i = 0; i < wordList.Length; i++)
            {
                System.Console.WriteLine(wordList[i]);
                System.Console.WriteLine(testList[i]);

                if (wordList[i]!=(testList[i]))
                {
                    errors++;
                }
             

            }
            richTextBox1.Text = errors.ToString();
        }
    }
}
