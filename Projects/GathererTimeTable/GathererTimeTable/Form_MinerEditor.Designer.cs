using ChreneLib.Controls.TextBoxes;

namespace GathererTimeTable {
    partial class Form_MinerEditor {
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.column1DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.column2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.cTextBox_Filter = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.checkBoxToggleSet = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column1DataGridViewCheckBoxColumn,
            this.column2DataGridViewTextBoxColumn,
            this.column3DataGridViewTextBoxColumn,
            this.column4DataGridViewTextBoxColumn,
            this.column5DataGridViewTextBoxColumn,
            this.column6DataGridViewTextBoxColumn,
            this.column7DataGridViewTextBoxColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(784, 490);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // column1DataGridViewCheckBoxColumn
            // 
            this.column1DataGridViewCheckBoxColumn.DataPropertyName = "Column1";
            this.column1DataGridViewCheckBoxColumn.HeaderText = "有効/無効";
            this.column1DataGridViewCheckBoxColumn.Name = "column1DataGridViewCheckBoxColumn";
            this.column1DataGridViewCheckBoxColumn.Width = 90;
            // 
            // column2DataGridViewTextBoxColumn
            // 
            this.column2DataGridViewTextBoxColumn.DataPropertyName = "Column2";
            this.column2DataGridViewTextBoxColumn.HeaderText = "Type";
            this.column2DataGridViewTextBoxColumn.Name = "column2DataGridViewTextBoxColumn";
            this.column2DataGridViewTextBoxColumn.ReadOnly = true;
            this.column2DataGridViewTextBoxColumn.Visible = false;
            // 
            // column3DataGridViewTextBoxColumn
            // 
            this.column3DataGridViewTextBoxColumn.DataPropertyName = "Column3";
            this.column3DataGridViewTextBoxColumn.HeaderText = "採集時刻";
            this.column3DataGridViewTextBoxColumn.Name = "column3DataGridViewTextBoxColumn";
            this.column3DataGridViewTextBoxColumn.ReadOnly = true;
            this.column3DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.column3DataGridViewTextBoxColumn.Width = 95;
            // 
            // column4DataGridViewTextBoxColumn
            // 
            this.column4DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.column4DataGridViewTextBoxColumn.DataPropertyName = "Column4";
            this.column4DataGridViewTextBoxColumn.HeaderText = "採集物";
            this.column4DataGridViewTextBoxColumn.Name = "column4DataGridViewTextBoxColumn";
            this.column4DataGridViewTextBoxColumn.ReadOnly = true;
            this.column4DataGridViewTextBoxColumn.Width = 61;
            // 
            // column5DataGridViewTextBoxColumn
            // 
            this.column5DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.column5DataGridViewTextBoxColumn.DataPropertyName = "Column5";
            this.column5DataGridViewTextBoxColumn.HeaderText = "採集場所";
            this.column5DataGridViewTextBoxColumn.Name = "column5DataGridViewTextBoxColumn";
            this.column5DataGridViewTextBoxColumn.ReadOnly = true;
            this.column5DataGridViewTextBoxColumn.Width = 61;
            // 
            // column6DataGridViewTextBoxColumn
            // 
            this.column6DataGridViewTextBoxColumn.DataPropertyName = "Column6";
            this.column6DataGridViewTextBoxColumn.HeaderText = "採集段数";
            this.column6DataGridViewTextBoxColumn.Name = "column6DataGridViewTextBoxColumn";
            this.column6DataGridViewTextBoxColumn.ReadOnly = true;
            this.column6DataGridViewTextBoxColumn.Width = 80;
            // 
            // column7DataGridViewTextBoxColumn
            // 
            this.column7DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column7DataGridViewTextBoxColumn.DataPropertyName = "Column7";
            this.column7DataGridViewTextBoxColumn.HeaderText = "メモ(編集可能列)";
            this.column7DataGridViewTextBoxColumn.MaxInputLength = 54;
            this.column7DataGridViewTextBoxColumn.Name = "column7DataGridViewTextBoxColumn";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCancel.Location = new System.Drawing.Point(646, 490);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(138, 72);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonOK.Location = new System.Drawing.Point(508, 490);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(138, 72);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "Complete";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // cTextBox_Filter
            // 
            this.cTextBox_Filter.Dock = System.Windows.Forms.DockStyle.Right;
            this.cTextBox_Filter.Location = new System.Drawing.Point(0, 490);
            this.cTextBox_Filter.Name = "cTextBox_Filter";
            this.cTextBox_Filter.Size = new System.Drawing.Size(508, 19);
            this.cTextBox_Filter.TabIndex = 3;
            this.cTextBox_Filter.Visible = false;
            this.cTextBox_Filter.WaterMark = "検索フィルター";
            this.cTextBox_Filter.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.cTextBox_Filter.WaterMarkFont = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cTextBox_Filter.WaterMarkForeColor = System.Drawing.Color.DimGray;
            // 
            // checkBoxToggleSet
            // 
            this.checkBoxToggleSet.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxToggleSet.AutoSize = true;
            this.checkBoxToggleSet.Location = new System.Drawing.Point(0, 490);
            this.checkBoxToggleSet.Name = "checkBoxToggleSet";
            this.checkBoxToggleSet.Size = new System.Drawing.Size(75, 22);
            this.checkBoxToggleSet.TabIndex = 8;
            this.checkBoxToggleSet.Text = "ALL On/Off";
            this.checkBoxToggleSet.UseVisualStyleBackColor = true;
            this.checkBoxToggleSet.CheckedChanged += new System.EventHandler(this.checkBoxToggleSet_CheckedChanged);
            // 
            // Form_MinerEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.checkBoxToggleSet);
            this.Controls.Add(this.cTextBox_Filter);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_MinerEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "追加・編集";
            this.Load += new System.EventHandler(this.form_Collection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private CTextBox cTextBox_Filter;
        private System.Windows.Forms.CheckBox checkBoxToggleSet;
        private System.Windows.Forms.DataGridViewCheckBoxColumn column1DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn column2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn column3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn column4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn column5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn column6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn column7DataGridViewTextBoxColumn;
    }
}