namespace Alert
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdicionar = new MetroFramework.Controls.MetroButton();
            this.btnVerTarefas = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Purple;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdicionar.Location = new System.Drawing.Point(216, 119);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(275, 120);
            this.btnAdicionar.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "ADICIONAR TAREFA";
            this.btnAdicionar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAdicionar.UseCustomBackColor = true;
            this.btnAdicionar.UseCustomForeColor = true;
            this.btnAdicionar.UseSelectable = true;
            this.btnAdicionar.UseStyleColors = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnVerTarefas
            // 
            this.btnVerTarefas.BackColor = System.Drawing.Color.Purple;
            this.btnVerTarefas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerTarefas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVerTarefas.Location = new System.Drawing.Point(216, 288);
            this.btnVerTarefas.Name = "btnVerTarefas";
            this.btnVerTarefas.Size = new System.Drawing.Size(275, 120);
            this.btnVerTarefas.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnVerTarefas.TabIndex = 1;
            this.btnVerTarefas.Text = "VER TAREFAS";
            this.btnVerTarefas.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnVerTarefas.UseCustomBackColor = true;
            this.btnVerTarefas.UseCustomForeColor = true;
            this.btnVerTarefas.UseSelectable = true;
            this.btnVerTarefas.UseStyleColors = true;
            this.btnVerTarefas.Click += new System.EventHandler(this.btnVerTarefas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(722, 525);
            this.Controls.Add(this.btnVerTarefas);
            this.Controls.Add(this.btnAdicionar);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Gerenciamento de Tarefas";
            this.TransparencyKey = System.Drawing.Color.DarkMagenta;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnAdicionar;
        private MetroFramework.Controls.MetroButton btnVerTarefas;
    }
}

