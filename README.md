# 🗄️ Aplicação Visual Basic com Base de Dados Microsoft Access

## 📖 Descrição

Este projeto consiste numa aplicação desenvolvida em **Visual Basic .NET** que permite aceder e trabalhar com dados armazenados numa base de dados criada no **Microsoft Access**.

A aplicação utiliza **ADO.NET** e um **DataSet** para estabelecer a ligação à base de dados, carregar os dados e permitir a sua consulta e apresentação através da interface gráfica.

A base de dados utilizada no projeto é um ficheiro do Microsoft Access com a extensão:

```text
.accdb
```

---

# 🧩 DataSet

O `DataSet` é utilizado para armazenar os dados provenientes da base de dados do Access.

Depois de executar uma consulta, os dados podem ser carregados para o `DataSet`.

Exemplo:

```vb
Dim ds As New DataSet()
```

O `DataSet` pode conter uma ou várias `DataTable`.

Exemplo:

```text
DataSet
│
├── Clientes
│
├── Produtos
│
└── Encomendas
```

---

# 🔌 Ligação ao Microsoft Access

Para estabelecer a ligação ao Access pode ser utilizado o `OleDbConnection`.

Exemplo:

```vb
Dim connectionString As String

connectionString =
    "Provider=Microsoft.ACE.OLEDB.12.0;" &
    "Data Source=C:\Projeto\BaseDados.accdb;"
```

A string de ligação indica:

* o provider utilizado;
* a localização da base de dados;
* o ficheiro `.accdb` que contém os dados.

---

# 📥 Carregar dados para o DataSet

Depois de estabelecer a ligação, pode ser utilizado um `OleDbDataAdapter` para executar uma consulta SQL e carregar os resultados para o `DataSet`.

---

📚 Conceitos utilizados

O projeto permite aplicar conhecimentos de:

Visual Basic .NET;
Microsoft Access;
Bases de dados relacionais;
ADO.NET;
DataSet;
DataTable;
OleDbConnection;
OleDbCommand;
OleDbDataAdapter;
SQL;
CRUD;
Windows Forms;
DataGridView;
Programação orientada a eventos.

---

👨‍💻 Autor

Nome: [Renan Straquicni]

---

📜 Licença

Este projeto foi desenvolvido para fins académicos e educacionais.
