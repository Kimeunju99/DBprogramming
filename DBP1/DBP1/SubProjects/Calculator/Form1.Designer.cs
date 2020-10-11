namespace Calculator
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
            this.groupBoxComboCalc = new System.Windows.Forms.GroupBox();
            this.textBoxComboCalc_3 = new System.Windows.Forms.TextBox();
            this.buttonComboBoxCalculator = new System.Windows.Forms.Button();
            this.textBoxComboCalc_2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxComboCalc_1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_RC = new System.Windows.Forms.Button();
            this.textBox_RC2 = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox_RC1 = new System.Windows.Forms.TextBox();
            this.textBox_RC3 = new System.Windows.Forms.TextBox();
            this.groupBoxComboCalc.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxComboCalc
            // 
            this.groupBoxComboCalc.Controls.Add(this.textBoxComboCalc_3);
            this.groupBoxComboCalc.Controls.Add(this.buttonComboBoxCalculator);
            this.groupBoxComboCalc.Controls.Add(this.textBoxComboCalc_2);
            this.groupBoxComboCalc.Controls.Add(this.comboBox1);
            this.groupBoxComboCalc.Controls.Add(this.textBoxComboCalc_1);
            this.groupBoxComboCalc.Controls.Add(this.label4);
            this.groupBoxComboCalc.Controls.Add(this.label3);
            this.groupBoxComboCalc.Controls.Add(this.label2);
            this.groupBoxComboCalc.Controls.Add(this.label1);
            this.groupBoxComboCalc.Location = new System.Drawing.Point(12, 27);
            this.groupBoxComboCalc.Name = "groupBoxComboCalc";
            this.groupBoxComboCalc.Size = new System.Drawing.Size(695, 184);
            this.groupBoxComboCalc.TabIndex = 0;
            this.groupBoxComboCalc.TabStop = false;
            this.groupBoxComboCalc.Text = "Combobox Calculator";
            // 
            // textBoxComboCalc_3
            // 
            this.textBoxComboCalc_3.Location = new System.Drawing.Point(535, 65);
            this.textBoxComboCalc_3.Name = "textBoxComboCalc_3";
            this.textBoxComboCalc_3.Size = new System.Drawing.Size(134, 25);
            this.textBoxComboCalc_3.TabIndex = 8;
            // 
            // buttonComboBoxCalculator
            // 
            this.buttonComboBoxCalculator.Location = new System.Drawing.Point(426, 65);
            this.buttonComboBoxCalculator.Name = "buttonComboBoxCalculator";
            this.buttonComboBoxCalculator.Size = new System.Drawing.Size(89, 25);
            this.buttonComboBoxCalculator.TabIndex = 7;
            this.buttonComboBoxCalculator.Text = "Calculate";
            this.buttonComboBoxCalculator.UseVisualStyleBackColor = true;
            this.buttonComboBoxCalculator.Click += new System.EventHandler(this.buttonComboBoxCalculator_Click);
            // 
            // textBoxComboCalc_2
            // 
            this.textBoxComboCalc_2.Location = new System.Drawing.Point(290, 65);
            this.textBoxComboCalc_2.Name = "textBoxComboCalc_2";
            this.textBoxComboCalc_2.Size = new System.Drawing.Size(100, 25);
            this.textBoxComboCalc_2.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(138, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxComboCalc_1
            // 
            this.textBoxComboCalc_1.Location = new System.Drawing.Point(17, 65);
            this.textBoxComboCalc_1.Name = "textBoxComboCalc_1";
            this.textBoxComboCalc_1.Size = new System.Drawing.Size(100, 25);
            this.textBoxComboCalc_1.TabIndex = 4;
            this.textBoxComboCalc_1.TextChanged += new System.EventHandler(this.textBoxComboCalc_1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(579, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Result";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Operand 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operator";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operand 1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_RC3);
            this.groupBox1.Controls.Add(this.button_RC);
            this.groupBox1.Controls.Add(this.textBox_RC2);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.textBox_RC1);
            this.groupBox1.Location = new System.Drawing.Point(12, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 108);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Radio button Calculator";
            // 
            // button_RC
            // 
            this.button_RC.Location = new System.Drawing.Point(426, 40);
            this.button_RC.Name = "button_RC";
            this.button_RC.Size = new System.Drawing.Size(89, 25);
            this.button_RC.TabIndex = 4;
            this.button_RC.Text = "Calculate";
            this.button_RC.UseVisualStyleBackColor = true;
            this.button_RC.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_RC2
            // 
            this.textBox_RC2.Location = new System.Drawing.Point(258, 39);
            this.textBox_RC2.Name = "textBox_RC2";
            this.textBox_RC2.Size = new System.Drawing.Size(132, 25);
            this.textBox_RC2.TabIndex = 3;
            this.textBox_RC2.TextChanged += new System.EventHandler(this.textBox_RC2_TextChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(156, 65);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(36, 19);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "-";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(156, 40);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(36, 19);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "+";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // textBox_RC1
            // 
            this.textBox_RC1.Location = new System.Drawing.Point(17, 39);
            this.textBox_RC1.Name = "textBox_RC1";
            this.textBox_RC1.Size = new System.Drawing.Size(100, 25);
            this.textBox_RC1.TabIndex = 0;
            this.textBox_RC1.TextChanged += new System.EventHandler(this.textBox_RC1_TextChanged);
            // 
            // textBox_RC3
            // 
            this.textBox_RC3.Location = new System.Drawing.Point(535, 40);
            this.textBox_RC3.Name = "textBox_RC3";
            this.textBox_RC3.Size = new System.Drawing.Size(134, 25);
            this.textBox_RC3.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 358);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxComboCalc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxComboCalc.ResumeLayout(false);
            this.groupBoxComboCalc.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxComboCalc;
        private System.Windows.Forms.Button buttonComboBoxCalculator;
        private System.Windows.Forms.TextBox textBoxComboCalc_2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxComboCalc_1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxComboCalc_3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_RC;
        private System.Windows.Forms.TextBox textBox_RC2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox_RC1;
        private System.Windows.Forms.TextBox textBox_RC3;
    }
}

