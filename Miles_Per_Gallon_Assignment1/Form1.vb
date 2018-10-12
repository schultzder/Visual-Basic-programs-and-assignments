Public Class Form1
   Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
      txt_gallons.Clear()
      txt_miles.Clear()
      txt_mpg.Clear()
   End Sub

   Private Sub btn_calculate_mpg_Click(sender As Object, e As EventArgs) Handles btn_calculate_mpg.Click
      Dim x As Double
      Dim y As Double
      Dim z As Double

      x = CDbl(txt_gallons.Text)
      y = CDbl(txt_miles.Text)

      z = y / x

      txt_mpg.Text = CStr(FormatNumber(z, 2))

   End Sub

   Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
      Application.Exit()
   End Sub

End Class
