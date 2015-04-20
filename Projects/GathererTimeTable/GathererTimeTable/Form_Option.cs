using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GathererTimeTable {
    public partial class Form_Option : Form {
        public string AlarmType {get;set;}
        public Form_Option() {
            InitializeComponent();
        }

        private void Frm_Option_Load(object sender,EventArgs e) {
            this.AlarmType = Settings.Default.AlarmType;
            switch(this.AlarmType) {
                case "None":
                    this._radioButton_SoundType1.Checked = true;
                    break;
                case "SystemSound":

                    this._radioButton_SoundType2.Checked = true;
                    break;
                case "UserDefinition":
                    this._radioButton_SonndType3.Checked = true;
                    this.textBox1.Enabled = true;
                    this.button1.Enabled = true;
                    break;
                default:
                    this._radioButton_SoundType1.Checked = true;
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
            Settings.Default.SoundFilePath = this.textBox1.Text;
            Settings.Default.Save();
            this.Close();
        }
        private void button_Cancel_Click(object sender,EventArgs e) {
            this.Close();
        }
        private void radioButton_CheckedChanged(object sender,EventArgs e) {
            if(this._radioButton_SoundType1.Checked) {
                this.AlarmType = "None";
                this.textBox1.Enabled = false;
                this.button1.Enabled = false;
            }
            if(this._radioButton_SoundType2.Checked) {
                this.AlarmType = "SystemSound";
                this.textBox1.Enabled = false;
                this.button1.Enabled = false;
            }
            if(this._radioButton_SonndType3.Checked) {
                this.AlarmType = "UserDefinition";
                this.textBox1.Enabled = true;
                this.button1.Enabled = true;
            }
        }

    }


}
