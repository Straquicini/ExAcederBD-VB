<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.botCarregarRegistos = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BotDelete = New System.Windows.Forms.Button()
        Me.BotUpdate = New System.Windows.Forms.Button()
        Me.BotInsert = New System.Windows.Forms.Button()
        Me.txtPreco = New System.Windows.Forms.TextBox()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.txtProdutoDescricao = New System.Windows.Forms.TextBox()
        Me.txtProdutoNome = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(520, 275)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.botCarregarRegistos)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(761, 303)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listagem de produtos"
        '
        'botCarregarRegistos
        '
        Me.botCarregarRegistos.Location = New System.Drawing.Point(606, 139)
        Me.botCarregarRegistos.Name = "botCarregarRegistos"
        Me.botCarregarRegistos.Size = New System.Drawing.Size(105, 23)
        Me.botCarregarRegistos.TabIndex = 1
        Me.botCarregarRegistos.Text = "Carregar Registo"
        Me.botCarregarRegistos.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BotDelete)
        Me.GroupBox2.Controls.Add(Me.BotUpdate)
        Me.GroupBox2.Controls.Add(Me.BotInsert)
        Me.GroupBox2.Controls.Add(Me.txtPreco)
        Me.GroupBox2.Controls.Add(Me.txtQuantidade)
        Me.GroupBox2.Controls.Add(Me.txtProdutoDescricao)
        Me.GroupBox2.Controls.Add(Me.txtProdutoNome)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 336)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(761, 265)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalhes do produto"
        '
        'BotDelete
        '
        Me.BotDelete.Location = New System.Drawing.Point(606, 170)
        Me.BotDelete.Name = "BotDelete"
        Me.BotDelete.Size = New System.Drawing.Size(75, 23)
        Me.BotDelete.TabIndex = 10
        Me.BotDelete.Text = "ELIMINAR"
        Me.BotDelete.UseVisualStyleBackColor = True
        '
        'BotUpdate
        '
        Me.BotUpdate.Location = New System.Drawing.Point(606, 129)
        Me.BotUpdate.Name = "BotUpdate"
        Me.BotUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BotUpdate.TabIndex = 9
        Me.BotUpdate.Text = "ATUALIZAR"
        Me.BotUpdate.UseVisualStyleBackColor = True
        '
        'BotInsert
        '
        Me.BotInsert.Location = New System.Drawing.Point(606, 86)
        Me.BotInsert.Name = "BotInsert"
        Me.BotInsert.Size = New System.Drawing.Size(75, 23)
        Me.BotInsert.TabIndex = 8
        Me.BotInsert.Text = "INSERIR"
        Me.BotInsert.UseVisualStyleBackColor = True
        '
        'txtPreco
        '
        Me.txtPreco.Location = New System.Drawing.Point(154, 190)
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.Size = New System.Drawing.Size(396, 20)
        Me.txtPreco.TabIndex = 7
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(154, 150)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(396, 20)
        Me.txtQuantidade.TabIndex = 6
        '
        'txtProdutoDescricao
        '
        Me.txtProdutoDescricao.Location = New System.Drawing.Point(154, 109)
        Me.txtProdutoDescricao.Name = "txtProdutoDescricao"
        Me.txtProdutoDescricao.Size = New System.Drawing.Size(396, 20)
        Me.txtProdutoDescricao.TabIndex = 5
        '
        'txtProdutoNome
        '
        Me.txtProdutoNome.Location = New System.Drawing.Point(154, 64)
        Me.txtProdutoNome.Name = "txtProdutoNome"
        Me.txtProdutoNome.Size = New System.Drawing.Size(396, 20)
        Me.txtProdutoNome.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(75, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "preço"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Quantidade"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descrição"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Produto"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 618)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents botCarregarRegistos As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtPreco As TextBox
    Friend WithEvents txtQuantidade As TextBox
    Friend WithEvents txtProdutoDescricao As TextBox
    Friend WithEvents txtProdutoNome As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BotDelete As Button
    Friend WithEvents BotUpdate As Button
    Friend WithEvents BotInsert As Button
End Class
