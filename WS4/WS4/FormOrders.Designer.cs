namespace WS4
{
    partial class FormOrders
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
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bDDataSet = new WS4.BDDataSet();
            this.bDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new WS4.BDDataSetTableAdapters.ordersTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerloginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerpasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerloginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerpasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadlineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examplesDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // bDDataSet
            // 
            this.bDDataSet.DataSetName = "BDDataSet";
            this.bDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bDDataSetBindingSource
            // 
            this.bDDataSetBindingSource.DataSource = this.bDDataSet;
            this.bDDataSetBindingSource.Position = 0;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.bDDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.customerloginDataGridViewTextBoxColumn,
            this.customerpasswordDataGridViewTextBoxColumn,
            this.managerloginDataGridViewTextBoxColumn,
            this.managerpasswordDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.deadlineDataGridViewTextBoxColumn,
            this.examplesDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.ordersBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(20, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(758, 417);
            this.dataGridView1.TabIndex = 0;
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "orders";
            this.ordersBindingSource1.DataSource = this.bDDataSet;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "product";
            this.productDataGridViewTextBoxColumn.HeaderText = "product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            // 
            // customerloginDataGridViewTextBoxColumn
            // 
            this.customerloginDataGridViewTextBoxColumn.DataPropertyName = "customer_login";
            this.customerloginDataGridViewTextBoxColumn.HeaderText = "customer_login";
            this.customerloginDataGridViewTextBoxColumn.Name = "customerloginDataGridViewTextBoxColumn";
            // 
            // customerpasswordDataGridViewTextBoxColumn
            // 
            this.customerpasswordDataGridViewTextBoxColumn.DataPropertyName = "customer_password";
            this.customerpasswordDataGridViewTextBoxColumn.HeaderText = "customer_password";
            this.customerpasswordDataGridViewTextBoxColumn.Name = "customerpasswordDataGridViewTextBoxColumn";
            // 
            // managerloginDataGridViewTextBoxColumn
            // 
            this.managerloginDataGridViewTextBoxColumn.DataPropertyName = "manager_login";
            this.managerloginDataGridViewTextBoxColumn.HeaderText = "manager_login";
            this.managerloginDataGridViewTextBoxColumn.Name = "managerloginDataGridViewTextBoxColumn";
            // 
            // managerpasswordDataGridViewTextBoxColumn
            // 
            this.managerpasswordDataGridViewTextBoxColumn.DataPropertyName = "manager_password";
            this.managerpasswordDataGridViewTextBoxColumn.HeaderText = "manager_password";
            this.managerpasswordDataGridViewTextBoxColumn.Name = "managerpasswordDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // deadlineDataGridViewTextBoxColumn
            // 
            this.deadlineDataGridViewTextBoxColumn.DataPropertyName = "deadline";
            this.deadlineDataGridViewTextBoxColumn.HeaderText = "deadline";
            this.deadlineDataGridViewTextBoxColumn.Name = "deadlineDataGridViewTextBoxColumn";
            // 
            // examplesDataGridViewImageColumn
            // 
            this.examplesDataGridViewImageColumn.DataPropertyName = "examples";
            this.examplesDataGridViewImageColumn.HeaderText = "examples";
            this.examplesDataGridViewImageColumn.Name = "examplesDataGridViewImageColumn";
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormOrders";
            this.Text = "FormOrders";
            this.Load += new System.EventHandler(this.FormOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bDDataSetBindingSource;
        private BDDataSet bDDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private BDDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerloginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerpasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerloginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerpasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadlineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn examplesDataGridViewImageColumn;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
    }
}