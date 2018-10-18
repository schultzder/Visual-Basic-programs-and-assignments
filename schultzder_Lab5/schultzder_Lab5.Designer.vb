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
      Me.lbl_pizza = New System.Windows.Forms.Label()
      Me.lbl_softDrink = New System.Windows.Forms.Label()
      Me.lbl_fires = New System.Windows.Forms.Label()
      Me.btn_Compute = New System.Windows.Forms.Button()
      Me.lst_check = New System.Windows.Forms.ListBox()
      Me.txt_pizza = New System.Windows.Forms.TextBox()
      Me.txt_softDrinks = New System.Windows.Forms.TextBox()
      Me.txt_fries = New System.Windows.Forms.TextBox()
      Me.btn_reset = New System.Windows.Forms.Button()
      Me.btn_quit = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'lbl_pizza
      '
      Me.lbl_pizza.AutoSize = True
      Me.lbl_pizza.Location = New System.Drawing.Point(62, 47)
      Me.lbl_pizza.Name = "lbl_pizza"
      Me.lbl_pizza.Size = New System.Drawing.Size(119, 13)
      Me.lbl_pizza.TabIndex = 0
      Me.lbl_pizza.Text = "How many pizza slices?"
      '
      'lbl_softDrink
      '
      Me.lbl_softDrink.AutoSize = True
      Me.lbl_softDrink.Location = New System.Drawing.Point(67, 111)
      Me.lbl_softDrink.Name = "lbl_softDrink"
      Me.lbl_softDrink.Size = New System.Drawing.Size(114, 13)
      Me.lbl_softDrink.TabIndex = 1
      Me.lbl_softDrink.Text = "How many soft drinks?"
      '
      'lbl_fires
      '
      Me.lbl_fires.AutoSize = True
      Me.lbl_fires.Location = New System.Drawing.Point(96, 80)
      Me.lbl_fires.Name = "lbl_fires"
      Me.lbl_fires.Size = New System.Drawing.Size(85, 13)
      Me.lbl_fires.TabIndex = 2
      Me.lbl_fires.Text = "How many fires?"
      '
      'btn_Compute
      '
      Me.btn_Compute.Location = New System.Drawing.Point(298, 105)
      Me.btn_Compute.Name = "btn_Compute"
      Me.btn_Compute.Size = New System.Drawing.Size(129, 25)
      Me.btn_Compute.TabIndex = 3
      Me.btn_Compute.Text = "Compute Total Cost"
      Me.btn_Compute.UseVisualStyleBackColor = True
      '
      'lst_check
      '
      Me.lst_check.FormattingEnabled = True
      Me.lst_check.Location = New System.Drawing.Point(12, 154)
      Me.lst_check.Name = "lst_check"
      Me.lst_check.Size = New System.Drawing.Size(415, 108)
      Me.lst_check.TabIndex = 4
      '
      'txt_pizza
      '
      Me.txt_pizza.Location = New System.Drawing.Point(187, 47)
      Me.txt_pizza.Name = "txt_pizza"
      Me.txt_pizza.Size = New System.Drawing.Size(100, 20)
      Me.txt_pizza.TabIndex = 5
      '
      'txt_softDrinks
      '
      Me.txt_softDrinks.Location = New System.Drawing.Point(187, 108)
      Me.txt_softDrinks.Name = "txt_softDrinks"
      Me.txt_softDrinks.Size = New System.Drawing.Size(100, 20)
      Me.txt_softDrinks.TabIndex = 6
      '
      'txt_fries
      '
      Me.txt_fries.Location = New System.Drawing.Point(187, 77)
      Me.txt_fries.Name = "txt_fries"
      Me.txt_fries.Size = New System.Drawing.Size(100, 20)
      Me.txt_fries.TabIndex = 7
      '
      'btn_reset
      '
      Me.btn_reset.Location = New System.Drawing.Point(147, 276)
      Me.btn_reset.Name = "btn_reset"
      Me.btn_reset.Size = New System.Drawing.Size(129, 25)
      Me.btn_reset.TabIndex = 8
      Me.btn_reset.Text = "Reset"
      Me.btn_reset.UseVisualStyleBackColor = True
      '
      'btn_quit
      '
      Me.btn_quit.Location = New System.Drawing.Point(12, 276)
      Me.btn_quit.Name = "btn_quit"
      Me.btn_quit.Size = New System.Drawing.Size(129, 25)
      Me.btn_quit.TabIndex = 9
      Me.btn_quit.Text = "Quit"
      Me.btn_quit.UseVisualStyleBackColor = True
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(439, 313)
      Me.Controls.Add(Me.btn_quit)
      Me.Controls.Add(Me.btn_reset)
      Me.Controls.Add(Me.txt_fries)
      Me.Controls.Add(Me.txt_softDrinks)
      Me.Controls.Add(Me.txt_pizza)
      Me.Controls.Add(Me.lst_check)
      Me.Controls.Add(Me.btn_Compute)
      Me.Controls.Add(Me.lbl_fires)
      Me.Controls.Add(Me.lbl_softDrink)
      Me.Controls.Add(Me.lbl_pizza)
      Me.Name = "Form1"
      Me.Text = "Form1"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents lbl_pizza As Label
   Friend WithEvents lbl_softDrink As Label
   Friend WithEvents lbl_fires As Label
   Friend WithEvents btn_Compute As Button
   Friend WithEvents lst_check As ListBox
   Friend WithEvents txt_pizza As TextBox
   Friend WithEvents txt_softDrinks As TextBox
   Friend WithEvents txt_fries As TextBox
   Friend WithEvents btn_reset As Button
   Friend WithEvents btn_quit As Button
End Class
