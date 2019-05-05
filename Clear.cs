using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breakout
{
    public partial class Clear : Form
    {
        public Clear()
        {
            InitializeComponent();
        }

        private void ReturnTitleButton_Click(object sender, EventArgs e)
        {
            Title title = new Title();
            title.Show();
            this.Close();
        }
    }
}
