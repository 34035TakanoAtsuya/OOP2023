using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
        Settings settings = Settings.getInstance();

        public Form1() {
            InitializeComponent();
            //dgvCarReports.DataSource = CarReports;
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

            DataRow newRow = infosys202307DataSet.CarReportTable.NewRow();

            newRow[1] = dtpDate.Value;
            newRow[2] = cbAuthor.Text;
            newRow[3] = getSelectedMaker();
            newRow[4] = cbCarName.Text;
            newRow[5] = tbReport.Text;
            newRow[6] = ImageToByteArray(pbCarImage.Image);

            infosys202307DataSet.CarReportTable.Rows.Add(newRow);
            this.carReportTableTableAdapter.Update(infosys202307DataSet.CarReportTable);

            setCbAuthor(cbAuthor.Text); //記録者のコンボボックスの履歴登録処理
            setCbCarName(cbCarName.Text);   //車名コンボボックスの履歴登録処理

            Clear();    //項目クリア処理

            dgvCarReports.CurrentCell = null;
            btModifyReport.Enabled = true;  //修正ボタン
            btDeleteReport.Enabled = true;  //削除ボタン
        }

        private void setCbCarName(string carname) {
            if (!cbCarName.Items.Contains(carname)) {
                cbCarName.Items.Add(carname);
            }
        }

        private void setCbAuthor(string author) {
            if (!cbAuthor.Items.Contains(author)) {
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
        private void setSelectedMaker(string makerGroup) {
            switch (makerGroup) {
                case "トヨタ":
                    rbToyota.Checked = true;
                    break;
                case "日産":
                    rbNissan.Checked = true;
                    break;
                case "ホンダ":
                    rbHonda.Checked = true;
                    break;
                case "スバル":
                    rbSubaru.Checked = true;
                    break;
                case "スズキ":
                    rbSuzuki.Checked = true;
                    break;
                case "ダイハツ":
                    rbDaihatsu.Checked = true;
                    break;
                case "輸入車":
                    rbImported.Checked = true;
                    break;
                case "その他":
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

            dgvCarReports.RowsDefaultCellStyle.BackColor = Color.Cyan;  //全体に色を設定
            dgvCarReports.AlternatingRowsDefaultCellStyle.BackColor = Color.Khaki;  //奇数行の色を上書き設定

            dgvCarReports.Columns[0].Visible = false;   //ID項目非表示
            dgvCarReports.Columns[6].Visible = false;   //画像項目非表示
            btModifyReport.Enabled = false; //修正ボタン無効
            btDeleteReport.Enabled = false; //削除ボタン無効


            try {
                //設定ファイルを逆シリアル化して背景を設定
                using (var reader = XmlReader.Create("settings.xml")) {
                    var serializer = new XmlSerializer(typeof(Settings));
                    settings = serializer.Deserialize(reader) as Settings;
                    BackColor = Color.FromArgb(settings.MainFromColor);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }


        private void btDeleteReport_Click(object sender, EventArgs e) {
            //DataGridViewSelectedRowCollection src = dgvCarReports.SelectedRows;
            //    for (int i = src.Count - 1; i >= 0; i--) {
            //        dgvCarReports.Rows.RemoveAt(src[i].Index);
            //    }
            //    if (dgvCarReports.Rows.Count == 0) {
            //        btDeleteReport.Enabled = false;
            //        btModifyReport.Enabled = false;
            //    }
            //    btModifyReport.Enabled = false;
            //    btDeleteReport.Enabled = false;

            //    Clear();

            dgvCarReports.Rows.RemoveAt(dgvCarReports.CurrentRow.Index);
            this.tableAdapterManager.UpdateAll(this.infosys202307DataSet);
            Clear();
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

            dgvCarReports.CurrentRow.Cells[1].Value = dtpDate.Value;
            dgvCarReports.CurrentRow.Cells[2].Value = cbAuthor.Text;
            dgvCarReports.CurrentRow.Cells[3].Value = getSelectedMaker();
            dgvCarReports.CurrentRow.Cells[4].Value = cbCarName.Text;
            dgvCarReports.CurrentRow.Cells[5].Value = tbReport.Text;
            dgvCarReports.CurrentRow.Cells[6].Value = pbCarImage.Image;

            this.Validate();
            this.carReportTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202307DataSet);
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
                try {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(sfdCarRepoSave.FileName, FileMode.Create)) {
                        bf.Serialize(fs, CarReports);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvCarReports_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (dgvCarReports.RowCount != 0) {
                dtpDate.Text = dgvCarReports.CurrentRow.Cells[1].Value.ToString();
                cbAuthor.Text = dgvCarReports.CurrentRow.Cells[2].Value.ToString();
                setSelectedMaker(dgvCarReports.CurrentRow.Cells[3].Value.ToString());
                cbCarName.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
                tbReport.Text = dgvCarReports.CurrentRow.Cells[5].Value.ToString();
                pbCarImage.Image = !dgvCarReports.CurrentRow.Cells[6].Value.Equals(DBNull.Value)
                                    && ((Byte[])dgvCarReports.CurrentRow.Cells[6].Value).Length != 0 ?
                                    ByteArrayToImage((Byte[])dgvCarReports.CurrentRow.Cells[6].Value) : null;

                if (dgvCarReports.CurrentRow != null) {
                    btModifyReport.Enabled = true;
                    btDeleteReport.Enabled = true;
                    btScaleChange.Enabled = true;
                    btImageDelete.Enabled = true;
                }
            }
        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }


        private void carReportTableBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202307DataSet);

        }

        //接続ボタンイベントハンドラ
        private void btConnection_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202307DataSet.CarReportTable' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableTableAdapter.Fill(this.infosys202307DataSet.CarReportTable);
            dgvCarReports.ClearSelection(); //選択解除

            foreach (var carReport in infosys202307DataSet.CarReportTable) {
                setCbAuthor(carReport.Author);
                setCbCarName(carReport.CarName);
            }
        }

        private void dB接続NToolStripMenuItem_Click(object sender, EventArgs e) {
            dbConnection();
        }


        private void dbConnection() {
            // TODO: このコード行はデータを 'infosys202307DataSet.CarReportTable' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableTableAdapter.Fill(this.infosys202307DataSet.CarReportTable);
            dgvCarReports.ClearSelection(); //選択解除

            foreach (var carReport in infosys202307DataSet.CarReportTable) {
                setCbAuthor(carReport.Author);
                setCbCarName(carReport.CarName);
            }
        }

        private void btAuthorSearch_Click(object sender, EventArgs e) {
            carReportTableTableAdapter.FillByAuthor(this.infosys202307DataSet.CarReportTable, tbAuthorSearch.Text);
        }

        private void btCarNameSearch_Click(object sender, EventArgs e) {
            carReportTableTableAdapter.FillByCarName(this.infosys202307DataSet.CarReportTable, tbCarNameSearch.Text);
        }

        private void btDateSearch_Click(object sender, EventArgs e) {
            carReportTableTableAdapter.FillByDateToDate(this.infosys202307DataSet.CarReportTable, dtpDateSearchS.Text,dtpDateSearchE.Text);
        }

        private void btReset_Click(object sender, EventArgs e) {
            carReportTableTableAdapter.Fill(this.infosys202307DataSet.CarReportTable);
        }
    }
}