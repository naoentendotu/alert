namespace Alert
{
    partial class FormTarefa
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
            this.dtpDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.cmbTipo = new MetroFramework.Controls.MetroComboBox();
            this.txtDescricao = new MetroFramework.Controls.MetroTextBox();
            this.txtMateria = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // dtpDataEntrega
            // 
            this.dtpDataEntrega.Location = new System.Drawing.Point(154, 320);
            this.dtpDataEntrega.Name = "dtpDataEntrega";
            this.dtpDataEntrega.Size = new System.Drawing.Size(330, 22);
            this.dtpDataEntrega.TabIndex = 5;
            this.dtpDataEntrega.Tag = "DATA";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(386, 376);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(97, 37);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(154, 376);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 37);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(74, 26);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(0, 0);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel1.TabIndex = 8;
            this.htmlLabel1.Text = "htmlLabel1";
            // 
            // txtNome
            // 
            // 
            // 
            // 
            this.txtNome.CustomButton.Image = null;
            this.txtNome.CustomButton.Location = new System.Drawing.Point(307, 1);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(153, 118);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PromptText = "NOME";
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(330, 30);
            this.txtNome.TabIndex = 9;
            this.txtNome.Tag = "NOME";
            this.txtNome.UseSelectable = true;
            this.txtNome.UseStyleColors = true;
            this.txtNome.WaterMark = "NOME";
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.ItemHeight = 24;
            this.cmbTipo.Items.AddRange(new object[] {
            "TRABALHO",
            "PROVA",
            "ATIVIDADE",
            "OUTRO"});
            this.cmbTipo.Location = new System.Drawing.Point(153, 167);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(5);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(330, 30);
            this.cmbTipo.TabIndex = 11;
            this.cmbTipo.Tag = "TIPO";
            this.cmbTipo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cmbTipo.UseSelectable = true;
            this.cmbTipo.UseStyleColors = true;
            // 
            // txtDescricao
            // 
            // 
            // 
            // 
            this.txtDescricao.CustomButton.Image = null;
            this.txtDescricao.CustomButton.Location = new System.Drawing.Point(307, 1);
            this.txtDescricao.CustomButton.Name = "";
            this.txtDescricao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescricao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescricao.CustomButton.TabIndex = 1;
            this.txtDescricao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescricao.CustomButton.UseSelectable = true;
            this.txtDescricao.CustomButton.Visible = false;
            this.txtDescricao.Lines = new string[0];
            this.txtDescricao.Location = new System.Drawing.Point(153, 215);
            this.txtDescricao.MaxLength = 32767;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PasswordChar = '\0';
            this.txtDescricao.PromptText = "DESCRIÇÃO";
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescricao.SelectedText = "";
            this.txtDescricao.SelectionLength = 0;
            this.txtDescricao.SelectionStart = 0;
            this.txtDescricao.ShortcutsEnabled = true;
            this.txtDescricao.Size = new System.Drawing.Size(330, 30);
            this.txtDescricao.TabIndex = 12;
            this.txtDescricao.Tag = "NOME";
            this.txtDescricao.UseSelectable = true;
            this.txtDescricao.WaterMark = "DESCRIÇÃO";
            this.txtDescricao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescricao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMateria
            // 
            // 
            // 
            // 
            this.txtMateria.CustomButton.Image = null;
            this.txtMateria.CustomButton.Location = new System.Drawing.Point(307, 1);
            this.txtMateria.CustomButton.Name = "";
            this.txtMateria.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMateria.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMateria.CustomButton.TabIndex = 1;
            this.txtMateria.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMateria.CustomButton.UseSelectable = true;
            this.txtMateria.CustomButton.Visible = false;
            this.txtMateria.Lines = new string[0];
            this.txtMateria.Location = new System.Drawing.Point(153, 267);
            this.txtMateria.MaxLength = 32767;
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.PasswordChar = '\0';
            this.txtMateria.PromptText = "MATÉRIA";
            this.txtMateria.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMateria.SelectedText = "";
            this.txtMateria.SelectionLength = 0;
            this.txtMateria.SelectionStart = 0;
            this.txtMateria.ShortcutsEnabled = true;
            this.txtMateria.Size = new System.Drawing.Size(330, 30);
            this.txtMateria.TabIndex = 13;
            this.txtMateria.Tag = "MATÉRIA";
            this.txtMateria.UseSelectable = true;
            this.txtMateria.WaterMark = "MATÉRIA";
            this.txtMateria.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMateria.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FormTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 462);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dtpDataEntrega);
            this.Name = "FormTarefa";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "ADICIONAR TAREFA";
            this.Load += new System.EventHandler(this.FormTarefa_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpDataEntrega;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroComboBox cmbTipo;
        private MetroFramework.Controls.MetroTextBox txtDescricao;
        private MetroFramework.Controls.MetroTextBox txtMateria;
    }
}