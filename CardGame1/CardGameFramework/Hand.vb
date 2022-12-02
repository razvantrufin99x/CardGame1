Imports System.Collections.Generic

Namespace CardGameFramework

    Public Class Hand
        ' Creates a list of cards
        Protected _cardsProp As New List(Of Card)

        Public ReadOnly Property Cards() As List(Of Card)
            Get
                Return _cardsProp
            End Get
        End Property

        Public ReadOnly Property NumCards() As Integer
            Get
                Return _cardsProp.Count
            End Get
        End Property

        ''' <summary>
        ''' Checks to see if the hand contains a card of a certain face value
        ''' </summary>
        ''' <param name="item"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ContainsCard(ByVal item As FaceValue) As Boolean
            For Each c As Card In _cardsProp
                If c.FaceVal = item Then
                    Return True
                End If
            Next
            Return False
        End Function
    End Class
    ''' <summary>
    ''' This class is game-specific.  Creates a BlackJack hand that inherits from class hand
    ''' </summary>
    ''' <remarks></remarks>
    Public Class BlackJackHand
        Inherits Hand
        ''' <summary>
        ''' This method compares two BlackJack hands
        ''' </summary>
        ''' <param name="otherHand"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function CompareFaceValue(ByVal otherHand As Object) As Integer
            Dim aHand As BlackJackHand = CType(otherHand, BlackJackHand)
            If Not (aHand Is Nothing) Then
                Return Me.GetSumOfHand.CompareTo(aHand.GetSumOfHand)
            Else
                Throw New ArgumentException("Argument is not a Hand")
            End If
        End Function
        ''' <summary>
        ''' Gets the total value of a hand from BlackJack values
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetSumOfHand() As Integer
            Dim val As Integer = 0
            Dim numAces As Integer = 0

            For Each c As Card In _cardsProp
                If c.FaceVal = FaceValue.Ace Then
                    numAces = numAces + 1
                    val = val + 11
                Else
                    If c.FaceVal = FaceValue.Jack OrElse c.FaceVal = FaceValue.Queen OrElse c.FaceVal = FaceValue.King Then
                        val = val + 10
                    Else
                        val = val + CType(c.FaceVal, Integer)
                    End If
                End If
            Next

            While val > 21 AndAlso numAces > 0
                val = val - 10
                numAces = numAces - 1
            End While
            Return val
        End Function
    End Class
End Namespace