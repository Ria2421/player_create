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

        //------------------------------
        // メソッド

        /// <summary>
        /// プレイヤー作成
        /// </summary>
        public void CreatePlayer(string name,int hp,int attack)
        {
            // 各情報を代入
            this.name = name;
            this.attack = attack;
            this.hp = hp;
        }
    }
}
