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
      Me.txtFirst_textChanged = New System.Windows.Forms.TextBox()
      Me.txtFirst_Leave = New System.Windows.Forms.TextBox()
      Me.btnRed_Click = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'txtFirst_textChanged
      '
      Me.txtFirst_textChanged.Location = New System.Drawing.Point(219, 148)
      Me.txtFirst_textChanged.Name = "txtFirst_textChanged"
      Me.txtFirst_textChanged.Size = New System.Drawing.Size(100, 20)
      Me.txtFirst_textChanged.TabIndex = 0
      '
      'txtFirst_Leave
      '
      Me.txtFirst_Leave.Location = New System.Drawing.Point(219, 174)
      Me.txtFirst_Leave.Name = "txtFirst_Leave"
      Me.txtFirst_Leave.Size = New System.Drawing.Size(100, 20)
      Me.txtFirst_Leave.TabIndex = 1
      '
      'btnRed_Click
      '
      Me.btnRed_Click.Location = New System.Drawing.Point(190, 200)
      Me.btnRed_Click.Name = "btnRed_Click"
      Me.btnRed_Click.Size = New System.Drawing.Size(165, 23)
      Me.btnRed_Click.TabIndex = 2
      Me.btnRed_Click.Text = "Change Color to Red"
      Me.btnRed_Click.UseVisualStyleBackColor = True
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(522, 450)
      Me.Controls.Add(Me.btnRed_Click)
      Me.Controls.Add(Me.txtFirst_Leave)
      Me.Controls.Add(Me.txtFirst_textChanged)
      Me.Name = "Form1"
      Me.Text = "Derek Schultz"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents txtFirst_textChanged As TextBox
   Friend WithEvents txtFirst_Leave As TextBox
   Friend WithEvents btnRed_Click As Button
End Class
