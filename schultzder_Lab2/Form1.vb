Public Class Form1



   Private Sub btn_calculate_Click(sender As Object, e As EventArgs) Handles btn_calculate.Click
      Dim A As Double
      Dim B As Double
      Dim C As Double
      Dim D As Double
      Dim F As Double
      Dim sum As Double

      A = CDbl(txt_penny.Text) * 0.01
      B = CDbl(txt_nickle.Text) * 0.05
      C = CDbl(txt_dime.Text) * 0.1
      D = CDbl(txt_quarter.Text) * 0.25
      F = CDbl(txt_half_dollar.Text) * 0.5

      sum = A + B + C + D + F

      txt_answer.Text = FormatCurrency(sum, TriState.True, TriState.True)



   End Sub

   Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
      txt_answer.Clear()
      txt_dime.Clear()
      txt_penny.Clear()
      txt_nickle.Clear()
      txt_quarter.Clear()
      txt_half_dollar.Clear()

   End Sub

   Private Sub btn_quit_Click(sender As Object, e As EventArgs) Handles btn_quit.Click
      Application.Exit()
   End Sub


End Class
