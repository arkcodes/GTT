using System.Windows.Forms;
using GathererTimeTable.FFXIV.Tool;

namespace GathererTimeTable {
    public partial class Form_Main : Form {
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
            var formCollection = new Form_MineralEditor();
            formCollection.ShowDialog(this);
            formCollection.Dispose();
        }

    }
}
