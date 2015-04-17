using System;
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
using Microsoft.VisualBasic;


namespace GathererTimeTable {
    public partial class Form_MineralEditor : Form {
        Form_Main __form_Main = new Form_Main();
        DataTable __main_dataTableMineral = new DataTable();
        DataTable __dataTableMineral = new DataTable();
        public Form_MineralEditor(Form_Main _Form_Main,DataTable _DataTableMineral) {
            __form_Main = _Form_Main;
            __main_dataTableMineral = _DataTableMineral;
            InitializeComponent();
        }

        private void Form_Collection_Load(object sender,EventArgs e) {
            //__dataTableMineral = CsvIO.loadCsvToDataTable(dataSet,"Collection.csv");
            //dataGridView1.DataSource = __dataTableMineral;

        }

        private void buttonComplete_Click(object sender,EventArgs e) {
            CsvIO.SaveDataGridViewToCsv(ref dataGridView1,"Collection.csv");
            __main_dataTableMineral = (DataTable)dataGridView1.DataSource;
            Close();
        }

        private void buttonCancel_Click(object sender,EventArgs e) {
            Close();
        }


    }
}
