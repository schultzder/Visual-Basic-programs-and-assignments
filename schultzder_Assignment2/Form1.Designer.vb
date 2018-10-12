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
      Me.txt_number1 = New System.Windows.Forms.TextBox()
      Me.txt_number2 = New System.Windows.Forms.TextBox()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.btn_find_min_max = New System.Windows.Forms.Button()
      Me.btn_Clear = New System.Windows.Forms.Button()
      Me.btn_Exit = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'txt_number1
      '
      Me.txt_number1.Location = New System.Drawing.Point(85, 91)
      Me.txt_number1.Name = "txt_number1"
      Me.txt_number1.Size = New System.Drawing.Size(100, 20)
      Me.txt_number1.TabIndex = 0
      '
      'txt_number2
      '
      Me.txt_number2.Location = New System.Drawing.Point(191, 91)
      Me.txt_number2.Name = "txt_number2"
      Me.txt_number2.Size = New System.Drawing.Size(100, 20)
      Me.txt_number2.TabIndex = 1
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(115, 40)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(149, 20)
      Me.Label1.TabIndex = 2
      Me.Label1.Text = "Enter Two Numbers"
      '
      'btn_find_min_max
      '
      Me.btn_find_min_max.Location = New System.Drawing.Point(68, 117)
      Me.btn_find_min_max.Name = "btn_find_min_max"
      Me.btn_find_min_max.Size = New System.Drawing.Size(75, 38)
      Me.btn_find_min_max.TabIndex = 3
      Me.btn_find_min_max.Text = "Find min/max"
      Me.btn_find_min_max.UseVisualStyleBackColor = True
      '
      'btn_Clear
      '
      Me.btn_Clear.Location = New System.Drawing.Point(149, 117)
      Me.btn_Clear.Name = "btn_Clear"
      Me.btn_Clear.Size = New System.Drawing.Size(75, 38)
      Me.btn_Clear.TabIndex = 4
      Me.btn_Clear.Text = "Clear"
      Me.btn_Clear.UseVisualStyleBackColor = True
      '
      'btn_Exit
      '
      Me.btn_Exit.Location = New System.Drawing.Point(230, 117)
      Me.btn_Exit.Name = "btn_Exit"
      Me.btn_Exit.Size = New System.Drawing.Size(75, 38)
      Me.btn_Exit.TabIndex = 5
      Me.btn_Exit.Text = "Exit"
      Me.btn_Exit.UseVisualStyleBackColor = True
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(397, 181)
      Me.Controls.Add(Me.btn_Exit)
      Me.Controls.Add(Me.btn_Clear)
      Me.Controls.Add(Me.btn_find_min_max)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.txt_number2)
      Me.Controls.Add(Me.txt_number1)
      Me.Name = "Form1"
      Me.Text = "Form1"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents txt_number1 As TextBox
   Friend WithEvents txt_number2 As TextBox
   Friend WithEvents Label1 As Label
   Friend WithEvents btn_find_min_max As Button
   Friend WithEvents btn_Clear As Button
   Friend WithEvents btn_Exit As Button
End Class
