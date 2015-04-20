using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using GathererTimeTable.FFXIV.Tool;
using GathererTimeTable.IO.Tool;

namespace GathererTimeTable {
    public partial class Form_Main : Form {
        public bool FlagAlarmInitialAttempt { get; set; }
        public bool TemporaryMute { get; set; }
        HashSet<string> _minerTimeSet = new HashSet<string>();
        HashSet<string> _botanistTimeSet = new HashSet<string>();

        List<string> _listButtonText = new List<string>();
        List<string> _listLabelText = new List<string>();

        public Form_Main() {
            InitializeComponent();
            FlagAlarmInitialAttempt = true;
        }

        private void Form_Main_Load(object sender,System.EventArgs e) {
            labelTimeNow.Text = Eorzea_Time.GetTimeAsString();
            CsvIO.loadCSVIsCheckBoxTrue("MinerCollection.csv",_minerTimeSet);
            CsvIO.loadCSVIsCheckBoxTrue("BotanistCollection.csv",_botanistTimeSet);

        }
        private void timerSec_Tick(object sender,System.EventArgs e) {

            string _eTime = Eorzea_Time.GetTimeAsString();
            labelTimeNow.Text = _eTime;
            //その時間での初回実行確認、採掘師及び園芸師でのリストにアイテム登録があるかどうかの確認
            if(FlagAlarmInitialAttempt && (_minerTimeSet.Contains(_eTime) || _botanistTimeSet.Contains(_eTime))) {
                _listButtonText.Clear();
                _listLabelText.Clear();
                int i = 0;
                CsvIO.loadCSVToControlList(_eTime,"MinerCollection.csv",_listButtonText,_listLabelText,_minerTimeSet);
                CsvIO.loadCSVToControlList(_eTime,"BotanistCollection.csv",_listButtonText,_listLabelText,_botanistTimeSet);

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

                if(TemporaryMute == false) _setOffAlarm();
                if(FlagAlarmInitialAttempt) FlagAlarmInitialAttempt = !FlagAlarmInitialAttempt;
            }
            //エオルゼア時間がo'clock以外の時はアラームフラグを起こし直す
            if(_eTime.Substring(3,2) != "00") {
                FlagAlarmInitialAttempt = true;
            }
        }


        private void _buttonMiner_Click(object sender,System.EventArgs e) {
            var formMinerEditor = new Form_MineralEditor(this);
            formMinerEditor.StartPosition = FormStartPosition.CenterParent;
            formMinerEditor.ShowDialog(this);
            formMinerEditor.Dispose();
            CsvIO.loadCSVIsCheckBoxTrue("MinerCollection.csv",_minerTimeSet);
        }
        private void _buttonBotanist_Click(object sender,System.EventArgs e) {
            var formBotanistEditor = new Form_BotanistEditor(this);
            formBotanistEditor.StartPosition = FormStartPosition.CenterParent;
            formBotanistEditor.ShowDialog(this);
            formBotanistEditor.Dispose();
            CsvIO.loadCSVIsCheckBoxTrue("BotanistCollection.csv",_botanistTimeSet);
        }

        private void checkBox1_CheckedChanged(object sender,System.EventArgs e) {
            CheckBox cb = (CheckBox)sender;
            this.TopMost = cb.Checked ? true : false;
        }

        private void buttonOption_Click(object sender,EventArgs e) {
            Form_Option form_Option = new Form_Option();
            form_Option.StartPosition = FormStartPosition.CenterParent;
            form_Option.ShowDialog(this);
            form_Option.Dispose();
        }

        private void _checkBoxMute_CheckedChanged(object sender,EventArgs e) {
            CheckBox cb = (CheckBox)sender;
            TemporaryMute = cb.Checked;
            labelDebug.Text = checkBoxMute.Checked.ToString();

        }

        [DllImport("winmm.dll",CharSet = CharSet.Auto)]
        private static extern int mciSendString(string command,StringBuilder buffer,int bufferSize,IntPtr hwndCallback);
        private void _setOffAlarm() {
            switch(Settings.Default.AlarmType) {
                case "None":
                    break;
                case "SystemSound":
                    //同期再生する
                    using(System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Chime)) {
                        player.PlaySync();
                    } 
                    break;
                case "UserDefinition":
                    if(File.Exists(Settings.Default.SoundFilePath)) {
                        string command = "open \"" + Settings.Default.SoundFilePath + "\" alias MediaFile";
                        if(mciSendString(command,null,0,IntPtr.Zero) != 0) {
                            return;
                        }
                        command = "play MediaFile";
                        mciSendString(command,null,0,IntPtr.Zero);
                    }
                    break;
            }
        }


    }
}
