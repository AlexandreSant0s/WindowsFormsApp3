using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox3.Text);
            listBox2.Items.Add(DateTime.Now.Date.ToShortDateString());
            listBox2.Items.Add(DateTime.Now.TimeOfDay.ToString());
        }
    }
}
