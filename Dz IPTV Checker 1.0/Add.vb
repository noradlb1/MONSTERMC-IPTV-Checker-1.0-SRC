Public Class Add
    Private Shared list_0 As List(Of WeakReference) = New List(Of WeakReference)

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        My.Forms.Form1.method_0(Me.MetroTextBox1.Text)
        My.Forms.Form1.MetroButton5.Enabled = True
        My.Forms.Form1.MetroButton2.Enabled = True
        Me.Close()
    End Sub


End Class