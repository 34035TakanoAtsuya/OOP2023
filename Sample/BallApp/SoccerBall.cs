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
        public override void Move(PictureBox pbBar, PictureBox pbBall) {

            Rectangle rBar = new Rectangle(pbBar.Location.X, pbBar.Location.Y, 
                                           pbBar.Width, pbBar.Height);
            Rectangle rBall = new Rectangle(pbBall.Location.X, pbBall.Location.Y, 
                                            pbBall.Width, pbBall.Height);

            if (PosX > 700 || PosX < 0 || rBar.IntersectsWith(rBall))
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
