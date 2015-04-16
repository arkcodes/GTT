using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace GathererTimeTable.IO.Tool {
    class CsvIO {
        public CsvIO() {

        }

        public static void SaveDataTableToCsv(ref DataGridView dataGridView1,string _FileName) {
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

        public static void loadCsvToDataTable(ref DataGridView dataGridView1,string _FileName) {
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

    }
}
