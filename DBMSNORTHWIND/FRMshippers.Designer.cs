namespace DBMSNORTHWIND
{
    partial class FRMshippers
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
            label1 = new Label();
            tshipperID = new TextBox();
            label2 = new Label();
            tcompanyname = new TextBox();
            label3 = new Label();
            tphone = new TextBox();
            btnsave = new Button();
            btnCancle = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(52, 44);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 2;
            label1.Text = "รหัสบริษัทขนส่ง";
            // 
            // tshipperID
            // 
            tshipperID.Font = new Font("Segoe UI", 12F);
            tshipperID.Location = new Point(189, 41);
            tshipperID.Name = "tshipperID";
            tshipperID.Size = new Size(270, 29);
            tshipperID.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(52, 126);
            label2.Name = "label2";
            label2.Size = new Size(62, 21);
            label2.TabIndex = 6;
            label2.Text = "ชื่อบริษัท";
            // 
            // tcompanyname
            // 
            tcompanyname.Font = new Font("Segoe UI", 12F);
            tcompanyname.Location = new Point(189, 118);
            tcompanyname.Name = "tcompanyname";
            tcompanyname.Size = new Size(327, 29);
            tcompanyname.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(52, 208);
            label3.Name = "label3";
            label3.Size = new Size(62, 21);
            label3.TabIndex = 8;
            label3.Text = "โทรศัพท์";
            // 
            // tphone
            // 
            tphone.Font = new Font("Segoe UI", 12F);
            tphone.Location = new Point(189, 208);
            tphone.Name = "tphone";
            tphone.Size = new Size(327, 29);
            tphone.TabIndex = 9;
            // 
            // btnsave
            // 
            btnsave.Font = new Font("Segoe UI", 15F);
            btnsave.Location = new Point(174, 281);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(146, 51);
            btnsave.TabIndex = 10;
            btnsave.Text = "Submit";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // btnCancle
            // 
            btnCancle.Font = new Font("Segoe UI", 15F);
            btnCancle.Location = new Point(400, 281);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(146, 51);
            btnCancle.TabIndex = 11;
            btnCancle.Text = "Cancle";
            btnCancle.UseVisualStyleBackColor = true;
            btnCancle.Click += btnCancle_Click;
            // 
            // FRMshippers
            // 
            AcceptButton = btnsave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancle;
            ClientSize = new Size(984, 356);
            Controls.Add(btnCancle);
            Controls.Add(btnsave);
            Controls.Add(tphone);
            Controls.Add(label3);
            Controls.Add(tcompanyname);
            Controls.Add(label2);
            Controls.Add(tshipperID);
            Controls.Add(label1);
            Name = "FRMshippers";
            Text = "FRMshippers";
            Load += FRMshippers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tshipperID;
        private Label label2;
        private TextBox tcompanyname;
        private Label label3;
        private TextBox tphone;
        private Button btnsave;
        private Button btnCancle;
    }
}