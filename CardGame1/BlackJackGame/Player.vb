Imports CardGame.CardGameFramework

Public Class Player

    'Objects to store player information
    Private _balanceProp As Decimal
    Private _handProp As BlackJackHand
    Private _betProp As Decimal
    Private _winsProp As Integer
    Private _lossesProp As Integer
    Private _pushes As Integer
    Private _imageProp As String
    Private _nameProp As String
    Private _currentDeckProp As Deck

    'Creates a list of cards
    Private _cards As New List(Of Card)


    Public Property CurrentDeck() As Deck
        Get
            Return _currentDeckProp
        End Get
        Set(ByVal value As Deck)
            _currentDeckProp = value
        End Set
    End Property

    Public Property Image() As String
        Get
            Return _imageProp
        End Get
        Set(ByVal value As String)
            _imageProp = value
        End Set
    End Property

    Public ReadOnly Property Hand() As BlackJackHand
        Get
            Return _handProp
        End Get
    End Property

    Public Property Name() As String
        Get
            Return _nameProp
        End Get
        Set(ByVal value As String)
            _nameProp = value
        End Set
    End Property

    Public Property Bet() As Decimal
        Get
            Return _betProp
        End Get
        Set(ByVal value As Decimal)
            _betProp = value
        End Set
    End Property

    Public Property Balance() As Decimal
        Get
            Return _balanceProp
        End Get
        Set(ByVal value As Decimal)
            _balanceProp = value
        End Set
    End Property

    Public Property Wins() As Integer
        Get
            Return _winsProp
        End Get
        Set(ByVal value As Integer)
            _winsProp = value
        End Set
    End Property

    Public Property Losses() As Integer
        Get
            Return _lossesProp
        End Get
        Set(ByVal value As Integer)
            _lossesProp = value
        End Set
    End Property

    Public Property Push() As Integer
        Get
            Return _pushes
        End Get
        Set(ByVal value As Integer)
            _pushes = value
        End Set
    End Property

    ''' <summary>
    ''' Creates a player with a default balance account 
    ''' </summary>
    ''' <remarks>It doesn't matter what the dealer's balance is</remarks>
    Public Sub New()
        MyClass.New(-1)
    End Sub

    ''' <summary>
    ''' Creates a player with a new hand and new balance
    ''' </summary>
    ''' <param name="newBalance"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal newBalance As Integer)
        'Sets the player's image and name that is displayed in the picture frame in the UI.
        Me._imageProp = My.Settings.PlayerImage
        Me._nameProp = My.Settings.PlayerName
        Me._handProp = New BlackJackHand
        Me._balanceProp = newBalance
    End Sub

    ''' <summary>
    ''' Increases the bet amount before the start of each game
    ''' </summary>
    ''' <param name="amt"></param>
    ''' <remarks>Invoked through the betting coins in the BlackJackForm.vb UI</remarks>
    Public Sub IncreaseBet(ByVal amt As Decimal)
        'Checks to see if there is enough money in the balance to make the bet
        If (_balanceProp - (_betProp + amt)) >= 0 Then
            'Add money to the bet
            _betProp += amt
        Else
            Throw New Exception("You do not have enough money to make this bet.")
        End If
    End Sub

    ''' <summary>
    ''' Places the bet and subtracts the amount from "My Account"
    ''' </summary>
    Public Sub PlaceBet()
        'Check to see if the user has enough money to place this bet
        If (_balanceProp - _betProp) >= 0 Then
            _balanceProp = _balanceProp - _betProp
        Else
            Throw New Exception("You do not have enough money to place this bet.")
        End If
    End Sub

    ''' <summary>
    ''' Creates a new hand for the current player
    ''' </summary>
    ''' <returns>BlackJackHand</returns>
    ''' <remarks></remarks>
    Public Function NewHand() As BlackJackHand
        Me._handProp = New BlackJackHand
        Return Me._handProp
    End Function

    ''' <summary>
    ''' Set the bet value back to 0
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ClearBet()
        _betProp = 0
    End Sub

    ''' <summary>
    ''' Check if the current player has BlackJack
    ''' </summary>
    ''' <returns>Returns True if the current player has BlackJack</returns>
    ''' <remarks></remarks>
    Public Function HasBlackJack() As Boolean
        If _handProp.GetSumOfHand = 21 Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Check if the current player has bust
    ''' </summary>
    ''' <returns>Returns True if the current player has bust</returns>
    ''' <remarks></remarks>
    Public Function HasBust() As Boolean
        If _handProp.GetSumOfHand > 21 Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Player has hit
    ''' </summary>
    ''' <remarks>Draws a card from the deck and adds it to the player's hand</remarks>
    Public Sub Hit()
        Dim c As Card = _currentDeckProp.Draw
        _handProp.Cards.Add(c)
    End Sub

    ''' <summary>
    ''' Player has chosen to double down  
    ''' </summary>
    ''' <remarks>Double the player's bet and hit once</remarks>
    Public Sub DoubleDown()
        IncreaseBet(_betProp)
        'Only decrease the balance by half of the current bet
        _balanceProp = _balanceProp - (_betProp / 2)
        Hit()
    End Sub
End Class