
namespace CalendarApp {
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btDayCalc = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.prevYear = new System.Windows.Forms.Button();
            this.nextYear = new System.Windows.Forms.Button();
            this.prevMonth = new System.Windows.Forms.Button();
            this.nextMonth = new System.Windows.Forms.Button();
            this.prevDay = new System.Windows.Forms.Button();
            this.nextDay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTimeNow = new System.Windows.Forms.TextBox();
            this.btAge = new System.Windows.Forms.Button();
            this.tmTimeDisp = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付：";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpDate.Location = new System.Drawing.Point(94, 30);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 31);
            this.dtpDate.TabIndex = 1;
            // 
            // btDayCalc
            // 
            this.btDayCalc.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDayCalc.Location = new System.Drawing.Point(94, 78);
            this.btDayCalc.Name = "btDayCalc";
            this.btDayCalc.Size = new System.Drawing.Size(139, 49);
            this.btDayCalc.TabIndex = 2;
            this.btDayCalc.Text = "日数計算";
            this.btDayCalc.UseVisualStyleBackColor = true;
            this.btDayCalc.Click += new System.EventHandler(this.btDayCalc_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbMessage.Location = new System.Drawing.Point(357, 47);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(448, 396);
            this.tbMessage.TabIndex = 3;
            // 
            // prevYear
            // 
            this.prevYear.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.prevYear.Location = new System.Drawing.Point(70, 230);
            this.prevYear.Name = "prevYear";
            this.prevYear.Size = new System.Drawing.Size(97, 49);
            this.prevYear.TabIndex = 4;
            this.prevYear.Text = "ー年";
            this.prevYear.UseVisualStyleBackColor = true;
            this.prevYear.Click += new System.EventHandler(this.prevYear_Click);
            // 
            // nextYear
            // 
            this.nextYear.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nextYear.Location = new System.Drawing.Point(199, 230);
            this.nextYear.Name = "nextYear";
            this.nextYear.Size = new System.Drawing.Size(95, 49);
            this.nextYear.TabIndex = 4;
            this.nextYear.Text = "＋年";
            this.nextYear.UseVisualStyleBackColor = true;
            // 
            // prevMonth
            // 
            this.prevMonth.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.prevMonth.Location = new System.Drawing.Point(70, 313);
            this.prevMonth.Name = "prevMonth";
            this.prevMonth.Size = new System.Drawing.Size(97, 49);
            this.prevMonth.TabIndex = 4;
            this.prevMonth.Text = "ー月";
            this.prevMonth.UseVisualStyleBackColor = true;
            // 
            // nextMonth
            // 
            this.nextMonth.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nextMonth.Location = new System.Drawing.Point(199, 313);
            this.nextMonth.Name = "nextMonth";
            this.nextMonth.Size = new System.Drawing.Size(95, 49);
            this.nextMonth.TabIndex = 4;
            this.nextMonth.Text = "＋月";
            this.nextMonth.UseVisualStyleBackColor = true;
            // 
            // prevDay
            // 
            this.prevDay.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.prevDay.Location = new System.Drawing.Point(70, 394);
            this.prevDay.Name = "prevDay";
            this.prevDay.Size = new System.Drawing.Size(97, 49);
            this.prevDay.TabIndex = 4;
            this.prevDay.Text = "ー日";
            this.prevDay.UseVisualStyleBackColor = true;
            // 
            // nextDay
            // 
            this.nextDay.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nextDay.Location = new System.Drawing.Point(199, 394);
            this.nextDay.Name = "nextDay";
            this.nextDay.Size = new System.Drawing.Size(95, 49);
            this.nextDay.TabIndex = 4;
            this.nextDay.Text = "＋日";
            this.nextDay.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(15, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "現在時刻：";
            // 
            // tbTimeNow
            // 
            this.tbTimeNow.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTimeNow.Location = new System.Drawing.Point(143, 478);
            this.tbTimeNow.Multiline = true;
            this.tbTimeNow.Name = "tbTimeNow";
            this.tbTimeNow.Size = new System.Drawing.Size(466, 39);
            this.tbTimeNow.TabIndex = 6;
            // 
            // btAge
            // 
            this.btAge.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAge.Location = new System.Drawing.Point(94, 143);
            this.btAge.Name = "btAge";
            this.btAge.Size = new System.Drawing.Size(139, 49);
            this.btAge.TabIndex = 7;
            this.btAge.Text = "年齢";
            this.btAge.UseVisualStyleBackColor = true;
            this.btAge.Click += new System.EventHandler(this.btAge_Click);
            // 
            // tmTimeDisp
            // 
            this.tmTimeDisp.Interval = 500;
            this.tmTimeDisp.Tick += new System.EventHandler(this.tmTimeDisp_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 522);
            this.Controls.Add(this.btAge);
            this.Controls.Add(this.tbTimeNow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nextDay);
            this.Controls.Add(this.nextMonth);
            this.Controls.Add(this.nextYear);
            this.Controls.Add(this.prevDay);
            this.Controls.Add(this.prevMonth);
            this.Controls.Add(this.prevYear);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.btDayCalc);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "カレンダーアプリ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btDayCalc;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button prevYear;
        private System.Windows.Forms.Button nextYear;
        private System.Windows.Forms.Button prevMonth;
        private System.Windows.Forms.Button nextMonth;
        private System.Windows.Forms.Button prevDay;
        private System.Windows.Forms.Button nextDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTimeNow;
        private System.Windows.Forms.Button btAge;
        private System.Windows.Forms.Timer tmTimeDisp;
    }
}

