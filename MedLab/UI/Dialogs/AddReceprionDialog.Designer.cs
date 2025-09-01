namespace DiplomProgramm.UI.Dialogs
{
    partial class AddReceprionDialog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MinimazedBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CloseAppBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ProgressBarSavingEvent = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.DataPickerLastDateVisitingTakeAnalize = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ComboBoxFreeTimeOnThisDate = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DataGridViewServices = new Guna.UI2.WinForms.Guna2DataGridView();
            this.SearchTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckBoxSendResultEmail = new Guna.UI2.WinForms.Guna2CheckBox();
            this.SearchBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.AddEventBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewServices)).BeginInit();
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
            this.MinimazedBtn.TabIndex = 16;
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
            this.CloseAppBtn.TabIndex = 15;
            this.CloseAppBtn.Text = "X";
            this.CloseAppBtn.Click += new System.EventHandler(this.CloseAppBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(280, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Добавление Записи";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(12, 38);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(776, 10);
            this.guna2Separator1.TabIndex = 13;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // ProgressBarSavingEvent
            // 
            this.ProgressBarSavingEvent.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.ProgressBarSavingEvent.Location = new System.Drawing.Point(2, 417);
            this.ProgressBarSavingEvent.Name = "ProgressBarSavingEvent";
            this.ProgressBarSavingEvent.ShadowDecoration.Parent = this.ProgressBarSavingEvent;
            this.ProgressBarSavingEvent.Size = new System.Drawing.Size(300, 30);
            this.ProgressBarSavingEvent.TabIndex = 17;
            this.ProgressBarSavingEvent.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // DataPickerLastDateVisitingTakeAnalize
            // 
            this.DataPickerLastDateVisitingTakeAnalize.BorderRadius = 10;
            this.DataPickerLastDateVisitingTakeAnalize.CheckedState.Parent = this.DataPickerLastDateVisitingTakeAnalize;
            this.DataPickerLastDateVisitingTakeAnalize.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DataPickerLastDateVisitingTakeAnalize.HoverState.Parent = this.DataPickerLastDateVisitingTakeAnalize;
            this.DataPickerLastDateVisitingTakeAnalize.Location = new System.Drawing.Point(12, 82);
            this.DataPickerLastDateVisitingTakeAnalize.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DataPickerLastDateVisitingTakeAnalize.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DataPickerLastDateVisitingTakeAnalize.Name = "DataPickerLastDateVisitingTakeAnalize";
            this.DataPickerLastDateVisitingTakeAnalize.ShadowDecoration.Parent = this.DataPickerLastDateVisitingTakeAnalize;
            this.DataPickerLastDateVisitingTakeAnalize.Size = new System.Drawing.Size(149, 36);
            this.DataPickerLastDateVisitingTakeAnalize.TabIndex = 18;
            this.DataPickerLastDateVisitingTakeAnalize.Value = new System.DateTime(2022, 5, 5, 20, 16, 42, 363);
            this.DataPickerLastDateVisitingTakeAnalize.ValueChanged += new System.EventHandler(this.DataPickerLastDateVisitingTakeAnalize_ValueChanged);
            // 
            // ComboBoxFreeTimeOnThisDate
            // 
            this.ComboBoxFreeTimeOnThisDate.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxFreeTimeOnThisDate.BorderRadius = 10;
            this.ComboBoxFreeTimeOnThisDate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxFreeTimeOnThisDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFreeTimeOnThisDate.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBoxFreeTimeOnThisDate.FocusedState.Parent = this.ComboBoxFreeTimeOnThisDate;
            this.ComboBoxFreeTimeOnThisDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxFreeTimeOnThisDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxFreeTimeOnThisDate.FormattingEnabled = true;
            this.ComboBoxFreeTimeOnThisDate.HoverState.Parent = this.ComboBoxFreeTimeOnThisDate;
            this.ComboBoxFreeTimeOnThisDate.ItemHeight = 30;
            this.ComboBoxFreeTimeOnThisDate.ItemsAppearance.Parent = this.ComboBoxFreeTimeOnThisDate;
            this.ComboBoxFreeTimeOnThisDate.Location = new System.Drawing.Point(181, 82);
            this.ComboBoxFreeTimeOnThisDate.Name = "ComboBoxFreeTimeOnThisDate";
            this.ComboBoxFreeTimeOnThisDate.ShadowDecoration.Parent = this.ComboBoxFreeTimeOnThisDate;
            this.ComboBoxFreeTimeOnThisDate.Size = new System.Drawing.Size(143, 36);
            this.ComboBoxFreeTimeOnThisDate.TabIndex = 19;
            this.ComboBoxFreeTimeOnThisDate.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFreeTimeOnThisDate_SelectedIndexChanged);
            // 
            // DataGridViewServices
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataGridViewServices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewServices.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewServices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewServices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewServices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewServices.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewServices.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewServices.EnableHeadersVisualStyles = false;
            this.DataGridViewServices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewServices.Location = new System.Drawing.Point(12, 126);
            this.DataGridViewServices.Name = "DataGridViewServices";
            this.DataGridViewServices.RowHeadersVisible = false;
            this.DataGridViewServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewServices.Size = new System.Drawing.Size(776, 235);
            this.DataGridViewServices.TabIndex = 21;
            this.DataGridViewServices.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGridViewServices.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewServices.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewServices.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewServices.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewServices.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewServices.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewServices.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewServices.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewServices.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewServices.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewServices.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewServices.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewServices.ThemeStyle.HeaderStyle.Height = 40;
            this.DataGridViewServices.ThemeStyle.ReadOnly = false;
            this.DataGridViewServices.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewServices.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewServices.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewServices.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewServices.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridViewServices.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewServices.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewServices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewServices_CellContentClick);
            // 
            // SearchTxtBox
            // 
            this.SearchTxtBox.BorderRadius = 10;
            this.SearchTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTxtBox.DefaultText = "";
            this.SearchTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTxtBox.DisabledState.Parent = this.SearchTxtBox;
            this.SearchTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTxtBox.FocusedState.Parent = this.SearchTxtBox;
            this.SearchTxtBox.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTxtBox.ForeColor = System.Drawing.Color.Black;
            this.SearchTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTxtBox.HoverState.Parent = this.SearchTxtBox;
            this.SearchTxtBox.Location = new System.Drawing.Point(375, 82);
            this.SearchTxtBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.SearchTxtBox.Name = "SearchTxtBox";
            this.SearchTxtBox.PasswordChar = '\0';
            this.SearchTxtBox.PlaceholderText = "";
            this.SearchTxtBox.SelectedText = "";
            this.SearchTxtBox.ShadowDecoration.Parent = this.SearchTxtBox;
            this.SearchTxtBox.Size = new System.Drawing.Size(341, 36);
            this.SearchTxtBox.TabIndex = 22;
            this.SearchTxtBox.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(185, 57);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(131, 22);
            this.labelTime.TabIndex = 25;
            this.labelTime.Text = "Время Записи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Дата Записи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(391, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "Поиск Услуги";
            // 
            // CheckBoxSendResultEmail
            // 
            this.CheckBoxSendResultEmail.AutoSize = true;
            this.CheckBoxSendResultEmail.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckBoxSendResultEmail.CheckedState.BorderRadius = 2;
            this.CheckBoxSendResultEmail.CheckedState.BorderThickness = 0;
            this.CheckBoxSendResultEmail.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckBoxSendResultEmail.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxSendResultEmail.Location = new System.Drawing.Point(12, 379);
            this.CheckBoxSendResultEmail.Name = "CheckBoxSendResultEmail";
            this.CheckBoxSendResultEmail.Size = new System.Drawing.Size(161, 22);
            this.CheckBoxSendResultEmail.TabIndex = 38;
            this.CheckBoxSendResultEmail.Text = "Отправить на почту";
            this.CheckBoxSendResultEmail.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CheckBoxSendResultEmail.UncheckedState.BorderRadius = 2;
            this.CheckBoxSendResultEmail.UncheckedState.BorderThickness = 0;
            this.CheckBoxSendResultEmail.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CheckBoxSendResultEmail.UseVisualStyleBackColor = true;
            this.CheckBoxSendResultEmail.CheckedChanged += new System.EventHandler(this.CheckBoxSendResultEmail_CheckedChanged);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.DarkGray;
            this.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SearchBtn.CheckedState.Parent = this.SearchBtn;
            this.SearchBtn.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.SearchBtn.HoverState.Parent = this.SearchBtn;
            this.SearchBtn.Image = global::DiplomProgramm.Properties.Resources.icons8_поиск_48;
            this.SearchBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.SearchBtn.Location = new System.Drawing.Point(349, 82);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.PressedState.Parent = this.SearchBtn;
            this.SearchBtn.Size = new System.Drawing.Size(35, 36);
            this.SearchBtn.TabIndex = 23;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
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
            this.AddEventBtn.Image = global::DiplomProgramm.Properties.Resources.icons8_информация_48;
            this.AddEventBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.AddEventBtn.Location = new System.Drawing.Point(742, 54);
            this.AddEventBtn.Name = "AddEventBtn";
            this.AddEventBtn.ShadowDecoration.Parent = this.AddEventBtn;
            this.AddEventBtn.Size = new System.Drawing.Size(46, 46);
            this.AddEventBtn.TabIndex = 20;
            this.AddEventBtn.Click += new System.EventHandler(this.AddEventBtn_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.LightGray;
            this.guna2Button2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Image = global::DiplomProgramm.Properties.Resources.icons8_добавить_48;
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button2.Location = new System.Drawing.Point(367, 397);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(243, 41);
            this.guna2Button2.TabIndex = 39;
            this.guna2Button2.Text = "Персональная услуга";
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.LightGray;
            this.guna2Button1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::DiplomProgramm.Properties.Resources.icons8_загрузка_обновлений_48;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button1.Location = new System.Drawing.Point(635, 397);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(153, 41);
            this.guna2Button1.TabIndex = 37;
            this.guna2Button1.Text = "Сохранить";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // AddReceprionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.CheckBoxSendResultEmail);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchTxtBox);
            this.Controls.Add(this.DataGridViewServices);
            this.Controls.Add(this.AddEventBtn);
            this.Controls.Add(this.ComboBoxFreeTimeOnThisDate);
            this.Controls.Add(this.DataPickerLastDateVisitingTakeAnalize);
            this.Controls.Add(this.ProgressBarSavingEvent);
            this.Controls.Add(this.MinimazedBtn);
            this.Controls.Add(this.CloseAppBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Separator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddReceprionDialog";
            this.Text = "AddReceprionDialog";
            this.Load += new System.EventHandler(this.AddReceprionDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button MinimazedBtn;
        private Guna.UI2.WinForms.Guna2Button CloseAppBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2ProgressBar ProgressBarSavingEvent;
        private Guna.UI2.WinForms.Guna2DateTimePicker DataPickerLastDateVisitingTakeAnalize;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxFreeTimeOnThisDate;
        private Guna.UI2.WinForms.Guna2Button AddEventBtn;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewServices;
        private Guna.UI2.WinForms.Guna2TextBox SearchTxtBox;
        private Guna.UI2.WinForms.Guna2ImageButton SearchBtn;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CheckBox CheckBoxSendResultEmail;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}