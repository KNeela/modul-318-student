using SwissTransport;
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
    public partial class frmConnections : Form
    {
        public frmConnections()
        {
            InitializeComponent();
        }

        #region Variabeln
        Transport transport = new Transport();
        DataTable dt = new DataTable();

        #endregion

        #region Events
        //Buttonclick auf "Verbindungen anzeigen"
        private void btnShowConnections_Click(object sender, EventArgs e)
        {                         
            //Sanduhr einblenden
            Cursor.Current = Cursors.WaitCursor;

            bool isValid = true;
            string fromStation = txtStart.Text;
            string toStation = txtDestination.Text;

            //--------A001--------
            //Validierung: Prüfen ob eingegebene Stationen gültig sind.
            if (string.IsNullOrEmpty(fromStation) && string.IsNullOrEmpty(toStation) && rbConnections.Checked== true)
            {
                isValid = false;
                MessageBox.Show("Es wurden keine Stationen eingegeben.");              
            }
            if (isValid)
            {
                if (string.IsNullOrEmpty(fromStation))
                {
                    
                    isValid = false;
                    MessageBox.Show("Die Startstation ist ungültig.");
                }
            }

            if (isValid)
            {
                if (string.IsNullOrEmpty(toStation) && rbConnections.Checked == true)
                {
                    
                    isValid = false;
                    MessageBox.Show("Die Endstation ist ungültig.");
                }
            }

            if(!isValid)
            {
                toolStripLabel.Text = string.Format("Verbindungen konnten nicht geladen werden.");
                statusStrip.Refresh();
            }

            //--------A002--------
            //Verbindungen zwischen Start- und Endstation in DataGrid ausgeben
            if (isValid)
            {
                var source = new AutoCompleteStringCollection();

                DateTime date = dtpDate.Value;
                DateTime time = dtpTime.Value;

                //DataGridView: Zeilenumbruch in Zellen
                this.dataGridConnections.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                if (rbConnections.Checked == true)
                {
                    dt.Columns.Add(new DataColumn("Von/" + Environment.NewLine + "Nach"));
                    dt.Columns.Add(new DataColumn("Abfahrt Gleis/" + Environment.NewLine + "Ankunft Gleis"));
                    dt.Columns.Add(new DataColumn("Abfahrtszeit/" + Environment.NewLine + "Ankunftszeit"));
                    dt.Columns.Add(new DataColumn("Dauer"));
                    
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
                           Convert.ToDateTime(connection.To.Arrival).ToShortTimeString(),
                           connection.Duration.Substring(3, 2) + "h " + connection.Duration.Substring(6, 2) +"min"
                           );
                    }
                    toolStripLabel.Text = string.Format("Verbindungen wurden geladen.");
                    statusStrip.Refresh();
                }
                else
                {
                    //--------A003--------
                    //Verbindungen ab eingegebener Station in DataGrid ausgeben
                    dt.Columns.Add(new DataColumn("Nach"));
                    dt.Columns.Add(new DataColumn("Linie"));
                    dt.Columns.Add(new DataColumn("Abfahrtszeit/"));

                    //--------A005--------
                    //Bei der Klasse Transport.cs GetStationBoardbyDateTime-Funktion hinzugefügt.
                    //Diese Funktion macht dasselbe wie GetStationboard, nur benötigt sie als Parameter zusätlich noch Datum und Zeit.
                    var stationboard = transport.GetStationBoardbyDateTime(fromStation, transport.GetStations(fromStation).StationList[0].Id, date, time).Entries;


                    foreach (var connectionsFrom in stationboard)
                    {
                        dt.Rows.Add(connectionsFrom.To,
                            connectionsFrom.Name,
                            Convert.ToDateTime(connectionsFrom.Stop.Departure).ToShortTimeString()
                            );
                    }
                    toolStripLabel.Text = string.Format("Verbindungen wurden geladen.");
                    statusStrip.Refresh();
                }
                dataGridConnections.RowTemplate.Height = 35;
                dataGridConnections.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridConnections.DataSource = dt;
            }
            //Cursor wieder auf Default setzen
            Cursor = Cursors.Default;
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
                toolStripLabel.Text = string.Format("");
                statusStrip.Refresh();
                txtStart.Text = "";
                txtDestination.Text = "";
                txtDestination.Show();
                lblDestination.Show();
                this.dataGridConnections.DataSource = null;
                this.dataGridConnections.Rows.Clear();
            }
            else
            {
                toolStripLabel.Text = string.Format("");
                statusStrip.Refresh();
                txtStart.Text = "";
                txtDestination.Hide();
                lblDestination.Hide();
                //der Button "Endstation auf Maps" nicht mehr anzeigen.
                btnMapsTo.Hide();

                this.dataGridConnections.DataSource = null;
                this.dataGridConnections.Rows.Clear();
            }
        }

        //--------A005--------
        private void SwissTransport_Load(object sender, EventArgs e)
        {
            //Wenn ein vergangenes Datum gewählt wird, wird das Datum automatisch auf das heutige Datum gesetzt.
            dtpDate.MinDate = DateTime.Today;
        }

        //--------A006--------
        //Eingegebene Station per Buttonclick auf Google Maps anzeigen lassen (mit ShowOnMaps-Funktion)
        private void btnMaps_Click(object sender, EventArgs e)
        {
            string fromStation = txtStart.Text.ToString();
            ShowOnMaps(fromStation);
        }

        private void btnMapsTo_Click(object sender, EventArgs e)
        {
            string toStation = txtDestination.Text.ToString();
            ShowOnMaps(toStation);         
        }

        private void SendviaMail_Click(object sender, EventArgs e)
        {
            frmSendMail SendMailForm = new frmSendMail();
            SendMailForm.ShowDialog();
        }

        //Fenster per Schliessen-Button schliessen
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Funktionen
        //--------A004--------
        //AutoComplete-Funktion --> liest Stationen aus StationList
        public AutoCompleteStringCollection AutoComplete(string station)
        {
            var source = new AutoCompleteStringCollection();

            var transportList = transport.GetStations(station).StationList;
            foreach (var transportStation in transportList)
            {
                source.Add(transportStation.Name.ToString());
            }
            return source;
        }

        //--------A006--------
        //ShowOnMaps-Funktion: Koordinaten aus der eingegebenen Station lesen und den Standort im Browser auf Google Maps anzeigen
        public void ShowOnMaps(string station)
        {
            if (!string.IsNullOrEmpty(station))
            {
                DialogResult dialogYesNo = MessageBox.Show("Standort nun im Browser auf Google Maps anzeigen?", "Hinweis", MessageBoxButtons.YesNo);
                if (dialogYesNo == DialogResult.Yes)
                {
                    double x = transport.GetStations(station).StationList[0].Coordinate.XCoordinate;
                    double y = transport.GetStations(station).StationList[0].Coordinate.YCoordinate;

                    System.Diagnostics.Process.Start("http://www.google.ch/maps/place/" + x + "+" + y);
                }
            }
            else
            {
                MessageBox.Show("Bitte geben Sie eine Station ein.");
            }
        }

        #endregion
    }
}
