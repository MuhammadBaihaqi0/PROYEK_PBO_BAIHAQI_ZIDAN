namespace Proyek_besar_pbo_baihaqi_zidan.View
{
    partial class FormTopUpGame
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.flowGames = new System.Windows.Forms.FlowLayoutPanel();
            this.crdML = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbML = new System.Windows.Forms.PictureBox();
            this.crdFF = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pbFF = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pbPUBG = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            this.flowGames.SuspendLayout();
            this.crdML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbML)).BeginInit();
            this.crdFF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFF)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPUBG)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 100);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(205, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TOP UP GAME";
            // 
            // flowGames
            // 
            this.flowGames.AutoScroll = true;
            this.flowGames.BackColor = System.Drawing.Color.Transparent;
            this.flowGames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowGames.Controls.Add(this.crdML);
            this.flowGames.Controls.Add(this.crdFF);
            this.flowGames.Controls.Add(this.panel2);
            this.flowGames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flowGames.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowGames.Location = new System.Drawing.Point(0, 100);
            this.flowGames.Name = "flowGames";
            this.flowGames.Size = new System.Drawing.Size(800, 347);
            this.flowGames.TabIndex = 1;
            this.flowGames.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowGames_Paint);
            // 
            // crdML
            // 
            this.crdML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(63)))), ((int)(((byte)(92)))));
            this.crdML.Controls.Add(this.label1);
            this.crdML.Controls.Add(this.pbML);
            this.crdML.Location = new System.Drawing.Point(3, 3);
            this.crdML.Name = "crdML";
            this.crdML.Size = new System.Drawing.Size(130, 132);
            this.crdML.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mobile Lagends";
            // 
            // pbML
            // 
            this.pbML.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbML.ErrorImage = global::Proyek_besar_pbo_baihaqi_zidan.Properties.Resources.ml;
            this.pbML.Location = new System.Drawing.Point(0, 0);
            this.pbML.Name = "pbML";
            this.pbML.Size = new System.Drawing.Size(130, 132);
            this.pbML.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbML.TabIndex = 0;
            this.pbML.TabStop = false;
            this.pbML.Click += new System.EventHandler(this.pbML_Click_1);
            // 
            // crdFF
            // 
            this.crdFF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(63)))), ((int)(((byte)(92)))));
            this.crdFF.Controls.Add(this.label2);
            this.crdFF.Controls.Add(this.pbFF);
            this.crdFF.Location = new System.Drawing.Point(139, 3);
            this.crdFF.Name = "crdFF";
            this.crdFF.Size = new System.Drawing.Size(130, 132);
            this.crdFF.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Free Fire";
            // 
            // pbFF
            // 
            this.pbFF.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbFF.ErrorImage = global::Proyek_besar_pbo_baihaqi_zidan.Properties.Resources.ff;
            this.pbFF.Location = new System.Drawing.Point(0, 0);
            this.pbFF.Name = "pbFF";
            this.pbFF.Size = new System.Drawing.Size(130, 132);
            this.pbFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFF.TabIndex = 0;
            this.pbFF.TabStop = false;
            this.pbFF.Click += new System.EventHandler(this.pbFF_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(63)))), ((int)(((byte)(92)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pbPUBG);
            this.panel2.Location = new System.Drawing.Point(275, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 132);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "PUBG";
            // 
            // pbPUBG
            // 
            this.pbPUBG.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbPUBG.ErrorImage = global::Proyek_besar_pbo_baihaqi_zidan.Properties.Resources.pubg;
            this.pbPUBG.Location = new System.Drawing.Point(0, 0);
            this.pbPUBG.Name = "pbPUBG";
            this.pbPUBG.Size = new System.Drawing.Size(130, 132);
            this.pbPUBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPUBG.TabIndex = 1;
            this.pbPUBG.TabStop = false;
            this.pbPUBG.Click += new System.EventHandler(this.pbPUBG_Click_1);
            // 
            // FormTopUpGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowGames);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTopUpGame";
            this.Text = "FormTopUpGame";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.flowGames.ResumeLayout(false);
            this.crdML.ResumeLayout(false);
            this.crdML.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbML)).EndInit();
            this.crdFF.ResumeLayout(false);
            this.crdFF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFF)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPUBG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.FlowLayoutPanel flowGames;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel crdML;
        private System.Windows.Forms.PictureBox pbML;
        private System.Windows.Forms.Panel crdFF;
        private System.Windows.Forms.PictureBox pbFF;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbPUBG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}