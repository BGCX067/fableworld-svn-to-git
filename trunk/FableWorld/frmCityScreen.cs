using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FableWorld
{
    public partial class frmCityScreen : Form
    {
        public frmCityScreen()
        {
            InitializeComponent();
        }

        private void btnManageParty_Click(object sender, EventArgs e)
        {
            new frmPartyManagement().ShowDialog();
        }
    }
}
