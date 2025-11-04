namespace Torri_di_Hanoi
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
            lbl_nmrdischi = new Label();
            nmr_Dischi = new NumericUpDown();
            btn_Invia = new Button();
            ((System.ComponentModel.ISupportInitialize)nmr_Dischi).BeginInit();
            SuspendLayout();
            // 
            // lbl_nmrdischi
            // 
            lbl_nmrdischi.AutoSize = true;
            lbl_nmrdischi.Location = new Point(296, 170);
            lbl_nmrdischi.Name = "lbl_nmrdischi";
            lbl_nmrdischi.Size = new Size(156, 15);
            lbl_nmrdischi.TabIndex = 1;
            lbl_nmrdischi.Text = "Inserisci il numero di dischi..";
            // 
            // nmr_Dischi
            // 
            nmr_Dischi.Location = new Point(296, 188);
            nmr_Dischi.Name = "nmr_Dischi";
            nmr_Dischi.Size = new Size(120, 23);
            nmr_Dischi.TabIndex = 2;
            // 
            // btn_Invia
            // 
            btn_Invia.Location = new Point(296, 217);
            btn_Invia.Name = "btn_Invia";
            btn_Invia.Size = new Size(75, 23);
            btn_Invia.TabIndex = 3;
            btn_Invia.Text = "Invia";
            btn_Invia.UseVisualStyleBackColor = true;
            btn_Invia.Click += btn_Invia_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Invia);
            Controls.Add(nmr_Dischi);
            Controls.Add(lbl_nmrdischi);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nmr_Dischi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nmrdischi;
        private NumericUpDown nmr_Dischi;
        private Button btn_Invia;
    }
}