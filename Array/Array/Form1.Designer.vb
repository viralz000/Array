<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.submit = New System.Windows.Forms.Button()
        Me.nametext = New System.Windows.Forms.TextBox()
        Me.showname = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.show = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.number = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'submit
        '
        Me.submit.Location = New System.Drawing.Point(144, 95)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(100, 35)
        Me.submit.TabIndex = 0
        Me.submit.Text = "Submit"
        Me.submit.UseVisualStyleBackColor = True
        '
        'nametext
        '
        Me.nametext.Location = New System.Drawing.Point(144, 63)
        Me.nametext.Name = "nametext"
        Me.nametext.Size = New System.Drawing.Size(100, 26)
        Me.nametext.TabIndex = 1
        '
        'showname
        '
        Me.showname.AutoSize = True
        Me.showname.Location = New System.Drawing.Point(12, 267)
        Me.showname.Name = "showname"
        Me.showname.Size = New System.Drawing.Size(152, 20)
        Me.showname.TabIndex = 2
        Me.showname.Text = "Name here will show"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enter a name:"
        '
        'show
        '
        Me.show.Location = New System.Drawing.Point(144, 198)
        Me.show.Name = "show"
        Me.show.Size = New System.Drawing.Size(100, 35)
        Me.show.TabIndex = 4
        Me.show.Text = "show"
        Me.show.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Enter a number:"
        '
        'number
        '
        Me.number.Location = New System.Drawing.Point(144, 166)
        Me.number.Name = "number"
        Me.number.Size = New System.Drawing.Size(100, 26)
        Me.number.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 350)
        Me.Controls.Add(Me.number)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.show)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.showname)
        Me.Controls.Add(Me.nametext)
        Me.Controls.Add(Me.submit)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents submit As Button
    Friend WithEvents nametext As TextBox
    Friend WithEvents showname As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents show As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents number As TextBox
End Class
