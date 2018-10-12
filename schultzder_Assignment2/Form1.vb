Public Class Form1
   Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
      txt_number1.Clear()
      txt_number2.Clear()
   End Sub

   Private Sub btn_find_min_max_Click(sender As Object, e As EventArgs) Handles btn_find_min_max.Click


      If (IsNumeric(txt_number1.Text) And IsNumeric(txt_number2.Text)) Then
         If (txt_number1.Text > txt_number2.Text) Then

            MessageBox.Show(txt_number1.Text + " is larger", txt_number2.Text + " is smaller")

         End If

         If (txt_number2.Text > txt_number1.Text) Then

            MessageBox.Show(txt_number2.Text + "is larger", txt_number1.Text + " is smaller")

         End If

         If (txt_number1.Text = txt_number2.Text) Then

            MessageBox.Show(txt_number1.Text + " and " + txt_number2.Text + " are equal")

         End If
      Else
         MessageBox.Show("Invalid input, please enter integers")
      End If
   End Sub

   Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
      Application.Exit()
   End Sub
End Class
