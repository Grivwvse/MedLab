namespace DiplomProgramm.UI.Administrator
{
    partial class AFeedback
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
            this.AddNewUserBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddNewUserBtn
            // 
            this.AddNewUserBtn.BackColor = System.Drawing.SystemColors.Control;
            this.AddNewUserBtn.BorderRadius = 10;
            this.AddNewUserBtn.CheckedState.Parent = this.AddNewUserBtn;
            this.AddNewUserBtn.CustomImages.Parent = this.AddNewUserBtn;
            this.AddNewUserBtn.FillColor = System.Drawing.Color.LightGray;
            this.AddNewUserBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewUserBtn.ForeColor = System.Drawing.Color.Black;
            this.AddNewUserBtn.HoverState.Parent = this.AddNewUserBtn;
            this.AddNewUserBtn.Image = global::DiplomProgramm.Properties.Resources.icons8_tiktok_подтвержденный_аккаунт_48;
            this.AddNewUserBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddNewUserBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.AddNewUserBtn.Location = new System.Drawing.Point(820, 593);
            this.AddNewUserBtn.Name = "AddNewUserBtn";
            this.AddNewUserBtn.ShadowDecoration.Parent = this.AddNewUserBtn;
            this.AddNewUserBtn.Size = new System.Drawing.Size(155, 45);
            this.AddNewUserBtn.TabIndex = 31;
            this.AddNewUserBtn.Text = "Отправить";
            this.AddNewUserBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AddNewUserBtn.Click += new System.EventHandler(this.AddNewUserBtn_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(25, 187);
            this.guna2TextBox1.Multiline = true;
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(950, 377);
            this.guna2TextBox1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(260, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 37);
            this.label1.TabIndex = 34;
            this.label1.Text = "Обратная связь с разработчиком";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(676, 22);
            this.label2.TabIndex = 35;
            this.label2.Text = "*В тексте сообщения указите ФИО, организацию, должность и суть обращения";
            // 
            // AFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.AddNewUserBtn);
            this.Name = "AFeedback";
            this.Load += new System.EventHandler(this.AFeedback_Load);
            this.Controls.SetChildIndex(this.AddNewUserBtn, 0);
            this.Controls.SetChildIndex(this.guna2TextBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button AddNewUserBtn;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
