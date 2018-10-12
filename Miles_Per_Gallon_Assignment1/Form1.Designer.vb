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
      Me.lbl_gallons = New System.Windows.Forms.Label()
      Me.lbl_miles_on_full_tank = New System.Windows.Forms.Label()
      Me.lbl_MPG = New System.Windows.Forms.Label()
      Me.txt_gallons = New System.Windows.Forms.TextBox()
      Me.txt_miles = New System.Windows.Forms.TextBox()
      Me.txt_mpg = New System.Windows.Forms.TextBox()
      Me.btn_calculate_mpg = New System.Windows.Forms.Button()
      Me.btn_clear = New System.Windows.Forms.Button()
      Me.btn_exit = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'lbl_gallons
      '
      Me.lbl_gallons.AutoSize = True
      Me.lbl_gallons.Location = New System.Drawing.Point(12, 64)
      Me.lbl_gallons.Name = "lbl_gallons"
      Me.lbl_gallons.Size = New System.Drawing.Size(157, 13)
      Me.lbl_gallons.TabIndex = 0
      Me.lbl_gallons.Text = "Gallons of gas the car can hold:"
      '
      'lbl_miles_on_full_tank
      '
      Me.lbl_miles_on_full_tank.AutoSize = True
      Me.lbl_miles_on_full_tank.Location = New System.Drawing.Point(12, 127)
      Me.lbl_miles_on_full_tank.Name = "lbl_miles_on_full_tank"
      Me.lbl_miles_on_full_tank.Size = New System.Drawing.Size(225, 13)
      Me.lbl_miles_on_full_tank.TabIndex = 1
      Me.lbl_miles_on_full_tank.Text = "Number of miles it can be driven on a full tank:"
      '
      'lbl_MPG
      '
      Me.lbl_MPG.AutoSize = True
      Me.lbl_MPG.Location = New System.Drawing.Point(12, 249)
      Me.lbl_MPG.Name = "lbl_MPG"
      Me.lbl_MPG.Size = New System.Drawing.Size(83, 13)
      Me.lbl_MPG.TabIndex = 2
      Me.lbl_MPG.Text = "Miles per gallon:"
      '
      'txt_gallons
      '
      Me.txt_gallons.Location = New System.Drawing.Point(278, 61)
      Me.txt_gallons.Name = "txt_gallons"
      Me.txt_gallons.Size = New System.Drawing.Size(100, 20)
      Me.txt_gallons.TabIndex = 3
      '
      'txt_miles
      '
      Me.txt_miles.Location = New System.Drawing.Point(278, 124)
      Me.txt_miles.Name = "txt_miles"
      Me.txt_miles.Size = New System.Drawing.Size(100, 20)
      Me.txt_miles.TabIndex = 4
      '
      'txt_mpg
      '
      Me.txt_mpg.Location = New System.Drawing.Point(278, 246)
      Me.txt_mpg.Name = "txt_mpg"
      Me.txt_mpg.Size = New System.Drawing.Size(100, 20)
      Me.txt_mpg.TabIndex = 5
      '
      'btn_calculate_mpg
      '
      Me.btn_calculate_mpg.Location = New System.Drawing.Point(129, 289)
      Me.btn_calculate_mpg.Name = "btn_calculate_mpg"
      Me.btn_calculate_mpg.Size = New System.Drawing.Size(75, 45)
      Me.btn_calculate_mpg.TabIndex = 6
      Me.btn_calculate_mpg.Text = "Calculate MPG"
      Me.btn_calculate_mpg.UseVisualStyleBackColor = True
      '
      'btn_clear
      '
      Me.btn_clear.Location = New System.Drawing.Point(210, 289)
      Me.btn_clear.Name = "btn_clear"
      Me.btn_clear.Size = New System.Drawing.Size(75, 45)
      Me.btn_clear.TabIndex = 7
      Me.btn_clear.Text = "Clear"
      Me.btn_clear.UseVisualStyleBackColor = True
      '
      'btn_exit
      '
      Me.btn_exit.Location = New System.Drawing.Point(291, 289)
      Me.btn_exit.Name = "btn_exit"
      Me.btn_exit.Size = New System.Drawing.Size(75, 45)
      Me.btn_exit.TabIndex = 8
      Me.btn_exit.Text = "Exit"
      Me.btn_exit.UseVisualStyleBackColor = True
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(504, 362)
      Me.Controls.Add(Me.btn_exit)
      Me.Controls.Add(Me.btn_clear)
      Me.Controls.Add(Me.btn_calculate_mpg)
      Me.Controls.Add(Me.txt_mpg)
      Me.Controls.Add(Me.txt_miles)
      Me.Controls.Add(Me.txt_gallons)
      Me.Controls.Add(Me.lbl_MPG)
      Me.Controls.Add(Me.lbl_miles_on_full_tank)
      Me.Controls.Add(Me.lbl_gallons)
      Me.Name = "Form1"
      Me.Text = "schultzder_Assignment1"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents lbl_gallons As Label
   Friend WithEvents lbl_miles_on_full_tank As Label
   Friend WithEvents lbl_MPG As Label
   Friend WithEvents txt_gallons As TextBox
   Friend WithEvents txt_miles As TextBox
   Friend WithEvents txt_mpg As TextBox
   Friend WithEvents btn_calculate_mpg As Button
   Friend WithEvents btn_clear As Button
   Friend WithEvents btn_exit As Button
End Class
