using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using GathererTimetable.Eorzea;
using GathererTimetable.IO.Tool;

namespace GathererTimetable {
    public partial class Form_Main : Form {
        public bool FlagAlarmInitialAttempt { get; set; }
        public bool FlagTemporaryMute { get; set; }
        public bool FlagFlashTaskbar { get; set; }

        HashSet<string> hashsetTimeSet = new HashSet<string>();
        List<string> listButtonText = new List<string>();
        List<string> listNoteText = new List<string>();

        public Form_Main() {
            InitializeComponent();
            FlagAlarmInitialAttempt = true;
        }

        private void form_Main_Load(object sender,System.EventArgs e) {
            labelTimeNow.Text = Eorzea_Time.GetTimeAsString();
            CsvIO.LoadCSVIsCheckBoxTrue("MinerCollection.csv",hashsetTimeSet);
            CsvIO.LoadCSVIsCheckBoxTrue("BotanistCollection.csv",hashsetTimeSet);
            CsvIO.LoadCSVIsCheckBoxTrue("FisherCollection.csv",hashsetTimeSet);


        }
        private void timerSec_Tick(object sender,System.EventArgs e) {
#if DEBUG
            labelInfomation.Text = FlagAlarmInitialAttempt.ToString() + hashsetTimeSet.Count.ToString() + Eorzea_Time.GetTimeAsString(Settings.Default.AlarmDelayType);
#endif
            string _eTime = Eorzea_Time.GetTimeAsString();
            string _eJudgeTime = Eorzea_Time.GetTimeAsString(Settings.Default.AlarmDelayType);
            labelTimeNow.Text = _eTime;
            //その時間での初回実行確認、採掘師及び園芸師でのリストにアイテム登録があるかどうかの確認
            if(FlagAlarmInitialAttempt && (hashsetTimeSet.Contains(_eJudgeTime))) {
                hashsetTimeSet.Clear();
                listButtonText.Clear();
                listNoteText.Clear();
                int i = 0;
                CsvIO.LoadCSVToControlList(_eJudgeTime,"MinerCollection.csv",listButtonText,listNoteText,hashsetTimeSet);
                CsvIO.LoadCSVToControlList(_eJudgeTime,"BotanistCollection.csv",listButtonText,listNoteText,hashsetTimeSet);
                CsvIO.LoadCSVToControlList(_eJudgeTime,"FisherCollection.csv",listButtonText,listNoteText,hashsetTimeSet);


                foreach(var s in listButtonText.Select((value,index) => new { value,index })) {
                    if(s.index < 4) {
                        this.Controls["button" + (s.index + 1)].Enabled = true;
                        this.Controls["button" + (s.index + 1)].Text = s.value;
                        i++;
                    }

                }

                for(int j = i + 1;j <= 4;j++) {
                    this.Controls["button" + j].ResetText();
                    this.Controls["button" + j].Enabled = false;
                }
                if(listButtonText.Count > 4) labelInfomation.Text = "注意：同一時刻におけるアラーム登録数が4を超えています";
                if(FlagTemporaryMute == false) setOffAlarm();
                if(FlagFlashTaskbar) flashTaskBar();
                if(FlagAlarmInitialAttempt) FlagAlarmInitialAttempt = !FlagAlarmInitialAttempt;
            }
            //エオルゼア時間がo'clock以外の時はアラームフラグを起こし直す
            if(_eJudgeTime.Substring(3,2) != "00") {
                FlagAlarmInitialAttempt = true;
            }
        }


        private void buttonMiner_Click(object sender,System.EventArgs e) {
            var formMinerEditor = new Form_MinerEditor(this);
            formMinerEditor.StartPosition = FormStartPosition.CenterParent;
            formMinerEditor.ShowDialog(this);
            formMinerEditor.Dispose();
            CsvIO.LoadCSVIsCheckBoxTrue("MinerCollection.csv",hashsetTimeSet);
        }
        private void buttonBotanist_Click(object sender,System.EventArgs e) {
            var formBotanistEditor = new Form_BotanistEditor(this);
            formBotanistEditor.StartPosition = FormStartPosition.CenterParent;
            formBotanistEditor.ShowDialog(this);
            formBotanistEditor.Dispose();
            CsvIO.LoadCSVIsCheckBoxTrue("BotanistCollection.csv",hashsetTimeSet);
        }
        private void buttonFisher_Click(object sender,EventArgs e) {
            var form_FisherEditor = new Form_FisherEditor(this);
            form_FisherEditor.StartPosition = FormStartPosition.CenterParent;
            form_FisherEditor.ShowDialog(this);
            form_FisherEditor.Dispose();
            CsvIO.LoadCSVIsCheckBoxTrue("FisherCollection.csv",hashsetTimeSet);

        }

        private void checkBoxTopMost_CheckedChanged(object sender,System.EventArgs e) {
            CheckBox cb = (CheckBox)sender;
            this.TopMost = cb.Checked;
        }

        private void buttonOption_Click(object sender,EventArgs e) {
            Form_Option form_Option = new Form_Option();
            form_Option.StartPosition = FormStartPosition.CenterParent;
            form_Option.ShowDialog(this);
            form_Option.Dispose();
        }

        private void checkBoxMute_CheckedChanged(object sender,EventArgs e) {
            CheckBox cb = (CheckBox)sender;
            FlagTemporaryMute = cb.Checked;
        }


        private void setOffAlarm() {
            switch(Settings.Default.AlarmType) {
                case "None":
                    break;
                case "SystemSound":
                    //同期再生する
                    using(var player = new System.Media.SoundPlayer(Properties.Resources.Chime)) {
                        player.Play();
                    }
                    break;
                case "UserDefinition":
                    using(var player = new System.Media.SoundPlayer(Settings.Default.SoundFilePath)) {
                        player.Play();
                    }
                    break;
            }
        }

        private void buttonItem_Click(object sender,EventArgs e) {
            string str = (string)((Button)sender).Tag;
            labelInfomation.Text = listNoteText[int.Parse(str)];
        }


        [DllImport("user32.dll")]
        static extern Int32 FlashWindowEx(ref FLASHWINFO pwfi);

        [StructLayout(LayoutKind.Sequential)]
        public struct FLASHWINFO {
            public UInt32 cbSize;    // FLASHWINFO構造体のサイズ
            public IntPtr hwnd;      // 点滅対象のウィンドウ・ハンドル
            public UInt32 dwFlags;   // 以下の「FLASHW_XXX」のいずれか
            public UInt32 uCount;    // 点滅する回数
            public UInt32 dwTimeout; // 点滅する間隔（ミリ秒単位）
        }

        // 点滅を止める
        public const UInt32 FLASHW_STOP = 0;
        // タイトルバーを点滅させる
        public const UInt32 FLASHW_CAPTION = 1;
        // タスクバー・ボタンを点滅させる
        public const UInt32 FLASHW_TRAY = 2;
        // タスクバー・ボタンとタイトルバーを点滅させる
        public const UInt32 FLASHW_ALL = 3;
        // FLASHW_STOPが指定されるまでずっと点滅させる
        public const UInt32 FLASHW_TIMER = 4;
        // ウィンドウが最前面に来るまでずっと点滅させる
        public const UInt32 FLASHW_TIMERNOFG = 12;

        private void flashTaskBar() {
            FLASHWINFO fInfo = new FLASHWINFO();
            fInfo.cbSize = Convert.ToUInt32(Marshal.SizeOf(fInfo));
            fInfo.hwnd = GetMainWindowHandle("GathererTimetable");
            fInfo.dwFlags = FLASHW_ALL;
            fInfo.uCount = 2;         // 点滅する回数
            fInfo.dwTimeout = 0;

            FlashWindowEx(ref fInfo);
        }

        public IntPtr GetMainWindowHandle(string processName) {
            Process curProcess = Process.GetCurrentProcess();
            Process[] allProcesses = Process.GetProcessesByName(processName);

            foreach(Process checkProcess in allProcesses) {
                if(checkProcess.MainWindowHandle != IntPtr.Zero) {
                    return checkProcess.MainWindowHandle;
                }
            }

            // 指定したプロセス名のアプリケーションが見つからない！
            return IntPtr.Zero;
        }

        private void checkBoxFlashTaskbar_CheckedChanged(object sender,EventArgs e) {
            FlagFlashTaskbar = checkBoxFlashTaskbar.Checked;
        }


    }
}
