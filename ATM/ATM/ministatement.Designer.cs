namespace ATM
{
    partial class ministatement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.aTMDbDataSet = new ATM.ATMDbDataSet();
            this.transactionTb1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionTb1TableAdapter = new ATM.ATMDbDataSetTableAdapters.TransactionTb1TableAdapter();
            this.tableAdapterManager = new ATM.ATMDbDataSetTableAdapters.TableAdapterManager();
            this.MinistatementGDV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aTMDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTb1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinistatementGDV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(-3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 58);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "ATM MANAGEMENT SYSTEM ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(514, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "X";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "MINI STSTEMENT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(220, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 51;
            this.label5.Text = "Back";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // aTMDbDataSet
            // 
            this.aTMDbDataSet.DataSetName = "ATMDbDataSet";
            this.aTMDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionTb1BindingSource
            // 
            this.transactionTb1BindingSource.DataMember = "TransactionTb1";
            this.transactionTb1BindingSource.DataSource = this.aTMDbDataSet;
            // 
            // transactionTb1TableAdapter
            // 
            this.transactionTb1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTb1TableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TransactionTb1TableAdapter = this.transactionTb1TableAdapter;
            this.tableAdapterManager.UpdateOrder = ATM.ATMDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // MinistatementGDV
            // 
            this.MinistatementGDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MinistatementGDV.Location = new System.Drawing.Point(-3, 103);
            this.MinistatementGDV.Name = "MinistatementGDV";
            this.MinistatementGDV.Size = new System.Drawing.Size(554, 229);
            this.MinistatementGDV.TabIndex = 52;
            this.MinistatementGDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ministatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 411);
            this.Controls.Add(this.MinistatementGDV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "ministatement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ministatement";
            this.Load += new System.EventHandler(this.ministatement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aTMDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTb1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinistatementGDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private ATMDbDataSet aTMDbDataSet;
        private System.Windows.Forms.BindingSource transactionTb1BindingSource;
        private ATMDbDataSetTableAdapters.TransactionTb1TableAdapter transactionTb1TableAdapter;
        private ATMDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView MinistatementGDV;
    }
}