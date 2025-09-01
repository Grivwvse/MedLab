namespace DiplomProgramm.UI.CheckInCastumer.ClientsPersonalAcc
{
    partial class Events
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
            this.listBoxClientEvents = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxClientEvents
            // 
            this.listBoxClientEvents.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxClientEvents.FormattingEnabled = true;
            this.listBoxClientEvents.HorizontalScrollbar = true;
            this.listBoxClientEvents.ItemHeight = 22;
            this.listBoxClientEvents.Location = new System.Drawing.Point(211, 243);
            this.listBoxClientEvents.Name = "listBoxClientEvents";
            this.listBoxClientEvents.Size = new System.Drawing.Size(777, 378);
            this.listBoxClientEvents.TabIndex = 33;
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.listBoxClientEvents);
            this.Name = "Events";
            this.Load += new System.EventHandler(this.Events_Load);
            this.Controls.SetChildIndex(this.listBoxClientEvents, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxClientEvents;
    }
}
