using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RandomNumberGenerator;

namespace RandomNumberGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r=new Random();
        private void generateButton_Click(object sender, EventArgs e)
        {
            //int randomNumber=r.Next();
            //upper boundary to randomize 
            //int randomNumber = r.Next(10);
            //upper boundary and lower boundary -number within this range 
            int randomNumber = r.Next(1,100);
            numberLable.Text= randomNumber.ToString();
        }
    }
}
