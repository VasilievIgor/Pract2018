namespace PerimetnPract2018
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.coordsTable = new System.Windows.Forms.DataGridView();
            this.lengthTable = new System.Windows.Forms.DataGridView();
            this.numLCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.NumericUpDown();
            this.numLabel = new System.Windows.Forms.Label();
            this.PerLabel = new System.Windows.Forms.Label();
            this.perRes = new System.Windows.Forms.TextBox();
            this.randomBtn = new System.Windows.Forms.Button();
            this.calkBtn = new System.Windows.Forms.Button();
            this.numCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.coordsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number)).BeginInit();
            this.SuspendLayout();
            // 
            // coordsTable
            // 
            this.coordsTable.AllowUserToAddRows = false;
            this.coordsTable.AllowUserToDeleteRows = false;
            this.coordsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coordsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numCol,
            this.xCol,
            this.yCol});
            this.coordsTable.Location = new System.Drawing.Point(12, 12);
            this.coordsTable.Name = "coordsTable";
            this.coordsTable.RowHeadersVisible = false;
            this.coordsTable.ShowEditingIcon = false;
            this.coordsTable.Size = new System.Drawing.Size(129, 323);
            this.coordsTable.TabIndex = 0;
            // 
            // lengthTable
            // 
            this.lengthTable.AllowUserToAddRows = false;
            this.lengthTable.AllowUserToDeleteRows = false;
            this.lengthTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lengthTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numLCol,
            this.lengthCol});
            this.lengthTable.Location = new System.Drawing.Point(147, 12);
            this.lengthTable.Name = "lengthTable";
            this.lengthTable.ReadOnly = true;
            this.lengthTable.RowHeadersVisible = false;
            this.lengthTable.ShowEditingIcon = false;
            this.lengthTable.Size = new System.Drawing.Size(80, 323);
            this.lengthTable.TabIndex = 1;
            // 
            // numLCol
            // 
            this.numLCol.Frozen = true;
            this.numLCol.HeaderText = "N";
            this.numLCol.Name = "numLCol";
            this.numLCol.ReadOnly = true;
            this.numLCol.Width = 25;
            // 
            // lengthCol
            // 
            this.lengthCol.Frozen = true;
            this.lengthCol.HeaderText = "Length";
            this.lengthCol.Name = "lengthCol";
            this.lengthCol.ReadOnly = true;
            this.lengthCol.Width = 50;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(12, 362);
            this.number.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.number.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(90, 20);
            this.number.TabIndex = 2;
            this.number.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.number.ValueChanged += new System.EventHandler(this.number_ValueChanged);
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Location = new System.Drawing.Point(12, 343);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(90, 13);
            this.numLabel.TabIndex = 3;
            this.numLabel.Text = "Number of points:";
            // 
            // PerLabel
            // 
            this.PerLabel.AutoSize = true;
            this.PerLabel.Location = new System.Drawing.Point(12, 389);
            this.PerLabel.Name = "PerLabel";
            this.PerLabel.Size = new System.Drawing.Size(48, 13);
            this.PerLabel.TabIndex = 4;
            this.PerLabel.Text = "Perimetr:";
            // 
            // perRes
            // 
            this.perRes.Location = new System.Drawing.Point(12, 405);
            this.perRes.Name = "perRes";
            this.perRes.ReadOnly = true;
            this.perRes.Size = new System.Drawing.Size(90, 20);
            this.perRes.TabIndex = 5;
            // 
            // randomBtn
            // 
            this.randomBtn.Location = new System.Drawing.Point(108, 359);
            this.randomBtn.Name = "randomBtn";
            this.randomBtn.Size = new System.Drawing.Size(119, 23);
            this.randomBtn.TabIndex = 6;
            this.randomBtn.Text = "Random fill";
            this.randomBtn.UseVisualStyleBackColor = true;
            this.randomBtn.Click += new System.EventHandler(this.randomBtn_Click);
            // 
            // calkBtn
            // 
            this.calkBtn.Location = new System.Drawing.Point(108, 404);
            this.calkBtn.Name = "calkBtn";
            this.calkBtn.Size = new System.Drawing.Size(119, 23);
            this.calkBtn.TabIndex = 7;
            this.calkBtn.Text = "Find perimetr";
            this.calkBtn.UseVisualStyleBackColor = true;
            this.calkBtn.Click += new System.EventHandler(this.calkBtn_Click);
            // 
            // numCol
            // 
            this.numCol.Frozen = true;
            this.numCol.HeaderText = "N";
            this.numCol.Name = "numCol";
            this.numCol.ReadOnly = true;
            this.numCol.Width = 25;
            // 
            // xCol
            // 
            this.xCol.Frozen = true;
            this.xCol.HeaderText = "X";
            this.xCol.Name = "xCol";
            this.xCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.xCol.Width = 50;
            // 
            // yCol
            // 
            this.yCol.Frozen = true;
            this.yCol.HeaderText = "Y";
            this.yCol.Name = "yCol";
            this.yCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.yCol.Width = 50;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 445);
            this.Controls.Add(this.calkBtn);
            this.Controls.Add(this.randomBtn);
            this.Controls.Add(this.perRes);
            this.Controls.Add(this.PerLabel);
            this.Controls.Add(this.numLabel);
            this.Controls.Add(this.number);
            this.Controls.Add(this.lengthTable);
            this.Controls.Add(this.coordsTable);
            this.Name = "MainForm";
            this.Text = "Polygon perimetr Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.coordsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView coordsTable;
        private System.Windows.Forms.DataGridView lengthTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn numLCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthCol;
        private System.Windows.Forms.NumericUpDown number;
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.Label PerLabel;
        private System.Windows.Forms.TextBox perRes;
        private System.Windows.Forms.Button randomBtn;
        private System.Windows.Forms.Button calkBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn yCol;
    }
}

