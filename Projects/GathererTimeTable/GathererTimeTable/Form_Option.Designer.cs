namespace GathererTimetable {
    partial class Form_Option {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton_SonndType3 = new System.Windows.Forms.RadioButton();
            this.radioButton_SoundType2 = new System.Windows.Forms.RadioButton();
            this.radioButton_SonndType1 = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.radioButton_TwoDelay = new System.Windows.Forms.RadioButton();
            this.radioButton_OneDelay = new System.Windows.Forms.RadioButton();
            this.radioButton_NoDelay = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(284, 111);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.radioButton_SonndType3);
            this.tabPage1.Controls.Add(this.radioButton_SoundType2);
            this.tabPage1.Controls.Add(this.radioButton_SonndType1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(276, 85);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "アラーム";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 19);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "参照";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonFileReference_Click);
            // 
            // radioButton_SonndType3
            // 
            this.radioButton_SonndType3.AutoSize = true;
            this.radioButton_SonndType3.Location = new System.Drawing.Point(8, 50);
            this.radioButton_SonndType3.Name = "radioButton_SonndType3";
            this.radioButton_SonndType3.Size = new System.Drawing.Size(87, 16);
            this.radioButton_SonndType3.TabIndex = 2;
            this.radioButton_SonndType3.Text = "ユーザー設定";
            this.radioButton_SonndType3.UseVisualStyleBackColor = true;
            this.radioButton_SonndType3.CheckedChanged += new System.EventHandler(this.radioButtonTab1_CheckedChanged);
            // 
            // radioButton_SoundType2
            // 
            this.radioButton_SoundType2.AutoSize = true;
            this.radioButton_SoundType2.Location = new System.Drawing.Point(8, 28);
            this.radioButton_SoundType2.Name = "radioButton_SoundType2";
            this.radioButton_SoundType2.Size = new System.Drawing.Size(133, 16);
            this.radioButton_SoundType2.TabIndex = 1;
            this.radioButton_SoundType2.Text = "既定のアラームを鳴らす";
            this.radioButton_SoundType2.UseVisualStyleBackColor = true;
            this.radioButton_SoundType2.CheckedChanged += new System.EventHandler(this.radioButtonTab1_CheckedChanged);
            // 
            // radioButton_SonndType1
            // 
            this.radioButton_SonndType1.AutoSize = true;
            this.radioButton_SonndType1.Checked = true;
            this.radioButton_SonndType1.Location = new System.Drawing.Point(8, 6);
            this.radioButton_SonndType1.Name = "radioButton_SonndType1";
            this.radioButton_SonndType1.Size = new System.Drawing.Size(56, 16);
            this.radioButton_SonndType1.TabIndex = 0;
            this.radioButton_SonndType1.TabStop = true;
            this.radioButton_SonndType1.Text = "ミュート";
            this.radioButton_SonndType1.UseVisualStyleBackColor = true;
            this.radioButton_SonndType1.CheckedChanged += new System.EventHandler(this.radioButtonTab1_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.radioButton_TwoDelay);
            this.tabPage2.Controls.Add(this.radioButton_OneDelay);
            this.tabPage2.Controls.Add(this.radioButton_NoDelay);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(276, 85);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "アラーム予約";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // radioButton_TwoDelay
            // 
            this.radioButton_TwoDelay.AutoSize = true;
            this.radioButton_TwoDelay.Location = new System.Drawing.Point(8, 50);
            this.radioButton_TwoDelay.Name = "radioButton_TwoDelay";
            this.radioButton_TwoDelay.Size = new System.Drawing.Size(136, 16);
            this.radioButton_TwoDelay.TabIndex = 5;
            this.radioButton_TwoDelay.Text = "リアル時間3分前に通知";
            this.radioButton_TwoDelay.UseVisualStyleBackColor = true;
            this.radioButton_TwoDelay.CheckedChanged += new System.EventHandler(this.radioButtonTab2_CheckedChanged);
            // 
            // radioButton_OneDelay
            // 
            this.radioButton_OneDelay.AutoSize = true;
            this.radioButton_OneDelay.Location = new System.Drawing.Point(8, 28);
            this.radioButton_OneDelay.Name = "radioButton_OneDelay";
            this.radioButton_OneDelay.Size = new System.Drawing.Size(136, 16);
            this.radioButton_OneDelay.TabIndex = 4;
            this.radioButton_OneDelay.Text = "リアル時間1分前に通知";
            this.radioButton_OneDelay.UseVisualStyleBackColor = true;
            this.radioButton_OneDelay.CheckedChanged += new System.EventHandler(this.radioButtonTab2_CheckedChanged);
            // 
            // radioButton_NoDelay
            // 
            this.radioButton_NoDelay.AutoSize = true;
            this.radioButton_NoDelay.Checked = true;
            this.radioButton_NoDelay.Location = new System.Drawing.Point(8, 6);
            this.radioButton_NoDelay.Name = "radioButton_NoDelay";
            this.radioButton_NoDelay.Size = new System.Drawing.Size(42, 16);
            this.radioButton_NoDelay.TabIndex = 3;
            this.radioButton_NoDelay.TabStop = true;
            this.radioButton_NoDelay.Text = "なし";
            this.radioButton_NoDelay.UseVisualStyleBackColor = true;
            this.radioButton_NoDelay.CheckedChanged += new System.EventHandler(this.radioButtonTab2_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(276, 85);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "苦情";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "いまはこれが限界です～((☛(◜◔。◔◝)☚))\r\n\r\n\r\n\r\n\r\n＠shinkai_ch";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(209, 108);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 37);
            this.button3.TabIndex = 5;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // Form_Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 146);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Option";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "設定";
            this.Load += new System.EventHandler(this.form_Option_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton radioButton_SonndType3;
        private System.Windows.Forms.RadioButton radioButton_SoundType2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioButton_SonndType1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton radioButton_TwoDelay;
        private System.Windows.Forms.RadioButton radioButton_OneDelay;
        private System.Windows.Forms.RadioButton radioButton_NoDelay;
    }
}