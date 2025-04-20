using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace Alert
{
    public partial class FormTarefa: Form
    {
        private List<Tarefa> tarefas;
        private string caminhoJson = Path.Combine(Application.StartupPath, "tarefas.json");
        public FormTarefa()
        {
            InitializeComponent();
            CarregarTarefas();
        }

        private void CarregarTarefas()
        {
            if (File.Exists(caminhoJson))
            {
                string json = File.ReadAllText(caminhoJson);
                tarefas = JsonConvert.DeserializeObject<List<Tarefa>>(json);

                if (tarefas == null)
                    tarefas = new List<Tarefa>();
            }
            else
            {
                tarefas = new List<Tarefa>();
            }
        }
        private void FormTarefa_Load(object sender, EventArgs e)
        {
            CarregarTarefas();

            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("Trabalho");
            cmbTipo.Items.Add("Prova");
            cmbTipo.Items.Add("Apresentação");
            cmbTipo.Items.Add("Revisão");
            cmbTipo.Items.Add("Entrega de Projeto");

            cmbTipo.SelectedIndex = 0;

        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            var novaTarefa = new Tarefa
            {
                Nome = txtNome.Text,
                Tipo = cmbTipo.Text,
                Descricao = txtDescricao.Text,
                Materia = txtMateria.Text,
                DataEntrega = dtpDataEntrega.Value.Date
            };

            tarefas.Add(novaTarefa);

            string json = JsonConvert.SerializeObject(tarefas, Formatting.Indented);
            File.WriteAllText(caminhoJson, json);

            MessageBox.Show("Tarefa salva com sucesso!");
            this.Close();
        }
    }
}
