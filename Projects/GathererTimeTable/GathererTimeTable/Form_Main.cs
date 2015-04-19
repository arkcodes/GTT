using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using GathererTimeTable.FFXIV.Tool;
using GathererTimeTable.IO.Tool;

namespace GathererTimeTable {
    public partial class Form_Main : Form {
        private int _count;
        public int Count {
            get { return _count; }
            set { _count = value; }
        }
        HashSet<string> _isMinerTimeSet = new HashSet<string>();
        HashSet<string> _isBotanistTimeSet = new HashSet<string>();

        List<string> _listButtonText = new List<string>();
        List<string> _listLabelText = new List<string>();

        public Form_Main() {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender,System.EventArgs e) {
            labelTimeNow.Text = Eorzea_Time.GetTimeAsString();
            CsvIO.loadCSVIsCheckBoxTrue("MinerCollection.csv",_isMinerTimeSet);
            CsvIO.loadCSVIsCheckBoxTrue("BotanistCollection.csv",_isBotanistTimeSet);

        }
        private void timerSec_Tick(object sender,System.EventArgs e) {

            string _eTime = Eorzea_Time.GetTimeAsString();
            labelTimeNow.Text = _eTime;
            if(_eTime.Substring(3,2) == "00" && Count == 0 && (_isMinerTimeSet.Contains(_eTime) || _isBotanistTimeSet.Contains(_eTime))) {
                _listButtonText.Clear();
                _listLabelText.Clear();
                int i = 0;
                CsvIO.loadCSVToControl(_eTime,"MinerCollection.csv",_listButtonText,_listLabelText,_isMinerTimeSet);
                CsvIO.loadCSVToControl(_eTime,"BotanistCollection.csv",_listButtonText,_listLabelText,_isBotanistTimeSet);

                foreach(var s in _listButtonText.Select((value,index) => new { value,index })) {
                    if(s.index < 4) {
                        this.Controls["button" + (s.index + 1)].Enabled = true;
                        this.Controls["button" + (s.index + 1)].Text = s.value;
                        i++;
                    }

                }

                foreach(var s in _listLabelText.Select((value,index) => new { value,index })) {
                    if(s.index < 4) {
                        this.Controls["label" + (s.index + 1)].Enabled = true;
                        this.Controls["label" + (s.index + 1)].Text = s.value;
                    }
                }

                for(int j = i + 1;j <= 4;j++) {
                    this.Controls["button" + j].ResetText();
                    this.Controls["button" + j].Enabled = false;
                    this.Controls["label" + j].ResetText();
                    this.Controls["button" + j].Enabled = false;
                }
                Count++;
            }

            if(_eTime.Substring(3,2) == "01") {
                Count = 0;
            }
        }


        private void _buttonMiner_Click(object sender,System.EventArgs e) {
            var formMinerEditor = new Form_MineralEditor(this);
            formMinerEditor.ShowDialog(this);
            formMinerEditor.Dispose();
            CsvIO.loadCSVIsCheckBoxTrue("MinerCollection.csv",_isMinerTimeSet);
        }
        private void _buttonBotanist_Click(object sender,System.EventArgs e) {
            var formBotanistEditor = new Form_BotanistEditor(this);
            formBotanistEditor.ShowDialog(this);
            formBotanistEditor.Dispose();
            CsvIO.loadCSVIsCheckBoxTrue("BotanistCollection.csv",_isBotanistTimeSet);
        }

        private void checkBox1_CheckedChanged(object sender,System.EventArgs e) {
            CheckBox cb = (CheckBox)sender;
            this.TopMost = cb.Checked ? true : false;
        }


    }
}
