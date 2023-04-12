using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fabric_metod
{
    public partial class Form1 : Form
    {
      //  IShapeFactory creator;        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ILogger logger = LoggerFactory.CreateLogger(LoggerType.RichTextBox, logTextBox: richTextBox1);
            logger.Log("кнопка 1 нажалась");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ILogger logger = LoggerFactory.CreateLogger(LoggerType.RichTextBox, logTextBox: richTextBox1);
            logger.Log("форма завантажилась");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ILogger logger = LoggerFactory.CreateLogger(LoggerType.RichTextBox, logTextBox: richTextBox1);
            logger.Log("кнопка 2 нажалась");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string logFilePath = @"D:\HomeWork\Projects\Fabric_metod\Fabric_metod\bin\Debug\log.txt";
            ILogger logger = LoggerFactory.CreateLogger(LoggerType.File, logFilePath: logFilePath);
            logger.Log("кнопка 3 нажалась");
        }
    }
}
