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
      Me.lst_StartBox = New System.Windows.Forms.ListBox()
      Me.btn_Loop = New System.Windows.Forms.Button()
      Me.btn_Clear = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'lst_StartBox
      '
      Me.lst_StartBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lst_StartBox.FormattingEnabled = True
      Me.lst_StartBox.ItemHeight = 31
      Me.lst_StartBox.Location = New System.Drawing.Point(191, 58)
      Me.lst_StartBox.Name = "lst_StartBox"
      Me.lst_StartBox.Size = New System.Drawing.Size(354, 314)
      Me.lst_StartBox.TabIndex = 0
      '
      'btn_Loop
      '
      Me.btn_Loop.Location = New System.Drawing.Point(587, 58)
      Me.btn_Loop.Name = "btn_Loop"
      Me.btn_Loop.Size = New System.Drawing.Size(75, 23)
      Me.btn_Loop.TabIndex = 1
      Me.btn_Loop.Text = "Print Stars"
      Me.btn_Loop.UseVisualStyleBackColor = True
      '
      'btn_Clear
      '
      Me.btn_Clear.Location = New System.Drawing.Point(587, 87)
      Me.btn_Clear.Name = "btn_Clear"
      Me.btn_Clear.Size = New System.Drawing.Size(75, 23)
      Me.btn_Clear.TabIndex = 2
      Me.btn_Clear.Text = "Clear"
      Me.btn_Clear.UseVisualStyleBackColor = True
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(800, 450)
      Me.Controls.Add(Me.btn_Clear)
      Me.Controls.Add(Me.btn_Loop)
      Me.Controls.Add(Me.lst_StartBox)
      Me.Name = "Form1"
      Me.Text = "schultzder_assignment3"
      Me.ResumeLayout(False)

   End Sub

   Friend WithEvents lst_StartBox As ListBox
   Friend WithEvents btn_Loop As Button
   Friend WithEvents btn_Clear As Button
End Class
