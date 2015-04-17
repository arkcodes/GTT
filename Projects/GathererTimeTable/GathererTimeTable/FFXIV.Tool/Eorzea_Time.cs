using System;

namespace GathererTimeTable.FFXIV.Tool {
    class Eorzea_Time {
        //コンストラクタ
        public Eorzea_Time() {
            
        }

        /// <summary>
        /// を取得する
        /// </summary>
        /// <returns></returns>
        public static string GetTimeAsString() {
            ulong eSecond;
            ulong eMinute;
            ulong eHour;
            ulong diff;
            DateTime d = new DateTime(2013,7,14,0,0,0);
            //時刻の差分を秒表示
            diff = (ulong)(DateTime.Now - d).TotalSeconds;
            //地球時間の1440/70倍のスピードでエオルゼア時間は進む
            ulong num = diff * 1440uL / 70uL;
            //差分秒を60で割った余りがエオルゼア秒となる

            eSecond = num % 60uL;
            //差分秒から端数秒となるエオルゼア秒を引く
            num -= eSecond;
            //差分秒を差分分に変換
            num /= 60uL;

            eMinute = num % 60uL;
            num -= eMinute;
            num /= 60uL;

            eHour = num % 24uL;

            //Hour:Minuteで出力。右寄り0埋めで出力。

            return string.Concat(new string[]{
                eHour.ToString("D2"),":",
                eMinute.ToString("D2")
            });
        }// M GetTimeAsString

        public static string GetMinuteAsString() {
            ulong eSecond;
            ulong eMinute;
            ulong eHour;
            ulong diff;
            DateTime d = new DateTime(2013,7,14,0,0,0);
            //時刻の差分を秒表示
            diff = (ulong)(DateTime.Now - d).TotalSeconds;
            //地球時間の1440/70倍のスピードでエオルゼア時間は進む
            ulong num = diff * 1440uL / 70uL;
            //差分秒を60で割った余りがエオルゼア秒となる

            eSecond = num % 60uL;
            //差分秒から端数秒となるエオルゼア秒を引く
            num -= eSecond;
            //差分秒を差分分に変換
            num /= 60uL;

            eMinute = num % 60uL;
            num -= eMinute;
            num /= 60uL;

            eHour = num % 24uL;

            //Hour:Minuteで出力。右寄り0埋めで出力。

            return eMinute.ToString("D2");
        }// M GetTimeAsString
    }
}
