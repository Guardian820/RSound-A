﻿namespace RSound_A
{
    partial class PrimaryForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrimaryForm));
            this.importBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxSoundPath = new System.Windows.Forms.TextBox();
            this.btnCrypt = new System.Windows.Forms.Button();
            this.checkExportSound = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // importBtn
            // 
            this.importBtn.Location = new System.Drawing.Point(6, 54);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(134, 30);
            this.importBtn.TabIndex = 0;
            this.importBtn.Text = "Browse sound (*.wav)";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status :";
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.ForeColor = System.Drawing.Color.Red;
            this.statusLbl.Location = new System.Drawing.Point(61, 126);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(143, 13);
            this.statusLbl.TabIndex = 2;
            this.statusLbl.Text = "You need to import a sound !";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxSoundPath);
            this.groupBox1.Controls.Add(this.importBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 94);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Import";
            // 
            // txtBoxSoundPath
            // 
            this.txtBoxSoundPath.Location = new System.Drawing.Point(6, 28);
            this.txtBoxSoundPath.Name = "txtBoxSoundPath";
            this.txtBoxSoundPath.ReadOnly = true;
            this.txtBoxSoundPath.Size = new System.Drawing.Size(250, 20);
            this.txtBoxSoundPath.TabIndex = 3;
            // 
            // btnCrypt
            // 
            this.btnCrypt.Location = new System.Drawing.Point(18, 152);
            this.btnCrypt.Name = "btnCrypt";
            this.btnCrypt.Size = new System.Drawing.Size(134, 30);
            this.btnCrypt.TabIndex = 0;
            this.btnCrypt.Text = "Crypt the sound";
            this.btnCrypt.UseVisualStyleBackColor = true;
            this.btnCrypt.Click += new System.EventHandler(this.btnCrypt_click);
            // 
            // checkExportSound
            // 
            this.checkExportSound.AutoSize = true;
            this.checkExportSound.Checked = true;
            this.checkExportSound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkExportSound.Location = new System.Drawing.Point(156, 163);
            this.checkExportSound.Name = "checkExportSound";
            this.checkExportSound.Size = new System.Drawing.Size(128, 17);
            this.checkExportSound.TabIndex = 4;
            this.checkExportSound.Text = "Also export the sound";
            this.checkExportSound.UseVisualStyleBackColor = true;
            // 
            // PrimaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 195);
            this.Controls.Add(this.checkExportSound);
            this.Controls.Add(this.btnCrypt);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrimaryForm";
            this.Text = "RSound-A";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxSoundPath;
        private System.Windows.Forms.Button btnCrypt;
        private System.Windows.Forms.CheckBox checkExportSound;
    }
}

