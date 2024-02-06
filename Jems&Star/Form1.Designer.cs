namespace Jems_Star
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timStartBackground = new System.Windows.Forms.Timer(this.components);
            this.picStratMyAir = new System.Windows.Forms.PictureBox();
            this.timStartLeftt = new System.Windows.Forms.Timer(this.components);
            this.timStartTop = new System.Windows.Forms.Timer(this.components);
            this.timStartRight = new System.Windows.Forms.Timer(this.components);
            this.timStartDown = new System.Windows.Forms.Timer(this.components);
            this.timStartBullet = new System.Windows.Forms.Timer(this.components);
            this.timStratBadGuys = new System.Windows.Forms.Timer(this.components);
            this.timStratBadBullet = new System.Windows.Forms.Timer(this.components);
            this.lblStartOver = new System.Windows.Forms.Label();
            this.timMisson = new System.Windows.Forms.Timer(this.components);
            this.lblMitionTimeValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picStratMyAir)).BeginInit();
            this.SuspendLayout();
            // 
            // timStartBackground
            // 
            this.timStartBackground.Enabled = true;
            this.timStartBackground.Interval = 10;
            this.timStartBackground.Tick += new System.EventHandler(this.timStartBackground_Tick);
            // 
            // picStratMyAir
            // 
            this.picStratMyAir.Image = ((System.Drawing.Image)(resources.GetObject("picStratMyAir.Image")));
            this.picStratMyAir.Location = new System.Drawing.Point(595, 564);
            this.picStratMyAir.Name = "picStratMyAir";
            this.picStratMyAir.Size = new System.Drawing.Size(80, 80);
            this.picStratMyAir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStratMyAir.TabIndex = 0;
            this.picStratMyAir.TabStop = false;
            // 
            // timStartLeftt
            // 
            this.timStartLeftt.Interval = 5;
            this.timStartLeftt.Tick += new System.EventHandler(this.timStartLeftt_Tick);
            // 
            // timStartTop
            // 
            this.timStartTop.Interval = 5;
            this.timStartTop.Tick += new System.EventHandler(this.timStartTop_Tick);
            // 
            // timStartRight
            // 
            this.timStartRight.Interval = 5;
            this.timStartRight.Tick += new System.EventHandler(this.timStartRight_Tick);
            // 
            // timStartDown
            // 
            this.timStartDown.Interval = 5;
            this.timStartDown.Tick += new System.EventHandler(this.timStartDown_Tick);
            // 
            // timStartBullet
            // 
            this.timStartBullet.Enabled = true;
            this.timStartBullet.Interval = 20;
            this.timStartBullet.Tick += new System.EventHandler(this.timStartBullet_Tick);
            // 
            // timStratBadGuys
            // 
            this.timStratBadGuys.Enabled = true;
            this.timStratBadGuys.Tick += new System.EventHandler(this.timStratBadGuys_Tick);
            // 
            // timStratBadBullet
            // 
            this.timStratBadBullet.Enabled = true;
            this.timStratBadBullet.Interval = 20;
            this.timStratBadBullet.Tick += new System.EventHandler(this.timStratBadBullet_Tick);
            // 
            // lblStartOver
            // 
            this.lblStartOver.AutoSize = true;
            this.lblStartOver.Font = new System.Drawing.Font("Modern No. 20", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartOver.ForeColor = System.Drawing.Color.Red;
            this.lblStartOver.Location = new System.Drawing.Point(435, 259);
            this.lblStartOver.Name = "lblStartOver";
            this.lblStartOver.Size = new System.Drawing.Size(396, 83);
            this.lblStartOver.TabIndex = 1;
            this.lblStartOver.Text = "Game Over";
            this.lblStartOver.Visible = false;
            this.lblStartOver.Click += new System.EventHandler(this.label1_Click);
            // 
            // timMisson
            // 
            this.timMisson.Enabled = true;
            this.timMisson.Interval = 1000;
            this.timMisson.Tick += new System.EventHandler(this.timMisson_Tick);
            // 
            // lblMitionTimeValue
            // 
            this.lblMitionTimeValue.AutoSize = true;
            this.lblMitionTimeValue.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMitionTimeValue.ForeColor = System.Drawing.Color.Red;
            this.lblMitionTimeValue.Location = new System.Drawing.Point(1186, 9);
            this.lblMitionTimeValue.Name = "lblMitionTimeValue";
            this.lblMitionTimeValue.Size = new System.Drawing.Size(0, 25);
            this.lblMitionTimeValue.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1282, 733);
            this.Controls.Add(this.lblMitionTimeValue);
            this.Controls.Add(this.lblStartOver);
            this.Controls.Add(this.picStratMyAir);
            this.Font = new System.Drawing.Font("Modern No. 20", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1300, 780);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jems & Star GUN Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picStratMyAir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timStartBackground;
        private System.Windows.Forms.PictureBox picStratMyAir;
        private System.Windows.Forms.Timer timStartLeftt;
        private System.Windows.Forms.Timer timStartTop;
        private System.Windows.Forms.Timer timStartRight;
        private System.Windows.Forms.Timer timStartDown;
        private System.Windows.Forms.Timer timStartBullet;
        private System.Windows.Forms.Timer timStratBadGuys;
        private System.Windows.Forms.Timer timStratBadBullet;
        private System.Windows.Forms.Label lblStartOver;
        private System.Windows.Forms.Timer timMisson;
        private System.Windows.Forms.Label lblMitionTimeValue;
    }
}

