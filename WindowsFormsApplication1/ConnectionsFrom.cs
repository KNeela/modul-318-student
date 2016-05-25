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
    public partial class frmConnectionsFrom : Form
    {
        public frmConnectionsFrom()
        {
            InitializeComponent();
        }

        //AutoComplete-Funktion --> liest Stationen aus StationList
        private AutoCompleteStringCollection AutoComplete(string station)
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

        //AutoComplete bei einer Eingabe ab 4 Zeichen werden Stationen angezeigt
        private void StartStation_KeyUp(object sender, KeyEventArgs e)
        {
            string start = txtConnectionsFrom.Text;
            if (start.Length == 3)
            {
                txtConnectionsFrom.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtConnectionsFrom.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtConnectionsFrom.AutoCompleteCustomSource = AutoComplete(start);
            }
        }


        private void btnShowDepartures_Click(object sender, EventArgs e)
        {

        }
    }
}
