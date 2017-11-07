namespace ToutEmbal
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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.typeA = new System.Windows.Forms.TabPage();
            this.textBoxFaultsRateSinceBegining = new System.Windows.Forms.TextBox();
            this.textBoxFaultsRateOneHour = new System.Windows.Forms.TextBox();
            this.textBoxNbrOfBoxes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.typeB = new System.Windows.Forms.TabPage();
            this.typeC = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.démarrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrêterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.continuerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.labelA = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxBNbrBoxes = new System.Windows.Forms.TextBox();
            this.textBoxBDefaultHour = new System.Windows.Forms.TextBox();
            this.textBoxBSBegining = new System.Windows.Forms.TextBox();
            this.textBoxCNbrBoxes = new System.Windows.Forms.TextBox();
            this.textBoxCDefaultHour = new System.Windows.Forms.TextBox();
            this.textBoxCSBegining = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.typeA.SuspendLayout();
            this.typeB.SuspendLayout();
            this.typeC.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.typeA);
            this.tabControl.Controls.Add(this.typeB);
            this.tabControl.Controls.Add(this.typeC);
            this.tabControl.Location = new System.Drawing.Point(70, 62);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(322, 112);
            this.tabControl.TabIndex = 0;
            // 
            // TypeA
            // 
            this.typeA.Controls.Add(this.textBoxFaultsRateSinceBegining);
            this.typeA.Controls.Add(this.textBoxFaultsRateOneHour);
            this.typeA.Controls.Add(this.textBoxNbrOfBoxes);
            this.typeA.Controls.Add(this.label3);
            this.typeA.Controls.Add(this.label2);
            this.typeA.Controls.Add(this.label1);
            this.typeA.Location = new System.Drawing.Point(4, 22);
            this.typeA.Name = "TypeA";
            this.typeA.Padding = new System.Windows.Forms.Padding(3);
            this.typeA.Size = new System.Drawing.Size(314, 86);
            this.typeA.TabIndex = 0;
            this.typeA.Text = "TypeA";
            this.typeA.UseVisualStyleBackColor = true;
            // 
            // textBoxFaultsRateSinceBegining
            // 
            this.textBoxFaultsRateSinceBegining.Location = new System.Drawing.Point(208, 54);
            this.textBoxFaultsRateSinceBegining.Name = "textBoxFaultsRateSinceBegining";
            this.textBoxFaultsRateSinceBegining.Size = new System.Drawing.Size(100, 20);
            this.textBoxFaultsRateSinceBegining.TabIndex = 5;
            // 
            // textBoxFaultsRateOneHour
            // 
            this.textBoxFaultsRateOneHour.Location = new System.Drawing.Point(208, 32);
            this.textBoxFaultsRateOneHour.Name = "textBoxFaultsRateOneHour";
            this.textBoxFaultsRateOneHour.Size = new System.Drawing.Size(100, 20);
            this.textBoxFaultsRateOneHour.TabIndex = 4;
            // 
            // textBoxNbrOfBoxes
            // 
            this.textBoxNbrOfBoxes.Location = new System.Drawing.Point(208, 10);
            this.textBoxNbrOfBoxes.Name = "textBoxNbrOfBoxes";
            this.textBoxNbrOfBoxes.Size = new System.Drawing.Size(100, 20);
            this.textBoxNbrOfBoxes.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Taux défaut depuis démarrage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Taux défaut heure";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de caisses depuis le démarrage";
            // 
            // tabPage2
            // 
            this.typeB.Controls.Add(this.label8);
            this.typeB.Controls.Add(this.label6);
            this.typeB.Controls.Add(this.label4);
            this.typeB.Controls.Add(this.textBoxBSBegining);
            this.typeB.Controls.Add(this.textBoxBDefaultHour);
            this.typeB.Controls.Add(this.textBoxBNbrBoxes);
            this.typeB.Location = new System.Drawing.Point(4, 22);
            this.typeB.Name = "tabPage2";
            this.typeB.Padding = new System.Windows.Forms.Padding(3);
            this.typeB.Size = new System.Drawing.Size(314, 86);
            this.typeB.TabIndex = 1;
            this.typeB.Text = "TypeB";
            this.typeB.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.typeC.Controls.Add(this.label9);
            this.typeC.Controls.Add(this.label7);
            this.typeC.Controls.Add(this.label5);
            this.typeC.Controls.Add(this.textBoxCSBegining);
            this.typeC.Controls.Add(this.textBoxCDefaultHour);
            this.typeC.Controls.Add(this.textBoxCNbrBoxes);
            this.typeC.Location = new System.Drawing.Point(4, 22);
            this.typeC.Name = "tabPage3";
            this.typeC.Padding = new System.Windows.Forms.Padding(3);
            this.typeC.Size = new System.Drawing.Size(314, 86);
            this.typeC.TabIndex = 2;
            this.typeC.Text = "TypeC";
            this.typeC.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.productionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(429, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // productionToolStripMenuItem
            // 
            this.productionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.démarrerToolStripMenuItem,
            this.arrêterToolStripMenuItem,
            this.continuerToolStripMenuItem});
            this.productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            this.productionToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.productionToolStripMenuItem.Text = "Production";
            // 
            // démarrerToolStripMenuItem
            // 
            this.démarrerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.bToolStripMenuItem,
            this.cToolStripMenuItem});
            this.démarrerToolStripMenuItem.Name = "démarrerToolStripMenuItem";
            this.démarrerToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.démarrerToolStripMenuItem.Text = "Démarrer";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.aToolStripMenuItem.Tag = "1";
            this.aToolStripMenuItem.Text = "A";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.bToolStripMenuItem.Tag = "2";
            this.bToolStripMenuItem.Text = "B";
            this.bToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.cToolStripMenuItem.Tag = "3";
            this.cToolStripMenuItem.Text = "C";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // arrêterToolStripMenuItem
            // 
            this.arrêterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem1,
            this.bToolStripMenuItem1,
            this.cToolStripMenuItem1});
            this.arrêterToolStripMenuItem.Name = "arrêterToolStripMenuItem";
            this.arrêterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.arrêterToolStripMenuItem.Text = "Arrêter";
            // 
            // aToolStripMenuItem1
            // 
            this.aToolStripMenuItem1.Name = "aToolStripMenuItem1";
            this.aToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aToolStripMenuItem1.Tag = "1";
            this.aToolStripMenuItem1.Text = "A";
            this.aToolStripMenuItem1.Click += new System.EventHandler(this.aToolStripMenuItem1_Click);
            // 
            // bToolStripMenuItem1
            // 
            this.bToolStripMenuItem1.Name = "bToolStripMenuItem1";
            this.bToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.bToolStripMenuItem1.Tag = "2";
            this.bToolStripMenuItem1.Text = "B";
            this.bToolStripMenuItem1.Click += new System.EventHandler(this.aToolStripMenuItem1_Click);
            // 
            // cToolStripMenuItem1
            // 
            this.cToolStripMenuItem1.Name = "cToolStripMenuItem1";
            this.cToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.cToolStripMenuItem1.Tag = "3";
            this.cToolStripMenuItem1.Text = "C";
            this.cToolStripMenuItem1.Click += new System.EventHandler(this.aToolStripMenuItem1_Click);
            // 
            // continuerToolStripMenuItem
            // 
            this.continuerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem2,
            this.bToolStripMenuItem2,
            this.cToolStripMenuItem2});
            this.continuerToolStripMenuItem.Name = "continuerToolStripMenuItem";
            this.continuerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.continuerToolStripMenuItem.Text = "Continuer";
            // 
            // aToolStripMenuItem2
            // 
            this.aToolStripMenuItem2.Name = "aToolStripMenuItem2";
            this.aToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.aToolStripMenuItem2.Tag = "1";
            this.aToolStripMenuItem2.Text = "A";
            this.aToolStripMenuItem2.Click += new System.EventHandler(this.aToolStripMenuItem2_Click);
            // 
            // bToolStripMenuItem2
            // 
            this.bToolStripMenuItem2.Name = "bToolStripMenuItem2";
            this.bToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.bToolStripMenuItem2.Tag = "2";
            this.bToolStripMenuItem2.Text = "B";
            this.bToolStripMenuItem2.Click += new System.EventHandler(this.aToolStripMenuItem2_Click);
            // 
            // cToolStripMenuItem2
            // 
            this.cToolStripMenuItem2.Name = "cToolStripMenuItem2";
            this.cToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.cToolStripMenuItem2.Tag = "3";
            this.cToolStripMenuItem2.Text = "C";
            this.cToolStripMenuItem2.Click += new System.EventHandler(this.aToolStripMenuItem2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Enabled = false;
            this.progressBar1.Location = new System.Drawing.Point(192, 180);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(196, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // progressBar2
            // 
            this.progressBar2.Enabled = false;
            this.progressBar2.Location = new System.Drawing.Point(192, 209);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(196, 23);
            this.progressBar2.TabIndex = 3;
            // 
            // progressBar3
            // 
            this.progressBar3.Enabled = false;
            this.progressBar3.Location = new System.Drawing.Point(192, 238);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(196, 23);
            this.progressBar3.TabIndex = 4;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA.Location = new System.Drawing.Point(67, 180);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(80, 13);
            this.labelA.TabIndex = 5;
            this.labelA.Text = "Production A";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC.Location = new System.Drawing.Point(67, 238);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(80, 13);
            this.labelC.TabIndex = 6;
            this.labelC.Text = "Production C";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelB.Location = new System.Drawing.Point(67, 209);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(80, 13);
            this.labelB.TabIndex = 7;
            this.labelB.Text = "Production B";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBoxBNbrBoxes
            // 
            this.textBoxBNbrBoxes.Location = new System.Drawing.Point(208, 7);
            this.textBoxBNbrBoxes.Name = "textBoxBNbrBoxes";
            this.textBoxBNbrBoxes.Size = new System.Drawing.Size(100, 20);
            this.textBoxBNbrBoxes.TabIndex = 4;
            // 
            // textBoxBDefaultHour
            // 
            this.textBoxBDefaultHour.Location = new System.Drawing.Point(208, 33);
            this.textBoxBDefaultHour.Name = "textBoxBDefaultHour";
            this.textBoxBDefaultHour.Size = new System.Drawing.Size(100, 20);
            this.textBoxBDefaultHour.TabIndex = 5;
            // 
            // textBoxBSBegining
            // 
            this.textBoxBSBegining.Location = new System.Drawing.Point(208, 59);
            this.textBoxBSBegining.Name = "textBoxBSBegining";
            this.textBoxBSBegining.Size = new System.Drawing.Size(100, 20);
            this.textBoxBSBegining.TabIndex = 6;
            // 
            // textBoxCNbrBoxes
            // 
            this.textBoxCNbrBoxes.Location = new System.Drawing.Point(208, 8);
            this.textBoxCNbrBoxes.Name = "textBoxCNbrBoxes";
            this.textBoxCNbrBoxes.Size = new System.Drawing.Size(100, 20);
            this.textBoxCNbrBoxes.TabIndex = 4;
            // 
            // textBoxCDefaultHour
            // 
            this.textBoxCDefaultHour.Location = new System.Drawing.Point(208, 34);
            this.textBoxCDefaultHour.Name = "textBoxCDefaultHour";
            this.textBoxCDefaultHour.Size = new System.Drawing.Size(100, 20);
            this.textBoxCDefaultHour.TabIndex = 5;
            // 
            // textBoxCSBegining
            // 
            this.textBoxCSBegining.Location = new System.Drawing.Point(208, 60);
            this.textBoxCSBegining.Name = "textBoxCSBegining";
            this.textBoxCSBegining.Size = new System.Drawing.Size(100, 20);
            this.textBoxCSBegining.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre de caisses depuis le démarrage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nombre de caisses depuis le démarrage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Taux défaut heure";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Taux défaut heure";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Taux défaut depuis démarrage";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Taux défaut depuis démarrage";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 296);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.typeA.ResumeLayout(false);
            this.typeA.PerformLayout();
            this.typeB.ResumeLayout(false);
            this.typeB.PerformLayout();
            this.typeC.ResumeLayout(false);
            this.typeC.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage typeA;
        private System.Windows.Forms.TabPage typeB;
        private System.Windows.Forms.TabPage typeC;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem démarrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrêterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem continuerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TextBox textBoxFaultsRateSinceBegining;
        private System.Windows.Forms.TextBox textBoxFaultsRateOneHour;
        private System.Windows.Forms.TextBox textBoxNbrOfBoxes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBSBegining;
        private System.Windows.Forms.TextBox textBoxBDefaultHour;
        private System.Windows.Forms.TextBox textBoxBNbrBoxes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCSBegining;
        private System.Windows.Forms.TextBox textBoxCDefaultHour;
        private System.Windows.Forms.TextBox textBoxCNbrBoxes;
    }
}

