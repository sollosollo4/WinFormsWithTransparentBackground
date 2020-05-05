namespace WinFormsWithTransparentBackground
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MovingPanel = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PicturePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NC_Panel = new System.Windows.Forms.Panel();
            this.NWSE_Panel = new System.Windows.Forms.Panel();
            this.WE_Panel = new System.Windows.Forms.Panel();
            this.SN_Panel = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.MovingPanel.SuspendLayout();
            this.PicturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.MovingPanel);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Location = new System.Drawing.Point(256, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(715, 510);
            this.MainPanel.TabIndex = 0;
            // 
            // MovingPanel
            // 
            this.MovingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovingPanel.BackColor = System.Drawing.Color.Transparent;
            this.MovingPanel.Controls.Add(this.MinimizeButton);
            this.MovingPanel.Controls.Add(this.CloseButton);
            this.MovingPanel.Location = new System.Drawing.Point(0, 0);
            this.MovingPanel.Name = "MovingPanel";
            this.MovingPanel.Size = new System.Drawing.Size(715, 31);
            this.MovingPanel.TabIndex = 1;
            this.MovingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovingPanel_MouseDown);
            this.MovingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MovingPanel_MouseMove);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimizeButton.Location = new System.Drawing.Point(651, -1);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(32, 32);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.Text = "—";
            this.MinimizeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.AutoSize = true;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(683, -1);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(32, 32);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(201, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Активная часть приложения";
            // 
            // PicturePanel
            // 
            this.PicturePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicturePanel.Controls.Add(this.pictureBox1);
            this.PicturePanel.Location = new System.Drawing.Point(0, 0);
            this.PicturePanel.Margin = new System.Windows.Forms.Padding(0);
            this.PicturePanel.MinimumSize = new System.Drawing.Size(256, 511);
            this.PicturePanel.Name = "PicturePanel";
            this.PicturePanel.Size = new System.Drawing.Size(256, 511);
            this.PicturePanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WinFormsWithTransparentBackground.Properties.Resources.backg;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 511);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NC_Panel
            // 
            this.NC_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NC_Panel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NC_Panel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.NC_Panel.Location = new System.Drawing.Point(254, 510);
            this.NC_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.NC_Panel.Name = "NC_Panel";
            this.NC_Panel.Size = new System.Drawing.Size(714, 2);
            this.NC_Panel.TabIndex = 2;
            this.NC_Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SizeChanged_Panel_MouseMove);
            // 
            // NWSE_Panel
            // 
            this.NWSE_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NWSE_Panel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NWSE_Panel.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.NWSE_Panel.Location = new System.Drawing.Point(968, 509);
            this.NWSE_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.NWSE_Panel.Name = "NWSE_Panel";
            this.NWSE_Panel.Size = new System.Drawing.Size(3, 3);
            this.NWSE_Panel.TabIndex = 3;
            this.NWSE_Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SizeChanged_Panel_MouseMove);
            // 
            // WE_Panel
            // 
            this.WE_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WE_Panel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WE_Panel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.WE_Panel.Location = new System.Drawing.Point(969, 0);
            this.WE_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.WE_Panel.Name = "WE_Panel";
            this.WE_Panel.Size = new System.Drawing.Size(2, 509);
            this.WE_Panel.TabIndex = 4;
            this.WE_Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SizeChanged_Panel_MouseMove);
            // 
            // SN_Panel
            // 
            this.SN_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SN_Panel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SN_Panel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SN_Panel.Location = new System.Drawing.Point(254, -1);
            this.SN_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.SN_Panel.Name = "SN_Panel";
            this.SN_Panel.Size = new System.Drawing.Size(715, 2);
            this.SN_Panel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 511);
            this.Controls.Add(this.SN_Panel);
            this.Controls.Add(this.WE_Panel);
            this.Controls.Add(this.NWSE_Panel);
            this.Controls.Add(this.NC_Panel);
            this.Controls.Add(this.PicturePanel);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(970, 511);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.MovingPanel.ResumeLayout(false);
            this.MovingPanel.PerformLayout();
            this.PicturePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel MovingPanel;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel PicturePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel NC_Panel;
        private System.Windows.Forms.Panel NWSE_Panel;
        private System.Windows.Forms.Panel WE_Panel;
        private System.Windows.Forms.Panel SN_Panel;
    }
}

