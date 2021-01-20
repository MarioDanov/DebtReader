
namespace Reader
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Credit_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrower_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditor_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Overdue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Credit_ID,
            this.Amount,
            this.Deadline,
            this.borrower_name,
            this.creditor_name,
            this.Overdue});
            this.dataGridView1.Location = new System.Drawing.Point(141, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(807, 250);
            this.dataGridView1.TabIndex = 0;
            // 
            // Credit_ID
            // 
            this.Credit_ID.HeaderText = "Credit ID";
            this.Credit_ID.MinimumWidth = 8;
            this.Credit_ID.Name = "Credit_ID";
            this.Credit_ID.ReadOnly = true;
            this.Credit_ID.Width = 108;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 8;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 101;
            // 
            // Deadline
            // 
            this.Deadline.HeaderText = "Deadline";
            this.Deadline.MinimumWidth = 8;
            this.Deadline.Name = "Deadline";
            this.Deadline.ReadOnly = true;
            this.Deadline.Width = 108;
            // 
            // borrower_name
            // 
            this.borrower_name.HeaderText = "Borrower Name";
            this.borrower_name.MinimumWidth = 8;
            this.borrower_name.Name = "borrower_name";
            this.borrower_name.ReadOnly = true;
            this.borrower_name.Width = 155;
            // 
            // creditor_name
            // 
            this.creditor_name.HeaderText = "Creditor_name";
            this.creditor_name.MinimumWidth = 8;
            this.creditor_name.Name = "creditor_name";
            this.creditor_name.ReadOnly = true;
            this.creditor_name.Width = 150;
            // 
            // Overdue
            // 
            this.Overdue.HeaderText = "Overdue";
            this.Overdue.MinimumWidth = 8;
            this.Overdue.Name = "Overdue";
            this.Overdue.ReadOnly = true;
            this.Overdue.Width = 105;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1061, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrower_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditor_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Overdue;
    }
}