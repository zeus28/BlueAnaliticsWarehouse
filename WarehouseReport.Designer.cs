﻿namespace BlueAnaliticsWarehouse
{
    partial class WarehouseReport
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
            button1 = new Button();
            cboWarehouse = new ComboBox();
            cboProducts = new ComboBox();
            dtFrom = new DateTimePicker();
            dtTo = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(544, 32);
            button1.Name = "button1";
            button1.Size = new Size(177, 23);
            button1.TabIndex = 0;
            button1.Text = "Get Warehouse Report";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cboWarehouse
            // 
            cboWarehouse.FormattingEnabled = true;
            cboWarehouse.Location = new Point(28, 32);
            cboWarehouse.Name = "cboWarehouse";
            cboWarehouse.Size = new Size(147, 23);
            cboWarehouse.TabIndex = 1;
            cboWarehouse.SelectionChangeCommitted += cboWarehouse_SelectionChangeCommitted;
            // 
            // cboProducts
            // 
            cboProducts.FormattingEnabled = true;
            cboProducts.Location = new Point(181, 32);
            cboProducts.Name = "cboProducts";
            cboProducts.Size = new Size(121, 23);
            cboProducts.TabIndex = 2;
            // 
            // dtFrom
            // 
            dtFrom.CustomFormat = "dd/MM/yyyy";
            dtFrom.Format = DateTimePickerFormat.Custom;
            dtFrom.Location = new Point(308, 32);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(115, 23);
            dtFrom.TabIndex = 3;
            // 
            // dtTo
            // 
            dtTo.CustomFormat = "dd/MM/yyyy";
            dtTo.Format = DateTimePickerFormat.Custom;
            dtTo.Location = new Point(429, 32);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(109, 23);
            dtTo.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 14);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 5;
            label1.Text = "Warehouse";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 14);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 6;
            label2.Text = "Product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(308, 14);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 7;
            label3.Text = "From";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(429, 14);
            label4.Name = "label4";
            label4.Size = new Size(19, 15);
            label4.TabIndex = 8;
            label4.Text = "To";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(693, 237);
            dataGridView1.TabIndex = 9;
            // 
            // WarehouseReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 316);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtTo);
            Controls.Add(dtFrom);
            Controls.Add(cboProducts);
            Controls.Add(cboWarehouse);
            Controls.Add(button1);
            Name = "WarehouseReport";
            Text = "WarehouseReport";
            FormClosing += WarehouseReport_FormClosing;
            Load += WarehouseReport_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox cboWarehouse;
        private ComboBox cboProducts;
        private DateTimePicker dtFrom;
        private DateTimePicker dtTo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
    }
}