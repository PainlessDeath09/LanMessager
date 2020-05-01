Imports System.IO
Imports System.ServiceProcess
Public Class Form1
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

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sr As New StreamReader(Application.StartupPath + "\System.dll")
        While sr.EndOfStream = False
            ListBox1.Items.Add(sr.ReadLine)
        End While
        sr.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Add(TextBox1.Text)
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim sw As New StreamWriter(Application.StartupPath + "\System.dll")
        For i As Integer = 0 To ListBox1.Items.Count - 1
            sw.WriteLine(ListBox1.Items(i))
            sw.Flush()
        Next
        sw.Close()
        Me.Close()
    End Sub
    
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ListBox1.Items.Count = 0 Then
            MessageBox.Show("Please Add the System on Which you Want to Send Message", "Select System Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf ListBox1.SelectedItem = Nothing Then
            MessageBox.Show("Please Select the System on Which you Want to Send Message", "Select System Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("Please Enter the Message you Want to Send", "Select System Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Shell("net send " + ListBox1.SelectedItem + " """ + TextBox2.Text + """", AppWinStyle.Hide, False)
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Help.ShowDialog()
    End Sub
End Class
