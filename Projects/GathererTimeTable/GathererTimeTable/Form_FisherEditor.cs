using System;
using System.ComponentModel;
using System.Windows.Forms;
using GathererTimetable.IO.Tool;


namespace GathererTimetable {
    public partial class Form_FisherEditor : Form {
        Form_Main _form_Main = new Form_Main();
        public Form_FisherEditor(Form_Main _Form_Main) {
            _form_Main = _Form_Main;
            InitializeComponent();
        }

        private void form_Collection_Load(object sender,EventArgs e) {
            CsvIO.LoadCSVToDataGridView(dataGridView1,"FisherCollection.csv");

        }

        private void buttonComplete_Click(object sender,EventArgs e) {
            CsvIO.SaveDataTableToCSV(dataGridView1,"FisherCollection.csv");
            Close();
        }
        private void buttonCancel_Click(object sender,EventArgs e) {
            Close();
        }
        private void checkBoxToggleCheck_CheckedChanged(object sender,EventArgs e) {
            if(checkBoxToggleCheck.Checked) {
                for(int i = 0;i < dataGridView1.RowCount;i++) {
                    dataGridView1[0,i].Value = true;
                }
            }
            else {
                for(int i = 0;i < dataGridView1.RowCount;i++) {
                    dataGridView1[0,i].Value = false;
                }
            }

        }

        public bool Order { get; set; }

        private void dataGridView1_ColumnHeaderMouseClick(object sender,DataGridViewCellMouseEventArgs e) {
            DataGridViewColumn clickedColumn = dataGridView1.Columns[e.ColumnIndex];
            if(clickedColumn.SortMode != DataGridViewColumnSortMode.Automatic)
                this.sortRows(clickedColumn,Order);
        }

        /// <summary>
        /// 指定された列を基準にして並び替えを行う
        /// </summary>
        /// <param name="sortColumn">基準にする列</param>
        /// <param name="orderToggle">並び替えの方向をトグルで変更する</param>
        private void sortRows(DataGridViewColumn sortColumn,bool orderToggle) {
            if(sortColumn == null)
                return;



            //並び替えの方向（昇順か降順か）を決める
            ListSortDirection sortDirection;
            if(orderToggle) {
                sortDirection =
                    dataGridView1.SortOrder == SortOrder.Descending ?
                    ListSortDirection.Ascending : ListSortDirection.Descending;
                Order = false;
            }
            else {
                sortDirection =
                    dataGridView1.SortOrder == SortOrder.Descending ?
                    ListSortDirection.Descending : ListSortDirection.Ascending;
                Order = true;
            }
            SortOrder sortOrder =
                sortDirection == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;

            //今までの並び替えグリフを消す
            if(sortColumn.SortMode == DataGridViewColumnSortMode.Programmatic &&
                dataGridView1.SortedColumn != null &&
                !dataGridView1.SortedColumn.Equals(sortColumn)) {
                dataGridView1.SortedColumn.HeaderCell.SortGlyphDirection =
                    SortOrder.None;
            }

            //並び替えを行う
            if(sortDirection == ListSortDirection.Ascending) dataGridView1.Sort(new rowComparer(SortOrder.Ascending));
            else if(sortDirection == ListSortDirection.Descending) dataGridView1.Sort(new rowComparer(SortOrder.Descending));


            if(sortColumn.SortMode == DataGridViewColumnSortMode.Programmatic) {
                //並び替えグリフを変更
                sortColumn.HeaderCell.SortGlyphDirection = sortOrder;
            }
        }

        private class rowComparer : System.Collections.IComparer {
            private static int sortOrderModifier = 1;

            public rowComparer(SortOrder sortOrder) {
                if(sortOrder == SortOrder.Descending) {
                    sortOrderModifier = -1;
                }
                else if(sortOrder == SortOrder.Ascending) {
                    sortOrderModifier = 1;
                }
            }

            public int Compare(object x,object y) {
                DataGridViewRow DataGridViewRow1 = (DataGridViewRow)x;
                DataGridViewRow DataGridViewRow2 = (DataGridViewRow)y;

                // Try to sort based on the Last Name column.
                int CompareResult = System.String.Compare(
                    DataGridViewRow1.Cells[2].Value.ToString(),
                    DataGridViewRow2.Cells[2].Value.ToString());

                // If the Last Names are equal, sort based on the First Name.
                if(CompareResult == 0) {
                    CompareResult = System.String.Compare(
                        DataGridViewRow1.Cells[5].Value.ToString(),
                        DataGridViewRow2.Cells[5].Value.ToString());
                }
                return CompareResult * sortOrderModifier;
            }
        }

    }
}
