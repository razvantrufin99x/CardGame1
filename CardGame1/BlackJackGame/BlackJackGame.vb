Imports CardGame.CardGameFramework

Public Class BlackJackGame

#Region "Fields"

    'private Deck and Player objects for the current deck, dealer, and player
    Private _deck As Deck
    Private _dealer As Player
    Private _player As Player

#End Region

#Region "Properties"

    'public properties to return the current player, dealer, and current deck

    Public ReadOnly Property CurrentPlayer() As Player
        Get
            Return _player
        End Get
    End Property

    Public ReadOnly Property CurrentDealer() As Player
        Get
            Return _dealer
        End Get
    End Property

    Public ReadOnly Property CurrentDeck() As Deck
        Get
            Return _deck
        End Get
    End Property
#End Region

#Region "Main Game Constructor"

    ''' <summary>
    ''' Main Constructor for BlackJack Game
    ''' </summary>
    ''' <param name="initBalance"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal initBalance As Integer)
        ' Create a dealer and one player with the initial balance.
        _dealer = New Player
        _player = New Player(initBalance)
    End Sub

#End Region

#Region "Game Methods"

    ''' <summary>
    ''' Deals a new game.
    ''' </summary>
    ''' <remarks>This is invoked through the Deal button in BlackJackForm.vb</remarks>
    Public Sub DealNewGame()

        'Create a new deck and then shuffle the deck
        _deck = New Deck
        _deck.Shuffle()

        'Reset the player and the dealer's hands in case this is not the first game
        _player.NewHand()
        _dealer.NewHand()

        'Deal two cards to each person's hand
        Dim i As Integer = 0
        While i < 2
            Dim c As Card = _deck.Draw
            _player.Hand.Cards.Add(c)

            Dim d As Card = _deck.Draw
            'Set the dealer's second card to be facing down
            If i = 1 Then
                d.IsCardUp = False
            End If
            _dealer.Hand.Cards.Add(d)
            i = i + 1
        End While

        'Give the player and the dealer a handle to the current deck
        _player.CurrentDeck = _deck
        _dealer.CurrentDeck = _deck
    End Sub

    ''' <summary>
    ''' This method finishes playing the dealer's hand
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub DealerPlay()
        'Dealer's card that was facing down is turned up when they start playing
        _dealer.Hand.Cards(1).IsCardUp = True
        ' Check to see if dealer has a hand that is less than 17
        ' If so, dealer should keep hitting until their hand is greater or equal to 17
        If _dealer.Hand.GetSumOfHand < 17 Then
            _dealer.Hit()
            DealerPlay()
        End If
    End Sub

    ''' <summary>
    ''' Updates the player's record with a loss
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub PlayerLose()
        _player.Losses += 1
    End Sub

    ''' <summary>
    ''' Updates the player's record with a win
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub PlayerWin()
        _player.Balance += _player.Bet * 2
        _player.Wins += 1
    End Sub
#End Region

End Class

