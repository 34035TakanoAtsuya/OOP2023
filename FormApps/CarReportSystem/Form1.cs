using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //管理用データ
        BindingList<CarReport> CarReports = new BindingList<CarReport>();
        private uint mode;

        //設定情報保存オブジェクト
        Settings settings = new Settings();

        public Form1() {
            InitializeComponent();
            dgvCarReports.DataSource = CarReports;
        }

        //ステータスラベルのテキスト表示・非表示(引数なしはメッセージ非表示)
        private void statusLabelDisp(string msg = "") {
            tsInfoText.Text = msg;
        }

        //追加ボタンがクリックされた時のイベントハンドラー
        private void btAddReport_Click(object sender, EventArgs e) {
            statusLabelDisp();  //ステータスラベルのテキスト非表示
            if (cbAuthor.Text.Equals("")) {
                statusLabelDisp("記録者を入力してください");
                return;
            } else if (cbCarName.Text.Equals("")) {
                statusLabelDisp("車名を入力してください");
                return;
            } else {
                statusLabelDisp();
            }

            var carReport = new CarReport {                            //Saleインスタンスを生成
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker = getSelectedMaker(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                CarImage = pbCarImage.Image,
            };

            CarReports.Add(carReport);

            setCbAuthor(cbAuthor.Text); //記録者のコンボボックスの履歴登録処理
            setCbCarName(cbCarName.Text);   //車名コンボボックスの履歴登録処理

            Clear();    //項目クリア処理

            dgvCarReports.CurrentCell = null;
            btModifyReport.Enabled = true;  //修正ボタン
            btDeleteReport.Enabled = true;  //削除ボタン
        }

        private void setCbCarName(string carname) {
            if (cbCarName.Items.Contains(carname)) {
                cbCarName.Items.Add(carname);
            }
        }

        private void setCbAuthor(string author) {
            if (cbAuthor.Items.Contains(author)) {
                cbAuthor.Items.Add(author);
            }
        }

        //項目クリア
        private void Clear() {
            cbAuthor.Text = "";
            cbCarName.Text = "";
            gbMaker.Text = "";
            tbReport.Text = "";
            pbCarImage.Image = null;
            foreach (var item in gbMaker.Controls) {
                ((RadioButton)item).Checked = false;
            }
        }

        private CarReport.MakerGroup getSelectedMaker() {
            foreach (var item in gbMaker.Controls) {
                if (((RadioButton)item).Checked) {
                    return (CarReport.MakerGroup)int.Parse(((RadioButton)item).Tag.ToString());
                }
            }
            return CarReport.MakerGroup.その他;
        }

        //指定したメーカーのラジオボタンをセット
        private void setSelectedMaker(CarReport.MakerGroup makerGroup) {
            switch (makerGroup) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.スズキ:
                    rbSuzuki.Checked = true;
                    break;
                case CarReport.MakerGroup.ダイハツ:
                    rbDaihatsu.Checked = true;
                    break;
                case CarReport.MakerGroup.輸入車:
                    rbImported.Checked = true;
                    break;
                case CarReport.MakerGroup.その他:
                    rbOther.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void btImageOpen_Click(object sender, EventArgs e) {

            if (ofdImageFileOpen.ShowDialog() == DialogResult.OK) {
                pbCarImage.Image = Image.FromFile(ofdImageFileOpen.FileName);
            }
            ofdImageFileOpen.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e) {

            tsInfo.Text = "";   //情報表示領域のテキストを初期化
            tsTimeDisp.Text = DateTime.Now.ToString("HH時mm分ss秒");
            tmTimeUpdate.Start();

            dgvCarReports.Columns[5].Visible = false;   //画像項目非表示
            btModifyReport.Enabled = false; //修正ボタン無効
            btDeleteReport.Enabled = false; //削除ボタン無効

            //設定ファイルを逆シリアル化して背景を設定
            using (var reader = XmlReader.Create("settings.xml")) {
                var serializer = new XmlSerializer(typeof(Settings));
                settings = serializer.Deserialize(reader) as Settings;
                BackColor = Color.FromArgb(settings.MainFromColor);
            }
        }

        private void btDeleteReport_Click(object sender, EventArgs e) {
            DataGridViewSelectedRowCollection src = dgvCarReports.SelectedRows;
            for (int i = src.Count - 1; i >= 0; i--) {
                dgvCarReports.Rows.RemoveAt(src[i].Index);
            }
            if (dgvCarReports.Rows.Count == 0) {
                btDeleteReport.Enabled = false;
                btModifyReport.Enabled = false;
            }
            btModifyReport.Enabled = false;
            btDeleteReport.Enabled = false;

            Clear();
        }

        //レコード選択時
        private void dgvCarReports_Click(object sender, DataGridViewCellEventArgs e) {
            if (0 < dgvCarReports.RowCount) {

                dgvCarReports.Columns[5].Visible = false;

                dtpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[0].Value;
                cbAuthor.Text = dgvCarReports.CurrentRow.Cells[1].Value.ToString();
                setSelectedMaker((CarReport.MakerGroup)dgvCarReports.CurrentRow.Cells[2].Value);
                cbCarName.Text = dgvCarReports.CurrentRow.Cells[3].Value.ToString();
                tbReport.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
                pbCarImage.Image = (Image)dgvCarReports.CurrentRow.Cells[5].Value;

                btModifyReport.Enabled = true;  //修正ボタン
                btDeleteReport.Enabled = true;  //削除ボタン
            }
        }

        //修正ボタンイベントハンドラ
        private void btModifyReport_Click(object sender, EventArgs e) {
            if (cbAuthor.Text.Equals("")) {
                statusLabelDisp("記録者を入力してください");
                return;
            } else if (cbCarName.Text.Equals("")) {
                statusLabelDisp("車名を入力してください");
                return;
            } else {
                statusLabelDisp();
            }
            dgvCarReports.CurrentRow.Cells[0].Value = dtpDate.Value;
            dgvCarReports.CurrentRow.Cells[1].Value = cbAuthor.Text;
            dgvCarReports.CurrentRow.Cells[2].Value = getSelectedMaker();
            dgvCarReports.CurrentRow.Cells[3].Value = cbCarName.Text;
            dgvCarReports.CurrentRow.Cells[4].Value = tbReport.Text;
            dgvCarReports.CurrentRow.Cells[5].Value = pbCarImage.Image;
        }

        //終了メニュー選択時のイベントハンドラ
        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e) {
            var vf = new VersionForm();
            vf.ShowDialog();    //モーダルダイアログとして表示
        }

        private void btImageDelete_Click(object sender, EventArgs e) {
            pbCarImage.Image = null;
        }

        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (cdColor.ShowDialog() == DialogResult.OK) {
                BackColor = cdColor.Color;
                settings.MainFromColor = cdColor.Color.ToArgb();
            }
        }

        private void btScaleChange_Click(object sender, EventArgs e) {
            mode++;
            if (mode > 4) {
                mode = 0;
            }
            mode = mode < 4 ? ((mode == 1) ? 3 : ++mode) : 0;
            pbCarImage.SizeMode = (PictureBoxSizeMode)mode;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            //設定ファイルのシリアル化
            using (var writer = XmlWriter.Create("settings.xml")) {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(writer, settings);
            }
        }

        private void tmTimeUpdate_Tick(object sender, EventArgs e) {
            tsTimeDisp.Text = DateTime.Now.ToString("HH時mm分ss秒");
        }

        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e) {
            if (sfdCarRepoSave.ShowDialog() == DialogResult.OK) {

            }
        }

        private void 開くOToolStripMenuItem_Click(object sender, EventArgs e) {
            if (ofdCarRepoOpen.ShowDialog() == DialogResult.OK) {

            }
        }
    }
}
