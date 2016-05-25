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

        //AutoComplete bei einer Eingabe ab 4 Zeichen bei Start- und Endstation
        private void StartStation_KeyUp(object sender, KeyEventArgs e)
        {
            string start = txtStart.Text;
            if (start.Length == 3)
            {
                txtStart.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtStart.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtStart.AutoCompleteCustomSource = AutoComplete(start);
            }
        }

        private void EndStation_KeyUp(object sender, KeyEventArgs e)
        {
            string destination = txtDestination.Text;
            if (destination.Length == 3)
            {
                txtDestination.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtDestination.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtDestination.AutoCompleteCustomSource = AutoComplete(destination);
            }
        }

        //Verbindungen zwischen Start- und Endstation in DataGrid ausgeben
        private void btnShowConnections_Click(object sender, EventArgs e)
        {
            string fromStation = txtStart.Text.ToString();
            string toStation = txtDestination.Text.ToString();


            Transport transport = new Transport();

            DataTable dt = new DataTable();
            dt.AcceptChanges();
            dt.Columns.Add(new DataColumn("Von", typeof(string)));
            dt.Columns.Add(new DataColumn("Gleis", typeof(string)));
            dt.Columns.Add(new DataColumn("Abfahrt", typeof(string)));
            dt.Columns.Add(new DataColumn("Ankunft", typeof(string)));


            var connections = transport.GetConnections(fromStation, toStation).ConnectionList;
            foreach (var connection in connections)
            {
                dt.Rows.Add(connection.From.Station.Name, 
                    connection.To.Platform, 
                    Convert.ToDateTime(connection.From.Departure).ToShortTimeString(), 
                    Convert.ToDateTime(connection.To.Arrival).ToShortTimeString());
            }
            
            dataGridConnections.DataSource = dt;
            //dt.RejectChanges();

        }

        //Fenster per Schliessen-Button schliessen
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
