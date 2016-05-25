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

        //--------A001--------
        //Validation: Prüfen ob eingegebene Station existiert.
        public void ValidateInput(string station)
        {
            var source = new AutoCompleteStringCollection();
            Transport transport = new Transport();

            var transportList = transport.GetStations(station).StationList;

            if (station != transportList.ToString())
            {
                MessageBox.Show("Die eingegebene Station existiert nicht.");
            }
        }

        //--------A004--------
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

        //--------A004--------
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

        //--------A002--------
        //Verbindungen zwischen Start- und Endstation in DataGrid ausgeben
        private void btnShowConnections_Click(object sender, EventArgs e)
        {
            string fromStation = txtStart.Text.ToString();
            string toStation = txtDestination.Text.ToString();

            ValidateInput(fromStation);         //Prüfen ob eingegebene Station existiert
            ValidateInput(toStation);

            Transport transport = new Transport();

            DataTable dt = new DataTable();
            this.dataGridConnections.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dt.Columns.Add(new DataColumn("Von/" + Environment.NewLine + "Nach"));
            dt.Columns.Add(new DataColumn("Abfahrt Gleis/" + Environment.NewLine + "Ankunft Gleis"));
            dt.Columns.Add(new DataColumn("Abfahrtszeit/" + Environment.NewLine + "Ankunftszeit"));

            //dt.Columns.Add(new DataColumn("Ankunft", typeof(string)));

            var connections = transport.GetConnections(fromStation, toStation).ConnectionList;
            foreach (var connection in connections)
            {
                dt.Rows.Add(connection.From.Station.Name + Environment.NewLine + 
                    connection.To.Station.Name,
                    connection.From.Platform + Environment.NewLine +
                    connection.To.Platform, 
                    Convert.ToDateTime(connection.From.Departure).ToShortTimeString() + Environment.NewLine + 
                    Convert.ToDateTime(connection.To.Arrival).ToShortTimeString());
            }

            dataGridConnections.RowTemplate.Height = 30;

            dataGridConnections.DataSource = dt;

        }

        //Fenster per Schliessen-Button schliessen
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
