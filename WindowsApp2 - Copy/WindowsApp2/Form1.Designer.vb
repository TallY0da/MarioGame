<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.WIN = New System.Windows.Forms.PictureBox()
        Me.PictureBox3wall = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WIN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WindowsApp2.My.Resources.Resources.mario
        Me.PictureBox1.Location = New System.Drawing.Point(123, 119)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 300
        '
        'WIN
        '
        Me.WIN.BackColor = System.Drawing.Color.Transparent
        Me.WIN.Image = Global.WindowsApp2.My.Resources.Resources.mariocastle
        Me.WIN.Location = New System.Drawing.Point(823, -40)
        Me.WIN.Name = "WIN"
        Me.WIN.Size = New System.Drawing.Size(198, 209)
        Me.WIN.TabIndex = 2
        Me.WIN.TabStop = False
        '
        'PictureBox3wall
        '
        Me.PictureBox3wall.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3wall.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox3wall.Location = New System.Drawing.Point(0, 154)
        Me.PictureBox3wall.Name = "PictureBox3wall"
        Me.PictureBox3wall.Size = New System.Drawing.Size(1021, 15)
        Me.PictureBox3wall.TabIndex = 3
        Me.PictureBox3wall.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.WindowsApp2.My.Resources.Resources.pixil_frame_0
        Me.PictureBox2.Location = New System.Drawing.Point(289, 82)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(83, 66)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.DarkOrange
        Me.PictureBox3.Image = Global.WindowsApp2.My.Resources.Resources.youlose
        Me.PictureBox3.Location = New System.Drawing.Point(534, -3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(283, 136)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.LightSalmon
        Me.PictureBox4.Image = Global.WindowsApp2.My.Resources.Resources.unnamed
        Me.PictureBox4.Location = New System.Drawing.Point(195, -3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(333, 136)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'Mario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.BackgroundImage = Global.WindowsApp2.My.Resources.Resources.download
        Me.ClientSize = New System.Drawing.Size(1021, 169)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox3wall)
        Me.Controls.Add(Me.WIN)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Name = "Mario"
        Me.Text = "Mario Game"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WIN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents WIN As PictureBox
    Friend WithEvents PictureBox3wall As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
