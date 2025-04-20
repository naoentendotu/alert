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
    public partial class FormAlerta : Form
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
                int dias = (tarefa.DataEntrega - hoje).Days;
                string texto = $"{tarefa.Nome} | {tarefa.Tipo} | {tarefa.Descricao} | {tarefa.Materia} | Faltam {dias} dias para entregar!";
                listBox1.Items.Add(texto);
            }
        }
    }
}
