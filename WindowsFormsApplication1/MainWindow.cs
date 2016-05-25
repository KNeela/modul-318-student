using SwissTransportTimeTable;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmMainWindow : Form
    {
        public frmMainWindow()
        {
            InitializeComponent();
        }

        private void btnConnectionsFromDestination_Click(object sender, EventArgs e)
        {
            frmConnections ConnectionsForm = new frmConnections();
            ConnectionsForm.ShowDialog();
        }

        private void btnConnectionsFrom_Click(object sender, EventArgs e)
        {
            frmConnectionsFrom ConnectionsFromForm = new frmConnectionsFrom();
            ConnectionsFromForm.ShowDialog();
        }
    }
}
