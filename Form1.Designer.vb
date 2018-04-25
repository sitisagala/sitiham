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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtnilai1 = New System.Windows.Forms.TextBox()
        Me.txtnilai2 = New System.Windows.Forms.TextBox()
        Me.txtnilai3 = New System.Windows.Forms.TextBox()
        Me.txtrata = New System.Windows.Forms.Label()
        Me.txthadiah = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "nilai1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "nilai2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "nilai3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "rataan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "hadiah"
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(128, 41)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(100, 20)
        Me.txtnama.TabIndex = 6
        '
        'txtnilai1
        '
        Me.txtnilai1.Location = New System.Drawing.Point(128, 81)
        Me.txtnilai1.Name = "txtnilai1"
        Me.txtnilai1.Size = New System.Drawing.Size(100, 20)
        Me.txtnilai1.TabIndex = 7
        '
        'txtnilai2
        '
        Me.txtnilai2.Location = New System.Drawing.Point(128, 124)
        Me.txtnilai2.Name = "txtnilai2"
        Me.txtnilai2.Size = New System.Drawing.Size(100, 20)
        Me.txtnilai2.TabIndex = 8
        '
        'txtnilai3
        '
        Me.txtnilai3.Location = New System.Drawing.Point(128, 168)
        Me.txtnilai3.Name = "txtnilai3"
        Me.txtnilai3.Size = New System.Drawing.Size(100, 20)
        Me.txtnilai3.TabIndex = 9
        '
        'txtrata
        '
        Me.txtrata.AutoSize = True
        Me.txtrata.Location = New System.Drawing.Point(125, 212)
        Me.txtrata.Name = "txtrata"
        Me.txtrata.Size = New System.Drawing.Size(79, 13)
        Me.txtrata.TabIndex = 10
        Me.txtrata.Text = "........................"
        '
        'txthadiah
        '
        Me.txthadiah.AutoSize = True
        Me.txthadiah.Location = New System.Drawing.Point(125, 247)
        Me.txthadiah.Name = "txthadiah"
        Me.txthadiah.Size = New System.Drawing.Size(85, 13)
        Me.txthadiah.TabIndex = 11
        Me.txthadiah.Text = ".........................."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(49, 325)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Hitung"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(176, 325)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Ulang"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 415)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txthadiah)
        Me.Controls.Add(Me.txtrata)
        Me.Controls.Add(Me.txtnilai3)
        Me.Controls.Add(Me.txtnilai2)
        Me.Controls.Add(Me.txtnilai1)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtnilai1 As System.Windows.Forms.TextBox
    Friend WithEvents txtnilai2 As System.Windows.Forms.TextBox
    Friend WithEvents txtnilai3 As System.Windows.Forms.TextBox
    Friend WithEvents txtrata As System.Windows.Forms.Label
    Friend WithEvents txthadiah As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
