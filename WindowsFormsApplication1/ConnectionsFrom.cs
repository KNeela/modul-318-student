﻿using SwissTransport;
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

        //--------A004--------
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

        //--------A004--------
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

        //--------A003--------
        //Abfahrten ab eingegebener Station werden in DataGrid angezeigt
        private void btnShowDepartures_Click(object sender, EventArgs e)
        {
            string fromStation = txtConnectionsFrom.Text.ToString();
            
            Transport transport = new Transport();

            DataTable dt = new DataTable();
            this.dataGridConnectionsFrom.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dt.Columns.Add(new DataColumn("Nach"));
            dt.Columns.Add(new DataColumn("Linie"));
            dt.Columns.Add(new DataColumn("Abfahrtszeit/"));

            //dt.Columns.Add(new DataColumn("Ankunft", typeof(string)));

            var stationboard = transport.GetStationBoard(fromStation, transport.GetStations(fromStation).StationList[0].Id).Entries;
            foreach (var connectionsFrom in stationboard)
            {
                dt.Rows.Add(connectionsFrom.To,
                    connectionsFrom.Name,
                    connectionsFrom.Stop.Departure.TimeOfDay.ToString().Substring(0, 5)
                    );

            }

            dataGridConnectionsFrom.RowTemplate.Height = 30;
            dataGridConnectionsFrom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridConnectionsFrom.DataSource = dt;
        }
    }
}
