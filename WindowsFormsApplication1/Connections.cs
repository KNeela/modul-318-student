using SwissTransport;
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
    public partial class frmConnections : Form
    {
        public frmConnections()
        {
            InitializeComponent();
        }

        private void btnShowConnections_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sali Peter!");
            Transport transport = new Transport();

            MessageBox.Show(transport.ToString());
        }



        //AutoComplete-Funktion --> liest Stationen aus StationList
        public AutoCompleteStringCollection AutoComplete(string station)
        {
            var source = new AutoCompleteStringCollection();
            Transport transport = new Transport();

            var transportList = transport.GetStations(station).StationList;
            foreach (var transportStation in transportList)
            {
                source.Add(transportStation.Name.ToString());
            }
            return source;
        }

        //AutoComplete bei einer Eingabe ab 3 Zeichen bei Start- und Endstation
        private void StartStation_KeyUp(object sender, KeyEventArgs e)
        {
            string start = txtStart.Text;
            if (start.Length >= 3)
            {
                txtStart.AutoCompleteCustomSource = AutoComplete(start);
                txtStart.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtStart.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }

        private void EndStation_KeyUp(object sender, KeyEventArgs e)
        {
            string destination = txtDestination.Text;
            if (destination.Length >= 3)
            {
                txtStart.AutoCompleteCustomSource = AutoComplete(destination);
                txtStart.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtStart.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }
    }
}
