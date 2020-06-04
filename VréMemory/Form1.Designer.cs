namespace VréMemory
{
    partial class FormMemory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMemory));
            this.nb_coups = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Jouer = new System.Windows.Forms.Button();
            this.tlpTapisDeCartes = new System.Windows.Forms.TableLayoutPanel();
            this.pb_05 = new System.Windows.Forms.PictureBox();
            this.pb_06 = new System.Windows.Forms.PictureBox();
            this.pb_07 = new System.Windows.Forms.PictureBox();
            this.pb_08 = new System.Windows.Forms.PictureBox();
            this.pb_01 = new System.Windows.Forms.PictureBox();
            this.pb_02 = new System.Windows.Forms.PictureBox();
            this.pb_03 = new System.Windows.Forms.PictureBox();
            this.pb_04 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Retourner = new System.Windows.Forms.Button();
            this.btn_Distribuer = new System.Windows.Forms.Button();
            this.ilSabotDeCartes = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lab_score = new System.Windows.Forms.Label();
            this.tlpTapisDeCartes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_08)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_04)).BeginInit();
            this.SuspendLayout();
            // 
            // nb_coups
            // 
            this.nb_coups.AutoSize = true;
            this.nb_coups.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nb_coups.Location = new System.Drawing.Point(193, 380);
            this.nb_coups.Name = "nb_coups";
            this.nb_coups.Size = new System.Drawing.Size(0, 26);
            this.nb_coups.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 26);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre de coups :";
            // 
            // btn_Jouer
            // 
            this.btn_Jouer.Location = new System.Drawing.Point(345, 375);
            this.btn_Jouer.Name = "btn_Jouer";
            this.btn_Jouer.Size = new System.Drawing.Size(104, 31);
            this.btn_Jouer.TabIndex = 18;
            this.btn_Jouer.Text = "Jouer";
            this.btn_Jouer.UseVisualStyleBackColor = true;
            this.btn_Jouer.Click += new System.EventHandler(this.btn_Jouer_Click);
            // 
            // tlpTapisDeCartes
            // 
            this.tlpTapisDeCartes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlpTapisDeCartes.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tlpTapisDeCartes.ColumnCount = 4;
            this.tlpTapisDeCartes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTapisDeCartes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTapisDeCartes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTapisDeCartes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTapisDeCartes.Controls.Add(this.pb_05, 0, 1);
            this.tlpTapisDeCartes.Controls.Add(this.pb_06, 0, 1);
            this.tlpTapisDeCartes.Controls.Add(this.pb_07, 0, 1);
            this.tlpTapisDeCartes.Controls.Add(this.pb_08, 0, 1);
            this.tlpTapisDeCartes.Controls.Add(this.pb_01, 0, 0);
            this.tlpTapisDeCartes.Controls.Add(this.pb_02, 1, 0);
            this.tlpTapisDeCartes.Controls.Add(this.pb_03, 2, 0);
            this.tlpTapisDeCartes.Controls.Add(this.pb_04, 3, 0);
            this.tlpTapisDeCartes.Location = new System.Drawing.Point(179, 131);
            this.tlpTapisDeCartes.Name = "tlpTapisDeCartes";
            this.tlpTapisDeCartes.RowCount = 2;
            this.tlpTapisDeCartes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTapisDeCartes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTapisDeCartes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTapisDeCartes.Size = new System.Drawing.Size(440, 220);
            this.tlpTapisDeCartes.TabIndex = 17;
            // 
            // pb_05
            // 
            this.pb_05.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_05.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_05.Location = new System.Drawing.Point(6, 114);
            this.pb_05.Name = "pb_05";
            this.pb_05.Size = new System.Drawing.Size(100, 100);
            this.pb_05.TabIndex = 9;
            this.pb_05.TabStop = false;
            this.pb_05.Tag = "5";
            this.pb_05.Click += new System.EventHandler(this.pb_05_Click);
            // 
            // pb_06
            // 
            this.pb_06.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_06.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_06.Location = new System.Drawing.Point(115, 114);
            this.pb_06.Name = "pb_06";
            this.pb_06.Size = new System.Drawing.Size(100, 100);
            this.pb_06.TabIndex = 8;
            this.pb_06.TabStop = false;
            this.pb_06.Tag = "6";
            this.pb_06.Click += new System.EventHandler(this.pb_06_Click);
            // 
            // pb_07
            // 
            this.pb_07.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_07.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_07.Location = new System.Drawing.Point(224, 114);
            this.pb_07.Name = "pb_07";
            this.pb_07.Size = new System.Drawing.Size(100, 100);
            this.pb_07.TabIndex = 7;
            this.pb_07.TabStop = false;
            this.pb_07.Tag = "7";
            this.pb_07.Click += new System.EventHandler(this.pb_07_Click);
            // 
            // pb_08
            // 
            this.pb_08.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_08.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_08.Location = new System.Drawing.Point(333, 114);
            this.pb_08.Name = "pb_08";
            this.pb_08.Size = new System.Drawing.Size(100, 100);
            this.pb_08.TabIndex = 6;
            this.pb_08.TabStop = false;
            this.pb_08.Tag = "8";
            this.pb_08.Click += new System.EventHandler(this.pb_08_Click);
            // 
            // pb_01
            // 
            this.pb_01.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_01.Location = new System.Drawing.Point(6, 6);
            this.pb_01.Name = "pb_01";
            this.pb_01.Size = new System.Drawing.Size(100, 99);
            this.pb_01.TabIndex = 0;
            this.pb_01.TabStop = false;
            this.pb_01.Tag = "1";
            this.pb_01.Click += new System.EventHandler(this.pb_01_Click);
            // 
            // pb_02
            // 
            this.pb_02.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_02.Location = new System.Drawing.Point(115, 6);
            this.pb_02.Name = "pb_02";
            this.pb_02.Size = new System.Drawing.Size(100, 99);
            this.pb_02.TabIndex = 5;
            this.pb_02.TabStop = false;
            this.pb_02.Tag = "2";
            this.pb_02.Click += new System.EventHandler(this.pb_02_Click);
            // 
            // pb_03
            // 
            this.pb_03.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_03.Location = new System.Drawing.Point(224, 6);
            this.pb_03.Name = "pb_03";
            this.pb_03.Size = new System.Drawing.Size(100, 99);
            this.pb_03.TabIndex = 10;
            this.pb_03.TabStop = false;
            this.pb_03.Tag = "3";
            this.pb_03.Click += new System.EventHandler(this.pb_03_Click);
            // 
            // pb_04
            // 
            this.pb_04.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_04.Location = new System.Drawing.Point(333, 6);
            this.pb_04.Name = "pb_04";
            this.pb_04.Size = new System.Drawing.Size(100, 99);
            this.pb_04.TabIndex = 11;
            this.pb_04.TabStop = false;
            this.pb_04.Tag = "4";
            this.pb_04.Click += new System.EventHandler(this.pb_04_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(225, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 60);
            this.label1.TabIndex = 23;
            this.label1.Text = "Jeu du Memory";
            // 
            // btn_Retourner
            // 
            this.btn_Retourner.Location = new System.Drawing.Point(450, 93);
            this.btn_Retourner.Name = "btn_Retourner";
            this.btn_Retourner.Size = new System.Drawing.Size(107, 32);
            this.btn_Retourner.TabIndex = 22;
            this.btn_Retourner.Text = "Retourner";
            this.btn_Retourner.UseVisualStyleBackColor = true;
            this.btn_Retourner.Click += new System.EventHandler(this.btn_Retourner_Click);
            // 
            // btn_Distribuer
            // 
            this.btn_Distribuer.Location = new System.Drawing.Point(235, 93);
            this.btn_Distribuer.Name = "btn_Distribuer";
            this.btn_Distribuer.Size = new System.Drawing.Size(107, 32);
            this.btn_Distribuer.TabIndex = 21;
            this.btn_Distribuer.Text = "Distribuer";
            this.btn_Distribuer.UseVisualStyleBackColor = true;
            this.btn_Distribuer.Click += new System.EventHandler(this.btn_Distribuer_Click);
            // 
            // ilSabotDeCartes
            // 
            this.ilSabotDeCartes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilSabotDeCartes.ImageStream")));
            this.ilSabotDeCartes.TransparentColor = System.Drawing.Color.Transparent;
            this.ilSabotDeCartes.Images.SetKeyName(0, "DosCarte.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(1, "Dialogue.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(2, "Diplome.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(3, "FemmeAffaire.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(4, "FemmeBatiment.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(5, "FemmeBlanche.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(6, "FemmeBleue.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(7, "FemmeCasque.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(8, "FemmeCuisinier.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(9, "FemmeInformaticienBrune.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(10, "FemmeInformaticienChatain.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(11, "FemmeJournal.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(12, "FemmeMedecin.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(13, "FemmeMegaphone.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(14, "FemmeOrange.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(15, "FemmePhotographe.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(16, "FemmePoliciere.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(17, "HommeAffaire.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(18, "HommeBatiment.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(19, "HommeBleu.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(20, "HommeCasque.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(21, "HommeCuisinier.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(22, "HommeGarde.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(23, "HommeInformaticienBrun.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(24, "HommeInformaticienChatain.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(25, "HommeJournal.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(26, "HommeMarron.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(27, "HommeMedecin.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(28, "HommeMegaphone.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(29, "HommeOrange.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(30, "HommePhotographe.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(31, "HommePolicier.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(32, "Joker.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(33, "LivreurPizza.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(34, "MarinMousse.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(35, "MarinOfficier.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(36, "MarinPompon.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(37, "Mecanicien.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(38, "Pilote.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(39, "Pompier.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(40, "Serveur.jpg");
            // 
            // timer1
            // 
            this.timer1.Interval = 15000;
            this.timer1.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 26);
            this.label3.TabIndex = 24;
            this.label3.Text = "Points :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Paire juste : +100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Paire fausse : - 50";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(632, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 26);
            this.label6.TabIndex = 27;
            this.label6.Text = "Score :";
            // 
            // lab_score
            // 
            this.lab_score.AutoSize = true;
            this.lab_score.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lab_score.Location = new System.Drawing.Point(700, 57);
            this.lab_score.Name = "lab_score";
            this.lab_score.Size = new System.Drawing.Size(0, 26);
            this.lab_score.TabIndex = 28;
            // 
            // FormMemory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 461);
            this.Controls.Add(this.lab_score);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nb_coups);
            this.Controls.Add(this.btn_Retourner);
            this.Controls.Add(this.btn_Distribuer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Jouer);
            this.Controls.Add(this.tlpTapisDeCartes);
            this.Name = "FormMemory";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMemory_Load);
            this.tlpTapisDeCartes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_08)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_04)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nb_coups;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Jouer;
        private System.Windows.Forms.TableLayoutPanel tlpTapisDeCartes;
        private System.Windows.Forms.PictureBox pb_05;
        private System.Windows.Forms.PictureBox pb_06;
        private System.Windows.Forms.PictureBox pb_07;
        private System.Windows.Forms.PictureBox pb_08;
        private System.Windows.Forms.PictureBox pb_01;
        private System.Windows.Forms.PictureBox pb_02;
        private System.Windows.Forms.PictureBox pb_03;
        private System.Windows.Forms.PictureBox pb_04;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Retourner;
        private System.Windows.Forms.Button btn_Distribuer;
        private System.Windows.Forms.ImageList ilSabotDeCartes;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lab_score;
    }
}

