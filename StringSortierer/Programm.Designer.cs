namespace StringSortierer
{
    partial class Programm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblinput = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sortiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbloutput = new System.Windows.Forms.Label();
            this.txtbxinput1 = new System.Windows.Forms.TextBox();
            this.txtbxinput2 = new System.Windows.Forms.TextBox();
            this.txtbxinput3 = new System.Windows.Forms.TextBox();
            this.txtbxinput4 = new System.Windows.Forms.TextBox();
            this.txtbxinput5 = new System.Windows.Forms.TextBox();
            this.lstbxoutput = new System.Windows.Forms.ListBox();
            this.endeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblinput
            // 
            this.lblinput.AutoSize = true;
            this.lblinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblinput.Location = new System.Drawing.Point(12, 77);
            this.lblinput.Name = "lblinput";
            this.lblinput.Size = new System.Drawing.Size(92, 26);
            this.lblinput.TabIndex = 0;
            this.lblinput.Text = "Eingabe";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortiereToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.endeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 45);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sortiereToolStripMenuItem
            // 
            this.sortiereToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.sortiereToolStripMenuItem.Name = "sortiereToolStripMenuItem";
            this.sortiereToolStripMenuItem.Size = new System.Drawing.Size(121, 41);
            this.sortiereToolStripMenuItem.Text = "Sortiere";
            this.sortiereToolStripMenuItem.Click += new System.EventHandler(this.sortiereToolStripMenuItem_Click);
            // 
            // lbloutput
            // 
            this.lbloutput.AutoSize = true;
            this.lbloutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbloutput.Location = new System.Drawing.Point(12, 112);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(98, 26);
            this.lbloutput.TabIndex = 2;
            this.lbloutput.Text = "Ausgabe";
            // 
            // txtbxinput1
            // 
            this.txtbxinput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtbxinput1.Location = new System.Drawing.Point(110, 74);
            this.txtbxinput1.Name = "txtbxinput1";
            this.txtbxinput1.Size = new System.Drawing.Size(100, 32);
            this.txtbxinput1.TabIndex = 3;
            // 
            // txtbxinput2
            // 
            this.txtbxinput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtbxinput2.Location = new System.Drawing.Point(216, 74);
            this.txtbxinput2.Name = "txtbxinput2";
            this.txtbxinput2.Size = new System.Drawing.Size(100, 32);
            this.txtbxinput2.TabIndex = 4;
            // 
            // txtbxinput3
            // 
            this.txtbxinput3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtbxinput3.Location = new System.Drawing.Point(322, 74);
            this.txtbxinput3.Name = "txtbxinput3";
            this.txtbxinput3.Size = new System.Drawing.Size(100, 32);
            this.txtbxinput3.TabIndex = 5;
            // 
            // txtbxinput4
            // 
            this.txtbxinput4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtbxinput4.Location = new System.Drawing.Point(428, 74);
            this.txtbxinput4.Name = "txtbxinput4";
            this.txtbxinput4.Size = new System.Drawing.Size(100, 32);
            this.txtbxinput4.TabIndex = 6;
            // 
            // txtbxinput5
            // 
            this.txtbxinput5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtbxinput5.Location = new System.Drawing.Point(534, 74);
            this.txtbxinput5.Name = "txtbxinput5";
            this.txtbxinput5.Size = new System.Drawing.Size(100, 32);
            this.txtbxinput5.TabIndex = 7;
            // 
            // lstbxoutput
            // 
            this.lstbxoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lstbxoutput.FormattingEnabled = true;
            this.lstbxoutput.ItemHeight = 25;
            this.lstbxoutput.Location = new System.Drawing.Point(110, 112);
            this.lstbxoutput.Name = "lstbxoutput";
            this.lstbxoutput.Size = new System.Drawing.Size(100, 204);
            this.lstbxoutput.TabIndex = 8;
            // 
            // endeToolStripMenuItem
            // 
            this.endeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.endeToolStripMenuItem.Name = "endeToolStripMenuItem";
            this.endeToolStripMenuItem.Size = new System.Drawing.Size(88, 41);
            this.endeToolStripMenuItem.Text = "Ende";
            this.endeToolStripMenuItem.Click += new System.EventHandler(this.endeToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(90, 41);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // Programm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstbxoutput);
            this.Controls.Add(this.txtbxinput5);
            this.Controls.Add(this.txtbxinput4);
            this.Controls.Add(this.txtbxinput3);
            this.Controls.Add(this.txtbxinput2);
            this.Controls.Add(this.txtbxinput1);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.lblinput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Programm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sortiereToolStripMenuItem;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.TextBox txtbxinput1;
        private System.Windows.Forms.TextBox txtbxinput2;
        private System.Windows.Forms.TextBox txtbxinput3;
        private System.Windows.Forms.TextBox txtbxinput4;
        private System.Windows.Forms.TextBox txtbxinput5;
        private System.Windows.Forms.ListBox lstbxoutput;
        private System.Windows.Forms.ToolStripMenuItem endeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    }
}

