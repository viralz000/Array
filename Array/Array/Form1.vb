Public Class Form1
    Dim names As Array = New Array()
    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        names.Names.Add(nametext.Text)
    End Sub

    Private Sub show_Click(sender As Object, e As EventArgs) Handles show.Click
        showname.Text = names.Names(number.Text)
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)
    End Sub
End Class


Public Class Array
    Public Names As New ArrayList
End Class