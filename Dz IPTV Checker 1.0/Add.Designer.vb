<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Add
    Inherits MetroFramework.Forms.MetroForm

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
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'MetroTextBox1
        '
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(23, 63)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Multiline = True
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.Size = New System.Drawing.Size(434, 316)
        Me.MetroTextBox1.TabIndex = 0
        Me.MetroTextBox1.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(23, 383)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(434, 32)
        Me.MetroButton1.TabIndex = 1
        Me.MetroButton1.Text = "Add to List"
        Me.MetroButton1.UseSelectable = True
        '
        'Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 429)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroTextBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Add"
        Me.Resizable = False
        Me.ShowInTaskbar = False
        Me.Text = "Add List"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
End Class
