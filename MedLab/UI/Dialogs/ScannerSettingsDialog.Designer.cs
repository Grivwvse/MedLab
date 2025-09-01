namespace DiplomProgramm.UI.Dialogs
{
    partial class ScannerSettingsDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.MinimazedBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CloseAppBtn = new Guna.UI2.WinForms.Guna2Button();
            this.listBoxChooseInputDevice = new System.Windows.Forms.ListBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.ChooseVideoDeviceBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(114, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Добавление Записи";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(12, 38);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(415, 10);
            this.guna2Separator1.TabIndex = 15;
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
            this.MinimazedBtn.Location = new System.Drawing.Point(562, 12);
            this.MinimazedBtn.Name = "MinimazedBtn";
            this.MinimazedBtn.ShadowDecoration.Parent = this.MinimazedBtn;
            this.MinimazedBtn.Size = new System.Drawing.Size(20, 20);
            this.MinimazedBtn.TabIndex = 18;
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
            this.CloseAppBtn.Location = new System.Drawing.Point(409, 12);
            this.CloseAppBtn.Name = "CloseAppBtn";
            this.CloseAppBtn.ShadowDecoration.Parent = this.CloseAppBtn;
            this.CloseAppBtn.Size = new System.Drawing.Size(20, 20);
            this.CloseAppBtn.TabIndex = 17;
            this.CloseAppBtn.Text = "X";
            this.CloseAppBtn.Click += new System.EventHandler(this.CloseAppBtn_Click);
            // 
            // listBoxChooseInputDevice
            // 
            this.listBoxChooseInputDevice.FormattingEnabled = true;
            this.listBoxChooseInputDevice.Location = new System.Drawing.Point(49, 101);
            this.listBoxChooseInputDevice.Name = "listBoxChooseInputDevice";
            this.listBoxChooseInputDevice.Size = new System.Drawing.Size(336, 212);
            this.listBoxChooseInputDevice.TabIndex = 19;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // ChooseVideoDeviceBtn
            // 
            this.ChooseVideoDeviceBtn.BorderRadius = 10;
            this.ChooseVideoDeviceBtn.CheckedState.Parent = this.ChooseVideoDeviceBtn;
            this.ChooseVideoDeviceBtn.CustomImages.Parent = this.ChooseVideoDeviceBtn;
            this.ChooseVideoDeviceBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseVideoDeviceBtn.ForeColor = System.Drawing.Color.White;
            this.ChooseVideoDeviceBtn.HoverState.Parent = this.ChooseVideoDeviceBtn;
            this.ChooseVideoDeviceBtn.Location = new System.Drawing.Point(119, 355);
            this.ChooseVideoDeviceBtn.Name = "ChooseVideoDeviceBtn";
            this.ChooseVideoDeviceBtn.ShadowDecoration.Parent = this.ChooseVideoDeviceBtn;
            this.ChooseVideoDeviceBtn.Size = new System.Drawing.Size(171, 45);
            this.ChooseVideoDeviceBtn.TabIndex = 20;
            this.ChooseVideoDeviceBtn.Text = "Выбрать камеру";
            this.ChooseVideoDeviceBtn.Click += new System.EventHandler(this.ChooseVideoDeviceBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(97, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Переферийные устройства";
            // 
            // ScannerSettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChooseVideoDeviceBtn);
            this.Controls.Add(this.listBoxChooseInputDevice);
            this.Controls.Add(this.MinimazedBtn);
            this.Controls.Add(this.CloseAppBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Separator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScannerSettingsDialog";
            this.Text = "ScannerSettingsDialog";
            this.Load += new System.EventHandler(this.ScannerSettingsDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button MinimazedBtn;
        private Guna.UI2.WinForms.Guna2Button CloseAppBtn;
        private System.Windows.Forms.ListBox listBoxChooseInputDevice;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button ChooseVideoDeviceBtn;
        private System.Windows.Forms.Label label2;
    }
}