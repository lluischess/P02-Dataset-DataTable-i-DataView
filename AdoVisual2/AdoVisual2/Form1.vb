Imports System.Data.SqlClient

Public Class Form1

    'Declaramos la conexion
    Private Conexion As SqlConnection
    Private ds As DataSet
    Private ada, ada2 As SqlDataAdapter

    Private registroActual As Integer
    Public VCP, VContacte As DataView
    Dim datosPorHacerPersistencia As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Abrimos la conexion con la base de datos
        Conexion = New SqlConnection
        Conexion.ConnectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CIUTATS; Trusted_Connection=True;"
        Conexion.Open()

        ds = New DataSet()
        ada = New SqlDataAdapter("select CODI, NOM, CP, TELEFON, CATEGORIA, EMAIL, RISCMAXIM from CONTACTE", Conexion)
        ada2 = New SqlDataAdapter("select CP, NOM_CIUTAT from CIUTAT", Conexion)
        Dim CB1 As SqlCommandBuilder = New SqlCommandBuilder(ada)
        Dim CB2 As SqlCommandBuilder = New SqlCommandBuilder(ada2)

        ada.Fill(ds, "CONTACTE")
        ada2.Fill(ds, "CIUTAT")

        Dim pk(1) As DataColumn
        pk(0) = ds.Tables("contacte").Columns("CODI")
        ds.Tables("CONTACTE").PrimaryKey = pk

        Dim parentColumn As DataColumn = ds.Tables("CIUTAT").Columns("CP")
        Dim childColumn As DataColumn = ds.Tables("CONTACTE").Columns("CP")

        Dim foreignKeyConstraint As ForeignKeyConstraint
        foreignKeyConstraint = New ForeignKeyConstraint _
        ("SupplierForeignKeyConstraint", parentColumn, childColumn)
        ds.Tables("CONTACTE").Constraints.Add(foreignKeyConstraint)

        VCP = New DataView(ds.Tables("CIUTAT"))
        VContacte = New DataView(ds.Tables("CONTACTE"))

        registroActual = 0
        InfoRegistro()

    End Sub

    Private Sub anterior_Click(sender As Object, e As EventArgs) Handles anterior.Click
        If registroActual > 0 Then
            Dim original As Integer = registroActual
            registroActual = registroActual - 1

            While registroActual > 0 And ds.Tables("CONTACTE").Rows(registroActual).RowState = DataRowState.Deleted
                registroActual = registroActual - 1
            End While

            If registroActual >= 0 Then
                InfoRegistro()
            Else
                registroActual = original
                InfoRegistro()
            End If
        End If
    End Sub

    Private Sub seguent_Click(sender As Object, e As EventArgs) Handles seguent.Click
        If registroActual < ds.Tables("CONTACTE").Rows.Count - 1 Then
            Dim original As Integer = registroActual
            registroActual = registroActual + 1

            While registroActual < ds.Tables("CONTACTE").Rows.Count - 1 And ds.Tables("CONTACTE").Rows(registroActual).RowState = DataRowState.Deleted
                registroActual = registroActual + 1
            End While

            If registroActual <= ds.Tables("CONTACTE").Rows.Count - 1 Then
                InfoRegistro()
            Else
                registroActual = original
                InfoRegistro()
            End If
        End If
    End Sub

    Private Sub ultim_Click(sender As Object, e As EventArgs) Handles ultim.Click
        registroActual = ds.Tables("CONTACTE").Rows.Count - 1

        While ds.Tables("CONTACTE").Rows(registroActual).RowState = DataRowState.Deleted
            registroActual = registroActual - 1
        End While

        InfoRegistro()
    End Sub

    Private Sub buscar_Click(sender As Object, e As EventArgs) Handles buscar.Click
        Dim encontrado As Boolean = False
        registroActual = 0

        While registroActual <= ds.Tables("CONTACTE").Rows.Count - 1
            If ds.Tables("CONTACTE").Rows(registroActual)(0).ToString = id.Text Then
                InfoRegistro()
                encontrado = True
            End If
            registroActual = registroActual + 1
        End While

        If encontrado = False Then
            MsgBox("Este registro no existe")
        End If
    End Sub

    Private Sub crear_Click(sender As Object, e As EventArgs) Handles crear.Click
        Dim dr As DataRow

        dr = ds.Tables("CONTACTE").NewRow

        dr("CODI") = "Campo obligatorio"
        dr("NOM") = "Nombre desconocido"
        dr("CP") = DBNull.Value
        dr("TELEFON") = ""
        dr("CATEGORIA") = 0
        dr("EMAIL") = ""
        dr("RISCMAXIM") = 0

        ds.Tables("CONTACTE").Rows.Add(dr)

        registroActual = ds.Tables("CONTACTE").Rows.Count - 1
        InfoRegistro()
    End Sub

    Private Sub modif_Click(sender As Object, e As EventArgs) Handles modif.Click
        GuardarCambios()
        datosPorHacerPersistencia = datosPorHacerPersistencia + 1
    End Sub

    Private Sub GuardarCambios()


        If nom.Text = "" Then
            MsgBox("No puedes dejar el nombre vacio.")
            nom.Select()
            Exit Sub
        ElseIf IsNumeric(risc.Text) = False Then
            MsgBox("El riesgo maximo debe ser un valor numerico.")
            risc.Select()

        ElseIf risc.Text < 0 Then
            MsgBox("El riesgo maximo debe ser 0 o mayor.")
            risc.Select()

        ElseIf ValidateEmail(email.Text) = True Or email.Text = "" Then
            ds.Tables("CONTACTE").Rows(registroActual)(0) = codi.Text
            ds.Tables("CONTACTE").Rows(registroActual)(1) = nom.Text
            If cp.Text = "" Then
                ds.Tables("CONTACTE").Rows(registroActual)(2) = DBNull.Value
            Else
                Try
                    ds.Tables("CONTACTE").Rows(registroActual)(2) = cp.Text
                Catch ex As Exception
                    MsgBox("Este codigo postal no existe")
                End Try

            End If

            ds.Tables("CONTACTE").Rows(registroActual)(3) = telef.Text

            If cat.Text = "" Then
                ds.Tables("CONTACTE").Rows(registroActual)(4) = DBNull.Value
            Else
                Try
                    ds.Tables("CONTACTE").Rows(registroActual)(4) = cat.Text
                Catch ex As Exception
                    MsgBox("La categoria tiene que ser un valor numerico")
                End Try

            End If

            ds.Tables("CONTACTE").Rows(registroActual)(5) = email.Text

            ds.Tables("CONTACTE").Rows(registroActual)(6) = risc.Text
        Else
            MsgBox("El email tiene un formato incorrecto.")
            email.Select()
        End If
    End Sub

    Function ValidateEmail(ByVal email As String) As Boolean
        Dim emailRegex As New System.Text.RegularExpressions.Regex(
        "^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As System.Text.RegularExpressions.Match =
       emailRegex.Match(email)
        Return emailMatch.Success
    End Function

    Private Sub presis_Click(sender As Object, e As EventArgs) Handles presis.Click
        GuardarCambios()
    End Sub

    Private Sub elimin_Click(sender As Object, e As EventArgs) Handles elimin.Click
        Dim result As Integer = MessageBox.Show("¿Seguro que desea eliminar este contacto?", "Atención", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
        ElseIf result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then
            ds.Tables("CONTACTE").Rows(registroActual).Delete()
        End If


        registroActual = 0
        InfoRegistro()
    End Sub

    Private Sub CPB_Click(sender As Object, e As EventArgs) Handles CPB.Click
        Form2CP.ShowDialog()
    End Sub

    Private Sub codi_TextChanged(sender As Object, e As EventArgs) Handles codi.TextChanged
        Dim contador As Integer = 0

        If VContacte.RowFilter = "CODI like '%" & codi.Text & "%'" Then
            contador = contador + 1
        End If
    End Sub

    Private Sub primer_Click(sender As Object, e As EventArgs) Handles primer.Click
        registroActual = 0

        While ds.Tables("CONTACTE").Rows(registroActual).RowState = DataRowState.Deleted
            registroActual = registroActual + 1
        End While

        InfoRegistro()
    End Sub

    Private Sub InfoRegistro()
        codi.Text = ds.Tables("CONTACTE").Rows(registroActual)(0).ToString
        nom.Text = ds.Tables("CONTACTE").Rows(registroActual)(1).ToString
        cp.Text = ds.Tables("CONTACTE").Rows(registroActual)(2).ToString
        telef.Text = ds.Tables("CONTACTE").Rows(registroActual)(3).ToString
        cat.Text = ds.Tables("CONTACTE").Rows(registroActual)(4).ToString
        email.Text = ds.Tables("CONTACTE").Rows(registroActual)(5).ToString
        risc.Text = ds.Tables("CONTACTE").Rows(registroActual)(6).ToString
    End Sub

End Class
