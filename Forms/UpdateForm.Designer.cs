namespace NotesApplication.Forms
{
    partial class UpdateForm
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
            gboxUpdateNote = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnUpdate = new Button();
            rtxtContent = new RichTextBox();
            txtTitle = new TextBox();
            lblDate = new Label();
            gboxUpdateNote.SuspendLayout();
            SuspendLayout();
            // 
            // gboxUpdateNote
            // 
            gboxUpdateNote.BackColor = SystemColors.ActiveCaption;
            gboxUpdateNote.Controls.Add(lblDate);
            gboxUpdateNote.Controls.Add(label3);
            gboxUpdateNote.Controls.Add(label2);
            gboxUpdateNote.Controls.Add(label1);
            gboxUpdateNote.Controls.Add(btnUpdate);
            gboxUpdateNote.Controls.Add(rtxtContent);
            gboxUpdateNote.Controls.Add(txtTitle);
            gboxUpdateNote.Location = new Point(99, 27);
            gboxUpdateNote.Name = "gboxUpdateNote";
            gboxUpdateNote.Size = new Size(603, 397);
            gboxUpdateNote.TabIndex = 1;
            gboxUpdateNote.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(66, 202);
            label3.Name = "label3";
            label3.Size = new Size(100, 31);
            label3.TabIndex = 5;
            label3.Text = "Content";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(66, 125);
            label2.Name = "label2";
            label2.Size = new Size(62, 31);
            label2.TabIndex = 4;
            label2.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            label1.Location = new Point(209, 34);
            label1.Name = "label1";
            label1.Size = new Size(225, 37);
            label1.TabIndex = 3;
            label1.Text = "UPDATE NOTES";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(477, 334);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 36);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // rtxtContent
            // 
            rtxtContent.Location = new Point(273, 202);
            rtxtContent.Name = "rtxtContent";
            rtxtContent.Size = new Size(298, 102);
            rtxtContent.TabIndex = 1;
            rtxtContent.Text = "";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(273, 125);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(298, 27);
            txtTitle.TabIndex = 0;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(75, 325);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(0, 20);
            lblDate.TabIndex = 6;
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gboxUpdateNote);
            Name = "UpdateForm";
            Text = "UpdateForm";
            gboxUpdateNote.ResumeLayout(false);
            gboxUpdateNote.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gboxUpdateNote;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnUpdate;
        private RichTextBox rtxtContent;
        private TextBox txtTitle;
        private Label lblDate;
    }
}