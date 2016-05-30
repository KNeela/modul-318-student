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

        //Validation: Prüfen ob eingebene Start- und Endstation (bei Verbindungen Von-Nach) existiert.
        //public void ValidateInputStartToStation(string fromstation, string tostation)
        //{
        //    var source = new AutoCompleteStringCollection();
        //    Transport transport = new Transport();



        //    var connectionList = transport.GetConnections(fromstation, tostation).ConnectionList;
        //    if (fromstation != connectionList.ToString())
        //    {
        //        MessageBox.Show(fromstation + " existiert nicht. Meinten Sie:" + fromstation);
        //    }


        //    var starttransportList = transport.GetStations(fromstation).StationList;
        //    var totransportList = transport.GetStations(tostation).StationList;

        //    if (fromstation != starttransportList.ToString())
        //    {
        //        MessageBox.Show("Die eingegebene Startstation existiert nicht.");
        //    }
        //    else if(tostation != totransportList.ToString())
        //    {
        //        MessageBox.Show("Die eingegebene Startstation existiert nicht.");
        //    }

        //    else if(fromstation != starttransportList.ToString() && tostation != totransportList.ToString())
        //    {
        //        MessageBox.Show("Die eingegebenen Stationen existieren nicht.");
        //    }

        //}

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
            Transport transport = new Transport();

            DataTable dt = new DataTable();
            this.dataGridConnections.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            if (rbConnections.Checked == true)
            {
                
                dt.Columns.Add(new DataColumn("Von/" + Environment.NewLine + "Nach"));
                dt.Columns.Add(new DataColumn("Abfahrt Gleis/" + Environment.NewLine + "Ankunft Gleis"));
                dt.Columns.Add(new DataColumn("Abfahrtszeit/" + Environment.NewLine + "Ankunftszeit"));


                var connections = transport.GetConnections(fromStation, toStation).ConnectionList;

                //--------A001--------
                //Validierung: Prüfen ob eingegebene Stationen existieren.

                //Falls ein Komma oder Leerzeichen 
                if(fromStation.Contains(",") || fromStation.Contains(" "))
                {
                    // Mach nichts
                }
                else if(fromStation == "" && fromStation==" ")
                {
                    //Einggabe nicht gültig
                }
                else  if (fromStation != connections.First().From.Station.Name && toStation != connections.First().To.Station.Name)
                
                {
                    MessageBox.Show(fromStation + " und " + toStation + " existieren nicht. Meinten Sie: " + connections.First().From.Station.Name + " und " + connections.First().To.Station.Name + "?");
                }   

                else if (fromStation != connections.First().From.Station.Name)
                {
                    MessageBox.Show(fromStation + " existiert nicht. Meinten Sie: " + connections.First().From.Station.Name + "?");
                }

                else if(toStation != connections.First().To.Station.Name)
                {
                    MessageBox.Show(toStation + " existiert nicht. Meinten Sie: " + connections.First().To.Station.Name + "?"); 
                }



                foreach (var connection in connections)
                {
                    dt.Rows.Add(connection.From.Station.Name + Environment.NewLine +
                       connection.To.Station.Name,
                       connection.From.Platform + Environment.NewLine +
                       connection.To.Platform,
                       Convert.ToDateTime(connection.From.Departure).ToShortTimeString() + Environment.NewLine +
                       Convert.ToDateTime(connection.To.Arrival).ToShortTimeString());
                }
            }
            else
            {
                dt.Columns.Add(new DataColumn("Nach"));
                dt.Columns.Add(new DataColumn("Linie"));
                dt.Columns.Add(new DataColumn("Abfahrtszeit/"));


                var stationboard = transport.GetStationBoard(fromStation, transport.GetStations(fromStation).StationList[0].Id).Entries;

                //--------A001--------
                //Validierung: Prüfen ob eingegebene Station existiert.
                if (fromStation != stationboard.First().Name)
                {
                    MessageBox.Show(fromStation + " existiert nicht. Meinten Sie: " + stationboard.First().Name + "?");
                }


                foreach (var connectionsFrom in stationboard)
                {
                    dt.Rows.Add(connectionsFrom.To,
                        connectionsFrom.Name,
                        connectionsFrom.Stop.Departure.TimeOfDay.ToString().Substring(0, 5)
                        );
                }              
            }
            dataGridConnections.RowTemplate.Height = 30;
            dataGridConnections.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridConnections.DataSource = dt;


        }

        //Fenster per Schliessen-Button schliessen
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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


    }
}
