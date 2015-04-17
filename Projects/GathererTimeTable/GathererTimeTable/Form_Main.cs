using System.Data;
using System.Windows.Forms;
using GathererTimeTable.FFXIV.Tool;

namespace GathererTimeTable {
    public partial class Form_Main : Form {
        DataTable dataTableMineral = new DataTable();
        DataTable dataTablePlant = new DataTable();
        DataTable dataTableFish = new DataTable();
        
        public Form_Main() {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender,System.EventArgs e) {
            setDisplayTime();

        }
        private void timerSec_Tick(object sender,System.EventArgs e) {
            setDisplayTime();
        }

        private void setDisplayTime() {
            labelTimeNow.Text = Eorzea_Time.GetTimeAsString();
        }

        private void __buttonCollection_Click(object sender,System.EventArgs e) {
            var formCollection = new Form_MineralEditor(this,dataTableMineral);
            formCollection.ShowDialog(this);
            formCollection.Dispose();
            //デバッグ用
            if(dataTableMineral != null) labelDebug.Text = "Mineral";
            if(dataTableMineral != null) labelDebug.Text = "Plant";
            if(dataTableMineral != null) labelDebug.Text = "Fish";
        }

    }
}
