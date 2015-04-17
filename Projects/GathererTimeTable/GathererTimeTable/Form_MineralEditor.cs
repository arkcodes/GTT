﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GathererTimeTable.IO.Tool;



namespace GathererTimeTable {
    public partial class Form_MineralEditor : Form {
        Form_Main __form_Main = new Form_Main();
        public Form_MineralEditor(Form_Main _Form_Main) {
            __form_Main = _Form_Main;
            InitializeComponent();
        }

        private void Form_Collection_Load(object sender,EventArgs e) {
            CsvIO.loadCsvToDataTable(dataGridView1,"collection.csv");

        }

        private void buttonComplete_Click(object sender,EventArgs e) {
            CsvIO.SaveDataTableToCsv(dataGridView1,"collection.csv");
            Close();
        }

        private void buttonCancel_Click(object sender,EventArgs e) {
            Close();
        }


    }
}
