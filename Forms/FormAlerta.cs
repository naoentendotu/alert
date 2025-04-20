using MetroFramework.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alert
{
    public partial class FormAlerta : MetroFramework.Forms.MetroForm
    {
        public FormAlerta()
        {
            InitializeComponent();
        }

        private void FormAlerta_Load(object sender, EventArgs e)
        {
            string caminhoJson = Path.Combine(Application.StartupPath, "tarefas.json");
            if (!File.Exists(caminhoJson)) return;

            var json = File.ReadAllText(caminhoJson);
            var tarefas = JsonConvert.DeserializeObject<List<Tarefa>>(json);
            var hoje = DateTime.Today;

            foreach (var tarefa in tarefas)
            {
                // Fazendo com o ListBox
                //int dias = (tarefa.DataEntrega - hoje).Days;
                //string texto = $"{tarefa.Nome} | {tarefa.Tipo} | {tarefa.Descricao} | {tarefa.Materia} | Faltam {dias} dias para entregar!";
                //listBox1.Items.Add(texto);

            //=================================================================================================================================

                // Fazendo com o MetroGrid

                // Adicionando colunas ao DataGridView
                gridTarefas.Columns.Add("Nome", "Nome");
                gridTarefas.Columns.Add("Tipo", "Tipo");
                gridTarefas.Columns.Add("Descricao", "Descrição");
                gridTarefas.Columns.Add("Materia", "Matéria");
                gridTarefas.Columns.Add("DataEntrega", "Data de Entrega");

                // Adicionando os dados ao DataGridView
                int dias = (tarefa.DataEntrega - hoje).Days;
                string[] linha = new string[]
                {
                    tarefa.Nome,
                    tarefa.Tipo,
                    tarefa.Descricao,
                    tarefa.Materia,
                    tarefa.DataEntrega.ToString("dd/MM/yyyy")
                };

                gridTarefas.Rows.Add(linha);

            }

        }
    }
}
