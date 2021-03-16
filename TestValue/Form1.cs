using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ValueLiblary;

namespace TestValue
{
    public partial class Form1 : Form
    {

        public string Value = "4";
        public Form1()
        {
            InitializeComponent();
            new PropertyChange(ref Value, PropertyChange);
            Value = "10";
            Value = "30";
        }

        private void PropertyChange(PropertyChange e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static void PropertyChange(PropertyChangingAttribute e)
        {

        }
    }
}
