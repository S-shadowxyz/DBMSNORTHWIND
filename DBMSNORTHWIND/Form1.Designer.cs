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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tshipperID = new TextBox();
            tcompanyname = new TextBox();
            tphone = new TextBox();
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
            dvgShippers.Size = new Size(923, 275);
            dvgShippers.TabIndex = 0;
            dvgShippers.CellMouseUp += dvgShippers_CellMouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(36, 322);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 1;
            label1.Text = "รหัสบริษัทขนส่ง";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(36, 379);
            label2.Name = "label2";
            label2.Size = new Size(62, 21);
            label2.TabIndex = 2;
            label2.Text = "ชื่อบริษัท";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(36, 433);
            label3.Name = "label3";
            label3.Size = new Size(62, 21);
            label3.TabIndex = 3;
            label3.Text = "โทรศัพท์";
            // 
            // tshipperID
            // 
            tshipperID.Font = new Font("Segoe UI", 12F);
            tshipperID.Location = new Point(172, 319);
            tshipperID.Name = "tshipperID";
            tshipperID.ReadOnly = true;
            tshipperID.Size = new Size(240, 29);
            tshipperID.TabIndex = 4;
            // 
            // tcompanyname
            // 
            tcompanyname.Font = new Font("Segoe UI", 12F);
            tcompanyname.Location = new Point(172, 376);
            tcompanyname.Name = "tcompanyname";
            tcompanyname.Size = new Size(240, 29);
            tcompanyname.TabIndex = 5;
            // 
            // tphone
            // 
            tphone.Font = new Font("Segoe UI", 12F);
            tphone.Location = new Point(172, 425);
            tphone.Name = "tphone";
            tphone.Size = new Size(240, 29);
            tphone.TabIndex = 6;
            // 
            // btninsert
            // 
            btninsert.Font = new Font("Segoe UI", 15F);
            btninsert.Location = new Point(49, 530);
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
            btnEdit.Location = new Point(255, 530);
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
            btnDelete.Location = new Point(473, 530);
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
            btnReset.Location = new Point(700, 530);
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
            ClientSize = new Size(960, 630);
            Controls.Add(btnReset);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btninsert);
            Controls.Add(tphone);
            Controls.Add(tcompanyname);
            Controls.Add(tshipperID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dvgShippers);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dvgShippers).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
