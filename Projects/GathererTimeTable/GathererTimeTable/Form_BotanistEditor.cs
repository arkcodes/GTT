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
    public partial class Form_BotanistEditor : Form {
        Form_Main _form_Main = new Form_Main();
        public Form_BotanistEditor(Form_Main _Form_Main) {
            _form_Main = _Form_Main;
            InitializeComponent();
        }

        private void Form_Collection_Load(object sender,EventArgs e) {
            CsvIO.loadCSVToDataGridView(dataGridView1,"BotanistCollection.csv");

        }

        private void buttonComplete_Click(object sender,EventArgs e) {
            CsvIO.SaveDataTableToCSV(dataGridView1,"BotanistCollection.csv");
            Close();
        }

        private void buttonCancel_Click(object sender,EventArgs e) {
            Close();
        }


    }
}
