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



namespace GathererTimeTable {
    public partial class Form_MineralEditor : Form {
        public Form_MineralEditor() {
            InitializeComponent();
        }

        private void Form_Collection_Load(object sender,EventArgs e) {
            CsvIO.loadCsvToDataTable(ref dataGridView1,"proto1.csv");
            //dataGridView1.Rows.Add(false,"Mineral",1,"01:00","クルザス中央高地 (27, 19)","闇鉄鉱","3段目","");

        }

        private void buttonComplete_Click(object sender,EventArgs e) {
            CsvIO.SaveDataTableToCsv(ref dataGridView1,"proto1.csv");
        }

        private void buttonCancel_Click(object sender,EventArgs e) {

        }


    }
}
