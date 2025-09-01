namespace DiplomProgramm.UI.Administrator
{
    partial class AdministratorServices
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ServicesGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ActiveEventsLable = new System.Windows.Forms.Label();
            this.ChooseDatasourceComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ViewServiceBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.ServicesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ServicesGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ServicesGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ServicesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ServicesGridView.BackgroundColor = System.Drawing.Color.White;
            this.ServicesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServicesGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ServicesGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ServicesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ServicesGridView.ColumnHeadersHeight = 40;
            this.ServicesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ServicesGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ServicesGridView.EnableHeadersVisualStyles = false;
            this.ServicesGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ServicesGridView.Location = new System.Drawing.Point(25, 123);
            this.ServicesGridView.Name = "ServicesGridView";
            this.ServicesGridView.ReadOnly = true;
            this.ServicesGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ServicesGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ServicesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServicesGridView.Size = new System.Drawing.Size(950, 504);
            this.ServicesGridView.TabIndex = 22;
            this.ServicesGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.ServicesGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ServicesGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ServicesGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ServicesGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ServicesGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ServicesGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ServicesGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ServicesGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ServicesGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ServicesGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ServicesGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ServicesGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ServicesGridView.ThemeStyle.HeaderStyle.Height = 40;
            this.ServicesGridView.ThemeStyle.ReadOnly = true;
            this.ServicesGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ServicesGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ServicesGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ServicesGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ServicesGridView.ThemeStyle.RowsStyle.Height = 22;
            this.ServicesGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ServicesGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ServicesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ServicesGridView_CellContentClick);
            // 
            // ActiveEventsLable
            // 
            this.ActiveEventsLable.AutoSize = true;
            this.ActiveEventsLable.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActiveEventsLable.Location = new System.Drawing.Point(446, 91);
            this.ActiveEventsLable.Name = "ActiveEventsLable";
            this.ActiveEventsLable.Size = new System.Drawing.Size(80, 26);
            this.ActiveEventsLable.TabIndex = 26;
            this.ActiveEventsLable.Text = "Услуги";
            // 
            // ChooseDatasourceComboBox
            // 
            this.ChooseDatasourceComboBox.BackColor = System.Drawing.Color.Transparent;
            this.ChooseDatasourceComboBox.BorderRadius = 10;
            this.ChooseDatasourceComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ChooseDatasourceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseDatasourceComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.ChooseDatasourceComboBox.FocusedState.Parent = this.ChooseDatasourceComboBox;
            this.ChooseDatasourceComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ChooseDatasourceComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ChooseDatasourceComboBox.FormattingEnabled = true;
            this.ChooseDatasourceComboBox.HoverState.Parent = this.ChooseDatasourceComboBox;
            this.ChooseDatasourceComboBox.ItemHeight = 30;
            this.ChooseDatasourceComboBox.ItemsAppearance.Parent = this.ChooseDatasourceComboBox;
            this.ChooseDatasourceComboBox.Location = new System.Drawing.Point(25, 81);
            this.ChooseDatasourceComboBox.Name = "ChooseDatasourceComboBox";
            this.ChooseDatasourceComboBox.ShadowDecoration.Parent = this.ChooseDatasourceComboBox;
            this.ChooseDatasourceComboBox.Size = new System.Drawing.Size(189, 36);
            this.ChooseDatasourceComboBox.TabIndex = 27;
            this.ChooseDatasourceComboBox.SelectedIndexChanged += new System.EventHandler(this.ChooseDatasourceComboBox_SelectedIndexChanged);
            // 
            // ViewServiceBtn
            // 
            this.ViewServiceBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ViewServiceBtn.BorderRadius = 10;
            this.ViewServiceBtn.CheckedState.Parent = this.ViewServiceBtn;
            this.ViewServiceBtn.CustomImages.Parent = this.ViewServiceBtn;
            this.ViewServiceBtn.FillColor = System.Drawing.Color.LightGray;
            this.ViewServiceBtn.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewServiceBtn.ForeColor = System.Drawing.Color.Black;
            this.ViewServiceBtn.HoverState.Parent = this.ViewServiceBtn;
            this.ViewServiceBtn.Image = global::DiplomProgramm.Properties.Resources.icons8_view_64;
            this.ViewServiceBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ViewServiceBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.ViewServiceBtn.Location = new System.Drawing.Point(657, 72);
            this.ViewServiceBtn.Name = "ViewServiceBtn";
            this.ViewServiceBtn.ShadowDecoration.Parent = this.ViewServiceBtn;
            this.ViewServiceBtn.Size = new System.Drawing.Size(58, 45);
            this.ViewServiceBtn.TabIndex = 28;
            this.ViewServiceBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ViewServiceBtn.Click += new System.EventHandler(this.ViewServiceBtn_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Button3.BorderRadius = 10;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.LightGray;
            this.guna2Button3.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Image = global::DiplomProgramm.Properties.Resources.icons8_отмена_48;
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button3.Location = new System.Drawing.Point(721, 72);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(120, 45);
            this.guna2Button3.TabIndex = 25;
            this.guna2Button3.Text = "Удалить";
            this.guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.LightGray;
            this.guna2Button2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Image = global::DiplomProgramm.Properties.Resources.icons8_добавить_48;
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button2.Location = new System.Drawing.Point(847, 72);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(128, 45);
            this.guna2Button2.TabIndex = 24;
            this.guna2Button2.Text = "Добавить";
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // AdministratorServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.ViewServiceBtn);
            this.Controls.Add(this.ChooseDatasourceComboBox);
            this.Controls.Add(this.ActiveEventsLable);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.ServicesGridView);
            this.Name = "AdministratorServices";
            this.Activated += new System.EventHandler(this.AdministratorServices_Activated);
            this.Load += new System.EventHandler(this.AdministratorServices_Load);
            this.Controls.SetChildIndex(this.ServicesGridView, 0);
            this.Controls.SetChildIndex(this.guna2Button2, 0);
            this.Controls.SetChildIndex(this.guna2Button3, 0);
            this.Controls.SetChildIndex(this.ActiveEventsLable, 0);
            this.Controls.SetChildIndex(this.ChooseDatasourceComboBox, 0);
            this.Controls.SetChildIndex(this.ViewServiceBtn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ServicesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView ServicesGridView;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Label ActiveEventsLable;
        private Guna.UI2.WinForms.Guna2ComboBox ChooseDatasourceComboBox;
        private Guna.UI2.WinForms.Guna2Button ViewServiceBtn;
    }
}
