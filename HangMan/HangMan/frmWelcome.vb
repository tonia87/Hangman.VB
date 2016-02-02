Public Class frmWelcome
    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        Dim z As frmPlay
        z = New frmPlay()
        z.Show()

    End Sub

    Private Sub frmWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.BackgroundImage = My.Resources.back1
        lblWelcome.ForeColor = Color.Gold
        lblWelcome.Text = "Welcome to Hangman !"

    End Sub
End Class