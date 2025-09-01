namespace DiplomProgramm.UI.Dialogs
{
    partial class AdministratorAddUserDialog
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
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label1 = new System.Windows.Forms.Label();
            this.MinimazedBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CloseAppBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AddEventBtn = new Guna.UI2.WinForms.Guna2Button();
            this.NameTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SurnameTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ComboBoxRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.PhoneTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmailTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ChangeInfoLableName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChangeInfoLablePhone = new System.Windows.Forms.Label();
            this.ChangeInfoLableEmail = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(12, 38);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(776, 10);
            this.guna2Separator1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Добавление пользователя";
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
            this.MinimazedBtn.Location = new System.Drawing.Point(742, 12);
            this.MinimazedBtn.Name = "MinimazedBtn";
            this.MinimazedBtn.ShadowDecoration.Parent = this.MinimazedBtn;
            this.MinimazedBtn.Size = new System.Drawing.Size(20, 20);
            this.MinimazedBtn.TabIndex = 14;
            this.MinimazedBtn.Text = "_";
            this.MinimazedBtn.TextOffset = new System.Drawing.Point(0, -5);
            this.MinimazedBtn.Click += new System.EventHandler(this.MinimazedBtn_Click);
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
            this.CloseAppBtn.Location = new System.Drawing.Point(768, 12);
            this.CloseAppBtn.Name = "CloseAppBtn";
            this.CloseAppBtn.ShadowDecoration.Parent = this.CloseAppBtn;
            this.CloseAppBtn.Size = new System.Drawing.Size(20, 20);
            this.CloseAppBtn.TabIndex = 13;
            this.CloseAppBtn.Text = "X";
            this.CloseAppBtn.Click += new System.EventHandler(this.CloseAppBtn_Click);
            // 
            // AddEventBtn
            // 
            this.AddEventBtn.BorderRadius = 10;
            this.AddEventBtn.CheckedState.Parent = this.AddEventBtn;
            this.AddEventBtn.CustomImages.Parent = this.AddEventBtn;
            this.AddEventBtn.FillColor = System.Drawing.Color.LightGray;
            this.AddEventBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddEventBtn.ForeColor = System.Drawing.Color.Black;
            this.AddEventBtn.HoverState.Parent = this.AddEventBtn;
            this.AddEventBtn.Image = global::DiplomProgramm.Properties.Resources.icons8_сохранить_48;
            this.AddEventBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.AddEventBtn.Location = new System.Drawing.Point(626, 402);
            this.AddEventBtn.Name = "AddEventBtn";
            this.AddEventBtn.ShadowDecoration.Parent = this.AddEventBtn;
            this.AddEventBtn.Size = new System.Drawing.Size(162, 36);
            this.AddEventBtn.TabIndex = 15;
            this.AddEventBtn.Text = "Сохранить";
            this.AddEventBtn.Click += new System.EventHandler(this.AddEventBtn_Click);
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.BorderRadius = 10;
            this.NameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTxtBox.DefaultText = "";
            this.NameTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTxtBox.DisabledState.Parent = this.NameTxtBox;
            this.NameTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTxtBox.FocusedState.Parent = this.NameTxtBox;
            this.NameTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTxtBox.HoverState.Parent = this.NameTxtBox;
            this.NameTxtBox.Location = new System.Drawing.Point(12, 79);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.PasswordChar = '\0';
            this.NameTxtBox.PlaceholderText = "";
            this.NameTxtBox.SelectedText = "";
            this.NameTxtBox.ShadowDecoration.Parent = this.NameTxtBox;
            this.NameTxtBox.Size = new System.Drawing.Size(246, 36);
            this.NameTxtBox.TabIndex = 16;
            // 
            // SurnameTxtBox
            // 
            this.SurnameTxtBox.BorderRadius = 10;
            this.SurnameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SurnameTxtBox.DefaultText = "";
            this.SurnameTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SurnameTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SurnameTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SurnameTxtBox.DisabledState.Parent = this.SurnameTxtBox;
            this.SurnameTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SurnameTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SurnameTxtBox.FocusedState.Parent = this.SurnameTxtBox;
            this.SurnameTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SurnameTxtBox.HoverState.Parent = this.SurnameTxtBox;
            this.SurnameTxtBox.Location = new System.Drawing.Point(290, 79);
            this.SurnameTxtBox.Name = "SurnameTxtBox";
            this.SurnameTxtBox.PasswordChar = '\0';
            this.SurnameTxtBox.PlaceholderText = "";
            this.SurnameTxtBox.SelectedText = "";
            this.SurnameTxtBox.ShadowDecoration.Parent = this.SurnameTxtBox;
            this.SurnameTxtBox.Size = new System.Drawing.Size(242, 36);
            this.SurnameTxtBox.TabIndex = 17;
            // 
            // ComboBoxRole
            // 
            this.ComboBoxRole.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxRole.BorderRadius = 10;
            this.ComboBoxRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxRole.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBoxRole.FocusedState.Parent = this.ComboBoxRole;
            this.ComboBoxRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxRole.FormattingEnabled = true;
            this.ComboBoxRole.HoverState.Parent = this.ComboBoxRole;
            this.ComboBoxRole.ItemHeight = 30;
            this.ComboBoxRole.ItemsAppearance.Parent = this.ComboBoxRole;
            this.ComboBoxRole.Location = new System.Drawing.Point(562, 79);
            this.ComboBoxRole.Name = "ComboBoxRole";
            this.ComboBoxRole.ShadowDecoration.Parent = this.ComboBoxRole;
            this.ComboBoxRole.Size = new System.Drawing.Size(200, 36);
            this.ComboBoxRole.TabIndex = 18;
            this.ComboBoxRole.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRole_SelectedIndexChanged);
            // 
            // PhoneTxtBox
            // 
            this.PhoneTxtBox.BorderRadius = 10;
            this.PhoneTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneTxtBox.DefaultText = "";
            this.PhoneTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PhoneTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PhoneTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneTxtBox.DisabledState.Parent = this.PhoneTxtBox;
            this.PhoneTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneTxtBox.FocusedState.Parent = this.PhoneTxtBox;
            this.PhoneTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneTxtBox.HoverState.Parent = this.PhoneTxtBox;
            this.PhoneTxtBox.Location = new System.Drawing.Point(12, 156);
            this.PhoneTxtBox.Name = "PhoneTxtBox";
            this.PhoneTxtBox.PasswordChar = '\0';
            this.PhoneTxtBox.PlaceholderText = "";
            this.PhoneTxtBox.SelectedText = "";
            this.PhoneTxtBox.ShadowDecoration.Parent = this.PhoneTxtBox;
            this.PhoneTxtBox.Size = new System.Drawing.Size(200, 36);
            this.PhoneTxtBox.TabIndex = 19;
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.BorderRadius = 10;
            this.EmailTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTxtBox.DefaultText = "";
            this.EmailTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmailTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmailTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTxtBox.DisabledState.Parent = this.EmailTxtBox;
            this.EmailTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTxtBox.FocusedState.Parent = this.EmailTxtBox;
            this.EmailTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTxtBox.HoverState.Parent = this.EmailTxtBox;
            this.EmailTxtBox.Location = new System.Drawing.Point(290, 156);
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.PasswordChar = '\0';
            this.EmailTxtBox.PlaceholderText = "";
            this.EmailTxtBox.SelectedText = "";
            this.EmailTxtBox.ShadowDecoration.Parent = this.EmailTxtBox;
            this.EmailTxtBox.Size = new System.Drawing.Size(200, 36);
            this.EmailTxtBox.TabIndex = 20;
            // 
            // LoginTxtBox
            // 
            this.LoginTxtBox.BorderRadius = 10;
            this.LoginTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginTxtBox.DefaultText = "";
            this.LoginTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LoginTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LoginTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoginTxtBox.DisabledState.Parent = this.LoginTxtBox;
            this.LoginTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoginTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginTxtBox.FocusedState.Parent = this.LoginTxtBox;
            this.LoginTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginTxtBox.HoverState.Parent = this.LoginTxtBox;
            this.LoginTxtBox.Location = new System.Drawing.Point(12, 230);
            this.LoginTxtBox.Name = "LoginTxtBox";
            this.LoginTxtBox.PasswordChar = '\0';
            this.LoginTxtBox.PlaceholderText = "";
            this.LoginTxtBox.SelectedText = "";
            this.LoginTxtBox.ShadowDecoration.Parent = this.LoginTxtBox;
            this.LoginTxtBox.Size = new System.Drawing.Size(200, 36);
            this.LoginTxtBox.TabIndex = 21;
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.BorderRadius = 10;
            this.PasswordTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTxtBox.DefaultText = "";
            this.PasswordTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTxtBox.DisabledState.Parent = this.PasswordTxtBox;
            this.PasswordTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTxtBox.FocusedState.Parent = this.PasswordTxtBox;
            this.PasswordTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTxtBox.HoverState.Parent = this.PasswordTxtBox;
            this.PasswordTxtBox.Location = new System.Drawing.Point(12, 299);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.PasswordChar = '\0';
            this.PasswordTxtBox.PlaceholderText = "";
            this.PasswordTxtBox.SelectedText = "";
            this.PasswordTxtBox.ShadowDecoration.Parent = this.PasswordTxtBox;
            this.PasswordTxtBox.Size = new System.Drawing.Size(200, 36);
            this.PasswordTxtBox.TabIndex = 22;
            // 
            // ChangeInfoLableName
            // 
            this.ChangeInfoLableName.AutoSize = true;
            this.ChangeInfoLableName.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeInfoLableName.Location = new System.Drawing.Point(118, 54);
            this.ChangeInfoLableName.Name = "ChangeInfoLableName";
            this.ChangeInfoLableName.Size = new System.Drawing.Size(46, 22);
            this.ChangeInfoLableName.TabIndex = 35;
            this.ChangeInfoLableName.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(362, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 50;
            this.label2.Text = "Фамилия";
            // 
            // ChangeInfoLablePhone
            // 
            this.ChangeInfoLablePhone.AutoSize = true;
            this.ChangeInfoLablePhone.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeInfoLablePhone.Location = new System.Drawing.Point(73, 131);
            this.ChangeInfoLablePhone.Name = "ChangeInfoLablePhone";
            this.ChangeInfoLablePhone.Size = new System.Drawing.Size(82, 22);
            this.ChangeInfoLablePhone.TabIndex = 51;
            this.ChangeInfoLablePhone.Text = "Телефон";
            // 
            // ChangeInfoLableEmail
            // 
            this.ChangeInfoLableEmail.AutoSize = true;
            this.ChangeInfoLableEmail.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeInfoLableEmail.Location = new System.Drawing.Point(362, 131);
            this.ChangeInfoLableEmail.Name = "ChangeInfoLableEmail";
            this.ChangeInfoLableEmail.Size = new System.Drawing.Size(60, 22);
            this.ChangeInfoLableEmail.TabIndex = 52;
            this.ChangeInfoLableEmail.Text = "Почта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(593, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 22);
            this.label3.TabIndex = 53;
            this.label3.Text = "Роль в системе";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(83, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 54;
            this.label4.Text = "Пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(89, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 22);
            this.label5.TabIndex = 55;
            this.label5.Text = "Логин";
            // 
            // AdministratorAddUserDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ChangeInfoLableEmail);
            this.Controls.Add(this.ChangeInfoLablePhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChangeInfoLableName);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.LoginTxtBox);
            this.Controls.Add(this.EmailTxtBox);
            this.Controls.Add(this.PhoneTxtBox);
            this.Controls.Add(this.ComboBoxRole);
            this.Controls.Add(this.SurnameTxtBox);
            this.Controls.Add(this.NameTxtBox);
            this.Controls.Add(this.AddEventBtn);
            this.Controls.Add(this.MinimazedBtn);
            this.Controls.Add(this.CloseAppBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Separator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministratorAddUserDialog";
            this.Text = "AdministratorAddUserDialog";
            this.Load += new System.EventHandler(this.AdministratorAddUserDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button MinimazedBtn;
        private Guna.UI2.WinForms.Guna2Button CloseAppBtn;
        private Guna.UI2.WinForms.Guna2Button AddEventBtn;
        private Guna.UI2.WinForms.Guna2TextBox NameTxtBox;
        private Guna.UI2.WinForms.Guna2TextBox SurnameTxtBox;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxRole;
        private Guna.UI2.WinForms.Guna2TextBox PhoneTxtBox;
        private Guna.UI2.WinForms.Guna2TextBox EmailTxtBox;
        private Guna.UI2.WinForms.Guna2TextBox LoginTxtBox;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTxtBox;
        private System.Windows.Forms.Label ChangeInfoLableName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ChangeInfoLablePhone;
        private System.Windows.Forms.Label ChangeInfoLableEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}