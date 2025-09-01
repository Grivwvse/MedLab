namespace DiplomProgramm.UI.LaboratoryAssistant
{
    partial class LASearchClients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.TextBoxScannerData = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.label5 = new System.Windows.Forms.Label();
            this.OrderNumberLable = new System.Windows.Forms.Label();
            this.LaborantViewAnalyzesListDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SaveReceptionBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ScanSettingsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PictureBoxCameraImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StopScanBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            ((System.ComponentModel.ISupportInitialize)(this.LaborantViewAnalyzesListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCameraImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // TextBoxScannerData
            // 
            this.TextBoxScannerData.BorderRadius = 10;
            this.TextBoxScannerData.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxScannerData.DefaultText = "";
            this.TextBoxScannerData.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxScannerData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxScannerData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxScannerData.DisabledState.Parent = this.TextBoxScannerData;
            this.TextBoxScannerData.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxScannerData.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxScannerData.FocusedState.Parent = this.TextBoxScannerData;
            this.TextBoxScannerData.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxScannerData.HoverState.Parent = this.TextBoxScannerData;
            this.TextBoxScannerData.Location = new System.Drawing.Point(35, 443);
            this.TextBoxScannerData.Name = "TextBoxScannerData";
            this.TextBoxScannerData.PasswordChar = '\0';
            this.TextBoxScannerData.PlaceholderText = "";
            this.TextBoxScannerData.SelectedText = "";
            this.TextBoxScannerData.ShadowDecoration.Parent = this.TextBoxScannerData;
            this.TextBoxScannerData.Size = new System.Drawing.Size(248, 36);
            this.TextBoxScannerData.TabIndex = 22;
            this.TextBoxScannerData.TextChanged += new System.EventHandler(this.TextBoxScannerData_TextChanged);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(331, 71);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 525);
            this.guna2VSeparator1.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(553, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 26);
            this.label5.TabIndex = 28;
            this.label5.Text = "Данные Анализа";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // OrderNumberLable
            // 
            this.OrderNumberLable.AutoSize = true;
            this.OrderNumberLable.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderNumberLable.Location = new System.Drawing.Point(362, 91);
            this.OrderNumberLable.Name = "OrderNumberLable";
            this.OrderNumberLable.Size = new System.Drawing.Size(95, 26);
            this.OrderNumberLable.TabIndex = 34;
            this.OrderNumberLable.Text = "Заказ №";
            // 
            // LaborantViewAnalyzesListDataGridView
            // 
            this.LaborantViewAnalyzesListDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.LaborantViewAnalyzesListDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.LaborantViewAnalyzesListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LaborantViewAnalyzesListDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.LaborantViewAnalyzesListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LaborantViewAnalyzesListDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.LaborantViewAnalyzesListDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LaborantViewAnalyzesListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.LaborantViewAnalyzesListDataGridView.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LaborantViewAnalyzesListDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.LaborantViewAnalyzesListDataGridView.EnableHeadersVisualStyles = false;
            this.LaborantViewAnalyzesListDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.LaborantViewAnalyzesListDataGridView.Location = new System.Drawing.Point(357, 178);
            this.LaborantViewAnalyzesListDataGridView.Name = "LaborantViewAnalyzesListDataGridView";
            this.LaborantViewAnalyzesListDataGridView.RowHeadersVisible = false;
            this.LaborantViewAnalyzesListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LaborantViewAnalyzesListDataGridView.Size = new System.Drawing.Size(618, 371);
            this.LaborantViewAnalyzesListDataGridView.TabIndex = 35;
            this.LaborantViewAnalyzesListDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.LaborantViewAnalyzesListDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.LaborantViewAnalyzesListDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.LaborantViewAnalyzesListDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.LaborantViewAnalyzesListDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.LaborantViewAnalyzesListDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.LaborantViewAnalyzesListDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.LaborantViewAnalyzesListDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.LaborantViewAnalyzesListDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.LaborantViewAnalyzesListDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.LaborantViewAnalyzesListDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.LaborantViewAnalyzesListDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.LaborantViewAnalyzesListDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.LaborantViewAnalyzesListDataGridView.ThemeStyle.HeaderStyle.Height = 40;
            this.LaborantViewAnalyzesListDataGridView.ThemeStyle.ReadOnly = false;
            this.LaborantViewAnalyzesListDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.LaborantViewAnalyzesListDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.LaborantViewAnalyzesListDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.LaborantViewAnalyzesListDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.LaborantViewAnalyzesListDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.LaborantViewAnalyzesListDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.LaborantViewAnalyzesListDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.LaborantViewAnalyzesListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LaborantViewAnalyzesListDataGridView_CellContentClick);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.LightGray;
            this.guna2Button1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::DiplomProgramm.Properties.Resources.icons8_сканирование_изображения_48;
            this.guna2Button1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button1.Location = new System.Drawing.Point(35, 326);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(248, 42);
            this.guna2Button1.TabIndex = 36;
            this.guna2Button1.Text = "Начать сканирование";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
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
            this.SaveReceptionBtn.Image = global::DiplomProgramm.Properties.Resources.icons8_добавить_48;
            this.SaveReceptionBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.SaveReceptionBtn.Location = new System.Drawing.Point(813, 555);
            this.SaveReceptionBtn.Name = "SaveReceptionBtn";
            this.SaveReceptionBtn.ShadowDecoration.Parent = this.SaveReceptionBtn;
            this.SaveReceptionBtn.Size = new System.Drawing.Size(162, 41);
            this.SaveReceptionBtn.TabIndex = 33;
            this.SaveReceptionBtn.Text = "Результат";
            this.SaveReceptionBtn.Click += new System.EventHandler(this.SaveReceptionBtn_Click);
            // 
            // ScanSettingsBtn
            // 
            this.ScanSettingsBtn.BorderRadius = 10;
            this.ScanSettingsBtn.CheckedState.Parent = this.ScanSettingsBtn;
            this.ScanSettingsBtn.CustomImages.Parent = this.ScanSettingsBtn;
            this.ScanSettingsBtn.FillColor = System.Drawing.Color.LightGray;
            this.ScanSettingsBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScanSettingsBtn.ForeColor = System.Drawing.Color.Black;
            this.ScanSettingsBtn.HoverState.Parent = this.ScanSettingsBtn;
            this.ScanSettingsBtn.Image = global::DiplomProgramm.Properties.Resources.icons8_настройки_48;
            this.ScanSettingsBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.ScanSettingsBtn.Location = new System.Drawing.Point(929, 71);
            this.ScanSettingsBtn.Name = "ScanSettingsBtn";
            this.ScanSettingsBtn.ShadowDecoration.Parent = this.ScanSettingsBtn;
            this.ScanSettingsBtn.Size = new System.Drawing.Size(46, 46);
            this.ScanSettingsBtn.TabIndex = 21;
            this.ScanSettingsBtn.Click += new System.EventHandler(this.ScanSettingsBtn_Click);
            // 
            // PictureBoxCameraImage
            // 
            this.PictureBoxCameraImage.Location = new System.Drawing.Point(25, 71);
            this.PictureBoxCameraImage.Name = "PictureBoxCameraImage";
            this.PictureBoxCameraImage.ShadowDecoration.Parent = this.PictureBoxCameraImage;
            this.PictureBoxCameraImage.Size = new System.Drawing.Size(300, 200);
            this.PictureBoxCameraImage.TabIndex = 11;
            this.PictureBoxCameraImage.TabStop = false;
            this.PictureBoxCameraImage.Click += new System.EventHandler(this.PictureBoxCameraImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 22);
            this.label2.TabIndex = 37;
            this.label2.Text = "введите номер заказа вручную";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(140, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 22);
            this.label3.TabIndex = 38;
            this.label3.Text = "ИЛИ";
            // 
            // StopScanBtn
            // 
            this.StopScanBtn.BorderRadius = 10;
            this.StopScanBtn.CheckedState.Parent = this.StopScanBtn;
            this.StopScanBtn.CustomImages.Parent = this.StopScanBtn;
            this.StopScanBtn.FillColor = System.Drawing.Color.LightGray;
            this.StopScanBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopScanBtn.ForeColor = System.Drawing.Color.Black;
            this.StopScanBtn.HoverState.Parent = this.StopScanBtn;
            this.StopScanBtn.Image = global::DiplomProgramm.Properties.Resources.icons8_остановка_в_квадрате_48;
            this.StopScanBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.StopScanBtn.Location = new System.Drawing.Point(35, 277);
            this.StopScanBtn.Name = "StopScanBtn";
            this.StopScanBtn.ShadowDecoration.Parent = this.StopScanBtn;
            this.StopScanBtn.Size = new System.Drawing.Size(290, 42);
            this.StopScanBtn.TabIndex = 39;
            this.StopScanBtn.Text = "Остановить сканирование";
            this.StopScanBtn.Click += new System.EventHandler(this.StopScanBtn_Click);
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.Location = new System.Drawing.Point(347, 162);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(618, 10);
            this.guna2Separator3.TabIndex = 41;
            // 
            // LASearchClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.guna2Separator3);
            this.Controls.Add(this.StopScanBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.LaborantViewAnalyzesListDataGridView);
            this.Controls.Add(this.OrderNumberLable);
            this.Controls.Add(this.SaveReceptionBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.TextBoxScannerData);
            this.Controls.Add(this.ScanSettingsBtn);
            this.Controls.Add(this.PictureBoxCameraImage);
            this.Name = "LASearchClients";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LASearchClients_FormClosing);
            this.Load += new System.EventHandler(this.LASearchClients_Load);
            this.Controls.SetChildIndex(this.PictureBoxCameraImage, 0);
            this.Controls.SetChildIndex(this.ScanSettingsBtn, 0);
            this.Controls.SetChildIndex(this.TextBoxScannerData, 0);
            this.Controls.SetChildIndex(this.guna2VSeparator1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.SaveReceptionBtn, 0);
            this.Controls.SetChildIndex(this.OrderNumberLable, 0);
            this.Controls.SetChildIndex(this.LaborantViewAnalyzesListDataGridView, 0);
            this.Controls.SetChildIndex(this.guna2Button1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.StopScanBtn, 0);
            this.Controls.SetChildIndex(this.guna2Separator3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.LaborantViewAnalyzesListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCameraImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxCameraImage;
        private Guna.UI2.WinForms.Guna2Button ScanSettingsBtn;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxScannerData;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label OrderNumberLable;
        private Guna.UI2.WinForms.Guna2Button SaveReceptionBtn;
        private Guna.UI2.WinForms.Guna2DataGridView LaborantViewAnalyzesListDataGridView;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button StopScanBtn;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
    }
}
