Public Class Form1

   'Routine for the first text box
   Private Sub txtFirst_textChanged_TextChanged(sender As Object, e As EventArgs) Handles txtFirst_textChanged.TextChanged

      txtFirst_textChanged.ForeColor = Color.Blue

   End Sub

   'Routine for button

   Private Sub btnRed_Click_Click(sender As Object, e As EventArgs) Handles btnRed_Click.Click

      txtFirst_textChanged.ForeColor = Color.Red

   End Sub

   'Routine for leave
   Private Sub txtFirst_Leave_TextChanged(sender As Object, e As EventArgs) Handles txtFirst_Leave.TextChanged

      txtFirst_textChanged.ForeColor = Color.Black

   End Sub
End Class
