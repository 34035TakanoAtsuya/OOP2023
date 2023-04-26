using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class SoccerBall : Obj {

        //フィールド
        Random random = new Random(); //乱数インスタンス

        private static int cnt;

        public static int Cnt { get => cnt; set => cnt = value; }

        //コンストラクタ
        public SoccerBall(double xp, double yp)
            : base(xp, yp, "pic\\soccer_ball.png") {
            int rndX = random.Next(-15, 15);
            MoveX = (rndX != 0 ? rndX : 1); //乱数で移動量を設定
            int rndY = random.Next(-15, 15);
            MoveY = (rndY != 0 ? rndY : 1); //乱数で移動量を設定
            cnt++;
        }

        //メソッド
        public override void Move() {
            Console.WriteLine("X座標 = {0},Y座標 = {1}", PosX, PosY);
            if (PosX > 700 || PosX < 0)
            {
                MoveX = -MoveX;
            }

            if (PosY > 500 || PosY < 0)
            {
                MoveY = -MoveY;
            }
            PosX += MoveX;
            PosY += MoveY;
        }
        public override void Move(Keys direction) {
        }
    }
}
