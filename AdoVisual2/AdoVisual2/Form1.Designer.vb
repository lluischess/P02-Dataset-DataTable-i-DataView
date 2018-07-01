<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.anterior = New System.Windows.Forms.Button()
        Me.seguent = New System.Windows.Forms.Button()
        Me.ultim = New System.Windows.Forms.Button()
        Me.primer = New System.Windows.Forms.Button()
        Me.id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.codi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cat = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.risc = New System.Windows.Forms.TextBox()
        Me.crear = New System.Windows.Forms.Button()
        Me.modif = New System.Windows.Forms.Button()
        Me.elimin = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.telef = New System.Windows.Forms.TextBox()
        Me.buscar = New System.Windows.Forms.Button()
        Me.presis = New System.Windows.Forms.Button()
        Me.CPB = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'anterior
        '
        Me.anterior.Location = New System.Drawing.Point(39, 230)
        Me.anterior.Name = "anterior"
        Me.anterior.Size = New System.Drawing.Size(100, 65)
        Me.anterior.TabIndex = 0
        Me.anterior.Text = "<"
        Me.anterior.UseVisualStyleBackColor = True
        '
        'seguent
        '
        Me.seguent.Location = New System.Drawing.Point(145, 230)
        Me.seguent.Name = "seguent"
        Me.seguent.Size = New System.Drawing.Size(100, 65)
        Me.seguent.TabIndex = 1
        Me.seguent.Text = ">"
        Me.seguent.UseVisualStyleBackColor = True
        '
        'ultim
        '
        Me.ultim.Location = New System.Drawing.Point(145, 301)
        Me.ultim.Name = "ultim"
        Me.ultim.Size = New System.Drawing.Size(100, 65)
        Me.ultim.TabIndex = 3
        Me.ultim.Text = "Final"
        Me.ultim.UseVisualStyleBackColor = True
        '
        'primer
        '
        Me.primer.Location = New System.Drawing.Point(39, 301)
        Me.primer.Name = "primer"
        Me.primer.Size = New System.Drawing.Size(100, 65)
        Me.primer.TabIndex = 2
        Me.primer.Text = "First"
        Me.primer.UseVisualStyleBackColor = True
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(274, 45)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(100, 20)
        Me.id.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(271, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Buscar ID Client"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Codi"
        '
        'codi
        '
        Me.codi.Location = New System.Drawing.Point(39, 45)
        Me.codi.Name = "codi"
        Me.codi.Size = New System.Drawing.Size(100, 20)
        Me.codi.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Nom"
        '
        'nom
        '
        Me.nom.Location = New System.Drawing.Point(39, 94)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(100, 20)
        Me.nom.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "CP"
        '
        'cp
        '
        Me.cp.Location = New System.Drawing.Point(39, 195)
        Me.cp.Name = "cp"
        Me.cp.Size = New System.Drawing.Size(100, 20)
        Me.cp.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(145, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "CATEGORIA"
        '
        'cat
        '
        Me.cat.Location = New System.Drawing.Point(148, 45)
        Me.cat.Name = "cat"
        Me.cat.Size = New System.Drawing.Size(100, 20)
        Me.cat.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(145, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "EMAIL"
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(148, 94)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(100, 20)
        Me.email.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(145, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "RISCMAXIM"
        '
        'risc
        '
        Me.risc.Location = New System.Drawing.Point(148, 145)
        Me.risc.Name = "risc"
        Me.risc.Size = New System.Drawing.Size(100, 20)
        Me.risc.TabIndex = 16
        '
        'crear
        '
        Me.crear.Location = New System.Drawing.Point(274, 77)
        Me.crear.Name = "crear"
        Me.crear.Size = New System.Drawing.Size(100, 49)
        Me.crear.TabIndex = 18
        Me.crear.Text = "Crear Contacte"
        Me.crear.UseVisualStyleBackColor = True
        '
        'modif
        '
        Me.modif.Location = New System.Drawing.Point(380, 77)
        Me.modif.Name = "modif"
        Me.modif.Size = New System.Drawing.Size(100, 49)
        Me.modif.TabIndex = 19
        Me.modif.Text = "Modificar Contacte"
        Me.modif.UseVisualStyleBackColor = True
        '
        'elimin
        '
        Me.elimin.Location = New System.Drawing.Point(274, 132)
        Me.elimin.Name = "elimin"
        Me.elimin.Size = New System.Drawing.Size(100, 49)
        Me.elimin.TabIndex = 20
        Me.elimin.Text = "Eliminar Contacte"
        Me.elimin.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(36, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "TELEFON"
        '
        'telef
        '
        Me.telef.Location = New System.Drawing.Point(39, 146)
        Me.telef.Name = "telef"
        Me.telef.Size = New System.Drawing.Size(100, 20)
        Me.telef.TabIndex = 21
        '
        'buscar
        '
        Me.buscar.Location = New System.Drawing.Point(380, 45)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(87, 20)
        Me.buscar.TabIndex = 23
        Me.buscar.Text = "Buscar"
        Me.buscar.UseVisualStyleBackColor = True
        '
        'presis
        '
        Me.presis.Location = New System.Drawing.Point(380, 133)
        Me.presis.Name = "presis"
        Me.presis.Size = New System.Drawing.Size(100, 49)
        Me.presis.TabIndex = 24
        Me.presis.Text = "Persistència"
        Me.presis.UseVisualStyleBackColor = True
        '
        'CPB
        '
        Me.CPB.Location = New System.Drawing.Point(148, 179)
        Me.CPB.Name = "CPB"
        Me.CPB.Size = New System.Drawing.Size(97, 44)
        Me.CPB.TabIndex = 25
        Me.CPB.Text = "Elegir CP"
        Me.CPB.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 381)
        Me.Controls.Add(Me.CPB)
        Me.Controls.Add(Me.presis)
        Me.Controls.Add(Me.buscar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.telef)
        Me.Controls.Add(Me.elimin)
        Me.Controls.Add(Me.modif)
        Me.Controls.Add(Me.crear)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.risc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.codi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.ultim)
        Me.Controls.Add(Me.primer)
        Me.Controls.Add(Me.seguent)
        Me.Controls.Add(Me.anterior)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents anterior As Button
    Friend WithEvents seguent As Button
    Friend WithEvents ultim As Button
    Friend WithEvents primer As Button
    Friend WithEvents id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents codi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents nom As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cp As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cat As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents risc As TextBox
    Friend WithEvents crear As Button
    Friend WithEvents modif As Button
    Friend WithEvents elimin As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents telef As TextBox
    Friend WithEvents buscar As Button
    Friend WithEvents presis As Button
    Friend WithEvents CPB As Button
End Class
