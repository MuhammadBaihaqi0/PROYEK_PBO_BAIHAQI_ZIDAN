namespace Proyek_besar_pbo_baihaqi_zidan.View
{
    partial class FormItem
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
            this.btnBeli = new System.Windows.Forms.Button();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.tbZonaID = new System.Windows.Forms.TextBox();
            this.flowItem = new System.Windows.Forms.FlowLayoutPanel();
            this.lblJudul = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblZona = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBeli
            // 
            this.btnBeli.Location = new System.Drawing.Point(355, 363);
            this.btnBeli.Name = "btnBeli";
            this.btnBeli.Size = new System.Drawing.Size(75, 31);
            this.btnBeli.TabIndex = 2;
            this.btnBeli.Text = "Beli";
            this.btnBeli.UseVisualStyleBackColor = true;
            // 
            // tbUserID
            // 
            this.tbUserID.Location = new System.Drawing.Point(110, 42);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.Size = new System.Drawing.Size(169, 26);
            this.tbUserID.TabIndex = 6;
            // 
            // tbZonaID
            // 
            this.tbZonaID.Location = new System.Drawing.Point(410, 45);
            this.tbZonaID.Name = "tbZonaID";
            this.tbZonaID.Size = new System.Drawing.Size(148, 26);
            this.tbZonaID.TabIndex = 7;
            // 
            // flowItem
            // 
            this.flowItem.AutoScroll = true;
            this.flowItem.Location = new System.Drawing.Point(0, 106);
            this.flowItem.Name = "flowItem";
            this.flowItem.Size = new System.Drawing.Size(1237, 343);
            this.flowItem.TabIndex = 3;
            this.flowItem.Paint += new System.Windows.Forms.PaintEventHandler(this.flowItem_Paint);
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(3, 0);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(336, 32);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Top Up Mobile Legends";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.lblUserID);
            this.panel1.Controls.Add(this.tbZonaID);
            this.panel1.Controls.Add(this.lblZona);
            this.panel1.Controls.Add(this.tbUserID);
            this.panel1.Controls.Add(this.lblJudul);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1237, 100);
            this.panel1.TabIndex = 8;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(20, 45);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(73, 20);
            this.lblUserID.TabIndex = 9;
            this.lblUserID.Text = "ID Player";
            // 
            // lblZona
            // 
            this.lblZona.AutoSize = true;
            this.lblZona.Location = new System.Drawing.Point(314, 45);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(76, 20);
            this.lblZona.TabIndex = 11;
            this.lblZona.Text = "Server ID";
            // 
            // FormItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowItem);
            this.Controls.Add(this.btnBeli);
            this.ForeColor = System.Drawing.Color.White;
            this.Location = new System.Drawing.Point(20, 10);
            this.Name = "FormItem";
            this.Text = "FormItem";
            this.Load += new System.EventHandler(this.FormItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBeli;
        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.TextBox tbZonaID;
        private System.Windows.Forms.FlowLayoutPanel flowItem;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblZona;
    }
}