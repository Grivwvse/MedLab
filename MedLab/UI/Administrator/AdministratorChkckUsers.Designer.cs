namespace DiplomProgramm.UI.Administrator
{
    partial class AdministratorChkckUsers
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
            this.UserDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ChooseDatasourceComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ActiveEventsLable = new System.Windows.Forms.Label();
            this.DelUserBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AddNewUserBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UserDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.UserDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UserDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.UserDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UserDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UserDataGridView.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.UserDataGridView.EnableHeadersVisualStyles = false;
            this.UserDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UserDataGridView.Location = new System.Drawing.Point(25, 122);
            this.UserDataGridView.Name = "UserDataGridView";
            this.UserDataGridView.RowHeadersVisible = false;
            this.UserDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserDataGridView.Size = new System.Drawing.Size(950, 516);
            this.UserDataGridView.TabIndex = 19;
            this.UserDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.UserDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.UserDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.UserDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.UserDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.UserDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.UserDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.UserDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UserDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.UserDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.UserDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.UserDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.UserDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.UserDataGridView.ThemeStyle.HeaderStyle.Height = 40;
            this.UserDataGridView.ThemeStyle.ReadOnly = false;
            this.UserDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.UserDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UserDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.UserDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.UserDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.UserDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UserDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.ChooseDatasourceComboBox.Location = new System.Drawing.Point(25, 80);
            this.ChooseDatasourceComboBox.Name = "ChooseDatasourceComboBox";
            this.ChooseDatasourceComboBox.ShadowDecoration.Parent = this.ChooseDatasourceComboBox;
            this.ChooseDatasourceComboBox.Size = new System.Drawing.Size(189, 36);
            this.ChooseDatasourceComboBox.TabIndex = 28;
            this.ChooseDatasourceComboBox.SelectedIndexChanged += new System.EventHandler(this.ChooseDatasourceComboBox_SelectedIndexChanged);
            // 
            // ActiveEventsLable
            // 
            this.ActiveEventsLable.AutoSize = true;
            this.ActiveEventsLable.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActiveEventsLable.Location = new System.Drawing.Point(417, 90);
            this.ActiveEventsLable.Name = "ActiveEventsLable";
            this.ActiveEventsLable.Size = new System.Drawing.Size(154, 26);
            this.ActiveEventsLable.TabIndex = 29;
            this.ActiveEventsLable.Text = "Пользователи";
            // 
            // DelUserBtn
            // 
            this.DelUserBtn.BackColor = System.Drawing.SystemColors.Control;
            this.DelUserBtn.BorderRadius = 10;
            this.DelUserBtn.CheckedState.Parent = this.DelUserBtn;
            this.DelUserBtn.CustomImages.Parent = this.DelUserBtn;
            this.DelUserBtn.FillColor = System.Drawing.Color.LightGray;
            this.DelUserBtn.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelUserBtn.ForeColor = System.Drawing.Color.Black;
            this.DelUserBtn.HoverState.Parent = this.DelUserBtn;
            this.DelUserBtn.Image = global::DiplomProgramm.Properties.Resources.icons8_отмена_48;
            this.DelUserBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DelUserBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.DelUserBtn.Location = new System.Drawing.Point(713, 71);
            this.DelUserBtn.Name = "DelUserBtn";
            this.DelUserBtn.ShadowDecoration.Parent = this.DelUserBtn;
            this.DelUserBtn.Size = new System.Drawing.Size(128, 45);
            this.DelUserBtn.TabIndex = 31;
            this.DelUserBtn.Text = "Удалить";
            this.DelUserBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DelUserBtn.Click += new System.EventHandler(this.DelUserBtn_Click);
            // 
            // AddNewUserBtn
            // 
            this.AddNewUserBtn.BackColor = System.Drawing.SystemColors.Control;
            this.AddNewUserBtn.BorderRadius = 10;
            this.AddNewUserBtn.CheckedState.Parent = this.AddNewUserBtn;
            this.AddNewUserBtn.CustomImages.Parent = this.AddNewUserBtn;
            this.AddNewUserBtn.FillColor = System.Drawing.Color.LightGray;
            this.AddNewUserBtn.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewUserBtn.ForeColor = System.Drawing.Color.Black;
            this.AddNewUserBtn.HoverState.Parent = this.AddNewUserBtn;
            this.AddNewUserBtn.Image = global::DiplomProgramm.Properties.Resources.icons8_добавить_48;
            this.AddNewUserBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddNewUserBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.AddNewUserBtn.Location = new System.Drawing.Point(847, 71);
            this.AddNewUserBtn.Name = "AddNewUserBtn";
            this.AddNewUserBtn.ShadowDecoration.Parent = this.AddNewUserBtn;
            this.AddNewUserBtn.Size = new System.Drawing.Size(128, 45);
            this.AddNewUserBtn.TabIndex = 30;
            this.AddNewUserBtn.Text = "Добавить";
            this.AddNewUserBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AddNewUserBtn.Click += new System.EventHandler(this.AddNewUserBtn_Click);
            // 
            // AdministratorChkckUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.DelUserBtn);
            this.Controls.Add(this.AddNewUserBtn);
            this.Controls.Add(this.ActiveEventsLable);
            this.Controls.Add(this.ChooseDatasourceComboBox);
            this.Controls.Add(this.UserDataGridView);
            this.Name = "AdministratorChkckUsers";
            this.Load += new System.EventHandler(this.AdministratorChkckUsers_Load);
            this.Controls.SetChildIndex(this.UserDataGridView, 0);
            this.Controls.SetChildIndex(this.ChooseDatasourceComboBox, 0);
            this.Controls.SetChildIndex(this.ActiveEventsLable, 0);
            this.Controls.SetChildIndex(this.AddNewUserBtn, 0);
            this.Controls.SetChildIndex(this.DelUserBtn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView UserDataGridView;
        private Guna.UI2.WinForms.Guna2ComboBox ChooseDatasourceComboBox;
        private System.Windows.Forms.Label ActiveEventsLable;
        private Guna.UI2.WinForms.Guna2Button AddNewUserBtn;
        private Guna.UI2.WinForms.Guna2Button DelUserBtn;
    }
}
