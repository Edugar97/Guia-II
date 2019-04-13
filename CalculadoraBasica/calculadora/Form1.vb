Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmbOperaciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOperaciones.SelectedIndexChanged


    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Dim uno As Double
        'Dim dos As Double
        'uno = Convert.ToDouble(txtPrimero)
        'dos = Convert.ToDouble(txtSegundo)
        Select Case cmbOperaciones.SelectedItem
            Case "Suma"
                lblMostrar.Text = Convert.ToDouble(txtPrimero.Text) + Convert.ToDouble(txtSegundo.Text)
                'btnRespuesta = uno + dos
            Case "Resta"
                lblMostrar.Text = txtPrimero.Text - txtSegundo.Text
            Case "Multiplicacion"
                lblMostrar.Text = Convert.ToDouble(txtPrimero.Text) * Convert.ToDouble(txtSegundo.Text)
                'lblMostrar.Text = CInt(txtPrimero) * CInt(txtSegundo)
            Case "Division"
                lblMostrar.Text = txtPrimero.Text / txtSegundo.Text
        End Select


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtPrimero.Text = ""
        txtSegundo.Text = ""
    End Sub
End Class
