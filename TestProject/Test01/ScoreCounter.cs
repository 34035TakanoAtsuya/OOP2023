using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {

            _score = ReadScore(filePath);

        }


        //メソッドの概要： 
        private static IEnumerable<Student> ReadScore(string filePath) {
            
            var scores = new List<Student>(); //点数データを格納
            var lines = File.ReadAllLines(filePath);    //ファイルからすべてのデータを読み込む

            foreach (var line in lines) {   //すべての行から一行ずつ取り出す
                
                var items = line.Split(',');    //区切りで項目別に分ける
                var stud = new Student {    //Studentインスタンス作成
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2]),
                
                };
                
                scores.Add(stud);   //Studentインスタンスをコレクションに追加
            
            }

            return scores;
        
        }

        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {
            
            var dict = new SortedDictionary<string, int>();
            
            foreach (var score in _score) {
                
                if (dict.ContainsKey(score.Name)) {
                    dict[score.Name] += score.Score; //名前が既に存在する
                } else {
                    dict[score.Name] = score.Score; //名前が存在しない
                }

            }
            return dict;
        }
    }
}
