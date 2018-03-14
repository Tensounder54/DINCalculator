Public Class Skier_Types2

    'Private Sub OnStartup(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Button1.BackColor = Color.DimGray
    '    Button2.BackColor = Color.DimGray
    '    Button3.BackColor = Color.DimGray
    '    Button4.BackColor = Color.DimGray
    '    Button5.BackColor = Color.DimGray
    '    Button6.BackColor = Color.DimGray
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Image = My.Resources.skier_type1
        Label1.Text = "Cautious skier. This Type of skier will constantly do Snowplow. This skier is most likely a beginner."
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Image = My.Resources.skier_type2
        Label1.Text = "Recreational skier. This skier will be  sking in parralel. They will not be skiing aggresively."
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox1.Image = My.Resources.skier_type3
        Label1.Text = "Fast and agresive skier. They may be on the fun park and/or mogels and can ski higly competently."
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PictureBox1.Image = My.Resources.skier_type_minus1
        Label1.Text = "Extremely cautious skier. This Type of skier will almost certenly have never skied before. This skier is certainly a beginner."
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PictureBox1.Image = My.Resources.skier_type3plus
        Label1.Text = "Very aggresive skier. It is Likly This skier will be a racer."
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Close()
    End Sub
End Class