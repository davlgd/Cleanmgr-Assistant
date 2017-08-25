namespace Cleanmgr_Assistant
{
    partial class Form1
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
            if (disposing && (components != null))
            {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbDrives = new System.Windows.Forms.ComboBox();
            this.cbActions = new System.Windows.Forms.ComboBox();
            this.btDrives = new System.Windows.Forms.Button();
            this.btActions = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // cbDrives
            // 
            this.cbDrives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDrives.FormattingEnabled = true;
            this.cbDrives.Location = new System.Drawing.Point(12, 12);
            this.cbDrives.Name = "cbDrives";
            this.cbDrives.Size = new System.Drawing.Size(260, 21);
            this.cbDrives.TabIndex = 2;
            this.cbDrives.SelectedIndexChanged += new System.EventHandler(this.cbDrives_SelectedIndexChanged);
            // 
            // cbActions
            // 
            this.cbActions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActions.FormattingEnabled = true;
            this.cbActions.Items.AddRange(new object[] {
            "Lancer avec les paramètres par défaut",
            "Lancer et tout sélectionner (mode manuel)",
            "Lancer et tout sélectionner (mode automatique)",
            "----",
            "Configurer le profil #42",
            "Lancer le profil #42",
            "----",
            "Autoclean"});
            this.cbActions.Location = new System.Drawing.Point(12, 39);
            this.cbActions.Name = "cbActions";
            this.cbActions.Size = new System.Drawing.Size(341, 21);
            this.cbActions.TabIndex = 3;
            this.cbActions.SelectedIndexChanged += new System.EventHandler(this.cbActions_SelectedIndexChanged);
            // 
            // btDrives
            // 
            this.btDrives.Location = new System.Drawing.Point(278, 10);
            this.btDrives.Name = "btDrives";
            this.btDrives.Size = new System.Drawing.Size(75, 23);
            this.btDrives.TabIndex = 4;
            this.btDrives.Text = "Rafraîchir";
            this.btDrives.UseVisualStyleBackColor = true;
            this.btDrives.Click += new System.EventHandler(this.btDrives_Click);
            // 
            // btActions
            // 
            this.btActions.Location = new System.Drawing.Point(278, 66);
            this.btActions.Name = "btActions";
            this.btActions.Size = new System.Drawing.Size(75, 23);
            this.btActions.TabIndex = 5;
            this.btActions.Text = "Go !";
            this.btActions.UseVisualStyleBackColor = true;
            this.btActions.Click += new System.EventHandler(this.btActions_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 76);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(166, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Legrand David - Next INpact.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 100);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btActions);
            this.Controls.Add(this.btDrives);
            this.Controls.Add(this.cbActions);
            this.Controls.Add(this.cbDrives);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbDrives;
        private System.Windows.Forms.ComboBox cbActions;
        private System.Windows.Forms.Button btDrives;
        private System.Windows.Forms.Button btActions;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

