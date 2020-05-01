Imports System.Windows.Forms

Public Class Help
    Dim mouseOffset As Point
    Private Sub Me_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Label1.MouseDown
        mouseOffset = New Point(-e.X, -e.Y)
    End Sub

    Private Sub Me_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Label1.MouseMove
        If e.Button = MouseButtons.Left Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
