
namespace RssReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btGet = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.btBack = new System.Windows.Forms.Button();
            this.btForward = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.rbRss4 = new System.Windows.Forms.RadioButton();
            this.rbRss1 = new System.Windows.Forms.RadioButton();
            this.rbRss2 = new System.Windows.Forms.RadioButton();
            this.rbRss3 = new System.Windows.Forms.RadioButton();
            this.btFavorite = new System.Windows.Forms.Button();
            this.tbFavName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.gbRss = new System.Windows.Forms.GroupBox();
            this.cbFavName = new System.Windows.Forms.ComboBox();
            this.lbError = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.gbRss.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUrl.Location = new System.Drawing.Point(156, 12);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(1017, 41);
            this.tbUrl.TabIndex = 0;
            // 
            // btGet
            // 
            this.btGet.BackColor = System.Drawing.Color.Transparent;
            this.btGet.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGet.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btGet.Location = new System.Drawing.Point(1226, 12);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(44, 41);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "🔍";
            this.btGet.UseVisualStyleBackColor = false;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.BackColor = System.Drawing.Color.White;
            this.lbRssTitle.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRssTitle.ForeColor = System.Drawing.Color.Blue;
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 23;
            this.lbRssTitle.Location = new System.Drawing.Point(20, 72);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(373, 395);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.SelectedIndexChanged += new System.EventHandler(this.lbRssTitle_SelectedIndexChanged);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(403, 104);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(864, 565);
            this.wbBrowser.TabIndex = 3;
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btBack.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btBack.Location = new System.Drawing.Point(20, 15);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(41, 33);
            this.btBack.TabIndex = 4;
            this.btBack.Text = "←";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btForward
            // 
            this.btForward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btForward.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btForward.Location = new System.Drawing.Point(67, 15);
            this.btForward.Name = "btForward";
            this.btForward.Size = new System.Drawing.Size(39, 33);
            this.btForward.TabIndex = 5;
            this.btForward.Text = "→";
            this.btForward.UseVisualStyleBackColor = false;
            this.btForward.Click += new System.EventHandler(this.btForward_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btRefresh.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btRefresh.Location = new System.Drawing.Point(112, 15);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(38, 33);
            this.btRefresh.TabIndex = 6;
            this.btRefresh.Text = "♺";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // rbRss4
            // 
            this.rbRss4.AutoSize = true;
            this.rbRss4.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRss4.Location = new System.Drawing.Point(6, 104);
            this.rbRss4.Name = "rbRss4";
            this.rbRss4.Size = new System.Drawing.Size(101, 37);
            this.rbRss4.TabIndex = 8;
            this.rbRss4.TabStop = true;
            this.rbRss4.Text = "Anime!";
            this.rbRss4.UseVisualStyleBackColor = true;
            this.rbRss4.CheckedChanged += new System.EventHandler(this.rbRss4_CheckedChanged);
            // 
            // rbRss1
            // 
            this.rbRss1.AutoSize = true;
            this.rbRss1.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRss1.Location = new System.Drawing.Point(6, 18);
            this.rbRss1.Name = "rbRss1";
            this.rbRss1.Size = new System.Drawing.Size(130, 37);
            this.rbRss1.TabIndex = 9;
            this.rbRss1.TabStop = true;
            this.rbRss1.Text = "GunmaTV";
            this.rbRss1.UseVisualStyleBackColor = true;
            this.rbRss1.CheckedChanged += new System.EventHandler(this.rbRss1_CheckedChanged);
            // 
            // rbRss2
            // 
            this.rbRss2.AutoSize = true;
            this.rbRss2.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRss2.Location = new System.Drawing.Point(6, 61);
            this.rbRss2.Name = "rbRss2";
            this.rbRss2.Size = new System.Drawing.Size(135, 37);
            this.rbRss2.TabIndex = 10;
            this.rbRss2.TabStop = true;
            this.rbRss2.Text = "JomoNews";
            this.rbRss2.UseVisualStyleBackColor = true;
            this.rbRss2.CheckedChanged += new System.EventHandler(this.rbRss2_CheckedChanged);
            // 
            // rbRss3
            // 
            this.rbRss3.AutoSize = true;
            this.rbRss3.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRss3.Location = new System.Drawing.Point(6, 147);
            this.rbRss3.Name = "rbRss3";
            this.rbRss3.Size = new System.Drawing.Size(119, 37);
            this.rbRss3.TabIndex = 11;
            this.rbRss3.TabStop = true;
            this.rbRss3.Text = "Game🎮";
            this.rbRss3.UseVisualStyleBackColor = true;
            this.rbRss3.CheckedChanged += new System.EventHandler(this.rbRss3_CheckedChanged);
            // 
            // btFavorite
            // 
            this.btFavorite.Font = new System.Drawing.Font("Segoe Print", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFavorite.ForeColor = System.Drawing.Color.Gold;
            this.btFavorite.Location = new System.Drawing.Point(729, 67);
            this.btFavorite.Name = "btFavorite";
            this.btFavorite.Size = new System.Drawing.Size(127, 35);
            this.btFavorite.TabIndex = 12;
            this.btFavorite.Text = "★お気に入り★";
            this.btFavorite.UseVisualStyleBackColor = true;
            this.btFavorite.Click += new System.EventHandler(this.btFav_Click);
            // 
            // tbFavName
            // 
            this.tbFavName.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbFavName.Location = new System.Drawing.Point(462, 72);
            this.tbFavName.Name = "tbFavName";
            this.tbFavName.Size = new System.Drawing.Size(261, 26);
            this.tbFavName.TabIndex = 13;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(398, 70);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(58, 28);
            this.lbName.TabIndex = 14;
            this.lbName.Text = "Name";
            // 
            // gbRss
            // 
            this.gbRss.Controls.Add(this.rbRss4);
            this.gbRss.Controls.Add(this.rbRss1);
            this.gbRss.Controls.Add(this.rbRss2);
            this.gbRss.Controls.Add(this.rbRss3);
            this.gbRss.Location = new System.Drawing.Point(20, 474);
            this.gbRss.Name = "gbRss";
            this.gbRss.Size = new System.Drawing.Size(158, 195);
            this.gbRss.TabIndex = 18;
            this.gbRss.TabStop = false;
            this.gbRss.Text = "List";
            // 
            // cbFavName
            // 
            this.cbFavName.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbFavName.FormattingEnabled = true;
            this.cbFavName.Location = new System.Drawing.Point(184, 473);
            this.cbFavName.Name = "cbFavName";
            this.cbFavName.Size = new System.Drawing.Size(209, 29);
            this.cbFavName.TabIndex = 19;
            this.cbFavName.SelectedIndexChanged += new System.EventHandler(this.cbFavName_SelectedIndexChanged);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(184, 506);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 16);
            this.lbError.TabIndex = 20;
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.ForeColor = System.Drawing.Color.Red;
            this.btDelete.Location = new System.Drawing.Point(1179, 12);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(41, 41);
            this.btDelete.TabIndex = 21;
            this.btDelete.Text = "✕";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 678);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.cbFavName);
            this.Controls.Add(this.gbRss);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbFavName);
            this.Controls.Add(this.btFavorite);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btForward);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Controls.Add(this.tbUrl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "RssReader";
            this.gbRss.ResumeLayout(false);
            this.gbRss.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.ListBox lbRssTitle;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btForward;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.RadioButton rbRss4;
        private System.Windows.Forms.RadioButton rbRss1;
        private System.Windows.Forms.RadioButton rbRss2;
        private System.Windows.Forms.RadioButton rbRss3;
        private System.Windows.Forms.Button btFavorite;
        private System.Windows.Forms.TextBox tbFavName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.GroupBox gbRss;
        private System.Windows.Forms.ComboBox cbFavName;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Button btDelete;
    }
}

