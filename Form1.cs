using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Alert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

                    MessageBox.Show(sb.ToString(), "Tarefas Pendentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnVerAlertas_Click(object sender, EventArgs e)
        {
            new FormAlerta().ShowDialog();
        }
    }
}
