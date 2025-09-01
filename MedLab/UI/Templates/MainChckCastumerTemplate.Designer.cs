namespace DiplomProgramm
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
            this.components = new System.ComponentModel.Container();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.Label_NameProgramm = new System.Windows.Forms.Label();
            this.PannelMainMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.ClientBtn = new Guna.UI2.WinForms.Guna2Button();
            this.HomeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.MinimazedBtn = new Guna.UI2.WinForms.Guna2Button();
            this.MaximizedBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CloseAppBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.PannelMainMenu.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(25, 25);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(950, 15);
            this.guna2Separator1.TabIndex = 0;
            this.guna2Separator1.Click += new System.EventHandler(this.guna2Separator1_Click);
            // 
            // Label_NameProgramm
            // 
            this.Label_NameProgramm.AutoSize = true;
            this.Label_NameProgramm.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_NameProgramm.Location = new System.Drawing.Point(22, 9);
            this.Label_NameProgramm.Name = "Label_NameProgramm";
            this.Label_NameProgramm.Size = new System.Drawing.Size(130, 18);
            this.Label_NameProgramm.TabIndex = 1;
            this.Label_NameProgramm.Text = "MedLab Assistant";
            this.Label_NameProgramm.Click += new System.EventHandler(this.Label_NameProgramm_Click);
            // 
            // PannelMainMenu
            // 
            this.PannelMainMenu.Controls.Add(this.guna2Button1);
            this.PannelMainMenu.Controls.Add(this.ClientBtn);
            this.PannelMainMenu.Controls.Add(this.HomeBtn);
            this.PannelMainMenu.Location = new System.Drawing.Point(25, 40);
            this.PannelMainMenu.Name = "PannelMainMenu";
            this.PannelMainMenu.ShadowDecoration.Parent = this.PannelMainMenu;
            this.PannelMainMenu.Size = new System.Drawing.Size(950, 25);
            this.PannelMainMenu.TabIndex = 5;
            this.PannelMainMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PannelMainMenu_Paint);
            // 
            // ClientBtn
            // 
            this.ClientBtn.BorderColor = System.Drawing.Color.Transparent;
            this.ClientBtn.CheckedState.Parent = this.ClientBtn;
            this.ClientBtn.CustomImages.Parent = this.ClientBtn;
            this.ClientBtn.FillColor = System.Drawing.Color.Transparent;
            this.ClientBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientBtn.ForeColor = System.Drawing.Color.Black;
            this.ClientBtn.HoverState.Parent = this.ClientBtn;
            this.ClientBtn.Location = new System.Drawing.Point(110, 0);
            this.ClientBtn.Name = "ClientBtn";
            this.ClientBtn.ShadowDecoration.Parent = this.ClientBtn;
            this.ClientBtn.Size = new System.Drawing.Size(113, 25);
            this.ClientBtn.TabIndex = 1;
            this.ClientBtn.Text = "Клиенты";
            this.ClientBtn.Click += new System.EventHandler(this.ClientBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.BorderColor = System.Drawing.Color.Transparent;
            this.HomeBtn.CheckedState.Parent = this.HomeBtn;
            this.HomeBtn.CustomImages.Parent = this.HomeBtn;
            this.HomeBtn.FillColor = System.Drawing.Color.Transparent;
            this.HomeBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HomeBtn.ForeColor = System.Drawing.Color.Black;
            this.HomeBtn.HoverState.Parent = this.HomeBtn;
            this.HomeBtn.Location = new System.Drawing.Point(0, 0);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.ShadowDecoration.Parent = this.HomeBtn;
            this.HomeBtn.Size = new System.Drawing.Size(113, 25);
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.Text = "Главная";
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.Controls.Add(this.MinimazedBtn);
            this.guna2Panel1.Controls.Add(this.MaximizedBtn);
            this.guna2Panel1.Controls.Add(this.CloseAppBtn);
            this.guna2Panel1.Location = new System.Drawing.Point(905, 7);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(70, 20);
            this.guna2Panel1.TabIndex = 6;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // MinimazedBtn
            // 
            this.MinimazedBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MinimazedBtn.BorderRadius = 4;
            this.MinimazedBtn.CheckedState.Parent = this.MinimazedBtn;
            this.MinimazedBtn.CustomImages.Parent = this.MinimazedBtn;
            this.MinimazedBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(74)))), ((int)(((byte)(95)))));
            this.MinimazedBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimazedBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MinimazedBtn.HoverState.Parent = this.MinimazedBtn;
            this.MinimazedBtn.Location = new System.Drawing.Point(0, 0);
            this.MinimazedBtn.Name = "MinimazedBtn";
            this.MinimazedBtn.ShadowDecoration.Parent = this.MinimazedBtn;
            this.MinimazedBtn.Size = new System.Drawing.Size(20, 20);
            this.MinimazedBtn.TabIndex = 7;
            this.MinimazedBtn.Text = "_";
            this.MinimazedBtn.TextOffset = new System.Drawing.Point(0, -5);
            this.MinimazedBtn.Click += new System.EventHandler(this.MinimazedBtn_Click);
            // 
            // MaximizedBtn
            // 
            this.MaximizedBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizedBtn.BorderRadius = 4;
            this.MaximizedBtn.CheckedState.Parent = this.MaximizedBtn;
            this.MaximizedBtn.CustomImages.Parent = this.MaximizedBtn;
            this.MaximizedBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(74)))), ((int)(((byte)(95)))));
            this.MaximizedBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizedBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MaximizedBtn.HoverState.Parent = this.MaximizedBtn;
            this.MaximizedBtn.Location = new System.Drawing.Point(25, 0);
            this.MaximizedBtn.Name = "MaximizedBtn";
            this.MaximizedBtn.ShadowDecoration.Parent = this.MaximizedBtn;
            this.MaximizedBtn.Size = new System.Drawing.Size(20, 20);
            this.MaximizedBtn.TabIndex = 6;
            this.MaximizedBtn.Text = "▭";
            this.MaximizedBtn.Click += new System.EventHandler(this.MaximizedBtn_Click);
            // 
            // CloseAppBtn
            // 
            this.CloseAppBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseAppBtn.BorderRadius = 4;
            this.CloseAppBtn.CheckedState.Parent = this.CloseAppBtn;
            this.CloseAppBtn.CustomImages.Parent = this.CloseAppBtn;
            this.CloseAppBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(74)))), ((int)(((byte)(95)))));
            this.CloseAppBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloseAppBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CloseAppBtn.HoverState.Parent = this.CloseAppBtn;
            this.CloseAppBtn.Location = new System.Drawing.Point(50, 0);
            this.CloseAppBtn.Name = "CloseAppBtn";
            this.CloseAppBtn.ShadowDecoration.Parent = this.CloseAppBtn;
            this.CloseAppBtn.Size = new System.Drawing.Size(20, 20);
            this.CloseAppBtn.TabIndex = 5;
            this.CloseAppBtn.Text = "X";
            this.CloseAppBtn.Click += new System.EventHandler(this.CloseAppBtn_Click_2);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(224, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(113, 25);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Услуги";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.PannelMainMenu);
            this.Controls.Add(this.Label_NameProgramm);
            this.Controls.Add(this.guna2Separator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PannelMainMenu.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label Label_NameProgramm;
        private Guna.UI2.WinForms.Guna2Panel PannelMainMenu;
        private Guna.UI2.WinForms.Guna2Button HomeBtn;
        private Guna.UI2.WinForms.Guna2Button ClientBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button MinimazedBtn;
        private Guna.UI2.WinForms.Guna2Button MaximizedBtn;
        private Guna.UI2.WinForms.Guna2Button CloseAppBtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

