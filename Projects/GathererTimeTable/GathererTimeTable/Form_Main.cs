using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using GathererTimeTable.FFXIV.Tool;
using GathererTimeTable.IO.Tool;

namespace GathererTimeTable {
    public partial class Form_Main : Form {
        private int __count= 0;
        public int Count {
            get { return __count; }
            set { __count = value; }
        }
        List<string> ListButtonCollectText = new List<string>();
        List<string> ListLabelCollectText = new List<string>();

        public Form_Main() {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender,System.EventArgs e) {
            labelTimeNow.Text = Eorzea_Time.GetTimeAsString();


        }
        private void timerSec_Tick(object sender,System.EventArgs e) {

            string __eTime = Eorzea_Time.GetTimeAsString();
            string __emTime = Eorzea_Time.GetMinuteAsString();
            labelTimeNow.Text = __eTime;

            if(__emTime == "00" && Count == 0) {
                ListButtonCollectText.Clear();
                ListLabelCollectText.Clear();
                int i = 0;
                CsvIO.SearchCollectionCsvtoList(__eTime,"Collection.csv",ref ListButtonCollectText,ref ListLabelCollectText);
                foreach(var s in ListButtonCollectText.Select((value,index) => new { value,index })) {
                    this.Controls["button" + (s.index + 1)].Enabled = true;
                    this.Controls["button" + (s.index + 1)].Text = s.value;
                    i++;
                }

                foreach(var s in ListLabelCollectText.Select((value,index) => new { value,index })) {
                    this.Controls["label" + (s.index + 1)].Enabled = true;
                    this.Controls["label" + (s.index + 1)].Text = s.value;
                }

                for(int j = i + 1;j <= 4;j++) {
                    this.Controls["button" + j].Enabled = false;
                    this.Controls["label" + j].ResetText();
                }
                Count++;
            }

            if(__emTime == "01") {
                Count = 0;
            }
        }


        private void __buttonCollection_Click(object sender,System.EventArgs e) {
            var formCollection = new Form_MineralEditor(this);
            formCollection.ShowDialog(this);
            formCollection.Dispose();

        }

    }
}
