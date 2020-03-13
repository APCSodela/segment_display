Public Class Form1
    Dim segment(25) As PictureBox
    Dim number As Byte = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        segment(1) = Pixel11
        segment(2) = Pixel12
        segment(3) = Pixel13
        segment(4) = Pixel14
        segment(5) = Pixel15
        segment(6) = Pixel21
        segment(7) = Pixel22
        segment(8) = Pixel23
        segment(9) = Pixel24
        segment(10) = Pixel25
        segment(11) = Pixel31
        segment(12) = Pixel32
        segment(13) = Pixel33
        segment(14) = Pixel34
        segment(15) = Pixel35
        segment(16) = Pixel41
        segment(17) = Pixel42
        segment(18) = Pixel43
        segment(19) = Pixel44
        segment(20) = Pixel45
        segment(21) = Pixel51
        segment(22) = Pixel52
        segment(23) = Pixel53
        segment(24) = Pixel54
        segment(25) = Pixel55
        For i = 1 To 25
            segment(i).BackColor = Color.Silver
        Next
        resetBtn.Enabled = False
    End Sub
    Private Sub controlBtn_Click(sender As Object, e As EventArgs) Handles controlBtn.Click
        If (controlBtn.Text = "START") Then
            Timer1.Start()
            controlBtn.Text = "STOP"
            controlBtn.BackColor = Color.Red
            resetBtn.Enabled = True

            'Display ------> 0
            For i = 1 To 25
                segment(i).BackColor = Color.Silver
            Next
            'First Row
            segment(1).BackColor = Color.Red
            segment(2).BackColor = Color.Red
            segment(3).BackColor = Color.Red
            segment(4).BackColor = Color.Red
            segment(5).BackColor = Color.Red
            'Second Row
            segment(6).BackColor = Color.Red
            segment(10).BackColor = Color.Red
            'Third Row
            segment(11).BackColor = Color.Red
            segment(15).BackColor = Color.Red
            'Fourt Row
            segment(16).BackColor = Color.Red
            segment(20).BackColor = Color.Red
            'Fifth Row
            segment(21).BackColor = Color.Red
            segment(22).BackColor = Color.Red
            segment(23).BackColor = Color.Red
            segment(24).BackColor = Color.Red
            segment(25).BackColor = Color.Red

        ElseIf (controlBtn.Text = "STOP") Then
            Timer1.Stop()
            controlBtn.Text = "CONTINUE"
            controlBtn.BackColor = Color.Orange
        ElseIf (controlBtn.Text = "CONTINUE") Then
            Timer1.Start()
            controlBtn.Text = "STOP"
            controlBtn.BackColor = Color.Red
        End If
    End Sub
    Private Sub resetBtn_Click(sender As Object, e As EventArgs) Handles resetBtn.Click
        Timer1.Stop()
        controlBtn.Text = "START"
        controlBtn.BackColor = Color.Green

        For i = 1 To 25
            segment(i).BackColor = Color.Silver
        Next

        number = 0
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        number += 1

        If (number = 1) Then
            'Display ------> 1

            'First Row
            segment(1).BackColor = Color.Silver
            segment(2).BackColor = Color.Silver
            segment(4).BackColor = Color.Silver
            segment(5).BackColor = Color.Silver
            'Second Row
            segment(6).BackColor = Color.Silver
            segment(7).BackColor = Color.Red
            segment(8).BackColor = Color.Red
            segment(10).BackColor = Color.Silver
            'Third Row
            segment(13).BackColor = Color.Red
            segment(15).BackColor = Color.Silver
            'Fourt Row
            segment(16).BackColor = Color.Silver
            segment(18).BackColor = Color.Red
            segment(20).BackColor = Color.Silver
            'Fifth Row

        ElseIf (number = 2) Then
            'Display ------> 2
            'First Row
            segment(1).BackColor = Color.Red
            segment(2).BackColor = Color.Red
            segment(4).BackColor = Color.Red
            segment(5).BackColor = Color.Red
            'Second Row
            segment(7).BackColor = Color.Silver
            segment(8).BackColor = Color.Silver
            segment(10).BackColor = Color.Red
            'Third Row
            segment(12).BackColor = Color.Red
            segment(14).BackColor = Color.Red
            segment(15).BackColor = Color.Red
            'Fourt Row
            segment(16).BackColor = Color.Red
            segment(18).BackColor = Color.Silver
            'Fifth Row

        ElseIf (number = 3) Then

            'Display ------> 3

            'First Row

            'Second Row

            'Third Row
            segment(11).BackColor = Color.Silver
            'Fourt Row
            segment(16).BackColor = Color.Silver
            segment(20).BackColor = Color.Red
            'Fifth Row

        ElseIf (number = 4) Then

            'Display ------> 4

            'First Row
            segment(2).BackColor = Color.Silver
            segment(3).BackColor = Color.Silver
            segment(4).BackColor = Color.Silver
            'Second Row
            segment(6).BackColor = Color.Red
            'Third Row
            segment(11).BackColor = Color.Red
            'Fourt Row
            segment(20).BackColor = Color.Red
            'Fifth Row
            segment(21).BackColor = Color.Silver
            segment(22).BackColor = Color.Silver
            segment(23).BackColor = Color.Silver
            segment(24).BackColor = Color.Silver

        ElseIf (number = 5) Then

            'Display ------> 5

            'First Row
            segment(2).BackColor = Color.Red
            segment(3).BackColor = Color.Red
            segment(4).BackColor = Color.Red
            'Second Row
            segment(10).BackColor = Color.Silver
            'Third Row
            segment(11).BackColor = Color.Red
            segment(12).BackColor = Color.Red
            segment(13).BackColor = Color.Red
            segment(14).BackColor = Color.Red
            segment(15).BackColor = Color.Red
            'Fourt Row

            'Fifth Row
            segment(21).BackColor = Color.Red
            segment(22).BackColor = Color.Red
            segment(23).BackColor = Color.Red
            segment(24).BackColor = Color.Red

        ElseIf (number = 6) Then

            'Display ------> 6

            'First Row

            'Second Row

            'Third Row

            'Fourt Row
            segment(16).BackColor = Color.Red
            'Fifth Row

        ElseIf (number = 7) Then

            'Display ------> 7

            'First Row

            'Second Row
            segment(6).BackColor = Color.Silver
            segment(9).BackColor = Color.Red
            'Third Row
            segment(11).BackColor = Color.Silver
            segment(12).BackColor = Color.Silver
            segment(14).BackColor = Color.Silver
            segment(15).BackColor = Color.Silver
            'Fourt Row
            segment(16).BackColor = Color.Silver
            segment(18).BackColor = Color.Red
            segment(20).BackColor = Color.Silver
            'Fifth Row
            segment(21).BackColor = Color.Silver
            segment(22).BackColor = Color.Silver
            segment(24).BackColor = Color.Silver
            segment(25).BackColor = Color.Silver

        ElseIf (number = 8) Then

            'Display ------> 8

            'First Row

            'Second Row
            segment(6).BackColor = Color.Red
            segment(9).BackColor = Color.Silver
            segment(10).BackColor = Color.Red
            'Third Row
            segment(11).BackColor = Color.Red
            segment(12).BackColor = Color.Red
            segment(14).BackColor = Color.Red
            segment(15).BackColor = Color.Red
            'Fourt Row
            segment(16).BackColor = Color.Red
            segment(18).BackColor = Color.Silver
            segment(20).BackColor = Color.Red
            'Fifth Row
            segment(21).BackColor = Color.Red
            segment(22).BackColor = Color.Red
            segment(24).BackColor = Color.Red
            segment(25).BackColor = Color.Red

        ElseIf (number = 9) Then

            'Display ------> 9

            'First Row

            'Second Row

            'Third Row

            'Fourt Row
            segment(16).BackColor = Color.Silver
            'Fifth Row

        End If

        If (number = 9) Then
            Timer1.Stop()
            controlBtn.Text = "START"
            controlBtn.BackColor = Color.Green

            number = 0
        End If
    End Sub
End Class
