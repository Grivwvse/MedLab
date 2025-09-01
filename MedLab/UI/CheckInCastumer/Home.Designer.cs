namespace DiplomProgramm.UI.CheckInCastumer
{
    partial class Home
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
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.ReceptionDataGridViewEvents = new Guna.UI2.WinForms.Guna2DataGridView();
            this.NewsLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.WelcomeLable = new System.Windows.Forms.Label();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReceptionDataGridViewEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.ReceptionDataGridViewEvents);
            this.guna2Panel2.Location = new System.Drawing.Point(25, 130);
            this.guna2Panel2.MaximumSize = new System.Drawing.Size(1800, 980);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(950, 518);
            this.guna2Panel2.TabIndex = 7;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // ReceptionDataGridViewEvents
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ReceptionDataGridViewEvents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ReceptionDataGridViewEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReceptionDataGridViewEvents.BackgroundColor = System.Drawing.Color.White;
            this.ReceptionDataGridViewEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReceptionDataGridViewEvents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ReceptionDataGridViewEvents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReceptionDataGridViewEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ReceptionDataGridViewEvents.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReceptionDataGridViewEvents.DefaultCellStyle = dataGridViewCellStyle3;
            this.ReceptionDataGridViewEvents.EnableHeadersVisualStyles = false;
            this.ReceptionDataGridViewEvents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReceptionDataGridViewEvents.Location = new System.Drawing.Point(0, 0);
            this.ReceptionDataGridViewEvents.Name = "ReceptionDataGridViewEvents";
            this.ReceptionDataGridViewEvents.RowHeadersVisible = false;
            this.ReceptionDataGridViewEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReceptionDataGridViewEvents.Size = new System.Drawing.Size(950, 518);
            this.ReceptionDataGridViewEvents.TabIndex = 0;
            this.ReceptionDataGridViewEvents.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.ReceptionDataGridViewEvents.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ReceptionDataGridViewEvents.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ReceptionDataGridViewEvents.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ReceptionDataGridViewEvents.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ReceptionDataGridViewEvents.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ReceptionDataGridViewEvents.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ReceptionDataGridViewEvents.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReceptionDataGridViewEvents.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ReceptionDataGridViewEvents.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ReceptionDataGridViewEvents.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ReceptionDataGridViewEvents.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ReceptionDataGridViewEvents.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ReceptionDataGridViewEvents.ThemeStyle.HeaderStyle.Height = 40;
            this.ReceptionDataGridViewEvents.ThemeStyle.ReadOnly = false;
            this.ReceptionDataGridViewEvents.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ReceptionDataGridViewEvents.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ReceptionDataGridViewEvents.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ReceptionDataGridViewEvents.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ReceptionDataGridViewEvents.ThemeStyle.RowsStyle.Height = 22;
            this.ReceptionDataGridViewEvents.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReceptionDataGridViewEvents.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ReceptionDataGridViewEvents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // NewsLabel
            // 
            this.NewsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NewsLabel.BackColor = System.Drawing.Color.Transparent;
            this.NewsLabel.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewsLabel.Location = new System.Drawing.Point(445, 76);
            this.NewsLabel.Name = "NewsLabel";
            this.NewsLabel.Size = new System.Drawing.Size(155, 48);
            this.NewsLabel.TabIndex = 8;
            this.NewsLabel.Text = "События";
            // 
            // WelcomeLable
            // 
            this.WelcomeLable.AutoSize = true;
            this.WelcomeLable.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WelcomeLable.Location = new System.Drawing.Point(21, 93);
            this.WelcomeLable.Name = "WelcomeLable";
            this.WelcomeLable.Size = new System.Drawing.Size(172, 22);
            this.WelcomeLable.TabIndex = 9;
            this.WelcomeLable.Text = "Добро пожаловать ";
            this.WelcomeLable.Click += new System.EventHandler(this.WelcomeLable_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.WelcomeLable);
            this.Controls.Add(this.NewsLabel);
            this.Controls.Add(this.guna2Panel2);
            this.Name = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.Controls.SetChildIndex(this.guna2Panel2, 0);
            this.Controls.SetChildIndex(this.NewsLabel, 0);
            this.Controls.SetChildIndex(this.WelcomeLable, 0);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReceptionDataGridViewEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel NewsLabel;
        private System.Windows.Forms.Label WelcomeLable;
        private Guna.UI2.WinForms.Guna2DataGridView ReceptionDataGridViewEvents;
    }
}
