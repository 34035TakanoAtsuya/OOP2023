
namespace Section01 {
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
            this.btRunNotepad = new System.Windows.Forms.Button();
            this.btRunAndWaitNotepad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btRunNotepad
            // 
            this.btRunNotepad.BackColor = System.Drawing.Color.Plum;
            this.btRunNotepad.Font = new System.Drawing.Font("Palace Script MT", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRunNotepad.Location = new System.Drawing.Point(12, 12);
            this.btRunNotepad.Name = "btRunNotepad";
            this.btRunNotepad.Size = new System.Drawing.Size(715, 193);
            this.btRunNotepad.TabIndex = 0;
            this.btRunNotepad.Text = "RunNotepad";
            this.btRunNotepad.UseVisualStyleBackColor = false;
            this.btRunNotepad.Click += new System.EventHandler(this.btRunNotepad_Click);
            // 
            // btRunAndWaitNotepad
            // 
            this.btRunAndWaitNotepad.BackColor = System.Drawing.Color.Aquamarine;
            this.btRunAndWaitNotepad.Font = new System.Drawing.Font("Viner Hand ITC", 45.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRunAndWaitNotepad.Location = new System.Drawing.Point(12, 211);
            this.btRunAndWaitNotepad.Name = "btRunAndWaitNotepad";
            this.btRunAndWaitNotepad.Size = new System.Drawing.Size(715, 198);
            this.btRunAndWaitNotepad.TabIndex = 1;
            this.btRunAndWaitNotepad.Text = "RunAndWaitNotepad";
            this.btRunAndWaitNotepad.UseVisualStyleBackColor = false;
            this.btRunAndWaitNotepad.Click += new System.EventHandler(this.btRunAndWaitNotepad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 421);
            this.Controls.Add(this.btRunAndWaitNotepad);
            this.Controls.Add(this.btRunNotepad);
            this.Name = "Form1";
            this.Text = "14章1節";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRunNotepad;
        private System.Windows.Forms.Button btRunAndWaitNotepad;
    }
}

