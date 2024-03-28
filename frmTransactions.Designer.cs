using BlueAnaliticsWarehouse.Model.DTOs;
using System.Windows.Forms;

namespace BlueAnaliticsWarehouse
{
    partial class frmTransactions
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
            components = new System.ComponentModel.Container();
            cboWareHouse = new ComboBox();
            dataGridView1 = new DataGridView();
            transactionDTOBindingSource = new BindingSource(components);
            cboProducts = new ComboBox();
            nfQty = new NumericUpDown();
            btnAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            dfTransDate = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            cboInout = new ComboBox();
            label5 = new Label();
            button2 = new Button();
            errorProvider1 = new ErrorProvider(components);
            statusStrip1 = new StatusStrip();
            ttCurrentStockLevel = new ToolStripStatusLabel();
            cboCustomer = new ComboBox();
            label6 = new Label();
            btnMovingAvg = new Button();
            warehouseNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            transdateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transtypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            customerFriendlyNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            warprodidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nfQty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // cboWareHouse
            // 
            cboWareHouse.DropDownStyle = ComboBoxStyle.DropDownList;
            cboWareHouse.FormattingEnabled = true;
            cboWareHouse.Location = new Point(12, 49);
            cboWareHouse.Name = "cboWareHouse";
            cboWareHouse.Size = new Size(145, 23);
            cboWareHouse.TabIndex = 1;
            cboWareHouse.SelectedIndexChanged += cboWareHouse_SelectedIndexChanged;
            cboWareHouse.SelectionChangeCommitted += cboWareHouse_SelectionChangeCommitted;
            cboWareHouse.Validating += cboWareHouse_Validating;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { warehouseNameDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, UnitPrice, transdateDataGridViewTextBoxColumn, transtypeDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, Total, customerFriendlyNameDataGridViewTextBoxColumn, warprodidDataGridViewTextBoxColumn, userIdDataGridViewTextBoxColumn, customerIdDataGridViewTextBoxColumn });
            dataGridView1.DataSource = transactionDTOBindingSource;
            dataGridView1.Location = new Point(12, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(828, 286);
            dataGridView1.TabIndex = 0;
            // 
            // transactionDTOBindingSource
            // 
            transactionDTOBindingSource.DataSource = typeof(TransactionDTO);
            // 
            // cboProducts
            // 
            cboProducts.CausesValidation = false;
            cboProducts.Enabled = false;
            cboProducts.FormattingEnabled = true;
            cboProducts.Location = new Point(163, 49);
            cboProducts.Name = "cboProducts";
            cboProducts.Size = new Size(162, 23);
            cboProducts.TabIndex = 2;
            cboProducts.SelectionChangeCommitted += cboProducts_SelectionChangeCommitted;
            cboProducts.Validating += cboProducts_Validating;
            // 
            // nfQty
            // 
            nfQty.Location = new Point(532, 50);
            nfQty.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nfQty.Name = "nfQty";
            nfQty.Size = new Size(87, 23);
            nfQty.TabIndex = 4;
            nfQty.Validating += nfQty_Validating;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(765, 50);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 33);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 6;
            label1.Text = "Warehouse";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 33);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 7;
            label2.Text = "Product";
            // 
            // dfTransDate
            // 
            dfTransDate.Format = DateTimePickerFormat.Custom;
            dfTransDate.Location = new Point(331, 49);
            dfTransDate.Name = "dfTransDate";
            dfTransDate.Size = new Size(110, 23);
            dfTransDate.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(331, 33);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 9;
            label3.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(447, 33);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 10;
            label4.Text = "In/Out";
            // 
            // cboInout
            // 
            cboInout.FormattingEnabled = true;
            cboInout.Location = new Point(447, 49);
            cboInout.Name = "cboInout";
            cboInout.Size = new Size(79, 23);
            cboInout.TabIndex = 11;
            cboInout.Validating += cboInout_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(532, 32);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 12;
            label5.Text = "Quantity";
            // 
            // button2
            // 
            button2.Location = new Point(733, 367);
            button2.Name = "button2";
            button2.Size = new Size(107, 23);
            button2.TabIndex = 13;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_ClickAsync;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { ttCurrentStockLevel });
            statusStrip1.Location = new Point(0, 396);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(844, 22);
            statusStrip1.TabIndex = 14;
            statusStrip1.Text = "statusStrip1";
            // 
            // ttCurrentStockLevel
            // 
            ttCurrentStockLevel.Name = "ttCurrentStockLevel";
            ttCurrentStockLevel.Size = new Size(0, 17);
            // 
            // cboCustomer
            // 
            cboCustomer.FormattingEnabled = true;
            cboCustomer.Location = new Point(625, 49);
            cboCustomer.Name = "cboCustomer";
            cboCustomer.Size = new Size(134, 23);
            cboCustomer.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(625, 31);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 16;
            label6.Text = "Contact";
            // 
            // btnMovingAvg
            // 
            btnMovingAvg.Location = new Point(15, 367);
            btnMovingAvg.Name = "btnMovingAvg";
            btnMovingAvg.Size = new Size(200, 23);
            btnMovingAvg.TabIndex = 17;
            btnMovingAvg.Text = "View Moving Average";
            btnMovingAvg.UseVisualStyleBackColor = true;
            btnMovingAvg.Click += btnMovingAvg_Click;
            // 
            // warehouseNameDataGridViewTextBoxColumn
            // 
            warehouseNameDataGridViewTextBoxColumn.DataPropertyName = "WarehouseName";
            warehouseNameDataGridViewTextBoxColumn.HeaderText = "Warehouse";
            warehouseNameDataGridViewTextBoxColumn.Name = "warehouseNameDataGridViewTextBoxColumn";
            warehouseNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "Product";
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // UnitPrice
            // 
            UnitPrice.DataPropertyName = "UnitPrice";
            UnitPrice.HeaderText = "UnitPrice";
            UnitPrice.Name = "UnitPrice";
            // 
            // transdateDataGridViewTextBoxColumn
            // 
            transdateDataGridViewTextBoxColumn.DataPropertyName = "trans_date";
            transdateDataGridViewTextBoxColumn.HeaderText = "Date";
            transdateDataGridViewTextBoxColumn.Name = "transdateDataGridViewTextBoxColumn";
            // 
            // transtypeDataGridViewTextBoxColumn
            // 
            transtypeDataGridViewTextBoxColumn.DataPropertyName = "trans_type";
            transtypeDataGridViewTextBoxColumn.HeaderText = "Type";
            transtypeDataGridViewTextBoxColumn.Name = "transtypeDataGridViewTextBoxColumn";
            transtypeDataGridViewTextBoxColumn.Width = 80;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "QTY";
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.Width = 80;
            // 
            // Total
            // 
            Total.DataPropertyName = "Total";
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 80;
            // 
            // customerFriendlyNameDataGridViewTextBoxColumn
            // 
            customerFriendlyNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerFriendlyName";
            customerFriendlyNameDataGridViewTextBoxColumn.HeaderText = "Contact";
            customerFriendlyNameDataGridViewTextBoxColumn.Name = "customerFriendlyNameDataGridViewTextBoxColumn";
            customerFriendlyNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // warprodidDataGridViewTextBoxColumn
            // 
            warprodidDataGridViewTextBoxColumn.DataPropertyName = "war_prod_id";
            warprodidDataGridViewTextBoxColumn.HeaderText = "war_prod_id";
            warprodidDataGridViewTextBoxColumn.Name = "warprodidDataGridViewTextBoxColumn";
            warprodidDataGridViewTextBoxColumn.Visible = false;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            userIdDataGridViewTextBoxColumn.DataPropertyName = "userId";
            userIdDataGridViewTextBoxColumn.HeaderText = "userId";
            userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            userIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            customerIdDataGridViewTextBoxColumn.DataPropertyName = "customerId";
            customerIdDataGridViewTextBoxColumn.HeaderText = "customerId";
            customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            customerIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmTransactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 418);
            Controls.Add(btnMovingAvg);
            Controls.Add(label6);
            Controls.Add(cboCustomer);
            Controls.Add(statusStrip1);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(cboInout);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dfTransDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(nfQty);
            Controls.Add(cboProducts);
            Controls.Add(cboWareHouse);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            MaximumSize = new Size(860, 457);
            MinimizeBox = false;
            MinimumSize = new Size(860, 457);
            Name = "frmTransactions";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Transactions";
            FormClosing += frmTransactions_FormClosing;
            Load += frmTransactions_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)nfQty).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private List<TransactionDTO> ListTransactionDTO;
        private ComboBox cboWareHouse;
        private ComboBox cboProducts;
        private NumericUpDown nfQty;
        private Button btnAdd;
        private Label label1;
        private Label label2;
        private DateTimePicker dfTransDate;
        private Label label3;
        private Label label4;
        private ComboBox cboInout;
        private Label label5;
        private Button button2;
        private ErrorProvider errorProvider1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel ttCurrentStockLevel;
        private Label label6;
        private ComboBox cboCustomer;
        private BindingSource transactionDTOBindingSource;
        private Button btnMovingAvg;
        private DataGridViewTextBoxColumn warehouseNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn transdateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transtypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn customerFriendlyNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn warprodidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
    }
}