namespace DiplomProgramm.UI.Dialogs
{
    partial class RegisterNewClientDialog
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
            this.MinimazedBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CloseAppBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.ClientFIOTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PassportTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.GivenByTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PhoneTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EmailTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2CheckBox2 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.DataPickerDateOfBirth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CopyLinkDocument = new Guna.UI2.WinForms.Guna2Button();
            this.DogovorPrintBtn = new Guna.UI2.WinForms.Guna2Button();
            this.InfoBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SaveReceptionBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
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
            this.MinimazedBtn.TabIndex = 20;
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
            this.CloseAppBtn.TabIndex = 19;
            this.CloseAppBtn.Text = "X";
            this.CloseAppBtn.Click += new System.EventHandler(this.CloseAppBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(284, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Регистрация клиента";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(12, 38);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(776, 10);
            this.guna2Separator1.TabIndex = 17;
            // 
            // ClientFIOTxtBox
            // 
            this.ClientFIOTxtBox.BorderRadius = 10;
            this.ClientFIOTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ClientFIOTxtBox.DefaultText = "";
            this.ClientFIOTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ClientFIOTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ClientFIOTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ClientFIOTxtBox.DisabledState.Parent = this.ClientFIOTxtBox;
            this.ClientFIOTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ClientFIOTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClientFIOTxtBox.FocusedState.Parent = this.ClientFIOTxtBox;
            this.ClientFIOTxtBox.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientFIOTxtBox.ForeColor = System.Drawing.Color.Black;
            this.ClientFIOTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClientFIOTxtBox.HoverState.Parent = this.ClientFIOTxtBox;
            this.ClientFIOTxtBox.Location = new System.Drawing.Point(12, 81);
            this.ClientFIOTxtBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ClientFIOTxtBox.Name = "ClientFIOTxtBox";
            this.ClientFIOTxtBox.PasswordChar = '\0';
            this.ClientFIOTxtBox.PlaceholderText = "";
            this.ClientFIOTxtBox.SelectedText = "";
            this.ClientFIOTxtBox.ShadowDecoration.Parent = this.ClientFIOTxtBox;
            this.ClientFIOTxtBox.Size = new System.Drawing.Size(503, 36);
            this.ClientFIOTxtBox.TabIndex = 23;
            // 
            // PassportTxtBox
            // 
            this.PassportTxtBox.BorderRadius = 10;
            this.PassportTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PassportTxtBox.DefaultText = "";
            this.PassportTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PassportTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PassportTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PassportTxtBox.DisabledState.Parent = this.PassportTxtBox;
            this.PassportTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PassportTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PassportTxtBox.FocusedState.Parent = this.PassportTxtBox;
            this.PassportTxtBox.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassportTxtBox.ForeColor = System.Drawing.Color.Black;
            this.PassportTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PassportTxtBox.HoverState.Parent = this.PassportTxtBox;
            this.PassportTxtBox.Location = new System.Drawing.Point(525, 81);
            this.PassportTxtBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PassportTxtBox.Name = "PassportTxtBox";
            this.PassportTxtBox.PasswordChar = '\0';
            this.PassportTxtBox.PlaceholderText = "";
            this.PassportTxtBox.SelectedText = "";
            this.PassportTxtBox.ShadowDecoration.Parent = this.PassportTxtBox;
            this.PassportTxtBox.Size = new System.Drawing.Size(182, 36);
            this.PassportTxtBox.TabIndex = 26;
            // 
            // GivenByTxtBox
            // 
            this.GivenByTxtBox.BorderRadius = 10;
            this.GivenByTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GivenByTxtBox.DefaultText = "";
            this.GivenByTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.GivenByTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.GivenByTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GivenByTxtBox.DisabledState.Parent = this.GivenByTxtBox;
            this.GivenByTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GivenByTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GivenByTxtBox.FocusedState.Parent = this.GivenByTxtBox;
            this.GivenByTxtBox.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GivenByTxtBox.ForeColor = System.Drawing.Color.Black;
            this.GivenByTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GivenByTxtBox.HoverState.Parent = this.GivenByTxtBox;
            this.GivenByTxtBox.Location = new System.Drawing.Point(12, 247);
            this.GivenByTxtBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.GivenByTxtBox.Name = "GivenByTxtBox";
            this.GivenByTxtBox.PasswordChar = '\0';
            this.GivenByTxtBox.PlaceholderText = "";
            this.GivenByTxtBox.SelectedText = "";
            this.GivenByTxtBox.ShadowDecoration.Parent = this.GivenByTxtBox;
            this.GivenByTxtBox.Size = new System.Drawing.Size(774, 76);
            this.GivenByTxtBox.TabIndex = 27;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.AutoSize = true;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.CheckedState.BorderRadius = 2;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2CheckBox1.Location = new System.Drawing.Point(12, 342);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(280, 22);
            this.guna2CheckBox1.TabIndex = 40;
            this.guna2CheckBox1.Text = "Договор на оказание услуг подписан";
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UncheckedState.BorderRadius = 2;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UseVisualStyleBackColor = true;
            this.guna2CheckBox1.CheckedChanged += new System.EventHandler(this.guna2CheckBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(32, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 41;
            this.label2.Text = "ФИО ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 22);
            this.label3.TabIndex = 42;
            this.label3.Text = "Дата Рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(534, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 22);
            this.label5.TabIndex = 44;
            this.label5.Text = "Номер Паспорта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(25, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 22);
            this.label6.TabIndex = 45;
            this.label6.Text = "Паспорт выдан";
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
            this.PhoneTxtBox.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneTxtBox.ForeColor = System.Drawing.Color.Black;
            this.PhoneTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneTxtBox.HoverState.Parent = this.PhoneTxtBox;
            this.PhoneTxtBox.Location = new System.Drawing.Point(220, 151);
            this.PhoneTxtBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PhoneTxtBox.Name = "PhoneTxtBox";
            this.PhoneTxtBox.PasswordChar = '\0';
            this.PhoneTxtBox.PlaceholderText = "";
            this.PhoneTxtBox.SelectedText = "";
            this.PhoneTxtBox.ShadowDecoration.Parent = this.PhoneTxtBox;
            this.PhoneTxtBox.Size = new System.Drawing.Size(225, 36);
            this.PhoneTxtBox.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(258, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 22);
            this.label7.TabIndex = 47;
            this.label7.Text = "Номер телефона";
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
            this.EmailTxtBox.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailTxtBox.ForeColor = System.Drawing.Color.Black;
            this.EmailTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTxtBox.HoverState.Parent = this.EmailTxtBox;
            this.EmailTxtBox.Location = new System.Drawing.Point(482, 151);
            this.EmailTxtBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.PasswordChar = '\0';
            this.EmailTxtBox.PlaceholderText = "";
            this.EmailTxtBox.SelectedText = "";
            this.EmailTxtBox.ShadowDecoration.Parent = this.EmailTxtBox;
            this.EmailTxtBox.Size = new System.Drawing.Size(225, 36);
            this.EmailTxtBox.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(565, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 22);
            this.label8.TabIndex = 49;
            this.label8.Text = "Почта";
            // 
            // guna2CheckBox2
            // 
            this.guna2CheckBox2.AutoSize = true;
            this.guna2CheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox2.CheckedState.BorderRadius = 2;
            this.guna2CheckBox2.CheckedState.BorderThickness = 0;
            this.guna2CheckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2CheckBox2.Location = new System.Drawing.Point(11, 385);
            this.guna2CheckBox2.Name = "guna2CheckBox2";
            this.guna2CheckBox2.Size = new System.Drawing.Size(15, 14);
            this.guna2CheckBox2.TabIndex = 52;
            this.guna2CheckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox2.UncheckedState.BorderRadius = 2;
            this.guna2CheckBox2.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox2.UseVisualStyleBackColor = true;
            this.guna2CheckBox2.CheckedChanged += new System.EventHandler(this.guna2CheckBox2_CheckedChanged);
            // 
            // DataPickerDateOfBirth
            // 
            this.DataPickerDateOfBirth.BorderRadius = 10;
            this.DataPickerDateOfBirth.CheckedState.Parent = this.DataPickerDateOfBirth;
            this.DataPickerDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DataPickerDateOfBirth.HoverState.Parent = this.DataPickerDateOfBirth;
            this.DataPickerDateOfBirth.Location = new System.Drawing.Point(12, 151);
            this.DataPickerDateOfBirth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DataPickerDateOfBirth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DataPickerDateOfBirth.Name = "DataPickerDateOfBirth";
            this.DataPickerDateOfBirth.ShadowDecoration.Parent = this.DataPickerDateOfBirth;
            this.DataPickerDateOfBirth.Size = new System.Drawing.Size(182, 36);
            this.DataPickerDateOfBirth.TabIndex = 53;
            this.DataPickerDateOfBirth.Value = new System.DateTime(2022, 5, 5, 20, 16, 42, 363);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(26, 383);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(265, 18);
            this.label10.TabIndex = 54;
            this.label10.Text = "Договор на обработку персональных ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(26, 400);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 18);
            this.label11.TabIndex = 55;
            this.label11.Text = "данных подписан";
            // 
            // CopyLinkDocument
            // 
            this.CopyLinkDocument.BackColor = System.Drawing.SystemColors.Control;
            this.CopyLinkDocument.BorderRadius = 10;
            this.CopyLinkDocument.CheckedState.Parent = this.CopyLinkDocument;
            this.CopyLinkDocument.CustomImages.Parent = this.CopyLinkDocument;
            this.CopyLinkDocument.FillColor = System.Drawing.Color.LightGray;
            this.CopyLinkDocument.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CopyLinkDocument.ForeColor = System.Drawing.Color.Black;
            this.CopyLinkDocument.HoverState.Parent = this.CopyLinkDocument;
            this.CopyLinkDocument.Image = global::DiplomProgramm.Properties.Resources.icons8_копировать_ссылку_48;
            this.CopyLinkDocument.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CopyLinkDocument.ImageSize = new System.Drawing.Size(40, 40);
            this.CopyLinkDocument.Location = new System.Drawing.Point(314, 392);
            this.CopyLinkDocument.Name = "CopyLinkDocument";
            this.CopyLinkDocument.ShadowDecoration.Parent = this.CopyLinkDocument;
            this.CopyLinkDocument.Size = new System.Drawing.Size(140, 41);
            this.CopyLinkDocument.TabIndex = 56;
            this.CopyLinkDocument.Text = "Cсылка";
            this.CopyLinkDocument.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CopyLinkDocument.Click += new System.EventHandler(this.CopyLinkDocument_Click);
            // 
            // DogovorPrintBtn
            // 
            this.DogovorPrintBtn.BackColor = System.Drawing.SystemColors.Control;
            this.DogovorPrintBtn.BorderRadius = 10;
            this.DogovorPrintBtn.CheckedState.Parent = this.DogovorPrintBtn;
            this.DogovorPrintBtn.CustomImages.Parent = this.DogovorPrintBtn;
            this.DogovorPrintBtn.FillColor = System.Drawing.Color.LightGray;
            this.DogovorPrintBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DogovorPrintBtn.ForeColor = System.Drawing.Color.Black;
            this.DogovorPrintBtn.HoverState.Parent = this.DogovorPrintBtn;
            this.DogovorPrintBtn.Image = global::DiplomProgramm.Properties.Resources.icons8_load_from_file_48;
            this.DogovorPrintBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DogovorPrintBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.DogovorPrintBtn.Location = new System.Drawing.Point(469, 392);
            this.DogovorPrintBtn.Name = "DogovorPrintBtn";
            this.DogovorPrintBtn.ShadowDecoration.Parent = this.DogovorPrintBtn;
            this.DogovorPrintBtn.Size = new System.Drawing.Size(140, 41);
            this.DogovorPrintBtn.TabIndex = 38;
            this.DogovorPrintBtn.Text = "Договор";
            this.DogovorPrintBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DogovorPrintBtn.Click += new System.EventHandler(this.DogovorPrintBtn_Click);
            // 
            // InfoBtn
            // 
            this.InfoBtn.BorderRadius = 10;
            this.InfoBtn.CheckedState.Parent = this.InfoBtn;
            this.InfoBtn.CustomImages.Parent = this.InfoBtn;
            this.InfoBtn.FillColor = System.Drawing.Color.LightGray;
            this.InfoBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoBtn.ForeColor = System.Drawing.Color.Black;
            this.InfoBtn.HoverState.Parent = this.InfoBtn;
            this.InfoBtn.Image = global::DiplomProgramm.Properties.Resources.icons8_информация_48;
            this.InfoBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.InfoBtn.Location = new System.Drawing.Point(742, 54);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.ShadowDecoration.Parent = this.InfoBtn;
            this.InfoBtn.Size = new System.Drawing.Size(46, 46);
            this.InfoBtn.TabIndex = 28;
            this.InfoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
            // 
            // SaveReceptionBtn
            // 
            this.SaveReceptionBtn.BorderRadius = 10;
            this.SaveReceptionBtn.CheckedState.Parent = this.SaveReceptionBtn;
            this.SaveReceptionBtn.CustomImages.Parent = this.SaveReceptionBtn;
            this.SaveReceptionBtn.FillColor = System.Drawing.Color.LightGray;
            this.SaveReceptionBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveReceptionBtn.ForeColor = System.Drawing.Color.Black;
            this.SaveReceptionBtn.HoverState.Parent = this.SaveReceptionBtn;
            this.SaveReceptionBtn.Image = global::DiplomProgramm.Properties.Resources.icons8_загрузка_обновлений_48;
            this.SaveReceptionBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.SaveReceptionBtn.Location = new System.Drawing.Point(626, 392);
            this.SaveReceptionBtn.Name = "SaveReceptionBtn";
            this.SaveReceptionBtn.ShadowDecoration.Parent = this.SaveReceptionBtn;
            this.SaveReceptionBtn.Size = new System.Drawing.Size(162, 41);
            this.SaveReceptionBtn.TabIndex = 39;
            this.SaveReceptionBtn.Text = "Сохранить";
            this.SaveReceptionBtn.Click += new System.EventHandler(this.SaveReceptionBtn_Click);
            // 
            // RegisterNewClientDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CopyLinkDocument);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DataPickerDateOfBirth);
            this.Controls.Add(this.guna2CheckBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EmailTxtBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PhoneTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2CheckBox1);
            this.Controls.Add(this.SaveReceptionBtn);
            this.Controls.Add(this.DogovorPrintBtn);
            this.Controls.Add(this.InfoBtn);
            this.Controls.Add(this.GivenByTxtBox);
            this.Controls.Add(this.PassportTxtBox);
            this.Controls.Add(this.ClientFIOTxtBox);
            this.Controls.Add(this.MinimazedBtn);
            this.Controls.Add(this.CloseAppBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Separator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterNewClientDialog";
            this.Text = "RegisterNewClient";
            this.Load += new System.EventHandler(this.RegisterNewClientDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button MinimazedBtn;
        private Guna.UI2.WinForms.Guna2Button CloseAppBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2TextBox ClientFIOTxtBox;
        private Guna.UI2.WinForms.Guna2TextBox PassportTxtBox;
        private Guna.UI2.WinForms.Guna2TextBox GivenByTxtBox;
        private Guna.UI2.WinForms.Guna2Button InfoBtn;
        private Guna.UI2.WinForms.Guna2Button DogovorPrintBtn;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox EmailTxtBox;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox PhoneTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2DateTimePicker DataPickerDateOfBirth;
        private Guna.UI2.WinForms.Guna2Button CopyLinkDocument;
        private Guna.UI2.WinForms.Guna2Button SaveReceptionBtn;
    }
}