using System;
using System.Windows.Forms;

namespace GathererTimetable {
    public partial class Form_Option : Form {
        public string AlarmType { get; set; }
        public string AlarmDelayType { get; set; }

        public Form_Option() {
            InitializeComponent();
        }

        private void form_Option_Load(object sender,EventArgs e) {
            this.AlarmType = Settings.Default.AlarmType;
            this.AlarmDelayType = Settings.Default.AlarmDelayType;
            switch(this.AlarmType) {
                case "None":
                    this.radioButton_SonndType1.Checked = true;
                    this.textBox1.Enabled = false;
                    this.button1.Enabled = false;
                    break;
                case "SystemSound":

                    this.radioButton_SoundType2.Checked = true;
                    this.textBox1.Enabled = false;
                    this.button1.Enabled = false;
                    break;
                case "UserDefinition":
                    this.radioButton_SonndType3.Checked = true;
                    this.textBox1.Enabled = true;
                    this.button1.Enabled = true;
                    break;
                default:
                    this.radioButton_SonndType1.Checked = true;
                    break;
            }
            switch(this.AlarmDelayType) {
                case "None":
                    this.radioButton_NoDelay.Checked = true;
                    break;
                case "A":

                    this.radioButton_OneDelay.Checked = true;
                    break;
                case "B":
                    this.radioButton_TwoDelay.Checked = true;
                    break;
                default:
                    this.radioButton_NoDelay.Checked = true;
                    break;
            }
            this.textBox1.Text = Settings.Default.SoundFilePath;
        }
        private void buttonFileReference_Click(object sender,EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "音声ファイル(*.wav;*.mp3)|*.wav;*.mp3";
            if(openFileDialog.ShowDialog() == DialogResult.OK) {
                this.textBox1.Text = openFileDialog.FileName;
            }
        }
        private void button_OK_Click(object sender,EventArgs e) {
            Settings.Default.AlarmType = this.AlarmType;
            Settings.Default.AlarmDelayType = this.AlarmDelayType;
            Settings.Default.SoundFilePath = this.textBox1.Text;
            Settings.Default.Save();
            this.Close();
        }
        private void button_Cancel_Click(object sender,EventArgs e) {
            this.Close();
        }
        private void radioButtonTab1_CheckedChanged(object sender,EventArgs e) {
            if(this.radioButton_SonndType1.Checked) {
                this.AlarmType = "None";
                this.textBox1.Enabled = false;
                this.button1.Enabled = false;
            }
            if(this.radioButton_SoundType2.Checked) {
                this.AlarmType = "SystemSound";
                this.textBox1.Enabled = false;
                this.button1.Enabled = false;
            }
            if(this.radioButton_SonndType3.Checked) {
                this.AlarmType = "UserDefinition";
                this.textBox1.Enabled = true;
                this.button1.Enabled = true;
            }
        }

        private void radioButtonTab2_CheckedChanged(object sender,EventArgs e) {
            if(this.radioButton_NoDelay.Checked) {
                this.AlarmDelayType = "None";

            }
            if(this.radioButton_OneDelay.Checked) {
                this.AlarmDelayType = "A";

            }
            if(this.radioButton_TwoDelay.Checked) {
                this.AlarmDelayType = "B";

            }
        }


    }


}
