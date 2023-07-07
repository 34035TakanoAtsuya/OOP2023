using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //管理用データ
        BindingList<CarReport> CarReports = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvCarReports.DataSource = CarReports;
        }

        //追加ボタンが押された時のイベントハンドラー
        private void btAddReport_Click(object sender, EventArgs e) {
            var cr = new CarReport() {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                CarImage = pbCarImage.Image,
            };

            CarReports.Add(cr);
            dgvCarReports.DataSource = CarReports;
        }

        private CarReport.MakerGroup getSelectedMaker() {

            return CarReport.MakerGroup.トヨタ;

        }
    }
}
