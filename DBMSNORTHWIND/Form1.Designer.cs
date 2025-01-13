namespace DBMSNORTHWIND
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dvgShippers = new DataGridView();
            btninsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgShippers).BeginInit();
            SuspendLayout();
            // 
            // dvgShippers
            // 
            dvgShippers.AllowUserToAddRows = false;
            dvgShippers.AllowUserToDeleteRows = false;
            dvgShippers.BackgroundColor = SystemColors.ControlLight;
            dvgShippers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgShippers.Location = new Point(12, 12);
            dvgShippers.Name = "dvgShippers";
            dvgShippers.ReadOnly = true;
            dvgShippers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgShippers.Size = new Size(945, 378);
            dvgShippers.TabIndex = 0;
            dvgShippers.CellMouseDoubleClick += dvgShippers_CellMouseDoubleClick;
            dvgShippers.CellMouseUp += dvgShippers_CellMouseUp;
            // 
            // btninsert
            // 
            btninsert.Font = new Font("Segoe UI", 15F);
            btninsert.Location = new Point(36, 414);
            btninsert.Name = "btninsert";
            btninsert.Size = new Size(146, 51);
            btninsert.TabIndex = 7;
            btninsert.Text = "Add";
            btninsert.UseVisualStyleBackColor = true;
            btninsert.Click += btninsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 15F);
            btnEdit.Location = new Point(270, 414);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(146, 51);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 15F);
            btnDelete.Location = new Point(492, 414);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(146, 51);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 15F);
            btnReset.Location = new Point(730, 414);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(146, 51);
            btnReset.TabIndex = 10;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 508);
            Controls.Add(btnReset);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btninsert);
            Controls.Add(dvgShippers);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dvgShippers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dvgShippers;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tshipperID;
        private TextBox tcompanyname;
        private TextBox tphone;
        private Button btninsert;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnReset;
    }
}
