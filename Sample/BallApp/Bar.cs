using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Bar : Obj{
        public Bar(double xp, double yp)
            : base(xp, yp, "pic\\Bar.png") {
            MoveX = 10;
            MoveY = 0;
        }
        
        //中小クラスを継承しているので、不要なメソッドは空にする
        public override void Move() {
            ;//空のメソッドにする
        }

        public override void Move(Keys direction) {
            if(direction == Keys.Right){
                if (PosX < 635)
                {
                    PosX += MoveX;
                }
                else if (direction == Keys.Left)
                {
                    if (PosX > 0)
                    {
                        PosX -= MoveX;
                    }
                }
            }
        }
    }
}
