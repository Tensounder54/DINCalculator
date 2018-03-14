Public Class DIN_Calculator

#Region "definitions"

    Public type As String
    Public typeID As Integer = 0
    Public cliked As Boolean = False
    Public weight As String
    Public weightID As Integer = 0
    Public hight As String
    Public hightID As Integer = 0
    Public ageID As Integer = 0
    Public length As String
    Public lengthID As Integer = 0
    Public topID As Integer = 0
    Public din As String
    Public din_two As Integer
    Public clickCount As Integer = 0
    Public snowMode As Boolean = False
    'Public atTopID As Integer = 0

#End Region

#Region "start_up"
    Private Sub OnStartup(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("1")
        ComboBox1.Items.Add("2")
        ComboBox1.Items.Add("3")

        Label4.Visible = False

        PictureBox2.Visible = False

        Button7.Visible = False
        Button8.Visible = False
        Button9.Visible = False

        ComboBox2.Items.Clear()
        ComboBox2.Items.Add("10 - 13 Kg / 1st 8 - 2st 1")
        ComboBox2.Items.Add("14 - 17 Kg / 2st 2 - 2st 10")
        ComboBox2.Items.Add("18 - 21 Kg / 2st 11 - 3st 5")
        ComboBox2.Items.Add("22 - 25 Kg / 3st 6 - 4st")
        ComboBox2.Items.Add("26 - 30 Kg / 4st 1 - 4st 10")
        ComboBox2.Items.Add("31 - 35 Kg / 4st 11 - 5st 8")
        ComboBox2.Items.Add("36 - 41 Kg / 5st 9 - 6st 7")
        ComboBox2.Items.Add("42 - 48 Kg / 6st 8 - 7st 9")
        ComboBox2.Items.Add("49 - 57 Kg / 7st 10 - 8st 13")
        ComboBox2.Items.Add("58 - 66 Kg / 9st - 10st 7")
        ComboBox2.Items.Add("67 - 78 Kg / 10st 8 - 12st 6")
        ComboBox2.Items.Add("79 - 94 Kg / 12st 7 - 14st 13")
        ComboBox2.Items.Add("95 Kg + / 15st +")

        ComboBox3.Items.Clear()
        ComboBox3.Items.Add("148 cm / 4'10""")
        ComboBox3.Items.Add("149 - 157 cm / 4'11"" - 5'1""")
        ComboBox3.Items.Add("158 - 166 cm / 5'2"" - 5'5""")
        ComboBox3.Items.Add("167 - 178 cm / 5'6"" - 5'10""")
        ComboBox3.Items.Add("179 - 194 cm / 5'11"" - 6'4""")
        ComboBox3.Items.Add("195 cm + / 6'5"" +")

        ComboBox4.Items.Clear()
        ComboBox4.Items.Add("7 - 11 (Less than 230 mm)")
        ComboBox4.Items.Add("12 - 13 (231-250 mm)")
        ComboBox4.Items.Add("1 - 2 (251-270 mm Approx.EU ≤35, US ≤4)")
        ComboBox4.Items.Add("3 - 5.5 (271-290 mm Approx. EU 36.5-38.5, US 5-6.5)")
        ComboBox4.Items.Add("6 - 7.5 (291-310 mm Approx. UEU 39-41, US 7-8.5)")
        ComboBox4.Items.Add("8 - 10 (311-330 mm Approx. EU 42-44, US 9-10.5)")
        ComboBox4.Items.Add("10.5 - 12 (331-350 mm Approx. EU 44.5-46, US 11-12.5)")
        ComboBox4.Items.Add(">12 (More than 351 mm Approx. EU ≥47, US ≥13)")

    End Sub
#End Region

#Region "ID_Assignment"

    'Skier Type
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        type = ComboBox1.Text

        If type = "-1" Then
            PictureBox2.Visible = True
            Label4.Visible = True
            PictureBox2.Image = My.Resources.skier_type_minus1
            Label4.Text = "Extremely cautious skier. This Type of skier will almost certenly have never skied before. This skier is certainly a beginner."
            typeID = -1 '1
        ElseIf type = "1" Then
            PictureBox2.Visible = True
            Label4.Visible = True
            PictureBox2.Image = My.Resources.skier_type1
            Label4.Text = "Cautious skier. This Type of skier will constantly do Snowplow. This skier is most likely a beginner."
            typeID = 1 '2
        ElseIf type = "2" Then
            PictureBox2.Visible = True
            Label4.Visible = True
            PictureBox2.Image = My.Resources.skier_type2
            Label4.Text = "Recreational skier. This skier will be  sking in parralel. They will not be skiing aggresively."
            typeID = 2 '3
        ElseIf type = "3" Then
            PictureBox2.Visible = True
            Label4.Visible = True
            PictureBox2.Image = My.Resources.skier_type3
            Label4.Text = "Fast and agresive skier. They may be on the fun park and/or mogels and can ski higly competently."
            typeID = 3 '4
        ElseIf type = "3+" Then
            PictureBox2.Visible = True
            Label4.Visible = True
            PictureBox2.Image = My.Resources.skier_type3plus
            Label4.Text = "Very aggresive skier. It is Likly This skier will be a racer."
            typeID = 4 '5
        End If


    End Sub

    'Weight
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

        weight = ComboBox2.Text

        If weight = "10 - 13 Kg / 1st 8 - 2st 1" Then
            weightID = 1
        ElseIf weight = "14 - 17 Kg / 2st 2 - 2st 10" Then
            weightID = 2
        ElseIf weight = "18 - 21 Kg / 2st 11 - 3st 5" Then
            weightID = 3
        ElseIf weight = "22 - 25 Kg / 3st 6 - 4st" Then
            weightID = 4
        ElseIf weight = "26 - 30 Kg / 4st 1 - 4st 10" Then
            weightID = 5
        ElseIf weight = "31 - 35 Kg / 4st 11 - 5st 8" Then
            weightID = 6
        ElseIf weight = "36 - 41 Kg / 5st 9 - 6st 7" Then
            weightID = 7
        ElseIf weight = "42 - 48 Kg / 6st 8 - 7st 9" Then
            weightID = 8
        ElseIf weight = "49 - 57 Kg / 7st 10 - 8st 13" Then
            weightID = 9
        ElseIf weight = "58 - 66 Kg / 9st - 10st 7" Then
            weightID = 10
        ElseIf weight = "67 - 78 Kg / 10st 8 - 12st 6" Then
            weightID = 11
        ElseIf weight = "79 - 94 Kg / 12st 7 - 14st 13" Then
            weightID = 12
        ElseIf weight = "95 Kg + / 15st +" Then
            weightID = 13
        End If

    End Sub

    'Hight
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged

        'ComboBox3.Items.Add()
        'ComboBox3.Items.Add()
        'ComboBox3.Items.Add()
        'ComboBox3.Items.Add()
        'ComboBox3.Items.Add()
        'ComboBox3.Items.Add()

        hight = ComboBox3.Text

        If hight = "148 cm / 4'10""" Then
            hightID = 14
        ElseIf hight = "149 - 157 cm / 4'11"" - 5'1""" Then
            hightID = 15
        ElseIf hight = "158 - 166 cm / 5'2"" - 5'5""" Then
            hightID = 16
        ElseIf hight = "167 - 178 cm / 5'6"" - 5'10""" Then
            hightID = 17
        ElseIf hight = "179 - 194 cm / 5'11"" - 6'4""" Then
            hightID = 18
        ElseIf hight = "195 cm + / 6'5"" +" Then
            hightID = 19
        End If

    End Sub

    'Age START
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ageID = 1
        If ageID = 1 Then
            Button2.Visible = False
            Button3.Visible = True
            Button4.Visible = True
            Button7.Visible = True
            Button8.Visible = False
            Button9.Visible = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ageID = 2
        If ageID = 2 Then
            Button2.Visible = True
            Button3.Visible = False
            Button4.Visible = True
            Button7.Visible = False
            Button8.Visible = True
            Button9.Visible = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ageID = 3
        If ageID = 3 Then
            Button2.Visible = True
            Button3.Visible = True
            Button4.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = True
        End If
    End Sub
    'Age END

    'Boot Size
    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged

        length = ComboBox4.Text

        'ComboBox4.Items.Clear()
        'ComboBox4.Items.Add("7 - 11 (Less than 230 mm)")
        'ComboBox4.Items.Add("12 - 13 (231-250 mm)")
        'ComboBox4.Items.Add("1 - 2 (251-270 mm Approx.EU ≤35, US ≤4)")
        'ComboBox4.Items.Add("3 - 5.5 (271-290 mm Approx. EU 36.5-38.5, US 5-6.5)")
        'ComboBox4.Items.Add("6 - 7.5 (291-310 mm Approx. UEU 39-41, US 7-8.5)")
        'ComboBox4.Items.Add("8 - 10 (311-330 mm Approx. EU 42-44, US 9-10.5)")
        'ComboBox4.Items.Add("10.5 - 12 (331-350 mm Approx. EU 44.5-46, US 11-12.5)")
        'ComboBox4.Items.Add(">12 (More than 351 mm Approx. EU ≥47, US ≥13)")

        If length = "7 - 11 (Less than 230 mm)" Then
            lengthID = 1
        ElseIf length = "12 - 13 (231-250 mm)" Then
            lengthID = 2
        ElseIf length = "1 - 2 (251-270 mm Approx.EU ≤35, US ≤4)" Then
            lengthID = 3
        ElseIf length = "3 - 5.5 (271-290 mm Approx. EU 36.5-38.5, US 5-6.5)" Then
            lengthID = 4
        ElseIf length = "6 - 7.5 (291-310 mm Approx. UEU 39-41, US 7-8.5)" Then
            lengthID = 5
        ElseIf length = "8 - 10 (311-330 mm Approx. EU 42-44, US 9-10.5)" Then
            lengthID = 6
        ElseIf length = "10.5 - 12 (331-350 mm Approx. EU 44.5-46, US 11-12.5)" Then
            lengthID = 7
        ElseIf length = ">12 (More than 351 mm Approx. EU ≥47, US ≥13)" Then
            lengthID = 8
        End If

        '≥≤

    End Sub

#End Region

#Region "Easter_Egg + Misc"

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'Using 1 rather than 3. Sligtly hacky but it works.
        If clickCount > 1 Then
            If cliked = False Then
                ComboBox1.Items.Add("-1")
                ComboBox1.Items.Add("3+")
                cliked = True
            End If
        Else
            clickCount = clickCount + 1
        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If typeID = 3 AndAlso weightID = 10 AndAlso hightID = 18 AndAlso ageID = 2 AndAlso lengthID = 7 AndAlso Label13.Text = "5.5" AndAlso cliked = False Then
            Me.MaximumSize = New Size(500, 450)
            Label16.Location = New Point(11, 375)
            Label16.Visible = True
            Button12.Location = New Point(13, 383)
            Button12.Visible = True

            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("1")
            ComboBox1.Items.Add("2")
            ComboBox1.Items.Add("3")

            cliked = False
            clickCount = 0

            Label4.Visible = False

            PictureBox2.Visible = False

            Button2.Visible = True
            Button3.Visible = True
            Button4.Visible = True
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False

            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("10 - 13 Kg / 22 - 29 Lbs")
            ComboBox2.Items.Add("14 - 17 Kg / 30 - 38 Lbs")
            ComboBox2.Items.Add("18 - 21 Kg / 39 - 47 Lbs")
            ComboBox2.Items.Add("22 - 25 Kg / 48 - 56 Lbs")
            ComboBox2.Items.Add("26 - 30 Kg / 57 - 66 Lbs")
            ComboBox2.Items.Add("31 - 35 Kg / 67 - 78 Lbs")
            ComboBox2.Items.Add("36 - 41 Kg / 79 - 91 Lbs")
            ComboBox2.Items.Add("42 - 48 Kg / 92 - 107 Lbs")
            ComboBox2.Items.Add("49 - 57 Kg / 108 - 125 Lbs")
            ComboBox2.Items.Add("58 - 66 Kg / 126 - 147 Lbs")
            ComboBox2.Items.Add("67 - 78 Kg / 148 - 174 Lbs")
            ComboBox2.Items.Add("79 - 94 Kg / 175 - 209 Lbs")
            ComboBox2.Items.Add("95 Kg + / 210 Lbs +")

            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("148 cm / 4'10""")
            ComboBox3.Items.Add("149 - 157 cm / 4'11"" - 5'1""")
            ComboBox3.Items.Add("158 - 166 cm / 5'2"" - 5'5""")
            ComboBox3.Items.Add("167 - 178 cm / 5'6"" - 5'10""")
            ComboBox3.Items.Add("179 - 194 cm / 5'11"" - 6'4""")
            ComboBox3.Items.Add("195 cm + / 6'5"" +")

            ComboBox4.Items.Clear()
            ComboBox4.Items.Add("7 - 11 (Less than 230 mm)")
            ComboBox4.Items.Add("12 - 13 (231-250 mm)")
            ComboBox4.Items.Add("1 - 2 (251-270 mm Approx.EU ≤35, US ≤4)")
            ComboBox4.Items.Add("3 - 5.5 (271-290 mm Approx. EU 36.5-38.5, US 5-6.5)")
            ComboBox4.Items.Add("6 - 7.5 (291-310 mm Approx. UEU 39-41, US 7-8.5)")
            ComboBox4.Items.Add("8 - 10 (311-330 mm Approx. EU 42-44, US 9-10.5)")
            ComboBox4.Items.Add("10.5 - 12 (331-350 mm Approx. EU 44.5-46, US 11-12.5)")
            ComboBox4.Items.Add(">12 (More than 351 mm Approx. EU ≥47, US ≥13)")

            Label13.Text = " "

            din_two = 0

            din = " "

            Skier_Types1.Close()

        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.MinimumSize = New Size(500, 450)
        PictureBox3.Visible = True
        Button12.Text = "Snow Mode Activated"
        Button12.Enabled = False
        snowMode = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cliked = False Then
            Skier_Types1.Show()
        ElseIf cliked = True Then
            Skier_Types2.Show()
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Disclamer.Show()
    End Sub

#End Region

#Region "CalcuateAndReset"

    'Calculate Function here.
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Label13.Text = " "

        If typeID <> -1 AndAlso typeID <> 1 AndAlso typeID <> 2 AndAlso typeID <> 3 AndAlso typeID <> 4 AndAlso weightID = 1 AndAlso weightID <> 2 AndAlso weightID <> 3 AndAlso weightID <> 4 AndAlso weightID <> 5 AndAlso weightID <> 6 AndAlso weightID <> 7 AndAlso weightID <> 8 AndAlso weightID <> 9 AndAlso weightID <> 10 AndAlso weightID <> 11 AndAlso weightID <> 12 AndAlso weightID <> 13 AndAlso hightID <> 14 AndAlso hightID <> 15 AndAlso hightID <> 16 AndAlso hightID <> 17 AndAlso hightID <> 18 AndAlso hightID <> 19 AndAlso ageID <> 1 AndAlso ageID <> 2 AndAlso ageID <> 3 AndAlso lengthID <> 1 AndAlso lengthID <> 2 AndAlso lengthID <> 3 AndAlso lengthID <> 4 AndAlso lengthID <> 5 AndAlso lengthID <> 6 AndAlso lengthID <> 7 AndAlso lengthID <> 8 Then
            Label13.Text = "Undefined"
        Else
            If (weightID * 1) < 3 Then
                If (typeID * 1) = 1 Then
                    typeID = 0
                End If
            End If
            If (ageID * 1) = 1 Then
                If (weightID * 1) = 1 Then
                    ageID = 0
                End If
            End If

            If (hightID * 1) > (weightID * 1) Then
                din_two = (weightID * 1) + (typeID * 1) - (ageID * 1)
            ElseIf (hightID * 1) < (weightID * 1) Then
                din_two = (hightID * 1) + (typeID * 1) - (ageID * 1)
            Else
                din_two = (weightID * 1) + (typeID * 1) - (ageID * 1)
            End If

            If snowMode = True Then
                din_two = din_two + 1
            End If

            Dim boot1() As String = {"0.75", "1", "1.5", "2", "2.5", "3", "3.5", "NA", "NA", "NA", "NA", "NA", "NA", "NA", "NA", "NA"}
            Dim boot2() As String = {"0.75", "0.75", "1.25", "1.75", "2.25", "2.75", "3.5", "3.5", "4.5", "5.5", "6.5", "7.5", "NA", "NA", "NA", "NA"}
            Dim boot3() As String = {"0.75", "0.75", "1.25", "1.5", "2", "2.5", "3", "3.5", "4.5", "5.5", "6.5", "7.5", "8.5", "10", "11.5", "NA"}
            Dim boot4() As String = {"NA", "0.75", "1", "1.5", "1.75", "2.25", "2.75", "3", "4", "5", "6", "7", "8.5", "10", "11.5", "NA"}
            Dim boot5() As String = {"NA", "NA", "1", "1.25", "1.5", "2", "2.5", "3", "3.5", "4.5", "5.5", "6.5", "8", "9.5", "11", "NA"}
            Dim boot6() As String = {"NA", "NA", "NA", "1.25", "1.5", "1.75", "2.25", "2.75", "3.5", "4", "5", "6", "7", "8.5", "10", "12"}
            Dim boot7() As String = {"NA", "NA", "NA", "NA", "1.5", "1.75", "2", "2.5", "3", "3.5", "4.5", "5.5", "6.5", "8", "9.5", "11"}
            Dim boot8() As String = {"NA", "NA", "NA", "NA", "NA", "1.75", "2", "2.5", "3", "3", "4", "5", "6", "7.5", "9", "10.5"}

            'din_two = din_two - 1

            If lengthID = 1 Then
                Label13.Text = boot1(din_two)
            ElseIf lengthID = 2 Then
                Label13.Text = boot2(din_two)
            ElseIf lengthID = 3 Then
                Label13.Text = boot3(din_two)
            ElseIf lengthID = 4 Then
                Label13.Text = boot4(din_two)
            ElseIf lengthID = 5 Then
                Label13.Text = boot5(din_two)
            ElseIf lengthID = 6 Then
                Label13.Text = boot6(din_two)
            ElseIf lengthID = 7 Then
                Label13.Text = boot7(din_two)
            ElseIf lengthID = 8 Then
                Label13.Text = boot8(din_two)
            End If
        End If



    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("1")
        ComboBox1.Items.Add("2")
        ComboBox1.Items.Add("3")

        cliked = False
        clickCount = 0

        Label4.Visible = False

        PictureBox2.Visible = False

        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        Button7.Visible = False
        Button8.Visible = False
        Button9.Visible = False

        ComboBox2.Items.Clear()
        ComboBox2.Items.Add("10 - 13 Kg / 1st 8 - 2st 1")
        ComboBox2.Items.Add("14 - 17 Kg / 2st 2 - 2st 10")
        ComboBox2.Items.Add("18 - 21 Kg / 2st 11 - 3st 5")
        ComboBox2.Items.Add("22 - 25 Kg / 3st 6 - 4st")
        ComboBox2.Items.Add("26 - 30 Kg / 4st 1 - 4st 10")
        ComboBox2.Items.Add("31 - 35 Kg / 4st 11 - 5st 8")
        ComboBox2.Items.Add("36 - 41 Kg / 5st 9 - 6st 7")
        ComboBox2.Items.Add("42 - 48 Kg / 6st 8 - 7st 9")
        ComboBox2.Items.Add("49 - 57 Kg / 7st 10 - 8st 13")
        ComboBox2.Items.Add("58 - 66 Kg / 9st - 10st 7")
        ComboBox2.Items.Add("67 - 78 Kg / 10st 8 - 12st 6")
        ComboBox2.Items.Add("79 - 94 Kg / 12st 7 - 14st 13")
        ComboBox2.Items.Add("95 Kg + / 15st +")

        ComboBox3.Items.Clear()
        ComboBox3.Items.Add("148 cm / 4'10""")
        ComboBox3.Items.Add("149 - 157 cm / 4'11"" - 5'1""")
        ComboBox3.Items.Add("158 - 166 cm / 5'2"" - 5'5""")
        ComboBox3.Items.Add("167 - 178 cm / 5'6"" - 5'10""")
        ComboBox3.Items.Add("179 - 194 cm / 5'11"" - 6'4""")
        ComboBox3.Items.Add("195 cm + / 6'5"" +")

        ComboBox4.Items.Clear()
        ComboBox4.Items.Add("Less than 230 mm")
        ComboBox4.Items.Add("231-250 mm")
        ComboBox4.Items.Add("251-270 mm (Approx. UK ≤3, EU ≤35, US ≤4)*")
        ComboBox4.Items.Add("271-290 mm (Approx. UK 4-5.5, EU 36.5-38.5, US 5-6.5)*")
        ComboBox4.Items.Add("291-310 mm (Approx. UK 6-7.5, EU 39-41, US 7-8.5)*")
        ComboBox4.Items.Add("311-330 mm (Approx. UK 8-9.5, EU 42-44, US 9-10.5)*")
        ComboBox4.Items.Add("331-350 mm (Approx. UK 10-11.5, EU 44.5-46, US 11-12.5)*")
        ComboBox4.Items.Add("More than 351 mm (Approx. UK ≥12, EU ≥47, US ≥13)*")

        Label13.Text = " "

        din_two = 0

        din = " "

        Skier_Types1.Close()

        Skier_Types2.Close()

    End Sub

#End Region

End Class
