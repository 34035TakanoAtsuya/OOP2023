using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btDayCalc_Click(object sender, EventArgs e) {

            var now = DateTime.Now;
            var dtp = dtpDate.Value;
            var date = now - dtp; 

            tbMessage.Text = "生まれてから" + date.Days + "日経過しました。";
        }

        private void btAge_Click(object sender, EventArgs e) {

            var now = DateTime.Now;
            var dtp = dtpDate.Value;
            var age = now.Year - dtp.Year;
            if (now < dtp.AddYears(age)) {
                age--;
            }
            tbMessage.Text = age + "歳";
        }

        private void Form1_Load(object sender, EventArgs e) {
            var now = DateTime.Now;
            tbTimeNow.Text = now.ToString("yyyy年MM月dd日(ddd) HH時mm分ss秒");
            tmTimeDisp.Start();
        }

        //タイマーイベントハンドラ
        private void tmTimeDisp_Tick(object sender, EventArgs e) {
            tbTimeNow.Text = DateTime.Now.ToString("yyyy年MM月dd日(ddd) HH時mm分ss秒");
        }

        private void prevYear_Click(object sender, EventArgs e) {
            dtpDate.Value = dtpDate.Value.AddYears(1);
            tbMessage.Text = dtpDate.ToString();    
        }
    }
}
