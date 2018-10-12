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
      Me.lbl_Input_Password = New System.Windows.Forms.Label()
      Me.lbl_correct_password = New System.Windows.Forms.Label()
      Me.txt_input_password = New System.Windows.Forms.TextBox()
      Me.txt_password_is = New System.Windows.Forms.TextBox()
      Me.btn_set_passowrd = New System.Windows.Forms.Button()
      Me.btn_guess_passowrd = New System.Windows.Forms.Button()
      Me.btn_reset = New System.Windows.Forms.Button()
      Me.btn_quit = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'lbl_Input_Password
      '
      Me.lbl_Input_Password.AutoSize = True
      Me.lbl_Input_Password.Location = New System.Drawing.Point(91, 48)
      Me.lbl_Input_Password.Name = "lbl_Input_Password"
      Me.lbl_Input_Password.Size = New System.Drawing.Size(80, 13)
      Me.lbl_Input_Password.TabIndex = 0
      Me.lbl_Input_Password.Text = "Input Password"
      '
      'lbl_correct_password
      '
      Me.lbl_correct_password.AutoSize = True
      Me.lbl_correct_password.Location = New System.Drawing.Point(91, 78)
      Me.lbl_correct_password.Name = "lbl_correct_password"
      Me.lbl_correct_password.Size = New System.Drawing.Size(90, 13)
      Me.lbl_correct_password.TabIndex = 1
      Me.lbl_correct_password.Text = "The password is: "
      '
      'txt_input_password
      '
      Me.txt_input_password.Location = New System.Drawing.Point(187, 45)
      Me.txt_input_password.Name = "txt_input_password"
      Me.txt_input_password.Size = New System.Drawing.Size(100, 20)
      Me.txt_input_password.TabIndex = 2
      '
      'txt_password_is
      '
      Me.txt_password_is.Location = New System.Drawing.Point(187, 75)
      Me.txt_password_is.Name = "txt_password_is"
      Me.txt_password_is.Size = New System.Drawing.Size(100, 20)
      Me.txt_password_is.TabIndex = 3
      '
      'btn_set_passowrd
      '
      Me.btn_set_passowrd.Location = New System.Drawing.Point(293, 43)
      Me.btn_set_passowrd.Name = "btn_set_passowrd"
      Me.btn_set_passowrd.Size = New System.Drawing.Size(100, 23)
      Me.btn_set_passowrd.TabIndex = 4
      Me.btn_set_passowrd.Text = "Set Password"
      Me.btn_set_passowrd.UseVisualStyleBackColor = True
      '
      'btn_guess_passowrd
      '
      Me.btn_guess_passowrd.Location = New System.Drawing.Point(293, 72)
      Me.btn_guess_passowrd.Name = "btn_guess_passowrd"
      Me.btn_guess_passowrd.Size = New System.Drawing.Size(99, 23)
      Me.btn_guess_passowrd.TabIndex = 5
      Me.btn_guess_passowrd.Text = "Guess Password"
      Me.btn_guess_passowrd.UseVisualStyleBackColor = True
      '
      'btn_reset
      '
      Me.btn_reset.Location = New System.Drawing.Point(228, 228)
      Me.btn_reset.Name = "btn_reset"
      Me.btn_reset.Size = New System.Drawing.Size(75, 23)
      Me.btn_reset.TabIndex = 6
      Me.btn_reset.Text = "Reset"
      Me.btn_reset.UseVisualStyleBackColor = True
      '
      'btn_quit
      '
      Me.btn_quit.Location = New System.Drawing.Point(228, 257)
      Me.btn_quit.Name = "btn_quit"
      Me.btn_quit.Size = New System.Drawing.Size(75, 23)
      Me.btn_quit.TabIndex = 7
      Me.btn_quit.Text = "Quit"
      Me.btn_quit.UseVisualStyleBackColor = True
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(572, 325)
      Me.Controls.Add(Me.btn_quit)
      Me.Controls.Add(Me.btn_reset)
      Me.Controls.Add(Me.btn_guess_passowrd)
      Me.Controls.Add(Me.btn_set_passowrd)
      Me.Controls.Add(Me.txt_password_is)
      Me.Controls.Add(Me.txt_input_password)
      Me.Controls.Add(Me.lbl_correct_password)
      Me.Controls.Add(Me.lbl_Input_Password)
      Me.Name = "Form1"
      Me.Text = "Form1"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents lbl_Input_Password As Label
   Friend WithEvents lbl_correct_password As Label
   Friend WithEvents txt_input_password As TextBox
   Friend WithEvents txt_password_is As TextBox
   Friend WithEvents btn_set_passowrd As Button
   Friend WithEvents btn_guess_passowrd As Button
   Friend WithEvents btn_reset As Button
   Friend WithEvents btn_quit As Button
End Class
