Imports System.Text
Imports CardGame.CardGameFramework

Public Class BlackJackForm

#Region "Fields"
    'Creates a new blackjack game with one player and an inital balance set through the settings designer
    Private _game As New BlackJackGame(My.Settings.InitBalance)
    Private _playerCards As PictureBox()
    Private _dealerCards As PictureBox()
    Private _firstTurn As Boolean
#End Region

#Region "Main Constructor"
    ''' <summary>
    ''' Main constructor for the BlackJackForm.  Initializes components, loads the card skin images, and sets up the new game
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        InitializeComponent()
        LoadCardSkinImages()
        SetUpNewGame()
    End Sub
#End Region

#Region "Game Event Handlers"
    ''' <summary>
    ''' Invoked when the deal button is clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DealBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dealButton.Click

        Try
            'If the current bet is equal to 0, ask the player to place a bet
            If (_game.CurrentPlayer.Bet = 0) And (_game.CurrentPlayer.Balance > 0) Then
                MsgBox("You must place a bet before the dealer deals.", MsgBoxStyle.Information, "Error")
            Else
                'Place the bet
                _game.CurrentPlayer.PlaceBet()
                ShowBankValue()

                'Clear the table, set up the UI for playing a game, and deal a new game
                ClearTable()
                SetUpGameInPlay()
                _game.DealNewGame()
                UpdateUIPlayerCards()

                'Check see if the current player has blackjack
                If _game.CurrentPlayer.HasBlackJack Then
                    EndGame(EndResult.PlayerBlackJack)
                End If
            End If
        Catch NotEnoughMoneyException As Exception
            MsgBox(NotEnoughMoneyException.Message)
        End Try
    End Sub
    ''' <summary>
    ''' Invoked when a player has finished their turn and clicked the stand button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub StandBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles standButton.Click
        'Dealer should finish playing and the UI should be updated
        _game.DealerPlay()
        UpdateUIPlayerCards()

        'Check who won the game
        EndGame(GetGameResult)
    End Sub
    ''' <summary>
    ''' Invoked when the hit button is clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub HitBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hitButton.Click
        'It is no longer the first turn, set this to false so that the cards will all be facing upwards
        _firstTurn = False
        'Hit once and update UI cards
        _game.CurrentPlayer.Hit()
        UpdateUIPlayerCards()

        'Check to see if player has bust
        If _game.CurrentPlayer.HasBust Then
            EndGame(EndResult.PlayerBust)
        End If
    End Sub
    ''' <summary>
    ''' Invoked when the double down button is clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DblDwnBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles doubleDownButton.Click
        Try
            'Double the player's bet amount
            _game.CurrentPlayer.DoubleDown()
            UpdateUIPlayerCards()
            ShowBankValue()

            'Make sure that the player didn't bust
            If _game.CurrentPlayer.HasBust Then
                EndGame(EndResult.PlayerBust)
            Else
                'Otherwise, let the dealer finish playing
                _game.DealerPlay()
                UpdateUIPlayerCards()
                EndGame(GetGameResult)
            End If
        Catch NotEnoughMoneyException As Exception
            MsgBox(NotEnoughMoneyException.Message)
        End Try
    End Sub
    ''' <summary>
    ''' Exits the game
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ExitBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles endButton.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' Place a bet for 10 dollars
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub TenBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tenButton.Click
        Bet(10)
    End Sub
    ''' <summary>
    ''' Place a bet for 25 dollars
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub TwentyFiveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles twentyFiveButton.Click
        Bet(25)
    End Sub
    ''' <summary>
    ''' Place a bet for 50 dollars
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub FiftyBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fiftyButton.Click
        Bet(50)
    End Sub
    ''' <summary>
    ''' Place a bet for 100 dollars
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub HundredBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hundredButton.Click
        Bet(100)
    End Sub
    ''' <summary>
    ''' Clear the bet
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ClearBetBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearBetButton.Click
        'Clear the bet amount
        _game.CurrentPlayer.ClearBet()
        ShowBankValue()
    End Sub

#End Region

#Region "Game Methods"

    ''' <summary>
    ''' This method updates the current bet by a specified bet amount
    ''' </summary>
    ''' <param name="betValue"></param>
    ''' <remarks></remarks>
    Private Sub Bet(ByVal betValue As Integer)
        Try
            'Update the bet amount
            _game.CurrentPlayer.IncreaseBet(betValue)

            'Update the "My Bet" and "My Account" values
            ShowBankValue()
        Catch NotEnoughMoneyException As Exception
            MsgBox(NotEnoughMoneyException.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Sets the "My Account" value in the UI
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ShowBankValue()
        'Update the "My Account" value
        myBetTextBox.Text = "$" & _game.CurrentPlayer.Bet.ToString
        myAccountTextBox.Text = "$" & _game.CurrentPlayer.Balance.ToString
    End Sub

    ''' <summary>
    ''' Clear the dealer and player cards
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ClearTable()
        Dim i As Integer = 0
        While i < 6
            _dealerCards(i).Image = Nothing
            _dealerCards(i).Visible = False
            _playerCards(i).Image = Nothing
            _playerCards(i).Visible = False
            System.Math.Min(System.Threading.Interlocked.Increment(i), i - 1)
        End While
    End Sub

    ''' <summary>
    ''' Get the game result.  This returns an EndResult value
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetGameResult() As EndResult
        'Check for blackjack
        Dim endState As EndResult
        If _game.CurrentDealer.Hand.NumCards = 2 AndAlso _game.CurrentDealer.HasBlackJack Then
            endState = EndResult.DealerBlackJack
            'Check if the dealer has bust
        Else
            If _game.CurrentDealer.HasBust Then
                endState = EndResult.DealerBust
            Else
                If _game.CurrentDealer.Hand.CompareFaceValue(_game.CurrentPlayer.Hand) > 0 Then
                    'dealer wins
                    endState = EndResult.DealerWin
                Else
                    If _game.CurrentDealer.Hand.CompareFaceValue(_game.CurrentPlayer.Hand) = 0 Then
                        'push
                        endState = EndResult.Push
                    Else
                        'player wins
                        endState = EndResult.PlayerWin
                    End If
                End If
            End If
        End If
        Return endState
    End Function

    ''' <summary>
    ''' Takes an EndResult value and shows the resulting game ending in the UI
    ''' </summary>
    ''' <param name="endState"></param>
    ''' <remarks></remarks>
    Private Sub EndGame(ByVal endState As EndResult)
        Select Case endState
            Case EndResult.DealerBust
                gameOverTextBox.Text = "Dealer Bust!"
                _game.PlayerWin()
                ' break 
            Case EndResult.DealerBlackJack
                gameOverTextBox.Text = "Dealer BlackJack!"
                _game.PlayerLose()
                ' break 
            Case EndResult.DealerWin
                gameOverTextBox.Text = "Dealer Won!"
                _game.PlayerLose()
                ' break 
            Case EndResult.PlayerBlackJack
                gameOverTextBox.Text = "BlackJack!"
                _game.CurrentPlayer.Balance += (_game.CurrentPlayer.Bet * CType(2.5, Decimal))
                _game.CurrentPlayer.Wins += 1
                ' break 
            Case EndResult.PlayerBust
                gameOverTextBox.Text = "You Bust!"
                _game.PlayerLose()
                ' break 
            Case EndResult.PlayerWin
                gameOverTextBox.Text = "You Won!"
                _game.PlayerWin()
                ' break 
            Case EndResult.Push
                gameOverTextBox.Text = "Push"
                _game.CurrentPlayer.Push += 1
                _game.CurrentPlayer.Balance += _game.CurrentPlayer.Bet
                ' break 
        End Select
        'Update the "My Record" values
        winTextBox.Text = _game.CurrentPlayer.Wins.ToString
        lossTextBox.Text = _game.CurrentPlayer.Losses.ToString
        tieTextBox.Text = _game.CurrentPlayer.Push.ToString
        SetUpNewGame()
        ShowBankValue()
        gameOverTextBox.Show()
        'Check if the current player is out of money
        If _game.CurrentPlayer.Balance = 0 Then
            MsgBox("Out of Money. Please create a new game to play again.")
            Me.Close()
        End If
    End Sub
#End Region

#Region "Game UI Methods"

    ''' <summary>
    ''' Load the Deck Card Images
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadCardSkinImages()
        Try
            ' Load the card skin image from file
            Dim cardSkin As Image = Image.FromFile(My.Settings.CardGameImageSkinPath)
            ' Set the three cards on the UI to the card skin image
            deckCard1PictureBox.Image = cardSkin
            deckCard2PictureBox.Image = cardSkin
            deckCard3PictureBox.Image = cardSkin
        Catch Ex As OutOfMemoryException
            MsgBox("Card skin images are not loading correctly.  Make sure the card skin images are in the correct location.")
        End Try
        _playerCards = New PictureBox() {playerCard1PictureBox, playerCard2PictureBox, playerCard3PictureBox, playerCard4PictureBox, playerCard5PictureBox, playerCard6PictureBox}
        _dealerCards = New PictureBox() {dealerCard1PictureBox, dealerCard2PictureBox, dealerCard3PictureBox, dealerCard4PictureBox, dealerCard5PictureBox, dealerCard6PictureBox}
    End Sub

    ''' <summary>
    ''' Set up the UI for when the game is in play after the player has hit deal game
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetUpGameInPlay()
        tenButton.Enabled = False
        twentyFiveButton.Enabled = False
        fiftyButton.Enabled = False
        hundredButton.Enabled = False
        clearBetButton.Enabled = False
        standButton.Enabled = True
        hitButton.Enabled = True
        gameOverTextBox.Hide()
        playerTotalLabel.Show()
        dealButton.Enabled = False
        If _firstTurn Then
            doubleDownButton.Enabled = True
        End If
    End Sub

    ''' <summary>
    ''' Set up the UI for a new game
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetUpNewGame()
        photoPictureBox.ImageLocation = My.Settings.PlayerImage
        photoPictureBox.Visible = True
        playerNameLabel.Text = My.Settings.PlayerName
        dealButton.Enabled = True
        doubleDownButton.Enabled = False
        standButton.Enabled = False
        hitButton.Enabled = False
        clearBetButton.Enabled = True
        tenButton.Enabled = True
        twentyFiveButton.Enabled = True
        fiftyButton.Enabled = True
        hundredButton.Enabled = True
        gameOverTextBox.Hide()
        playerTotalLabel.Hide()
        _firstTurn = True
        ShowBankValue()
    End Sub

    ''' <summary>
    ''' Refresh the UI to update the player cards
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub UpdateUIPlayerCards()
        'Update the value of the hand
        playerTotalLabel.Text = _game.CurrentPlayer.Hand.GetSumOfHand.ToString

        Dim pcards As List(Of Card) = _game.CurrentPlayer.Hand.Cards()

        Dim i As Integer = 0
        While i < pcards.Count
            'Load each card from file
            LoadCard(_playerCards(i), pcards(i))
            _playerCards(i).Visible = True
            _playerCards(i).BringToFront()
            i = i + 1
        End While

        Dim dcards As List(Of Card) = _game.CurrentDealer.Hand.Cards()
        i = 0
        While i < dcards.Count
            LoadCard(_dealerCards(i), dcards(i))
            _dealerCards(i).Visible = True
            _dealerCards(i).BringToFront()
            i = i + 1
        End While
    End Sub

    ''' <summary>
    ''' Takes the card value and loads the corresponding card image from file
    ''' </summary>
    ''' <param name="pb"></param>
    ''' <param name="c"></param>
    ''' <remarks></remarks>
    Private Sub LoadCard(ByVal pb As PictureBox, ByVal c As Card)
        Try
            Dim image As StringBuilder = New StringBuilder
            Select Case c.Suit
                Case Suit.Diamonds
                    image.Append("di")

                Case Suit.Hearts
                    image.Append("he")

                Case Suit.Spades
                    image.Append("sp")

                Case Suit.Clubs
                    image.Append("cl")

            End Select
            Select Case c.FaceVal
                Case FaceValue.Ace
                    image.Append("1")

                Case FaceValue.King
                    image.Append("k")

                Case FaceValue.Queen
                    image.Append("q")

                Case FaceValue.Jack
                    image.Append("j")

                Case FaceValue.Ten
                    image.Append("10")

                Case FaceValue.Nine
                    image.Append("9")

                Case FaceValue.Eight
                    image.Append("8")

                Case FaceValue.Seven
                    image.Append("7")

                Case FaceValue.Six
                    image.Append("6")

                Case FaceValue.Five
                    image.Append("5")

                Case FaceValue.Four
                    image.Append("4")

                Case FaceValue.Three
                    image.Append("3")

                Case FaceValue.Two
                    image.Append("2")
            End Select

            image.Append(My.Settings.CardGameImageExtension)
            Dim cardGameImagePath As String = My.Settings.CardGameImagePath
            Dim cardGameImageSkinPath As String = My.Settings.CardGameImageSkinPath
            image.Insert(0, cardGameImagePath)
            'check to see if the card should be faced down or up;
            If Not c.IsCardUp Then
                image.Replace(image.ToString, cardGameImageSkinPath)
            End If
            pb.Image = New Bitmap(image.ToString)
        Catch
            MsgBox("Card images are not loading correctly.  Make sure all card images are in the right location.")
        End Try
    End Sub
#End Region

End Class

