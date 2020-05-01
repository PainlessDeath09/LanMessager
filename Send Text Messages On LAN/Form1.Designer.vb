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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ServiceController1 = New System.ServiceProcess.ServiceController()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.RosyBrown
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(4, 399)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.RosyBrown
        Me.Panel2.Location = New System.Drawing.Point(677, 27)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(4, 402)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.RosyBrown
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 425)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(681, 4)
        Me.Panel3.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 32)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(276, 262)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select System"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 17
        Me.ListBox1.Location = New System.Drawing.Point(11, 22)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(253, 225)
        Me.ListBox1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(16, 299)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(276, 117)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Enter System Name"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(193, 26)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 71)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Register"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(9, 21)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(172, 25)
        Me.TextBox1.TabIndex = 9
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(300, 299)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(364, 55)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Send Message"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(8, 20)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(344, 26)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Send Message"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextBox2)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(300, 32)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(364, 262)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Enter Message"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(13, 25)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(337, 226)
        Me.TextBox2.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Send_Text_Messages_On_LAN.My.Resources.Resources.Close
        Me.PictureBox1.Location = New System.Drawing.Point(653, 4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(684, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LAN Messenger"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(593, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(53, 28)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Help"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Enter IP Address"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(7, 72)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(174, 25)
        Me.TextBox3.TabIndex = 11
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button4)
        Me.GroupBox5.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(300, 361)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(364, 55)
        Me.GroupBox5.TabIndex = 11
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "System"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(8, 20)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(344, 26)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Delete System Record"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 429)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ServiceController1 As System.ServiceProcess.ServiceController
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Button4 As Button
End Class
