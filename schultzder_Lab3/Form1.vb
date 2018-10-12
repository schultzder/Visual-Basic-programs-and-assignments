Public Class Form1

   Dim yourPassword As String
   Dim passwordGuess As String = ""

   Private Sub btn_set_passowrd_Click(sender As Object, e As EventArgs) Handles btn_set_passowrd.Click
      yourPassword = txt_input_password.Text
   End Sub

   Private Sub btn_guess_passowrd_Click(sender As Object, e As EventArgs) Handles btn_guess_passowrd.Click
      Dim J As Integer
      Dim l As Integer
      l = yourPassword.Length
      If txt_input_password.Text.Equals("") Then
         MessageBox.Show("Please enter a password")
      End If

      For J = 1 To l
         Dim yourPassword_char As Char = yourPassword.Substring(J - 1, 1)
         Dim i As Integer = 1
         Do While ((Chr(i) <> yourPassword_char) And (i <= 255))
            i += 1
         Loop
         passwordGuess &= yourPassword_char
      Next J
      txt_password_is.Text = passwordGuess
   End Sub

   Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
      txt_input_password.Clear()
      txt_password_is.Clear()
      yourPassword = ""
      passwordGuess = ""
   End Sub

   Private Sub btn_quit_Click(sender As Object, e As EventArgs) Handles btn_quit.Click
      Application.Exit()
   End Sub
End Class
