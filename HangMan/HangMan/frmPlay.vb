Public Class frmPlay


    Dim arrayIndex As Integer = 0
    Dim effort As Integer = 5
    Dim letters As Integer = 0
    Dim found(10) As String



    Private Sub frmPlay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.BackgroundImage = My.Resources.back2

        pbxHangman.BackgroundImageLayout = ImageLayout.Stretch
        pbxHangman.BackgroundImage = My.Resources.hangman
        lblHT.Text = effort.ToString()
        lblMessage.ForeColor = Color.Gold
        btnHint.ForeColor = Color.IndianRed
        lblScore.ForeColor = Color.Gold
        lblRound.ForeColor = Color.Gold

        lblScore.Text = "Round " + round.ToString()
        lblRound.Text = "Score: " + score.ToString()

        Try
            arrayIndex = generator.Next(0, 14)
        Catch ex As Exception
            MsgBox("Failed to load word")
        End Try
        setNewGame()



    End Sub
    Private Sub setNewGame()
        effort = 5
        current = AwordArray(arrayIndex)
        letters = current.Length()
        Console.WriteLine(letters.ToString())
        Console.WriteLine(current)

        letterArray = {(pbx1), (pbx2), (pbx3), (pbx4), (pbx5), (pbx6), (pbx7), (pbx8), (pbx9), (pbx10)}

        For i As Integer = 0 To 9 Step 1
            letterArray(i).BackColor = Color.Transparent
        Next i

        For i As Integer = 0 To letters - 1 Step 1
            letterArray(i).BackgroundImageLayout = ImageLayout.Stretch
            letterArray(i).BackgroundImage = My.Resources.Underscore
        Next i

        For i As Integer = 0 To letters - 1 Step 1
            found(i) = i.ToString()
        Next i

        lblInstructions.Text = "Choose Letter From Grid..."
        lblMessage.Text = "Tries left: " + effort.ToString()

        btnA.Enabled = True
        btnB.Enabled = True
        btnC.Enabled = True
        btnD.Enabled = True
        btnE.Enabled = True
        btnF.Enabled = True
        btnG.Enabled = True
        btnH.Enabled = True
        btnI.Enabled = True
        btnJ.Enabled = True
        btnK.Enabled = True
        btnL.Enabled = True
        btnM.Enabled = True
        btnN.Enabled = True
        btnO.Enabled = True
        btnP.Enabled = True
        btnR.Enabled = True
        btnS.Enabled = True
        btnT.Enabled = True
        btnU.Enabled = True
        btnV.Enabled = True
        btnW.Enabled = True
        btnX.Enabled = True
        btnY.Enabled = True
        btnZ.Enabled = True
    End Sub
    Private Sub CheckButton(x As String, b As Bitmap)
        Dim ind As Integer
        If current.Contains(x) Then
            ind = current.IndexOf(x)
            letterArray(ind).BackgroundImage = b
            found(ind) = x
            CheckFound()

            Dim positionNew As Integer = ind + 1
            Dim elementsLeft As Integer = letters - positionNew

            While positionNew < letters
                ind = current.IndexOf(x, positionNew, elementsLeft)
                If ind = -1 Then
                    Return
                End If
                letterArray(ind).BackgroundImage = b
                found(ind) = x
                CheckFound()
                positionNew += 1
                elementsLeft -= 1
            End While
        Else
            ReduceTrial()
        End If
    End Sub
    Private Sub CheckFound()
        Dim straaa = String.Concat(found)
        If current = straaa Then
            LockResult()
            lblInstructions.Text = "Well done!!!Next round?"
            score += letters * 10
            lblRound.Text = "Score: " + score.ToString()
        End If
    End Sub
    Private Sub ReduceTrial()

        If effort > 0 Then
            effort -= 1
            lblMessage.Text = "Tries left:" + effort.ToString()
            lblHT.Text = effort.ToString()
        End If
        If effort = 0 Then
            pbxHangman.BackgroundImage = My.Resources.transparent
            lblHT.Text = effort.ToString()
            LockResult()
            lblInstructions.Text = "Looking for… " + current + " ?"
        End If

    End Sub
    Private Sub LockResult()

        effort = 0
        lblMessage.Text = ""

        btnA.Enabled = False
        btnB.Enabled = False
        btnC.Enabled = False
        btnD.Enabled = False
        btnE.Enabled = False
        btnF.Enabled = False
        btnG.Enabled = False
        btnH.Enabled = False
        btnI.Enabled = False
        btnJ.Enabled = False
        btnK.Enabled = False
        btnL.Enabled = False
        btnM.Enabled = False
        btnN.Enabled = False
        btnO.Enabled = False
        btnP.Enabled = False
        btnR.Enabled = False
        btnS.Enabled = False
        btnT.Enabled = False
        btnU.Enabled = False
        btnV.Enabled = False
        btnW.Enabled = False
        btnX.Enabled = False
        btnY.Enabled = False
        btnZ.Enabled = False
        btnQ.Enabled = False

        btnHint.Text = "Play again!"
    End Sub
    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        CheckButton("A", My.Resources.a)
        btnA.Enabled = False

    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        CheckButton("B", My.Resources.b)
        btnB.Enabled = False
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        CheckButton("C", My.Resources.c)
        btnC.Enabled = False
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        CheckButton("D", My.Resources.d)
        btnD.Enabled = False
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        CheckButton("E", My.Resources.e)
        btnE.Enabled = False
    End Sub

    Private Sub btnF_Click(sender As Object, e As EventArgs) Handles btnF.Click
        CheckButton("F", My.Resources.f)
        btnF.Enabled = False
    End Sub

    Private Sub btnG_Click(sender As Object, e As EventArgs) Handles btnG.Click
        CheckButton("G", My.Resources.g)
        btnG.Enabled = False
    End Sub

    Private Sub btnH_Click(sender As Object, e As EventArgs) Handles btnH.Click
        CheckButton("H", My.Resources.h)
        btnH.Enabled = False
    End Sub

    Private Sub btnI_Click(sender As Object, e As EventArgs) Handles btnI.Click
        CheckButton("I", My.Resources.i)
        btnI.Enabled = False
    End Sub

    Private Sub btnJ_Click(sender As Object, e As EventArgs) Handles btnJ.Click
        CheckButton("J", My.Resources.j)
        btnJ.Enabled = False
    End Sub

    Private Sub btnK_Click(sender As Object, e As EventArgs) Handles btnK.Click
        CheckButton("K", My.Resources.k)
        btnK.Enabled = False
    End Sub

    Private Sub btnL_Click(sender As Object, e As EventArgs) Handles btnL.Click
        CheckButton("L", My.Resources.l)
        btnL.Enabled = False
    End Sub

    Private Sub btnM_Click(sender As Object, e As EventArgs) Handles btnM.Click
        CheckButton("M", My.Resources.m)
        btnM.Enabled = False
    End Sub

    Private Sub btnN_Click(sender As Object, e As EventArgs) Handles btnN.Click
        CheckButton("N", My.Resources.n)
        btnN.Enabled = False
    End Sub

    Private Sub btnO_Click(sender As Object, e As EventArgs) Handles btnO.Click
        CheckButton("O", My.Resources.o)
        btnO.Enabled = False
    End Sub

    Private Sub btnP_Click(sender As Object, e As EventArgs) Handles btnP.Click
        CheckButton("P", My.Resources.p)
        btnP.Enabled = False
    End Sub

    Private Sub btnQ_Click(sender As Object, e As EventArgs) Handles btnQ.Click
        CheckButton("Q", My.Resources.q)
        btnQ.Enabled = False
    End Sub

    Private Sub btnR_Click(sender As Object, e As EventArgs) Handles btnR.Click
        CheckButton("R", My.Resources.r)
        btnR.Enabled = False
    End Sub

    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        CheckButton("S", My.Resources.s)
        btnS.Enabled = False
    End Sub

    Private Sub btnT_Click(sender As Object, e As EventArgs) Handles btnT.Click
        CheckButton("T", My.Resources.t)
        btnT.Enabled = False
    End Sub


    Private Sub btnU_Click(sender As Object, e As EventArgs) Handles btnU.Click
        CheckButton("U", My.Resources.u)
        btnU.Enabled = False
    End Sub
    Private Sub btnV_Click(sender As Object, e As EventArgs) Handles btnV.Click
        CheckButton("V", My.Resources.v)
        btnV.Enabled = False
    End Sub

    Private Sub btnW_Click(sender As Object, e As EventArgs) Handles btnW.Click
        CheckButton("W", My.Resources.w)
        btnW.Enabled = False

    End Sub

    Private Sub btnY_Click(sender As Object, e As EventArgs) Handles btnY.Click
        CheckButton("Y", My.Resources.y)
        btnY.Enabled = False
    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        CheckButton("X", My.Resources.x)
        btnX.Enabled = False
    End Sub

    Private Sub btnZ_Click(sender As Object, e As EventArgs) Handles btnZ.Click
        CheckButton("Z", My.Resources.z)
        btnZ.Enabled = False
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles pbx8.Click

    End Sub

    Private Sub pbx3_Click(sender As Object, e As EventArgs) Handles pbx3.Click

    End Sub

    Private Sub pbx4_Click(sender As Object, e As EventArgs) Handles pbx4.Click

    End Sub

    Private Sub lblInstructions_Click(sender As Object, e As EventArgs) Handles lblInstructions.Click

    End Sub

    Private Sub lblMessage_Click(sender As Object, e As EventArgs) Handles lblMessage.Click

    End Sub

    Private Sub btnHint_Click(sender As Object, e As EventArgs) Handles btnHint.Click
        If btnHint.Text = "Play again!" Then
            round += 1
            Me.Close()
            Dim z As frmPlay
            z = New frmPlay
            z.Show()



        Else
            If hints > 0 Then
                MsgBox("Current word: " + current)
                hints -= 1
                btnHint.Text = "Hints (" + hints.ToString() + ")"
            Else
                btnHint.Enabled = False
            End If
        End If

    End Sub
End Class
