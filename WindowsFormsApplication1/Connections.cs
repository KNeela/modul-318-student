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
        //Validation: Prüfen ob eingegebene Station (bei Abfahrtstafel) existiert.
        public void ValidateInputStation(string station)
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


        //Per RadioButton prüfen, ob Verbindungen Von-Nach oder Abfahrtstafel selektiert ist und je nach dem txtDestination enabeln oder disabeln
        private void rbConnections_CheckedChanged(object sender, EventArgs e)
        {
            if (rbConnections.Checked == true)
            {
                txtStart.Text = "";
                txtDestination.Text = "";
                txtDestination.Show();
                lblDestination.Show();
                this.dataGridConnections.DataSource = null;
                this.dataGridConnections.Rows.Clear();               
            }
            else
            {
                txtStart.Text = "";
                txtDestination.Hide();
                lblDestination.Hide();
                //der Button "Endstation auf Maps" nicht mehr anzeigen.
                btnMapsTo.Hide();
                
                this.dataGridConnections.DataSource = null;
                this.dataGridConnections.Rows.Clear();
            }
        }


        //--------A002--------
        //Verbindungen zwischen Start- und Endstation in DataGrid ausgeben
        private void btnShowConnections_Click(object sender, EventArgs e)
        {
            string fromStation = txtStart.Text.ToString();
            string toStation = txtDestination.Text.ToString();

            var source = new AutoCompleteStringCollection();

            DateTime date = dtpDate.Value;
            DateTime time = dtpTime.Value;


            DataTable dt = new DataTable();
            this.dataGridConnections.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            Transport transport = new Transport();

            if (rbConnections.Checked == true)
            {
                
                dt.Columns.Add(new DataColumn("Von/" + Environment.NewLine + "Nach"));
                dt.Columns.Add(new DataColumn("Abfahrt Gleis/" + Environment.NewLine + "Ankunft Gleis"));
                dt.Columns.Add(new DataColumn("Abfahrtszeit/" + Environment.NewLine + "Ankunftszeit"));

                //--------A005--------
                //Bei der Klasse Transport.cs GetConnectionsbyDateTime-Funktion hinzugefügt.
                //Diese Funktion macht dasselbe wie GetConnections, nur benötigt sie als Parameter zusätlich noch Datum und Zeit.
                var connections = transport.GetConnectionsbyDateTime(fromStation, toStation, date, time).ConnectionList;


                foreach (var connection in connections)
                {
                    dt.Rows.Add(connection.From.Station.Name + Environment.NewLine +
                       connection.To.Station.Name,
                       connection.From.Platform + Environment.NewLine +
                       connection.To.Platform,
                       Convert.ToDateTime(connection.From.Departure).ToShortTimeString() + Environment.NewLine +
                       Convert.ToDateTime(connection.To.Arrival).ToShortTimeString()
                       );
                }
            }
            else
            {
                dt.Columns.Add(new DataColumn("Nach"));
                dt.Columns.Add(new DataColumn("Linie"));
                dt.Columns.Add(new DataColumn("Abfahrtszeit/"));

                var stationboard = transport.GetStationBoardbyDateTime(fromStation, transport.GetStations(fromStation).StationList[0].Id, date, time).Entries;


                foreach (var connectionsFrom in stationboard)
                {
                    dt.Rows.Add(connectionsFrom.To,
                        connectionsFrom.Name,
                        //connectionsFrom.Stop.Departure.TimeOfDay.ToString().Substring(0, 5)
                        Convert.ToDateTime(connectionsFrom.Stop.Departure).ToShortTimeString()
                        );
                }              
            }
            dataGridConnections.RowTemplate.Height = 30;
            dataGridConnections.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridConnections.DataSource = dt;
        }


        //--------A006--------
        //FUNKTION: Koordinaten aus der eingegebenen Station lesen und den Standort im Browser auf Google Maps anzeigen
        public void ShowOnMaps(string station)
        {
            Transport transport = new Transport();

            double x = transport.GetStations(station).StationList[0].Coordinate.XCoordinate;
            double y = transport.GetStations(station).StationList[0].Coordinate.YCoordinate;

            System.Diagnostics.Process.Start("http://google.ch/maps/place/" + x + "+" + y);
        }

        //Eingegebene Startstation per Buttonclick auf Google Maps anzeigen lassen (mit ShowOnMaps-Funktion)
        private void btnMaps_Click(object sender, EventArgs e)
        {
            string fromStation = txtStart.Text.ToString();
            ShowOnMaps(fromStation);
        }

        //Eingegebene Endstation per Buttonclick auf Google Maps anzeigen lassen (mit ShowOnMaps-Funktion)
        private void btnMapsTo_Click(object sender, EventArgs e)
        {
            string toStation = txtDestination.Text.ToString();
            ShowOnMaps(toStation);         
        }


        //Fenster per Schliessen-Button schliessen
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
