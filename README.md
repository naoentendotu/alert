## 📌 Projeto: ALERT! — Windows Forms com C#

### 🧠 Sobre o Projeto

A ideia surgiu depois que eu perdi o prazo de entrega de um exercício, a aplicação tem como objetivo ajudar no controle de **trabalhos, provas e prazos**, exibindo um alerta com quantos dias faltam para cada atividade cadastrada.

Consiste em uma aplicação desktop desenvolvida em **.NET C# (Windows Forms)** que exibe um alerta com suas tarefas pendentes toda vez que o notebook é ligado.

---

### 🛠️ Funcionalidades

- ✅ Adicionar novas tarefas, com as seguintes informações:
    - Nome
    - Tipo (Trabalho, Prova, Atividade etc.)
    - Descrição
    - Matéria
    - Data de entrega
- 📝 Editar e excluir tarefas (em desenvolvimento)
- 🔔 Exibir alerta automático com detalhamento das tarefas pendentes e quantos dias faltam
- 💾 Salvar dados localmente em um arquivo `tarefas.json`
- 🖱️ Interface gráfica moderna com **MetroFramework**

---

### 📦 Tecnologias Utilizadas

- 🖥️ .NET Framework (Windows Forms)
- 💾 JSON para armazenamento local
- 🧩 Newtonsoft.Json (via NuGet) para manipulação de arquivos JSON
- 🧩 MetroFramework (via NuGet) para personalização de telas

---

### 🚀 Como Execut

1. Clone o repositório:
    
    ```bash
    bash
    git clone https://github.com/seu-usuario/alerta-tarefas.git
    
    ```
    
2. Abra o projeto no **Visual Studio Community 2022**
3. Instale o pacote `Newtonsoft.Json` e `MetroFramework` via NuGet:
    - Menu `Ferramentas > Gerenciador de Pacotes NuGet > Gerenciar Pacotes`
    - Busque por `Newtonsoft.Json` e clique em "Instalar" (faça o mesmo com `MetroFramework`)
4. Compile e execute o projeto (`F5`)
5. A tela inicial irá exibir as tarefas salvas (se existirem), ou um aviso de que ainda não há tarefas (e criar o arquivo onde serão adicionadas as novas tarefas).

---

### 🔁 Execução Automática ao Ligar o PC (opcional)

Para que o alerta seja exibido automaticamente ao iniciar o sistema:

1. Compile o projeto em **Release** e gere o `.exe`
2. Copie o caminho do executável
3. Pressione `Win + R`, digite `shell:startup` e pressione Enter
4. Cole um atalho do seu executável na pasta de inicialização

Pronto! Toda vez que o sistema iniciar, sua aplicação será executada.

---

### ✨ Funcionalidades Futuras

- ✅ Edição e exclusão de tarefas
- 🌈 Melhorar o visual com ícones e estilos personalizados
- 📅 Adicionar visualização em calendário
- 🔔 Notificações do sistema

---
