namespace BlueAnaliticsWarehouse
{
    partial class Profitability
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                //components.Dispose();
            }
            //base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtFrom = new DateTimePicker();
            dtTo = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            cboWarehouse = new ComboBox();
            cboProducts = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            ProfitabilityReport = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dtFrom
            // 
            dtFrom.CustomFormat = "dd/MM/yyyy";
            dtFrom.Format = DateTimePickerFormat.Custom;
            dtFrom.Location = new Point(28, 37);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(101, 23);
            dtFrom.TabIndex = 0;
            // 
            // dtTo
            // 
            dtTo.CustomFormat = "dd/MM/yyyy";
            dtTo.Format = DateTimePickerFormat.Custom;
            dtTo.Location = new Point(135, 37);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(99, 23);
            dtTo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 19);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 2;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 19);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 3;
            label2.Text = "To";
            // 
            // cboWarehouse
            // 
            cboWarehouse.FormattingEnabled = true;
            cboWarehouse.Location = new Point(240, 37);
            cboWarehouse.Name = "cboWarehouse";
            cboWarehouse.Size = new Size(139, 23);
            cboWarehouse.TabIndex = 4;
            cboWarehouse.SelectionChangeCommitted += cboWarehouse_SelectionChangeCommitted;
            // 
            // cboProducts
            // 
            cboProducts.Enabled = false;
            cboProducts.FormattingEnabled = true;
            cboProducts.Location = new Point(385, 37);
            cboProducts.Name = "cboProducts";
            cboProducts.Size = new Size(159, 23);
            cboProducts.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(240, 19);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 6;
            label3.Text = "Warehouse";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(385, 19);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 7;
            label4.Text = "Product";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(735, 260);
            dataGridView1.TabIndex = 8;
            // 
            // ProfitabilityReport
            // 
            ProfitabilityReport.Location = new Point(550, 37);
            ProfitabilityReport.Name = "ProfitabilityReport";
            ProfitabilityReport.Size = new Size(213, 23);
            ProfitabilityReport.TabIndex = 9;
            ProfitabilityReport.Text = "Get Profitability Report Data";
            ProfitabilityReport.UseVisualStyleBackColor = true;
            ProfitabilityReport.Click += ProfitabilityReport_Click;
            // 
            // Profitability
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 344);
            Controls.Add(ProfitabilityReport);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cboProducts);
            Controls.Add(cboWarehouse);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtTo);
            Controls.Add(dtFrom);
            MaximizeBox = false;
            MaximumSize = new Size(793, 383);
            MinimizeBox = false;
            MinimumSize = new Size(793, 383);
            Name = "Profitability";
            Text = "Profitability";
            FormClosing += Profitability_FormClosing;
            Load += Profitability_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtFrom;
        private DateTimePicker dtTo;
        private Label label1;
        private Label label2;
        private ComboBox cboWarehouse;
        private ComboBox cboProducts;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private Button ProfitabilityReport;
    }
}