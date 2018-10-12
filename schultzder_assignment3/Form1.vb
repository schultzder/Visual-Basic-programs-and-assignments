Public Class Form1
   Private Sub btn_Loop_Click(sender As Object, e As EventArgs) Handles btn_Loop.Click
      Dim count As Integer
      Dim star As String
      count = 0
      star = "**********"

      Do While (count < 10)
         lst_StartBox.Items.Add(star)
         count += 1
      Loop
   End Sub

   Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
      lst_StartBox.Items.Clear()
   End Sub
End Class
