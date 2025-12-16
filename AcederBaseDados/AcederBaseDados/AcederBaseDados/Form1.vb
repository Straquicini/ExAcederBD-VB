Public Class Form1
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\14642\VB\AcederBaseDados\AcederBaseDados\AcederBaseDados\Inventario.accdb")


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            con.Open()

            If con.State = ConnectionState.Open Then
                MsgBox("Ligado à BD")
            Else
                MsgBox("Não consegui ligação!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()

        End Try
    End Sub

    Private Sub botCarregarRegistos_Click(sender As Object, e As EventArgs) Handles botCarregarRegistos.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            con.Open()
            sql = "Select * from produtos"
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub BotInsert_Click(sender As Object, e As EventArgs) Handles BotInsert.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim i
            con.Open()

            ' especificar em que tabela, e em que campos vamos colocar a informação
            sql = "INSERT INTO produtos (PRODUTO_NOME, PRODUTO_DESCRICAO, QUANTIDADE, PRECO) values "
            ' especificar onde vamos buscar os dados para inserir na tabela/base de dados
            sql = sql & "('" & txtProdutoNome.Text & "', '" & txtProdutoDescricao.Text & "', '" & Val(txtQuantidade.Text) & "', '" & Val(txtPreco.Text) & "');"
            cmd.Connection = con
            cmd.CommandText = sql
            i = cmd.ExecuteNonQuery

            If i > 0 Then
                MsgBox("SUCESSO: Novo registo inserido na Base de Dados!")
            Else
                MsgBox("ERRO : Não foi inserido o registo na Base de Dados!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        Carregar()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'guarda o id a controlar, alterar o Texto Do Form, existente na coluna 1  !!
        Me.Text = DataGridView1.CurrentRow.Cells(0).Value

        ' guarda a coluna 2 em txtProdutoNome
        txtProdutoNome.Text = DataGridView1.CurrentRow.Cells(1).Value
        ' guarda a coluna 3 em txtProdutoDescricao
        txtProdutoDescricao.Text = DataGridView1.CurrentRow.Cells(2).Value
        ' guarda a coluna 4 em txtQuantidade
        txtQuantidade.Text = DataGridView1.CurrentRow.Cells(3).Value
        ' guarda a coluna 5 em txtPreco
        txtPreco.Text = DataGridView1.CurrentRow.Cells(4).Value
    End Sub

    Private Sub BotUpdate_Click(sender As Object, e As EventArgs) Handles BotUpdate.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim i

            MessageBox.Show(Me.Text)

            con.Open()
            sql = "UPDATE produtos SET "

            'vamos colocar em PRODUTO_NOME o que está na textBox txtProdutoNome
            sql = sql & " PRODUTO_NOME ='" & txtProdutoNome.Text & "', "
            'vamos colocar em PRODUTO_DESCRICAO o que está na textBox txtProdutoDescricao
            sql = sql & " PRODUTO_DESCRICAO ='" & txtProdutoDescricao.Text & "', "
            'vamos colocar em QUANTIDADE o que está na textBox txtQuantidade
            sql = sql & " QUANTIDADE ='" & Val(txtQuantidade.Text) & "', "
            'vamos colocar em PRECO o que está na textBox txtPreco
            sql = sql & " PRECO ='" & Val(txtPreco.Text) & "' "

            ' me.text é onde colocar o ID quando abrimos o registo
            sql = sql & " WHERE ID=" & Val(Me.Text) & ""

            cmd.Connection = con
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("REGISTO ATUALIZADO COM SUCESSO!")
            Else
                MsgBox("ERRO AO ATUALIZAR O REGISTO NA BASE DE DADOS!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        Carregar()
    End Sub

    Private Sub BotDelete_Click(sender As Object, e As EventArgs) Handles BotDelete.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim i

            con.Open()
            sql = "Delete * from produtos WHERE ID=" & Val(Me.Text) & ""
            cmd.Connection = con
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("REGISTO ELIMINADO COM SUCESSO!")
            Else
                MsgBox("ERRO : NENHUM REGISTO ELIMINADO NA BASE DE DADOS!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        Carregar()
    End Sub

    Public Sub Carregar()
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            con.Open()
            sql = "Select * from produtos"
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class
