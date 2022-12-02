Public Class StartForm

    ''' <summary>
    ''' Invokes a new BlackJack game
    ''' </summary>
    Private Sub NewGameBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newGameButton.Click
        ' Show the main BlackJack UI game
        Using blackjackform As New BlackJackForm
            Hide()
            blackjackform.ShowDialog()
            Show()
        End Using
    End Sub

    ''' <summary>
    ''' Brings up the options form
    ''' </summary>
    Private Sub OptionsBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optionsButton.Click
        'Show the Options panel
        Using optionsForm As New OptionsForm
            Hide()
            optionsForm.ShowDialog()
            Show()
        End Using
    End Sub

    ''' <summary>
    ''' Exits the application
    ''' </summary>
    Private Sub ExitBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        'Exit the Game
        Application.Exit()
    End Sub
End Class
