using System;
using System.Drawing;
using System.Windows.Forms;

namespace Driving_School_Management_System
{
    public partial class ExpensesBar : UserControl
    {
        public string ExpenceName { get; set; }
        public decimal ExpenceValue { get; set; } = 0; 

        //private Random rnd = new Random();

        private Color color { get; set; }
        public ExpensesBar(string ExpenceName ,decimal ExpenceValue , int percentage)
        {
            InitializeComponent();
            this.ExpenceName = ExpenceName;
            this.ExpenceValue = ExpenceValue;
            color = Color.FromArgb(100, 200, 30);
            ExpenceProgressBar.ProgressColor = color;
            ExpenceProgressBar.ProgressColor2 = color; 
            ExpenceProgressBar.Value = percentage;
            NameOfExpence.Text = ExpenceName.ToString();
            ValueOfExpence.Text = ExpenceValue.ToString() + " DA"; 
         
        }
        public ExpensesBar()
        {
            InitializeComponent(); 
        }
    }
}
