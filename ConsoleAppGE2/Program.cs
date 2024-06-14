using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGE2
{
    internal class Program
    {
        //----------------------------------------------
        // フィールド

        /// <summary>
        /// プレイヤーの人数
        /// </summary>
        const int MAX_PLAYER = 2;

        //----------------------------------------------
        // メソッド

        static void Main(string[] args)
        {
            // プレイヤー情報格納用
            Player[] players = new Player[MAX_PLAYER];

            // プレイヤーの生成
            for (int i = 0; i < MAX_PLAYER; i++)
            {
                Console.WriteLine("{0}Pのステータスを入力", i + 1);

                // インスタンスの生成
                players[i] = new Player();
                players[i].CreatePlayer();
            }

            // 終了処理
            Console.Write("Enterを押して終了...");
            Console.ReadLine();
        }
    }
}
