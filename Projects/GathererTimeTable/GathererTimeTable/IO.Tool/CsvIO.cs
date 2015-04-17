using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using System.Data;

namespace GathererTimeTable.IO.Tool {
    class CsvIO {
        public CsvIO() {

        }

        public static void SaveDataGridViewToCsv(ref DataGridView dataGridView1,string _FileName) {
            // 保存用のファイルを開く
            using(StreamWriter writer = new StreamWriter(_FileName,false,Encoding.GetEncoding("shift_jis"))) {

                int rowCount = dataGridView1.Rows.Count;

                // ユーザによる行追加が許可されている場合は、最後に新規入力用の1行分を差し引く
                if(dataGridView1.AllowUserToAddRows) {
                    rowCount = rowCount - 1;
                }

                // 行
                for(int i = 0;i < rowCount;i++) {
                    // リストの初期化
                    List<String> strList = new List<String>();

                    // 要素をリストへ登録する
                    for(int j = 0;j < dataGridView1.Columns.Count;j++) {
                        strList.Add("\"" + Convert.ToString(dataGridView1[j,i].Value) + "\"");
                    }
                    String[] strArray = strList.ToArray();  // 配列へ変換

                    // CSV 形式に変換
                    String strCsvData = String.Join(",",strArray);

                    writer.WriteLine(strCsvData);
                }
            }
        }

        public static void loadCsvToDataGridView(ref DataGridView dataGridView1,string _FileName) {
            TextFieldParser parser = new TextFieldParser(_FileName,Encoding.GetEncoding("Shift_JIS"));
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(","); // 区切り文字はコンマ
            //""コメント内のコンマは無視する
            parser.HasFieldsEnclosedInQuotes = true;

            // データをすべてクリア
            dataGridView1.Rows.Clear();

            while(!parser.EndOfData) {
                string[] row = parser.ReadFields(); // 1行読み込み
                // 読み込んだデータ(1行をDataGridViewに表示する)
                dataGridView1.Rows.Add(row);


            }
        }
        public static DataTable loadCsvToDataTable(System.Data.DataSet _DataSet,string _FileName) {
            String filename = System.IO.Directory.GetCurrentDirectory() + "\\Collection.csv"; // ファイルパス

            // データベースへ接続する(今回はCSVファイルを開く)
            OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Path.GetDirectoryName(filename) + "\\; Extended Properties=\"Text;HDR=YES;FMT=Delimited\"");

            // クエリ文字列を作る
            // ※ファイルパスを[]でくくること！
            OleDbCommand command = new OleDbCommand("SELECT * FROM [" + Path.GetFileName(filename) + "]",connection);

            System.Data.DataSet dataset = _DataSet;
            //dataset.Clear();    // 念のためクリア

            // CSVファイルの内容をDataSetに入れる
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            adapter.Fill(dataset);

            return dataset.Tables[0];

        }
    }
}
