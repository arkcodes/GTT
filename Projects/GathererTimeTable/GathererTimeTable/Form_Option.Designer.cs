namespace GathererTimeTable {
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
            this._radioButton_SonndType3 = new System.Windows.Forms.RadioButton();
            this._radioButton_SoundType2 = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this._radioButton_SoundType1 = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(284, 215);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this._radioButton_SonndType3);
            this.tabPage1.Controls.Add(this._radioButton_SoundType2);
            this.tabPage1.Controls.Add(this._radioButton_SoundType1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(276, 189);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
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
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonFileReference_Click);
            // 
            // _radioButton_SonndType3
            // 
            this._radioButton_SonndType3.AutoSize = true;
            this._radioButton_SonndType3.Location = new System.Drawing.Point(8, 50);
            this._radioButton_SonndType3.Name = "_radioButton_SonndType3";
            this._radioButton_SonndType3.Size = new System.Drawing.Size(88, 16);
            this._radioButton_SonndType3.TabIndex = 2;
            this._radioButton_SonndType3.TabStop = true;
            this._radioButton_SonndType3.Text = "radioButton3";
            this._radioButton_SonndType3.UseVisualStyleBackColor = true;
            this._radioButton_SonndType3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // _radioButton_SoundType2
            // 
            this._radioButton_SoundType2.AutoSize = true;
            this._radioButton_SoundType2.Location = new System.Drawing.Point(8, 28);
            this._radioButton_SoundType2.Name = "_radioButton_SoundType2";
            this._radioButton_SoundType2.Size = new System.Drawing.Size(88, 16);
            this._radioButton_SoundType2.TabIndex = 1;
            this._radioButton_SoundType2.TabStop = true;
            this._radioButton_SoundType2.Text = "radioButton2";
            this._radioButton_SoundType2.UseVisualStyleBackColor = true;
            this._radioButton_SoundType2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(276, 189);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Location = new System.Drawing.Point(134, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.Location = new System.Drawing.Point(209, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 37);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // _radioButton_SoundType1
            // 
            this._radioButton_SoundType1.AutoSize = true;
            this._radioButton_SoundType1.Location = new System.Drawing.Point(8, 6);
            this._radioButton_SoundType1.Name = "_radioButton_SoundType1";
            this._radioButton_SoundType1.Size = new System.Drawing.Size(80, 16);
            this._radioButton_SoundType1.TabIndex = 0;
            this._radioButton_SoundType1.TabStop = true;
            this._radioButton_SoundType1.Text = "ミュート設定";
            this._radioButton_SoundType1.UseVisualStyleBackColor = true;
            this._radioButton_SoundType1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // Form_Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 252);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form_Option";
            this.Text = "Form_Option";
            this.Load += new System.EventHandler(this.Frm_Option_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton _radioButton_SonndType3;
        private System.Windows.Forms.RadioButton _radioButton_SoundType2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton _radioButton_SoundType1;
    }
}