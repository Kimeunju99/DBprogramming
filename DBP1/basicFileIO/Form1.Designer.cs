﻿namespace basicFileIO
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBinaryWrite = new System.Windows.Forms.Button();
            this.buttonBinaryRead = new System.Windows.Forms.Button();
            this.buttonStreamWriter = new System.Windows.Forms.Button();
            this.buttonStreamReader = new System.Windows.Forms.Button();
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonBinaryWrite
            // 
            this.buttonBinaryWrite.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.buttonBinaryWrite.Location = new System.Drawing.Point(43, 38);
            this.buttonBinaryWrite.Name = "buttonBinaryWrite";
            this.buttonBinaryWrite.Size = new System.Drawing.Size(199, 52);
            this.buttonBinaryWrite.TabIndex = 0;
            this.buttonBinaryWrite.Text = "BinaryWriter";
            this.buttonBinaryWrite.UseVisualStyleBackColor = true;
            this.buttonBinaryWrite.Click += new System.EventHandler(this.buttonFileStreamWrite_Click);
            // 
            // buttonBinaryRead
            // 
            this.buttonBinaryRead.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.buttonBinaryRead.Location = new System.Drawing.Point(276, 38);
            this.buttonBinaryRead.Name = "buttonBinaryRead";
            this.buttonBinaryRead.Size = new System.Drawing.Size(199, 52);
            this.buttonBinaryRead.TabIndex = 0;
            this.buttonBinaryRead.Text = "BinaryReader";
            this.buttonBinaryRead.UseVisualStyleBackColor = true;
            this.buttonBinaryRead.Click += new System.EventHandler(this.buttonBinaryRead_Click);
            // 
            // buttonStreamWriter
            // 
            this.buttonStreamWriter.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.buttonStreamWriter.Location = new System.Drawing.Point(43, 134);
            this.buttonStreamWriter.Name = "buttonStreamWriter";
            this.buttonStreamWriter.Size = new System.Drawing.Size(199, 52);
            this.buttonStreamWriter.TabIndex = 1;
            this.buttonStreamWriter.Text = "StreamWriter";
            this.buttonStreamWriter.UseVisualStyleBackColor = true;
            this.buttonStreamWriter.Click += new System.EventHandler(this.buttonStreamWriter_Click);
            // 
            // buttonStreamReader
            // 
            this.buttonStreamReader.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.buttonStreamReader.Location = new System.Drawing.Point(276, 134);
            this.buttonStreamReader.Name = "buttonStreamReader";
            this.buttonStreamReader.Size = new System.Drawing.Size(199, 52);
            this.buttonStreamReader.TabIndex = 2;
            this.buttonStreamReader.Text = "StreamReader";
            this.buttonStreamReader.UseVisualStyleBackColor = true;
            this.buttonStreamReader.Click += new System.EventHandler(this.buttonStreamReader_Click);
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Location = new System.Drawing.Point(43, 213);
            this.textBoxDisplay.Multiline = true;
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(432, 198);
            this.textBoxDisplay.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 454);
            this.Controls.Add(this.textBoxDisplay);
            this.Controls.Add(this.buttonStreamReader);
            this.Controls.Add(this.buttonStreamWriter);
            this.Controls.Add(this.buttonBinaryRead);
            this.Controls.Add(this.buttonBinaryWrite);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBinaryWrite;
        private System.Windows.Forms.Button buttonBinaryRead;
        private System.Windows.Forms.Button buttonStreamWriter;
        private System.Windows.Forms.Button buttonStreamReader;
        private System.Windows.Forms.TextBox textBoxDisplay;
    }
}

