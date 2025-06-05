namespace WinFormsApp1.Controls
{
    partial class DynamicGridControl
    {
        private System.ComponentModel.IContainer components = null;

        
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            labelRows = new Label();
            labelColumns = new Label();
            textBoxRows = new TextBox();
            textBoxColumns = new TextBox();
            dataGridView1 = new DataGridView();
            panelInputs = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelInputs.SuspendLayout();
            SuspendLayout();
            // 
            // labelRows
            // 
            labelRows.AutoSize = true;
            labelRows.Location = new Point(12, 15);
            labelRows.Name = "labelRows";
            labelRows.Size = new Size(47, 20);
            labelRows.TabIndex = 0;
            labelRows.Text = "Rows:";
            // 
            // labelColumns
            // 
            labelColumns.AutoSize = true;
            labelColumns.Location = new Point(213, 15);
            labelColumns.Name = "labelColumns";
            labelColumns.Size = new Size(69, 20);
            labelColumns.TabIndex = 1;
            labelColumns.Text = "Columns:";
            // 
            // textBoxRows
            // 
            textBoxRows.Location = new Point(63, 12);
            textBoxRows.Name = "textBoxRows";
            textBoxRows.Size = new Size(125, 27);
            textBoxRows.TabIndex = 2;
            // 
            // textBoxColumns
            // 
            textBoxColumns.Location = new Point(286, 12);
            textBoxColumns.Name = "textBoxColumns";
            textBoxColumns.Size = new Size(125, 27);
            textBoxColumns.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(829, 518);
            dataGridView1.TabIndex = 4;
            // 
            // panelInputs
            // 
            panelInputs.Controls.Add(labelRows);
            panelInputs.Controls.Add(labelColumns);
            panelInputs.Controls.Add(textBoxColumns);
            panelInputs.Controls.Add(textBoxRows);
            panelInputs.Dock = DockStyle.Top;
            panelInputs.Location = new Point(0, 0);
            panelInputs.Name = "panelInputs";
            panelInputs.Size = new Size(829, 50);
            panelInputs.TabIndex = 5;
            // 
            // DynamicGridControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panelInputs);
            Name = "DynamicGridControl";
            Size = new Size(829, 568);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelInputs.ResumeLayout(false);
            panelInputs.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelRows;
        private Label labelColumns;
        private TextBox textBoxRows;
        private TextBox textBoxColumns;
        private DataGridView dataGridView1;
        private Panel panelInputs;
    }
}