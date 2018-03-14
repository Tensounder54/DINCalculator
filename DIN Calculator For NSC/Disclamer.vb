Public Class Disclamer

    Private Sub OnStartup(sender As Object, e As EventArgs) Handles MyBase.Load
        Label17.Text = "• Shoe sizes are for guidance only, the calculation requires the ski " + vbCrLf + "   boot sole length. " + vbCrLf + "• The calculator uses the Salomon 2016-17 Adjustment Chart. " + vbCrLf + "• If 'Undefined' is displayed, you have not selected all the variables " + vbCrLf + "  required for the calculation. " + vbCrLf + "• If the skier is unhappy with the setting they must sign a disclaimer " + vbCrLf + "  before you  change the setting."
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Close()
    End Sub

End Class