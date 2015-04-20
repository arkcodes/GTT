namespace GathererTimeTable.IO.Tool {
    class Serializer<T> {
        public Serializer() {
        }


        /// <summary>
        /// xml形式でインスタンスを保存する
        /// </summary>
        /// <param name="_item">保存するインスタンスを保持している型変数</param>
        /// <param name="_fileName">保存する際のファイル名を表す文字列</param>
        public void saveSettings(T _item,string _fileName) {
            //保存するファイルのパスを、カレントディレクトリ＋ファイルネームとして取得
            string filePath = _fileName;
            //型変数を基準としたシリアライザを作成
            var serializer = new System.Xml.Serialization.XmlSerializer(_item.GetType());
            using(var sw = new System.IO.StreamWriter(filePath,false,new System.Text.UTF8Encoding(false))) {
                ;
                //書き込みを行う
                serializer.Serialize(sw,_item);
                sw.Close();
            }
        }
        /// <summary>
        /// を実行する・取得する
        /// </summary>
        /// <param name="_FileName">読み込み対象のファイル名を表す文字列</param>
        /// <returns></returns>
        public T loadSettings(string _FileName) {
            string _filePath = _FileName;
            //XmlSerializerオブジェクトを作成
            var _serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
            //読み込むファイルを開く
            using(var sr = new System.IO.StreamReader(_filePath,new System.Text.UTF8Encoding(false))) {
                //XMLファイルから読み込み、逆シリアル化する
                //nameObjのメンバであるindexよりループカウンタを取得可能
                var _item = (T)_serializer.Deserialize(sr);

                return _item;
            }
        }
    }
}
