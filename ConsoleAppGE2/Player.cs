using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGE2
{
    internal class Player
    {
        //-----------------------------
        // フィールド

        /// <summary>
        /// 名前
        /// </summary>
        private string name;

        /// <summary>
        /// 体力
        /// </summary>
        private int hp;

        /// <summary>
        /// 攻撃力
        /// </summary>
        private int attack;

        /// <summary>
        /// 名前の最大入力数
        /// </summary>
        const int MAX_NAME_LENGTH = 10;

        /// <summary>
        /// ステータスの最大桁数
        /// </summary>
        const int MAX_STATUS_DIGIT = 3;

        //------------------------------
        // メソッド

        /// <summary>
        /// プレイヤー作成
        /// </summary>
        public void CreatePlayer()
        {
            // 名前の入力
            Console.Write("■ 名前を入力 (全角5文字 半角10文字) > ");
            string name = Console.ReadLine();

            while(name.Length > MAX_NAME_LENGTH)
            {   // nameが10文字以上の時は再入力

                Console.Write("名前が長すぎます。再入力してください >");
                name = Console.ReadLine();
            }

            this.name = name;

            while (true)
            {
                // 体力の入力
                Console.Write("■ 体力を入力 (3桁まで) > ");
                string hp = Console.ReadLine();

                if (!int.TryParse(hp, out this.hp))
                {   // 数字じゃない時
                    Console.WriteLine("入力された値が数字ではありませんでした。");
                    continue;
                }

                // 数値が範囲内かチェック
                int digit = (this.hp == 0) ? 1 : ((int)System.Math.Log10(this.hp) + 1);

                if (digit > MAX_STATUS_DIGIT)
                {   // 3桁以上の時
                    Console.WriteLine("入力された値が3桁以内ではありませんでした。");
                    continue;
                }

                // 問題なければループ脱出
                break;
            }

            while (true)
            {
                // 攻撃力の入力
                Console.Write("■ 攻撃力を入力 (3桁まで) > ");
                string attack = Console.ReadLine();

                if (!int.TryParse(attack, out this.attack))
                {   // 数字じゃない時
                    Console.WriteLine("入力された値が数字ではありませんでした。");
                    continue;
                }

                // 数値が範囲内かチェック
                int digit = (this.attack == 0) ? 1 : ((int)System.Math.Log10(this.attack) + 1);

                if (digit > MAX_STATUS_DIGIT)
                {   // 3桁以上の時
                    Console.WriteLine("入力された値が3桁以内ではありませんでした。");
                    continue;
                }

                // 問題なければループ脱出
                break;
            }

            Console.Write("\n");
        }

        /// <summary>
        /// プレイヤー作成
        /// </summary>
        public void ShowPlayer()
        {
            Console.WriteLine("・ 名前 :{0}", this.name);
            Console.WriteLine("・ 体力 :{0}", this.hp);
            Console.WriteLine("・攻撃力:{0}", this.attack);
        }
    }
}
