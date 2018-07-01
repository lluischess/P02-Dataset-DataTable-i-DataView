Imports System.Data.SqlClient
Public Class Form2CP
    Private dvCP As DataView
    Private Sub ListBoxCP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxCP.SelectedIndexChanged
        dvCP = Form1.VCP

        RadioButtonCP.Checked = True
        CargarListBox()
    End Sub

    Private Sub CargarListBox()
        ListBoxCP.Items.Clear()

        Dim contador As Integer = 0

        If RadioButtonCP.Checked = True Then
            dvCP.Sort = "CP"
            While contador < dvCP.Count - 1
                ListBoxCP.Items.Add(dvCP(contador)("CP").ToString & " - " & dvCP(contador)("NOM_CIUTAT").ToString)

                contador = contador + 1
            End While
        Else
            dvCP.Sort = "NOM_CIUTAT"
            While contador < dvCP.Count - 1
                ListBoxCP.Items.Add(dvCP(contador)("CP").ToString & " - " & dvCP(contador)("NOM_CIUTAT").ToString)

                contador = contador + 1
            End While
        End If
    End Sub

    Private Sub RadioButtonPoblacion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonPoblacion.CheckedChanged
        CargarListBox()
    End Sub

    Private Sub ButtonCerrar_Click(sender As Object, e As EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub

    Private Sub seleccionarcodigo_Click(sender As Object, e As EventArgs) Handles seleccionarcodigo.Click
        Dim cpSelecionado As String() = ListBoxCP.SelectedItem.split(" - ")
        Form1.cp.Text = cpSelecionado(0)
        Me.Close()
    End Sub

    Private Sub buscarcp_TextChanged(sender As Object, e As EventArgs) Handles buscarcp.TextChanged
        Dim i As Integer
        For i = 0 To ListBoxCP.Items.Count - 1
            If i > ListBoxCP.Items.Count - 1 Then Exit For
            If Not ListBoxCP.Items(i).Contains(buscarcp.Text) Then
                ListBoxCP.Items.Remove(ListBoxCP.Items(i))
                i -= 1
            End If
        Next
        If buscarcp.Text = "" Then
            CargarListBox()

        End If
    End Sub
End Class