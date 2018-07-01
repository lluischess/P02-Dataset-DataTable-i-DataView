<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2CP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListBoxCP = New System.Windows.Forms.ListBox()
        Me.RadioButtonCP = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPoblacion = New System.Windows.Forms.RadioButton()
        Me.seleccionarcodigo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.buscarcp = New System.Windows.Forms.TextBox()
        Me.ButtonCerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBoxCP
        '
        Me.ListBoxCP.FormattingEnabled = True
        Me.ListBoxCP.Location = New System.Drawing.Point(11, 11)
        Me.ListBoxCP.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBoxCP.Name = "ListBoxCP"
        Me.ListBoxCP.Size = New System.Drawing.Size(146, 290)
        Me.ListBoxCP.TabIndex = 1
        '
        'RadioButtonCP
        '
        Me.RadioButtonCP.AutoSize = True
        Me.RadioButtonCP.Checked = True
        Me.RadioButtonCP.Location = New System.Drawing.Point(174, 72)
        Me.RadioButtonCP.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButtonCP.Name = "RadioButtonCP"
        Me.RadioButtonCP.Size = New System.Drawing.Size(89, 17)
        Me.RadioButtonCP.TabIndex = 28
        Me.RadioButtonCP.TabStop = True
        Me.RadioButtonCP.Text = "Codigo postal"
        Me.RadioButtonCP.UseVisualStyleBackColor = True
        '
        'RadioButtonPoblacion
        '
        Me.RadioButtonPoblacion.AutoSize = True
        Me.RadioButtonPoblacion.Location = New System.Drawing.Point(267, 72)
        Me.RadioButtonPoblacion.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButtonPoblacion.Name = "RadioButtonPoblacion"
        Me.RadioButtonPoblacion.Size = New System.Drawing.Size(72, 17)
        Me.RadioButtonPoblacion.TabIndex = 29
        Me.RadioButtonPoblacion.Text = "Población"
        Me.RadioButtonPoblacion.UseVisualStyleBackColor = True
        '
        'seleccionarcodigo
        '
        Me.seleccionarcodigo.Location = New System.Drawing.Point(267, 20)
        Me.seleccionarcodigo.Margin = New System.Windows.Forms.Padding(2)
        Me.seleccionarcodigo.Name = "seleccionarcodigo"
        Me.seleccionarcodigo.Size = New System.Drawing.Size(100, 38)
        Me.seleccionarcodigo.TabIndex = 32
        Me.seleccionarcodigo.Text = "Escoger codigo"
        Me.seleccionarcodigo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(174, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Filtrar"
        '
        'buscarcp
        '
        Me.buscarcp.Location = New System.Drawing.Point(174, 30)
        Me.buscarcp.Margin = New System.Windows.Forms.Padding(2)
        Me.buscarcp.Name = "buscarcp"
        Me.buscarcp.Size = New System.Drawing.Size(76, 20)
        Me.buscarcp.TabIndex = 30
        '
        'ButtonCerrar
        '
        Me.ButtonCerrar.Location = New System.Drawing.Point(161, 264)
        Me.ButtonCerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonCerrar.Name = "ButtonCerrar"
        Me.ButtonCerrar.Size = New System.Drawing.Size(76, 37)
        Me.ButtonCerrar.TabIndex = 33
        Me.ButtonCerrar.Text = "Cerrar"
        Me.ButtonCerrar.UseVisualStyleBackColor = True
        '
        'Form2CP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 341)
        Me.Controls.Add(Me.ButtonCerrar)
        Me.Controls.Add(Me.seleccionarcodigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.buscarcp)
        Me.Controls.Add(Me.RadioButtonCP)
        Me.Controls.Add(Me.RadioButtonPoblacion)
        Me.Controls.Add(Me.ListBoxCP)
        Me.Name = "Form2CP"
        Me.Text = "Form2CP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxCP As ListBox
    Friend WithEvents RadioButtonCP As RadioButton
    Friend WithEvents RadioButtonPoblacion As RadioButton
    Friend WithEvents seleccionarcodigo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents buscarcp As TextBox
    Friend WithEvents ButtonCerrar As Button
End Class
