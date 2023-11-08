
namespace RssReader {
    partial class btFavorite {
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
            this.button1 = new System.Windows.Forms.Button();
            this.rbRss4 = new System.Windows.Forms.RadioButton();
            this.rbRss1 = new System.Windows.Forms.RadioButton();
            this.rbRss2 = new System.Windows.Forms.RadioButton();
            this.rbRss3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUrl.Location = new System.Drawing.Point(12, 8);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(1110, 41);
            this.tbUrl.TabIndex = 0;
            // 
            // btGet
            // 
            this.btGet.BackColor = System.Drawing.Color.Pink;
            this.btGet.ForeColor = System.Drawing.Color.Black;
            this.btGet.Location = new System.Drawing.Point(1128, 6);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(127, 35);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = false;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.BackColor = System.Drawing.Color.Black;
            this.lbRssTitle.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRssTitle.ForeColor = System.Drawing.Color.Aqua;
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 28;
            this.lbRssTitle.Location = new System.Drawing.Point(12, 47);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(1243, 116);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.SelectedIndexChanged += new System.EventHandler(this.lbRssTitle_SelectedIndexChanged);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(12, 208);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(1110, 615);
            this.wbBrowser.TabIndex = 3;
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btBack.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btBack.Location = new System.Drawing.Point(12, 169);
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
            this.btForward.Location = new System.Drawing.Point(59, 169);
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
            this.btRefresh.Location = new System.Drawing.Point(104, 169);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(38, 33);
            this.btRefresh.TabIndex = 6;
            this.btRefresh.Text = "§";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.ForeColor = System.Drawing.Color.Gold;
            this.button1.Location = new System.Drawing.Point(1125, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "★お気に入り★";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // rbRss4
            // 
            this.rbRss4.AutoSize = true;
            this.rbRss4.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRss4.Location = new System.Drawing.Point(1125, 418);
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
            this.rbRss1.Location = new System.Drawing.Point(1125, 289);
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
            this.rbRss2.Location = new System.Drawing.Point(1125, 332);
            this.rbRss2.Name = "rbRss2";
            this.rbRss2.Size = new System.Drawing.Size(142, 37);
            this.rbRss2.TabIndex = 10;
            this.rbRss2.TabStop = true;
            this.rbRss2.Text = "JomoMedia";
            this.rbRss2.UseVisualStyleBackColor = true;
            this.rbRss2.CheckedChanged += new System.EventHandler(this.rbRss2_CheckedChanged);
            // 
            // rbRss3
            // 
            this.rbRss3.AutoSize = true;
            this.rbRss3.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRss3.Location = new System.Drawing.Point(1125, 375);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 835);
            this.Controls.Add(this.rbRss3);
            this.Controls.Add(this.rbRss2);
            this.Controls.Add(this.rbRss1);
            this.Controls.Add(this.rbRss4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btForward);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Controls.Add(this.tbUrl);
            this.Name = "btFavorite";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbRss4;
        private System.Windows.Forms.RadioButton rbRss1;
        private System.Windows.Forms.RadioButton rbRss2;
        private System.Windows.Forms.RadioButton rbRss3;
    }
}

