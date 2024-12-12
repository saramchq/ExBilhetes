Public Class Form1
    ' Variáveis globais para armazenar o preço por bilhete
    Dim precoBilhete As Double = 15.0 ' Preço padrão de 15 euros

    ' Evento de clique do botão Confirmar
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        ' Exibe os valores selecionados nas caixas de texto correspondentes
        txtPartida.Text = cmbPartida.SelectedItem.ToString()
        txtDestino.Text = cmbDestino.SelectedItem.ToString()
        txtPreco.Text = precoBilhete.ToString("F2")
    End Sub

    ' Evento de clique do botão Calcular
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        ' Verifica se o número de bilhetes e o valor pago estão preenchidos corretamente
        If txtNumBilhetes.Text <> "" And txtValorPago.Text <> "" Then
            Dim numBilhetes As Integer = Integer.Parse(txtNumBilhetes.Text)
            Dim valorPago As Double = Double.Parse(txtValorPago.Text)
            Dim total As Double = numBilhetes * precoBilhete
            Dim troco As Double = valorPago - total

            ' Exibe o troco
            txtTroco.Text = troco.ToString("F2")
        Else
            MessageBox.Show("Por favor, insira o número de bilhetes e o valor pago.")
        End If
    End Sub

    ' Evento de clique do botão Limpar
    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        ' Limpa todos os campos
        cmbPartida.SelectedIndex = -1
        cmbDestino.SelectedIndex = -1
        txtPartida.Clear()
        txtDestino.Clear()
        txtPreco.Clear()
        txtNumBilhetes.Clear()
        txtValorPago.Clear()
        txtTroco.Clear()
    End Sub

    ' Evento de inicialização do formulário
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Adiciona os valores aos ComboBox
        CmbPartida.Items.Add("Lisboa")
        cmbPartida.Items.Add("Porto")
        cmbDestino.Items.Add("Lisboa")
        cmbDestino.Items.Add("Porto")

        ' Define os valores padrão
        cmbPartida.SelectedIndex = 0 ' Lisboa como padrão
        cmbDestino.SelectedIndex = 1 ' Porto como padrão
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtValorPago.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class
