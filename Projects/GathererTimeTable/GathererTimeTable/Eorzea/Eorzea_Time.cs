using System;

namespace GathererTimetable.Eorzea {
    class Eorzea_Time {
        //コンストラクタ
        public Eorzea_Time() {
            
        }
        /// <summary>
        /// エオルゼア時間hh:mmの形でを取得する
        /// </summary>
        /// <returns></returns>
        public static string GetTimeAsString() {
            ulong second;
            ulong minute;
            ulong hour;
            ulong elapsedTime;
            DateTime baseTime = new DateTime(2013,7,14,0,0,0);
            //時刻の差分を秒表示
            elapsedTime = (ulong)(DateTime.Now - baseTime).TotalSeconds;
            //地球時間の1440/70倍のスピードでエオルゼア時間は進む
            ulong restTime = elapsedTime * 1440uL / 70uL;
            //差分秒を60で割った余りがエオルゼア秒となる
            second = restTime % 60uL;
            //差分秒から端数秒となるエオルゼア秒を引く
            restTime -= second;
            //差分秒を差分分に変換
            restTime /= 60uL;
            minute = restTime % 60uL;
            restTime -= minute;
            restTime /= 60uL;

            hour = restTime % 24uL;
            //Hour:Minuteで出力。右寄り0埋めで出力。
            return string.Concat(new string[]{
                hour.ToString("D2"),":",
                minute.ToString("D2")
            });
        }// M GetTimeAsString



        public static string GetTimeAsString(string delayType) {
            ulong second;
            ulong minute;
            ulong hour;
            ulong elapsedTime;
            DateTime baseTime = new DateTime(2013,7,14,0,0,0);
            //時刻の差分を秒表示
            elapsedTime = (ulong)(DateTime.Now - baseTime).TotalSeconds;
            //地球時間の1440/70倍のスピードでエオルゼア時間は進む
            ulong restTime = elapsedTime * 1440uL / 70uL;
            //差分秒を60で割った余りがエオルゼア秒となる
            second = restTime % 60uL;
            //差分秒から端数秒となるエオルゼア秒を引く
            restTime -= second;
            //差分秒を差分分に変換
            restTime /= 60uL;
            //Timeのディレイ設定
            switch(delayType) {
                case "A":
                    restTime += 20uL;
                    break;
                case "B":
                    restTime += 61uL;
                    break;
            }
            minute = restTime % 60uL;
            restTime -= minute;
            restTime /= 60uL;

            hour = restTime % 24uL;
            //Hour:Minuteで出力。右寄り0埋めで出力。
            return string.Concat(new string[]{
                hour.ToString("D2"),":",
                minute.ToString("D2")
            });
        }// M GetTimeAsString

        
    }
}
