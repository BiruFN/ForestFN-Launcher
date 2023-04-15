namespace ForestFN_Launcher
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.HybridLaunch = new Guna.UI2.WinForms.Guna2Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PrivateLaunch = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.UserIcon = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.UserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.Login = new Guna.UI2.WinForms.Guna2Button();
            this.PrivateName = new Guna.UI2.WinForms.Guna2TextBox();
            this.HybridName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.guna2TabControl1.Controls.Add(this.tabPage1);
            this.guna2TabControl1.Controls.Add(this.tabPage2);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(200, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(13, 88);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(709, 311);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(200, 40);
            this.guna2TabControl1.TabIndex = 2;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabPage1.Controls.Add(this.HybridName);
            this.tabPage1.Controls.Add(this.HybridLaunch);
            this.tabPage1.Location = new System.Drawing.Point(204, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(501, 303);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hybrid Server";
            // 
            // HybridLaunch
            // 
            this.HybridLaunch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HybridLaunch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HybridLaunch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HybridLaunch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HybridLaunch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HybridLaunch.ForeColor = System.Drawing.Color.White;
            this.HybridLaunch.Location = new System.Drawing.Point(150, 200);
            this.HybridLaunch.Name = "HybridLaunch";
            this.HybridLaunch.Size = new System.Drawing.Size(200, 38);
            this.HybridLaunch.TabIndex = 11;
            this.HybridLaunch.Text = "Hybrid Launch";
            this.HybridLaunch.Click += new System.EventHandler(this.HybridLaunch_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabPage2.Controls.Add(this.PrivateName);
            this.tabPage2.Controls.Add(this.PrivateLaunch);
            this.tabPage2.Location = new System.Drawing.Point(204, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(501, 303);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Private Server";
            // 
            // PrivateLaunch
            // 
            this.PrivateLaunch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PrivateLaunch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PrivateLaunch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PrivateLaunch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PrivateLaunch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PrivateLaunch.ForeColor = System.Drawing.Color.White;
            this.PrivateLaunch.Location = new System.Drawing.Point(150, 200);
            this.PrivateLaunch.Name = "PrivateLaunch";
            this.PrivateLaunch.Size = new System.Drawing.Size(200, 38);
            this.PrivateLaunch.TabIndex = 12;
            this.PrivateLaunch.Text = "Private Launch";
            this.PrivateLaunch.Click += new System.EventHandler(this.PrivateLaunch_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(13, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(200, 70);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 3;
            this.guna2PictureBox1.TabStop = false;
            // 
            // UserIcon
            // 
            this.UserIcon.FillColor = System.Drawing.Color.Transparent;
            this.UserIcon.ImageRotate = 0F;
            this.UserIcon.Location = new System.Drawing.Point(652, 12);
            this.UserIcon.Name = "UserIcon";
            this.UserIcon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.UserIcon.Size = new System.Drawing.Size(70, 70);
            this.UserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserIcon.TabIndex = 6;
            this.UserIcon.TabStop = false;
            // 
            // UserName
            // 
            this.UserName.BorderColor = System.Drawing.Color.White;
            this.UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserName.DefaultText = "";
            this.UserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.UserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UserName.ForeColor = System.Drawing.Color.White;
            this.UserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserName.Location = new System.Drawing.Point(445, 56);
            this.UserName.Name = "UserName";
            this.UserName.PasswordChar = '\0';
            this.UserName.PlaceholderText = "";
            this.UserName.ReadOnly = true;
            this.UserName.SelectedText = "";
            this.UserName.Size = new System.Drawing.Size(200, 26);
            this.UserName.TabIndex = 7;
            // 
            // Login
            // 
            this.Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Login.FillColor = System.Drawing.Color.Green;
            this.Login.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Location = new System.Drawing.Point(545, 25);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(100, 26);
            this.Login.TabIndex = 11;
            this.Login.Text = "Login";
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // PrivateName
            // 
            this.PrivateName.BorderColor = System.Drawing.Color.White;
            this.PrivateName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PrivateName.DefaultText = "";
            this.PrivateName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PrivateName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PrivateName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PrivateName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PrivateName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.PrivateName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PrivateName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PrivateName.ForeColor = System.Drawing.Color.White;
            this.PrivateName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PrivateName.Location = new System.Drawing.Point(130, 155);
            this.PrivateName.Name = "PrivateName";
            this.PrivateName.PasswordChar = '\0';
            this.PrivateName.PlaceholderText = "UserName";
            this.PrivateName.SelectedText = "";
            this.PrivateName.Size = new System.Drawing.Size(240, 26);
            this.PrivateName.TabIndex = 13;
            // 
            // HybridName
            // 
            this.HybridName.BorderColor = System.Drawing.Color.White;
            this.HybridName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HybridName.DefaultText = "";
            this.HybridName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.HybridName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.HybridName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.HybridName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.HybridName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.HybridName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HybridName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HybridName.ForeColor = System.Drawing.Color.White;
            this.HybridName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HybridName.Location = new System.Drawing.Point(130, 155);
            this.HybridName.Name = "HybridName";
            this.HybridName.PasswordChar = '\0';
            this.HybridName.PlaceholderText = "UserName";
            this.HybridName.ReadOnly = true;
            this.HybridName.SelectedText = "";
            this.HybridName.Size = new System.Drawing.Size(240, 26);
            this.HybridName.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.UserIcon);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2TabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "ForestFN｜dsc.gg/birufn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox UserIcon;
        private Guna.UI2.WinForms.Guna2TextBox UserName;
        private Guna.UI2.WinForms.Guna2Button HybridLaunch;
        private Guna.UI2.WinForms.Guna2Button Login;
        private Guna.UI2.WinForms.Guna2Button PrivateLaunch;
        private Guna.UI2.WinForms.Guna2TextBox PrivateName;
        private Guna.UI2.WinForms.Guna2TextBox HybridName;
    }
}

