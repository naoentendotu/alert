using MetroFramework.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Alert
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private MetroFramework.Components.MetroStyleManager styleManager;

        public Form1()
        {
            InitializeComponent();
            styleManager = new MetroFramework.Components.MetroStyleManager();
            styleManager.Owner = this; // Define o dono como o formulário atual
            styleManager.Style = MetroFramework.MetroColorStyle.Purple; // Cor
            styleManager.Theme = MetroFramework.MetroThemeStyle.Light; // Tema

            this.StyleManager = styleManager;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string caminhoJson = Path.Combine(Application.StartupPath, "tarefas.json");

            if (File.Exists(caminhoJson))
            {
                string json = File.ReadAllText(caminhoJson);
                List<Tarefa> tarefas = JsonConvert.DeserializeObject<List<Tarefa>>(json);

                if (tarefas != null && tarefas.Count > 0)
                {
                    StringBuilder sb = new StringBuilder();
                    DateTime hoje = DateTime.Today;

                    foreach (var tarefa in tarefas)
                    {
                        int diasFaltando = (tarefa.DataEntrega - hoje).Days;
                        sb.AppendLine($"{tarefa.Tipo} - {tarefa.Descricao} - Faltam {diasFaltando} dias");
                    }

                    // Exibe a mensagem com as tarefas pendentes
                    // Posteriormente fazer um FormMenssagemBox
                    MetroFramework.MetroMessageBox.Show(this, sb.ToString(), "Tarefas Pendentes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Nenhuma tarefa encontrada.");
                }
            }
            else
            {
                File.WriteAllText(caminhoJson, "[]");
                MessageBox.Show("Arquivo de tarefas criado (vazio). Adicione sua primeira tarefa.");
            }

            // this.Close(); 
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new FormTarefa().ShowDialog();
        }

        private void btnVerTarefas_Click(object sender, EventArgs e)
        {
            new FormAlerta().ShowDialog();
        }
    }
}
