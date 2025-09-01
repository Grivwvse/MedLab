namespace DiplomProgramm.UI.Dialogs
{
    partial class AddDescriprionToNewReceptionDialog
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
            this.ReceptionDescriptionTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddDescriptionOrderBtn = new Guna.UI2.WinForms.Guna2Button();
            this.MinimazedBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CloseAppBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(12, 38);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(776, 10);
            this.guna2Separator1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(228, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Добавление описание к записи";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ReceptionDescriptionTxtBox
            // 
            this.ReceptionDescriptionTxtBox.BorderRadius = 10;
            this.ReceptionDescriptionTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ReceptionDescriptionTxtBox.DefaultText = "";
            this.ReceptionDescriptionTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ReceptionDescriptionTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ReceptionDescriptionTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ReceptionDescriptionTxtBox.DisabledState.Parent = this.ReceptionDescriptionTxtBox;
            this.ReceptionDescriptionTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ReceptionDescriptionTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ReceptionDescriptionTxtBox.FocusedState.Parent = this.ReceptionDescriptionTxtBox;
            this.ReceptionDescriptionTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ReceptionDescriptionTxtBox.HoverState.Parent = this.ReceptionDescriptionTxtBox;
            this.ReceptionDescriptionTxtBox.Location = new System.Drawing.Point(12, 127);
            this.ReceptionDescriptionTxtBox.Name = "ReceptionDescriptionTxtBox";
            this.ReceptionDescriptionTxtBox.PasswordChar = '\0';
            this.ReceptionDescriptionTxtBox.PlaceholderText = "";
            this.ReceptionDescriptionTxtBox.SelectedText = "";
            this.ReceptionDescriptionTxtBox.ShadowDecoration.Parent = this.ReceptionDescriptionTxtBox;
            this.ReceptionDescriptionTxtBox.Size = new System.Drawing.Size(776, 262);
            this.ReceptionDescriptionTxtBox.TabIndex = 16;
            this.ReceptionDescriptionTxtBox.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // AddDescriptionOrderBtn
            // 
            this.AddDescriptionOrderBtn.BackColor = System.Drawing.SystemColors.Control;
            this.AddDescriptionOrderBtn.BorderRadius = 10;
            this.AddDescriptionOrderBtn.CheckedState.Parent = this.AddDescriptionOrderBtn;
            this.AddDescriptionOrderBtn.CustomImages.Parent = this.AddDescriptionOrderBtn;
            this.AddDescriptionOrderBtn.FillColor = System.Drawing.Color.LightGray;
            this.AddDescriptionOrderBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDescriptionOrderBtn.ForeColor = System.Drawing.Color.Black;
            this.AddDescriptionOrderBtn.HoverState.Parent = this.AddDescriptionOrderBtn;
            this.AddDescriptionOrderBtn.Image = global::DiplomProgramm.Properties.Resources.icons8_добавить_48;
            this.AddDescriptionOrderBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddDescriptionOrderBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.AddDescriptionOrderBtn.Location = new System.Drawing.Point(635, 66);
            this.AddDescriptionOrderBtn.Name = "AddDescriptionOrderBtn";
            this.AddDescriptionOrderBtn.ShadowDecoration.Parent = this.AddDescriptionOrderBtn;
            this.AddDescriptionOrderBtn.Size = new System.Drawing.Size(153, 41);
            this.AddDescriptionOrderBtn.TabIndex = 37;
            this.AddDescriptionOrderBtn.Text = "Добавить";
            this.AddDescriptionOrderBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AddDescriptionOrderBtn.Click += new System.EventHandler(this.AddDescriptionToNewOrderBtn_Click);
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
            this.MinimazedBtn.TabIndex = 39;
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
            this.CloseAppBtn.TabIndex = 38;
            this.CloseAppBtn.Text = "X";
            this.CloseAppBtn.Click += new System.EventHandler(this.CloseAppBtn_Click);
            // 
            // AddDescriprionToNewReceptionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.MinimazedBtn);
            this.Controls.Add(this.CloseAppBtn);
            this.Controls.Add(this.AddDescriptionOrderBtn);
            this.Controls.Add(this.ReceptionDescriptionTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Separator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDescriprionToNewReceptionDialog";
            this.Text = "AddDescriprionToNewReceptionDialog";
            this.Load += new System.EventHandler(this.AddDescriprionToNewReceptionDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox ReceptionDescriptionTxtBox;
        private Guna.UI2.WinForms.Guna2Button AddDescriptionOrderBtn;
        private Guna.UI2.WinForms.Guna2Button MinimazedBtn;
        private Guna.UI2.WinForms.Guna2Button CloseAppBtn;
    }
}