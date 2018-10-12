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
      Me.lbl_num_pennies = New System.Windows.Forms.Label()
      Me.lbl_num_nickles = New System.Windows.Forms.Label()
      Me.lbl_num_dimes = New System.Windows.Forms.Label()
      Me.lbl_num_quarters = New System.Windows.Forms.Label()
      Me.lbl_num_half_dollar = New System.Windows.Forms.Label()
      Me.btn_calculate = New System.Windows.Forms.Button()
      Me.txt_penny = New System.Windows.Forms.TextBox()
      Me.txt_quarter = New System.Windows.Forms.TextBox()
      Me.txt_dime = New System.Windows.Forms.TextBox()
      Me.txt_nickle = New System.Windows.Forms.TextBox()
      Me.txt_half_dollar = New System.Windows.Forms.TextBox()
      Me.txt_answer = New System.Windows.Forms.TextBox()
      Me.btn_quit = New System.Windows.Forms.Button()
      Me.btn_reset = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'lbl_num_pennies
      '
      Me.lbl_num_pennies.AutoSize = True
      Me.lbl_num_pennies.Location = New System.Drawing.Point(118, 79)
      Me.lbl_num_pennies.Name = "lbl_num_pennies"
      Me.lbl_num_pennies.Size = New System.Drawing.Size(97, 13)
      Me.lbl_num_pennies.TabIndex = 0
      Me.lbl_num_pennies.Text = "Number of Pennies"
      '
      'lbl_num_nickles
      '
      Me.lbl_num_nickles.AutoSize = True
      Me.lbl_num_nickles.Location = New System.Drawing.Point(118, 116)
      Me.lbl_num_nickles.Name = "lbl_num_nickles"
      Me.lbl_num_nickles.Size = New System.Drawing.Size(94, 13)
      Me.lbl_num_nickles.TabIndex = 1
      Me.lbl_num_nickles.Text = "Number of Nickles"
      '
      'lbl_num_dimes
      '
      Me.lbl_num_dimes.AutoSize = True
      Me.lbl_num_dimes.Location = New System.Drawing.Point(118, 147)
      Me.lbl_num_dimes.Name = "lbl_num_dimes"
      Me.lbl_num_dimes.Size = New System.Drawing.Size(88, 13)
      Me.lbl_num_dimes.TabIndex = 2
      Me.lbl_num_dimes.Text = "Number of Dimes"
      '
      'lbl_num_quarters
      '
      Me.lbl_num_quarters.AutoSize = True
      Me.lbl_num_quarters.Location = New System.Drawing.Point(118, 183)
      Me.lbl_num_quarters.Name = "lbl_num_quarters"
      Me.lbl_num_quarters.Size = New System.Drawing.Size(99, 13)
      Me.lbl_num_quarters.TabIndex = 3
      Me.lbl_num_quarters.Text = "Number of Quarters"
      '
      'lbl_num_half_dollar
      '
      Me.lbl_num_half_dollar.AutoSize = True
      Me.lbl_num_half_dollar.Location = New System.Drawing.Point(118, 216)
      Me.lbl_num_half_dollar.Name = "lbl_num_half_dollar"
      Me.lbl_num_half_dollar.Size = New System.Drawing.Size(108, 13)
      Me.lbl_num_half_dollar.TabIndex = 4
      Me.lbl_num_half_dollar.Text = "Number of Half Dollar"
      '
      'btn_calculate
      '
      Me.btn_calculate.Location = New System.Drawing.Point(232, 302)
      Me.btn_calculate.Name = "btn_calculate"
      Me.btn_calculate.Size = New System.Drawing.Size(161, 23)
      Me.btn_calculate.TabIndex = 5
      Me.btn_calculate.Text = "Calculate"
      Me.btn_calculate.UseVisualStyleBackColor = True
      '
      'txt_penny
      '
      Me.txt_penny.Location = New System.Drawing.Point(232, 76)
      Me.txt_penny.Name = "txt_penny"
      Me.txt_penny.Size = New System.Drawing.Size(100, 20)
      Me.txt_penny.TabIndex = 6
      '
      'txt_quarter
      '
      Me.txt_quarter.Location = New System.Drawing.Point(232, 180)
      Me.txt_quarter.Name = "txt_quarter"
      Me.txt_quarter.Size = New System.Drawing.Size(100, 20)
      Me.txt_quarter.TabIndex = 7
      '
      'txt_dime
      '
      Me.txt_dime.Location = New System.Drawing.Point(232, 144)
      Me.txt_dime.Name = "txt_dime"
      Me.txt_dime.Size = New System.Drawing.Size(100, 20)
      Me.txt_dime.TabIndex = 8
      '
      'txt_nickle
      '
      Me.txt_nickle.Location = New System.Drawing.Point(232, 113)
      Me.txt_nickle.Name = "txt_nickle"
      Me.txt_nickle.Size = New System.Drawing.Size(100, 20)
      Me.txt_nickle.TabIndex = 9
      '
      'txt_half_dollar
      '
      Me.txt_half_dollar.Location = New System.Drawing.Point(232, 213)
      Me.txt_half_dollar.Name = "txt_half_dollar"
      Me.txt_half_dollar.Size = New System.Drawing.Size(100, 20)
      Me.txt_half_dollar.TabIndex = 10
      '
      'txt_answer
      '
      Me.txt_answer.Location = New System.Drawing.Point(399, 302)
      Me.txt_answer.Name = "txt_answer"
      Me.txt_answer.Size = New System.Drawing.Size(100, 20)
      Me.txt_answer.TabIndex = 11
      '
      'btn_quit
      '
      Me.btn_quit.Location = New System.Drawing.Point(338, 368)
      Me.btn_quit.Name = "btn_quit"
      Me.btn_quit.Size = New System.Drawing.Size(88, 23)
      Me.btn_quit.TabIndex = 12
      Me.btn_quit.Text = "Quit"
      Me.btn_quit.UseVisualStyleBackColor = True
      '
      'btn_reset
      '
      Me.btn_reset.Location = New System.Drawing.Point(242, 368)
      Me.btn_reset.Name = "btn_reset"
      Me.btn_reset.Size = New System.Drawing.Size(90, 23)
      Me.btn_reset.TabIndex = 13
      Me.btn_reset.Text = "Reset"
      Me.btn_reset.UseVisualStyleBackColor = True
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(800, 450)
      Me.Controls.Add(Me.btn_reset)
      Me.Controls.Add(Me.btn_quit)
      Me.Controls.Add(Me.txt_answer)
      Me.Controls.Add(Me.txt_half_dollar)
      Me.Controls.Add(Me.txt_nickle)
      Me.Controls.Add(Me.txt_dime)
      Me.Controls.Add(Me.txt_quarter)
      Me.Controls.Add(Me.txt_penny)
      Me.Controls.Add(Me.btn_calculate)
      Me.Controls.Add(Me.lbl_num_half_dollar)
      Me.Controls.Add(Me.lbl_num_quarters)
      Me.Controls.Add(Me.lbl_num_dimes)
      Me.Controls.Add(Me.lbl_num_nickles)
      Me.Controls.Add(Me.lbl_num_pennies)
      Me.Name = "Form1"
      Me.Text = "Piggy Bank"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents lbl_num_pennies As Label
   Friend WithEvents lbl_num_nickles As Label
   Friend WithEvents lbl_num_dimes As Label
   Friend WithEvents lbl_num_quarters As Label
   Friend WithEvents lbl_num_half_dollar As Label
   Friend WithEvents btn_calculate As Button
   Friend WithEvents txt_penny As TextBox
   Friend WithEvents txt_quarter As TextBox
   Friend WithEvents txt_dime As TextBox
   Friend WithEvents txt_nickle As TextBox
   Friend WithEvents txt_half_dollar As TextBox
   Friend WithEvents txt_answer As TextBox
   Friend WithEvents btn_quit As Button
   Friend WithEvents btn_reset As Button
End Class
