﻿namespace Gestion_Location_Voiture
{
    partial class client
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtid = new System.Windows.Forms.TextBox();
            this.precedentGC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtne = new System.Windows.Forms.TextBox();
            this.txtn = new System.Windows.Forms.TextBox();
            this.txtp = new System.Windows.Forms.TextBox();
            this.txtnc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableaux = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnp = new System.Windows.Forms.TextBox();
            this.enregistrer = new Guna.UI2.WinForms.Guna2Button();
            this.modifier = new Guna.UI2.WinForms.Guna2Button();
            this.supprimer = new Guna.UI2.WinForms.Guna2Button();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtt = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rechercher = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnpr = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableaux)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.precedentGC);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 100);
            this.panel1.TabIndex = 0;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(246, 54);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(114, 26);
            this.txtid.TabIndex = 26;
            this.txtid.Visible = false;
            // 
            // precedentGC
            // 
            this.precedentGC.AutoSize = true;
            this.precedentGC.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.precedentGC.ForeColor = System.Drawing.Color.White;
            this.precedentGC.Location = new System.Drawing.Point(1040, 54);
            this.precedentGC.Name = "precedentGC";
            this.precedentGC.Size = new System.Drawing.Size(113, 29);
            this.precedentGC.TabIndex = 4;
            this.precedentGC.Text = "précedent ";
            this.precedentGC.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(396, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 57);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestion Des Clients";
            // 
            // txtne
            // 
            this.txtne.Location = new System.Drawing.Point(76, 159);
            this.txtne.Name = "txtne";
            this.txtne.Size = new System.Drawing.Size(182, 26);
            this.txtne.TabIndex = 1;
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(334, 159);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(182, 26);
            this.txtn.TabIndex = 2;
            // 
            // txtp
            // 
            this.txtp.Location = new System.Drawing.Point(676, 159);
            this.txtp.Name = "txtp";
            this.txtp.Size = new System.Drawing.Size(182, 26);
            this.txtp.TabIndex = 3;
            // 
            // txtnc
            // 
            this.txtnc.Location = new System.Drawing.Point(943, 159);
            this.txtnc.Name = "txtnc";
            this.txtnc.Size = new System.Drawing.Size(182, 26);
            this.txtnc.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(82, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom Entreprise";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(356, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(956, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "N° C.I.N";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(730, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "N° Tel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(691, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 29);
            this.label9.TabIndex = 13;
            this.label9.Text = "Prenom";
            // 
            // tableaux
            // 
            this.tableaux.BackgroundColor = System.Drawing.Color.White;
            this.tableaux.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableaux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableaux.Location = new System.Drawing.Point(45, 397);
            this.tableaux.Name = "tableaux";
            this.tableaux.RowHeadersWidth = 62;
            this.tableaux.RowTemplate.Height = 28;
            this.tableaux.Size = new System.Drawing.Size(1108, 289);
            this.tableaux.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(382, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "N° Permis";
            // 
            // txtnp
            // 
            this.txtnp.Location = new System.Drawing.Point(340, 250);
            this.txtnp.Name = "txtnp";
            this.txtnp.Size = new System.Drawing.Size(182, 26);
            this.txtnp.TabIndex = 6;
            this.txtnp.Tag = "";
            // 
            // enregistrer
            // 
            this.enregistrer.BorderRadius = 18;
            this.enregistrer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.enregistrer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.enregistrer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.enregistrer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.enregistrer.FillColor = System.Drawing.Color.Teal;
            this.enregistrer.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregistrer.ForeColor = System.Drawing.Color.White;
            this.enregistrer.Location = new System.Drawing.Point(649, 315);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(180, 45);
            this.enregistrer.TabIndex = 9;
            this.enregistrer.Text = "Enregistrer";
            this.enregistrer.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // modifier
            // 
            this.modifier.BorderRadius = 18;
            this.modifier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.modifier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.modifier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.modifier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.modifier.Enabled = false;
            this.modifier.FillColor = System.Drawing.Color.Teal;
            this.modifier.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier.ForeColor = System.Drawing.Color.White;
            this.modifier.Location = new System.Drawing.Point(361, 315);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(180, 45);
            this.modifier.TabIndex = 19;
            this.modifier.Text = "Modifier";
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // supprimer
            // 
            this.supprimer.BorderRadius = 18;
            this.supprimer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.supprimer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.supprimer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.supprimer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.supprimer.FillColor = System.Drawing.Color.Teal;
            this.supprimer.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer.ForeColor = System.Drawing.Color.White;
            this.supprimer.Location = new System.Drawing.Point(896, 315);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(180, 45);
            this.supprimer.TabIndex = 20;
            this.supprimer.Text = "Supprimer";
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(943, 250);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(182, 26);
            this.txta.TabIndex = 8;
            // 
            // txtt
            // 
            this.txtt.Location = new System.Drawing.Point(676, 250);
            this.txtt.Mask = "00 00 00 00 00";
            this.txtt.Name = "txtt";
            this.txtt.Size = new System.Drawing.Size(182, 26);
            this.txtt.TabIndex = 7;
            this.txtt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(985, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "Adresse";
            // 
            // rechercher
            // 
            this.rechercher.BorderRadius = 18;
            this.rechercher.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.rechercher.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.rechercher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.rechercher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.rechercher.FillColor = System.Drawing.Color.Teal;
            this.rechercher.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rechercher.ForeColor = System.Drawing.Color.White;
            this.rechercher.Location = new System.Drawing.Point(104, 315);
            this.rechercher.Name = "rechercher";
            this.rechercher.Size = new System.Drawing.Size(180, 45);
            this.rechercher.TabIndex = 25;
            this.rechercher.Text = "rechercher";
            this.rechercher.Click += new System.EventHandler(this.rechercher_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(82, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 29);
            this.label8.TabIndex = 27;
            this.label8.Text = "N° Passport";
            // 
            // txtnpr
            // 
            this.txtnpr.Location = new System.Drawing.Point(76, 250);
            this.txtnpr.Name = "txtnpr";
            this.txtnpr.Size = new System.Drawing.Size(182, 26);
            this.txtnpr.TabIndex = 5;
            // 
            // client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 732);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtnpr);
            this.Controls.Add(this.rechercher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtt);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.enregistrer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtnp);
            this.Controls.Add(this.tableaux);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnc);
            this.Controls.Add(this.txtp);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.txtne);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "client";
            this.Load += new System.EventHandler(this.client_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableaux)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label precedentGC;
        private System.Windows.Forms.TextBox txtne;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.TextBox txtp;
        private System.Windows.Forms.TextBox txtnc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView tableaux;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnp;
        private Guna.UI2.WinForms.Guna2Button enregistrer;
        private Guna.UI2.WinForms.Guna2Button modifier;
        private Guna.UI2.WinForms.Guna2Button supprimer;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.MaskedTextBox txtt;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button rechercher;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnpr;
    }
}