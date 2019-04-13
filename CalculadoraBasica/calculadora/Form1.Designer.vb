<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblPrimero = New System.Windows.Forms.Label()
        Me.lblSegundo = New System.Windows.Forms.Label()
        Me.txtPrimero = New System.Windows.Forms.TextBox()
        Me.txtSegundo = New System.Windows.Forms.TextBox()
        Me.lblOperacion = New System.Windows.Forms.Label()
        Me.cmbOperaciones = New System.Windows.Forms.ComboBox()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.lblMostrar = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnRespuesta = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPrimero
        '
        Me.lblPrimero.AutoSize = True
        Me.lblPrimero.Location = New System.Drawing.Point(12, 20)
        Me.lblPrimero.Name = "lblPrimero"
        Me.lblPrimero.Size = New System.Drawing.Size(128, 13)
        Me.lblPrimero.TabIndex = 0
        Me.lblPrimero.Text = "Ingrese su primer numero:"
        '
        'lblSegundo
        '
        Me.lblSegundo.AutoSize = True
        Me.lblSegundo.Location = New System.Drawing.Point(12, 78)
        Me.lblSegundo.Name = "lblSegundo"
        Me.lblSegundo.Size = New System.Drawing.Size(141, 13)
        Me.lblSegundo.TabIndex = 1
        Me.lblSegundo.Text = "Ingrese su segundo numero:"
        '
        'txtPrimero
        '
        Me.txtPrimero.Location = New System.Drawing.Point(171, 20)
        Me.txtPrimero.Name = "txtPrimero"
        Me.txtPrimero.Size = New System.Drawing.Size(100, 20)
        Me.txtPrimero.TabIndex = 2
        '
        'txtSegundo
        '
        Me.txtSegundo.Location = New System.Drawing.Point(171, 78)
        Me.txtSegundo.Name = "txtSegundo"
        Me.txtSegundo.Size = New System.Drawing.Size(100, 20)
        Me.txtSegundo.TabIndex = 3
        '
        'lblOperacion
        '
        Me.lblOperacion.AutoSize = True
        Me.lblOperacion.Location = New System.Drawing.Point(12, 124)
        Me.lblOperacion.Name = "lblOperacion"
        Me.lblOperacion.Size = New System.Drawing.Size(209, 13)
        Me.lblOperacion.TabIndex = 4
        Me.lblOperacion.Text = "Seleciones la operacion que quiere realizar"
        '
        'cmbOperaciones
        '
        Me.cmbOperaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOperaciones.FormattingEnabled = True
        Me.cmbOperaciones.Items.AddRange(New Object() {"Suma", "Resta", "Multiplicacion", "Division"})
        Me.cmbOperaciones.Location = New System.Drawing.Point(53, 157)
        Me.cmbOperaciones.Name = "cmbOperaciones"
        Me.cmbOperaciones.Size = New System.Drawing.Size(121, 21)
        Me.cmbOperaciones.TabIndex = 5
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(15, 196)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(83, 13)
        Me.lblResultado.TabIndex = 6
        Me.lblResultado.Text = "Su resultado es:"
        '
        'lblMostrar
        '
        Me.lblMostrar.AutoSize = True
        Me.lblMostrar.Location = New System.Drawing.Point(18, 231)
        Me.lblMostrar.Name = "lblMostrar"
        Me.lblMostrar.Size = New System.Drawing.Size(58, 13)
        Me.lblMostrar.TabIndex = 7
        Me.lblMostrar.Text = "Respuesta"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(276, 157)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 8
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(276, 196)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 9
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnRespuesta
        '
        Me.btnRespuesta.Location = New System.Drawing.Point(97, 220)
        Me.btnRespuesta.Name = "btnRespuesta"
        Me.btnRespuesta.Size = New System.Drawing.Size(75, 23)
        Me.btnRespuesta.TabIndex = 10
        Me.btnRespuesta.Text = "Respuesta"
        Me.btnRespuesta.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 284)
        Me.Controls.Add(Me.btnRespuesta)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.lblMostrar)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.cmbOperaciones)
        Me.Controls.Add(Me.lblOperacion)
        Me.Controls.Add(Me.txtSegundo)
        Me.Controls.Add(Me.txtPrimero)
        Me.Controls.Add(Me.lblSegundo)
        Me.Controls.Add(Me.lblPrimero)
        Me.Name = "Form1"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrimero As Label
    Friend WithEvents lblSegundo As Label
    Friend WithEvents txtPrimero As TextBox
    Friend WithEvents txtSegundo As TextBox
    Friend WithEvents lblOperacion As Label
    Friend WithEvents cmbOperaciones As ComboBox
    Friend WithEvents lblResultado As Label
    Friend WithEvents lblMostrar As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnRespuesta As Button
End Class
