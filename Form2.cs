using System;
using System.Windows.Forms;

namespace CheckListApp_LH
{
    public partial class Form2 : Form
    {
        public Form2(string taskDetails)
        {
            InitializeComponent();
            textBox.Text = taskDetails;  // ✅ Assign task text (textBox is in Form2.Designer.cs)
        }
    }
}
