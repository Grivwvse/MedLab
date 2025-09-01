namespace DiplomProgramm.UI.Dialogs
{
    partial class InputResultsToDBDialog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label1 = new System.Windows.Forms.Label();
            this.MinimazedBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CloseAppBtn = new Guna.UI2.WinForms.Guna2Button();
            this.LaborantInputAnalyzesListDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.SaveButtonResult = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LaborantInputAnalyzesListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(12, 38);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(776, 10);
            this.guna2Separator1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(258, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Добавление Результата";
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
            this.MinimazedBtn.TabIndex = 41;
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
            this.CloseAppBtn.TabIndex = 40;
            this.CloseAppBtn.Text = "X";
            this.CloseAppBtn.Click += new System.EventHandler(this.CloseAppBtn_Click);
            // 
            // LaborantInputAnalyzesListDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.LaborantInputAnalyzesListDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.LaborantInputAnalyzesListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LaborantInputAnalyzesListDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.LaborantInputAnalyzesListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LaborantInputAnalyzesListDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.LaborantInputAnalyzesListDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LaborantInputAnalyzesListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.LaborantInputAnalyzesListDataGridView.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LaborantInputAnalyzesListDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.LaborantInputAnalyzesListDataGridView.EnableHeadersVisualStyles = false;
            this.LaborantInputAnalyzesListDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.LaborantInputAnalyzesListDataGridView.Location = new System.Drawing.Point(12, 71);
            this.LaborantInputAnalyzesListDataGridView.Name = "LaborantInputAnalyzesListDataGridView";
            this.LaborantInputAnalyzesListDataGridView.RowHeadersVisible = false;
            this.LaborantInputAnalyzesListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LaborantInputAnalyzesListDataGridView.Size = new System.Drawing.Size(776, 323);
            this.LaborantInputAnalyzesListDataGridView.TabIndex = 42;
            this.LaborantInputAnalyzesListDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.LaborantInputAnalyzesListDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.LaborantInputAnalyzesListDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.LaborantInputAnalyzesListDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.LaborantInputAnalyzesListDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.LaborantInputAnalyzesListDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.LaborantInputAnalyzesListDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.LaborantInputAnalyzesListDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.LaborantInputAnalyzesListDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.LaborantInputAnalyzesListDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.LaborantInputAnalyzesListDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.LaborantInputAnalyzesListDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.LaborantInputAnalyzesListDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.LaborantInputAnalyzesListDataGridView.ThemeStyle.HeaderStyle.Height = 40;
            this.LaborantInputAnalyzesListDataGridView.ThemeStyle.ReadOnly = false;
            this.LaborantInputAnalyzesListDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.LaborantInputAnalyzesListDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.LaborantInputAnalyzesListDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.LaborantInputAnalyzesListDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.LaborantInputAnalyzesListDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.LaborantInputAnalyzesListDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.LaborantInputAnalyzesListDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.LaborantInputAnalyzesListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LaborantInputAnalyzesListDataGridView_CellContentClick);
            // 
            // SaveButtonResult
            // 
            this.SaveButtonResult.BorderRadius = 10;
            this.SaveButtonResult.CheckedState.Parent = this.SaveButtonResult;
            this.SaveButtonResult.CustomImages.Parent = this.SaveButtonResult;
            this.SaveButtonResult.FillColor = System.Drawing.Color.LightGray;
            this.SaveButtonResult.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButtonResult.ForeColor = System.Drawing.Color.Black;
            this.SaveButtonResult.HoverState.Parent = this.SaveButtonResult;
            this.SaveButtonResult.Image = global::DiplomProgramm.Properties.Resources.icons8_загрузка_обновлений_48;
            this.SaveButtonResult.ImageSize = new System.Drawing.Size(40, 40);
            this.SaveButtonResult.Location = new System.Drawing.Point(646, 400);
            this.SaveButtonResult.Name = "SaveButtonResult";
            this.SaveButtonResult.ShadowDecoration.Parent = this.SaveButtonResult;
            this.SaveButtonResult.Size = new System.Drawing.Size(142, 41);
            this.SaveButtonResult.TabIndex = 44;
            this.SaveButtonResult.Text = "Сохранить";
            this.SaveButtonResult.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // InputResultsToDBDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveButtonResult);
            this.Controls.Add(this.LaborantInputAnalyzesListDataGridView);
            this.Controls.Add(this.MinimazedBtn);
            this.Controls.Add(this.CloseAppBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Separator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputResultsToDBDialog";
            this.Text = "InputResultsToDBDialog";
            this.Load += new System.EventHandler(this.InputResultsToDBDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LaborantInputAnalyzesListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button MinimazedBtn;
        private Guna.UI2.WinForms.Guna2Button CloseAppBtn;
        private Guna.UI2.WinForms.Guna2Button SaveButtonResult;
        public Guna.UI2.WinForms.Guna2DataGridView LaborantInputAnalyzesListDataGridView;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}