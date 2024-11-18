namespace NotesApplication.Forms
{
    partial class AddForm
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
            gboxAddNote = new GroupBox();
            txtTitle = new TextBox();
            rtxtContent = new RichTextBox();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            gboxAddNote.SuspendLayout();
            SuspendLayout();
            // 
            // gboxAddNote
            // 
            gboxAddNote.BackColor = SystemColors.ActiveCaption;
            gboxAddNote.Controls.Add(label3);
            gboxAddNote.Controls.Add(label2);
            gboxAddNote.Controls.Add(label1);
            gboxAddNote.Controls.Add(btnSave);
            gboxAddNote.Controls.Add(rtxtContent);
            gboxAddNote.Controls.Add(txtTitle);
            gboxAddNote.Location = new Point(60, 26);
            gboxAddNote.Name = "gboxAddNote";
            gboxAddNote.Size = new Size(603, 397);
            gboxAddNote.TabIndex = 0;
            gboxAddNote.TabStop = false;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(273, 125);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(298, 27);
            txtTitle.TabIndex = 0;
            // 
            // rtxtContent
            // 
            rtxtContent.Location = new Point(273, 202);
            rtxtContent.Name = "rtxtContent";
            rtxtContent.Size = new Size(298, 102);
            rtxtContent.TabIndex = 1;
            rtxtContent.Text = "";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(477, 334);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 38);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            label1.Location = new Point(209, 34);
            label1.Name = "label1";
            label1.Size = new Size(248, 37);
            label1.TabIndex = 3;
            label1.Text = "ADD NEW NOTES";
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
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 450);
            Controls.Add(gboxAddNote);
            Name = "AddForm";
            Text = "AddForm";
            gboxAddNote.ResumeLayout(false);
            gboxAddNote.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gboxAddNote;
        private Button btnSave;
        private RichTextBox rtxtContent;
        private TextBox txtTitle;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}