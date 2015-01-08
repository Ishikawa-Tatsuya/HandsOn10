namespace FormsTarget
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this._buttonMessageBox = new System.Windows.Forms.Button();
            this._buttonFolder = new System.Windows.Forms.Button();
            this._buttonFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _buttonMessageBox
            // 
            this._buttonMessageBox.Location = new System.Drawing.Point(12, 12);
            this._buttonMessageBox.Name = "_buttonMessageBox";
            this._buttonMessageBox.Size = new System.Drawing.Size(200, 23);
            this._buttonMessageBox.TabIndex = 0;
            this._buttonMessageBox.Text = "MessageBox";
            this._buttonMessageBox.UseVisualStyleBackColor = true;
            this._buttonMessageBox.Click += new System.EventHandler(this.ButtonMessageBoxClick);
            // 
            // _buttonFolder
            // 
            this._buttonFolder.Location = new System.Drawing.Point(13, 70);
            this._buttonFolder.Name = "_buttonFolder";
            this._buttonFolder.Size = new System.Drawing.Size(199, 23);
            this._buttonFolder.TabIndex = 1;
            this._buttonFolder.Text = "FolderBrowserDialog";
            this._buttonFolder.UseVisualStyleBackColor = true;
            this._buttonFolder.Click += new System.EventHandler(this.ButtonFolderClick);
            // 
            // _buttonFile
            // 
            this._buttonFile.Location = new System.Drawing.Point(13, 41);
            this._buttonFile.Name = "_buttonFile";
            this._buttonFile.Size = new System.Drawing.Size(199, 23);
            this._buttonFile.TabIndex = 2;
            this._buttonFile.Text = "OpenFileDialog";
            this._buttonFile.UseVisualStyleBackColor = true;
            this._buttonFile.Click += new System.EventHandler(this.ButtonFileClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 108);
            this.Controls.Add(this._buttonFile);
            this.Controls.Add(this._buttonFolder);
            this.Controls.Add(this._buttonMessageBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _buttonMessageBox;
        private System.Windows.Forms.Button _buttonFolder;
        private System.Windows.Forms.Button _buttonFile;
    }
}

