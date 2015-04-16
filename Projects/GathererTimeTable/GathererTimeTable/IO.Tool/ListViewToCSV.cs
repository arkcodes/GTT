using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace GathererTimeTable.IO.Tool {
    public class ListViewToCSV {
        ListViewToCSV() {
        }

        public static void SaveListViewtoCsv(ListView _listView,string _fileName,bool _includeHidden) {
            //make header string
            StringBuilder result = new StringBuilder();
            //カラム設定までテキスト出力する場合は下の行を有効化
            //WriteRowToCsv(result,_listView.Columns.Count,i => _includeHidden || _listView.Columns[i].Width > 0,i => _listView.Columns[i].Text);

            //export data rows
            foreach(ListViewItem listItem in _listView.Items)
                WriteRowToCsv(result,_listView.Columns.Count,i => _includeHidden || _listView.Columns[i].Width > 0,i => listItem.SubItems[i].Text);

            File.WriteAllText(_fileName,result.ToString());
        }

        public static void LoadCsvToListView(ref ListView _listView,string _fileName) {
            TextFieldParser parser = new TextFieldParser("listview.csv",System.Text.Encoding.GetEncoding("UTF-8"));
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");
            parser.HasFieldsEnclosedInQuotes = true;
            _listView.Items.Clear();
            while(!parser.EndOfData) {
                string[] row = parser.ReadFields();
                _listView.Items.Add(new ListViewItem(row));
            }
        }

        private static void WriteRowToCsv(StringBuilder _result,int _itemsCount,Func<int,bool> _isColumnNeeded,Func<int,string> _columnValue) {
            bool isFirstTime = true;
            for(int i = 0;i < _itemsCount;i++) {
                if(!_isColumnNeeded(i))
                    continue;

                if(!isFirstTime)
                    _result.Append(",");
                isFirstTime = false;

                _result.Append(String.Format("\"{0}\"",_columnValue(i)));
            }
            _result.AppendLine();
        }
    }
}
