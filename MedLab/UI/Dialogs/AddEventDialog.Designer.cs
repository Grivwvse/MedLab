namespace DiplomProgramm.UI.Dialogs
{
    partial class AddEventDialog
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
            this.ProgressBarSavingEvent = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.guna2ResizeForm1 = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.TxtBoxEventName = new Guna.UI2.WinForms.Guna2TextBox();
            this.ComboBoxImportance = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DataPickerLastDateVisibleFor = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ComboBoxVisibleFor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseAppBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddEventBtn = new Guna.UI2.WinForms.Guna2Button();
            this.MinimazedBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProgressBarSavingEvent
            // 
            this.ProgressBarSavingEvent.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.ProgressBarSavingEvent.Location = new System.Drawing.Point(2, 417);
            this.ProgressBarSavingEvent.Name = "ProgressBarSavingEvent";
            this.ProgressBarSavingEvent.ShadowDecoration.Parent = this.ProgressBarSavingEvent;
            this.ProgressBarSavingEvent.Size = new System.Drawing.Size(300, 30);
            this.ProgressBarSavingEvent.TabIndex = 0;
            this.ProgressBarSavingEvent.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ProgressBarSavingEvent.ValueChanged += new System.EventHandler(this.ProgressBarSavingEvent_ValueChanged);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(12, 38);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(776, 10);
            this.guna2Separator1.TabIndex = 1;
            this.guna2Separator1.Click += new System.EventHandler(this.guna2Separator1_Click);
            // 
            // TxtBoxEventName
            // 
            this.TxtBoxEventName.BorderRadius = 10;
            this.TxtBoxEventName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBoxEventName.DefaultText = "";
            this.TxtBoxEventName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtBoxEventName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtBoxEventName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBoxEventName.DisabledState.Parent = this.TxtBoxEventName;
            this.TxtBoxEventName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBoxEventName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBoxEventName.FocusedState.Parent = this.TxtBoxEventName;
            this.TxtBoxEventName.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtBoxEventName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBoxEventName.HoverState.Parent = this.TxtBoxEventName;
            this.TxtBoxEventName.Location = new System.Drawing.Point(13, 187);
            this.TxtBoxEventName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtBoxEventName.Multiline = true;
            this.TxtBoxEventName.Name = "TxtBoxEventName";
            this.TxtBoxEventName.PasswordChar = '\0';
            this.TxtBoxEventName.PlaceholderText = "";
            this.TxtBoxEventName.SelectedText = "";
            this.TxtBoxEventName.ShadowDecoration.Parent = this.TxtBoxEventName;
            this.TxtBoxEventName.Size = new System.Drawing.Size(774, 217);
            this.TxtBoxEventName.TabIndex = 2;
            // 
            // ComboBoxImportance
            // 
            this.ComboBoxImportance.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxImportance.BorderRadius = 10;
            this.ComboBoxImportance.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxImportance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxImportance.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBoxImportance.FocusedState.Parent = this.ComboBoxImportance;
            this.ComboBoxImportance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxImportance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxImportance.FormattingEnabled = true;
            this.ComboBoxImportance.HoverState.Parent = this.ComboBoxImportance;
            this.ComboBoxImportance.ItemHeight = 30;
            this.ComboBoxImportance.ItemsAppearance.Parent = this.ComboBoxImportance;
            this.ComboBoxImportance.Location = new System.Drawing.Point(300, 106);
            this.ComboBoxImportance.Name = "ComboBoxImportance";
            this.ComboBoxImportance.ShadowDecoration.Parent = this.ComboBoxImportance;
            this.ComboBoxImportance.Size = new System.Drawing.Size(200, 36);
            this.ComboBoxImportance.TabIndex = 3;
            // 
            // DataPickerLastDateVisibleFor
            // 
            this.DataPickerLastDateVisibleFor.BorderRadius = 10;
            this.DataPickerLastDateVisibleFor.CheckedState.Parent = this.DataPickerLastDateVisibleFor;
            this.DataPickerLastDateVisibleFor.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DataPickerLastDateVisibleFor.HoverState.Parent = this.DataPickerLastDateVisibleFor;
            this.DataPickerLastDateVisibleFor.Location = new System.Drawing.Point(588, 106);
            this.DataPickerLastDateVisibleFor.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DataPickerLastDateVisibleFor.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DataPickerLastDateVisibleFor.Name = "DataPickerLastDateVisibleFor";
            this.DataPickerLastDateVisibleFor.ShadowDecoration.Parent = this.DataPickerLastDateVisibleFor;
            this.DataPickerLastDateVisibleFor.Size = new System.Drawing.Size(200, 36);
            this.DataPickerLastDateVisibleFor.TabIndex = 5;
            this.DataPickerLastDateVisibleFor.Value = new System.DateTime(2022, 5, 5, 20, 16, 42, 363);
            this.DataPickerLastDateVisibleFor.ValueChanged += new System.EventHandler(this.DataPickerLastDateVisibleFor_ValueChanged);
            // 
            // ComboBoxVisibleFor
            // 
            this.ComboBoxVisibleFor.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxVisibleFor.BorderRadius = 10;
            this.ComboBoxVisibleFor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxVisibleFor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxVisibleFor.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBoxVisibleFor.FocusedState.Parent = this.ComboBoxVisibleFor;
            this.ComboBoxVisibleFor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxVisibleFor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxVisibleFor.FormattingEnabled = true;
            this.ComboBoxVisibleFor.HoverState.Parent = this.ComboBoxVisibleFor;
            this.ComboBoxVisibleFor.ItemHeight = 30;
            this.ComboBoxVisibleFor.ItemsAppearance.Parent = this.ComboBoxVisibleFor;
            this.ComboBoxVisibleFor.Location = new System.Drawing.Point(12, 106);
            this.ComboBoxVisibleFor.Name = "ComboBoxVisibleFor";
            this.ComboBoxVisibleFor.ShadowDecoration.Parent = this.ComboBoxVisibleFor;
            this.ComboBoxVisibleFor.Size = new System.Drawing.Size(200, 36);
            this.ComboBoxVisibleFor.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(280, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Добавление события";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.CloseAppBtn.TabIndex = 9;
            this.CloseAppBtn.Text = "X";
            this.CloseAppBtn.Click += new System.EventHandler(this.CloseAppBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(53, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Событие для";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(322, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Важность Собтия";
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
            this.AddEventBtn.Location = new System.Drawing.Point(626, 411);
            this.AddEventBtn.Name = "AddEventBtn";
            this.AddEventBtn.ShadowDecoration.Parent = this.AddEventBtn;
            this.AddEventBtn.Size = new System.Drawing.Size(162, 36);
            this.AddEventBtn.TabIndex = 7;
            this.AddEventBtn.Text = "Сохранить";
            this.AddEventBtn.Click += new System.EventHandler(this.AddEventBtn_ClickAsync);
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
            this.MinimazedBtn.TabIndex = 12;
            this.MinimazedBtn.Text = "_";
            this.MinimazedBtn.TextOffset = new System.Drawing.Point(0, -5);
            this.MinimazedBtn.Click += new System.EventHandler(this.MinimazedBtn_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Interval = 26;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(611, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Актуальность до ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(322, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Текст Собтия";
            // 
            // AddEventDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MinimazedBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CloseAppBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddEventBtn);
            this.Controls.Add(this.ComboBoxVisibleFor);
            this.Controls.Add(this.DataPickerLastDateVisibleFor);
            this.Controls.Add(this.ComboBoxImportance);
            this.Controls.Add(this.TxtBoxEventName);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.ProgressBarSavingEvent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEventDialog";
            this.Text = "AddEventDialog";
            this.Load += new System.EventHandler(this.AddEventDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ProgressBar ProgressBarSavingEvent;
        private Guna.UI2.WinForms.Guna2ResizeForm guna2ResizeForm1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2TextBox TxtBoxEventName;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxImportance;
        private Guna.UI2.WinForms.Guna2DateTimePicker DataPickerLastDateVisibleFor;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxVisibleFor;
        private Guna.UI2.WinForms.Guna2Button AddEventBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button CloseAppBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button MinimazedBtn;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}