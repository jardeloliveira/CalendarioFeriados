namespace CalendarioFeriados.Forms
{
    partial class CalendarioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarioForm));
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.atualizarBtn = new MetroFramework.Controls.MetroButton();
            this.codibge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calendario
            // 
            this.calendario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calendario.CalendarDimensions = new System.Drawing.Size(3, 2);
            this.calendario.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.calendario.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.calendario.Location = new System.Drawing.Point(29, 93);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 1;
            this.calendario.TitleForeColor = System.Drawing.SystemColors.ControlLight;
            this.calendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendario_DateSelected);
            // 
            // atualizarBtn
            // 
            this.atualizarBtn.Location = new System.Drawing.Point(634, 58);
            this.atualizarBtn.Name = "atualizarBtn";
            this.atualizarBtn.Size = new System.Drawing.Size(75, 23);
            this.atualizarBtn.TabIndex = 2;
            this.atualizarBtn.Text = "Atualizar";
            this.atualizarBtn.UseSelectable = true;
            this.atualizarBtn.Click += new System.EventHandler(this.atualizarBtn_Click);
            // 
            // codibge
            // 
            this.codibge.AcceptsReturn = true;
            this.codibge.Location = new System.Drawing.Point(563, 58);
            this.codibge.MaxLength = 10;
            this.codibge.Name = "codibge";
            this.codibge.Size = new System.Drawing.Size(65, 20);
            this.codibge.TabIndex = 3;
            this.codibge.Text = "3550308";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cód. IBGE";
            // 
            // CalendarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codibge);
            this.Controls.Add(this.atualizarBtn);
            this.Controls.Add(this.calendario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalendarioForm";
            this.Text = "Calendário";
            this.Load += new System.EventHandler(this.CalendarioForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendario;
        private MetroFramework.Controls.MetroButton atualizarBtn;
        private System.Windows.Forms.TextBox codibge;
        private System.Windows.Forms.Label label1;
    }
}