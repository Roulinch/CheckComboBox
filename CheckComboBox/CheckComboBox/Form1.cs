using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkComboBox1.SetItems(new List<string>() {"1", "2", "3", "4"});
            checkComboBox1.TextMode = CheckComboBoxTextMode.Items;

            checkComboBox2.SetItems(new List<string>() { "1", "2", "3", "4" });
            checkComboBox2.TextMode = CheckComboBoxTextMode.Items;
        }
    }
}
