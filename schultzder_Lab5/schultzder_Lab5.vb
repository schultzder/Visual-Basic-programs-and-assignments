Public Class Form1

   Dim cP As Double = 1.25
   Dim cF As Double = 1.0
   Dim cS As Double = 0.75
   Private Sub btn_Compute_Click(sender As Object, e As EventArgs) Handles btn_Compute.Click
      Input()
      Output()
   End Sub

   Public Sub Input()
      Dim p As Integer = CInt(txt_pizza.Text)
      Dim f As Integer = CInt(txt_fries.Text)
      Dim s As Integer = CInt(txt_softDrinks.Text)
      Calculate(p, f, s)
   End Sub

   Private Sub Output()
      lst_check.Items(0).Add("Item          Quantity       Price")
      lst_check.Items(1).add("                                  ")
      lst_check.Items(2).Add("Pizza Slice          " + txt_pizza.Text + "           " + FormatCurrency(cP, 2))
      lst_check.Items(3).Add("Fries                " + txt_fries.Text + "           " + FormatCurrency(cF, 2))
      lst_check.Items(4).add("Soft Drinks          " + txt_softDrinks.Text + "           " + FormatCurrency(cS, 2))
      lst_check.Items(5).Add("                                  ")
      lst_check.Items(6).Add("Total                        " +  )
   End Sub

   Function Calculate(ByVal p As Integer, f As Integer, s As Integer)

      Dim Sum As Double

      Sum = (p * 1.25) + (f * 1) + (s * 0.75)

      Return Sum
   End Function

   Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
      txt_fries.Clear()
      txt_pizza.Clear()
      txt_softDrinks.Clear()
   End Sub

   Private Sub btn_quit_Click(sender As Object, e As EventArgs) Handles btn_quit.Click
      Application.Exit()
   End Sub
End Class
