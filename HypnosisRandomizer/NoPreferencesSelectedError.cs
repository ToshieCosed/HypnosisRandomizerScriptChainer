using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HypnosisRandomizer
{
    public partial class NoPreferencesSelectedError : Form
    {
        public NoPreferencesSelectedError()
        {
            InitializeComponent();
        }

        private void ButtonOkay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
