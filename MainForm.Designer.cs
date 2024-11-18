namespace NotesApplication
{
    partial class MainForm
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
            panel1 = new Panel();
            notePanel = new FlowLayoutPanel();
            btnAddNotes = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAddNotes);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 136);
            panel1.TabIndex = 0;
            // 
            // notePanel
            // 
            notePanel.BackColor = SystemColors.ButtonHighlight;
            notePanel.Location = new Point(1, 131);
            notePanel.Name = "notePanel";
            notePanel.Size = new Size(800, 324);
            notePanel.TabIndex = 1;
            // 
            // btnAddNotes
            // 
            btnAddNotes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNotes.Location = new Point(625, 57);
            btnAddNotes.Name = "btnAddNotes";
            btnAddNotes.Size = new Size(137, 34);
            btnAddNotes.TabIndex = 0;
            btnAddNotes.Text = "Add Notes";
            btnAddNotes.UseVisualStyleBackColor = true;
            btnAddNotes.Click += btnAddNotes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold);
            label1.Location = new Point(43, 43);
            label1.Name = "label1";
            label1.Size = new Size(348, 50);
            label1.TabIndex = 1;
            label1.Text = "Notes Application";
            label1.Click += label1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(notePanel);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel notePanel;
        private Label label1;
        private Button btnAddNotes;
    }
}
