Partial Public Class BlackJackForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BlackJackForm))
        Me.lossesLabel = New System.Windows.Forms.Label
        Me.tiesLabel = New System.Windows.Forms.Label
        Me.playerCard6PictureBox = New System.Windows.Forms.PictureBox
        Me.winsLabel = New System.Windows.Forms.Label
        Me.betPanel = New System.Windows.Forms.Panel
        Me.twentyFiveButton = New System.Windows.Forms.Button
        Me.clearBetButton = New System.Windows.Forms.Button
        Me.fiftyButton = New System.Windows.Forms.Button
        Me.myBetTextBox = New System.Windows.Forms.TextBox
        Me.myBetLabel = New System.Windows.Forms.Label
        Me.hundredButton = New System.Windows.Forms.Button
        Me.tenButton = New System.Windows.Forms.Button
        Me.recordPanel = New System.Windows.Forms.Panel
        Me.winTextBox = New System.Windows.Forms.TextBox
        Me.tieTextBox = New System.Windows.Forms.TextBox
        Me.lossTextBox = New System.Windows.Forms.TextBox
        Me.myAccountLabel = New System.Windows.Forms.Label
        Me.myAccountTextBox = New System.Windows.Forms.TextBox
        Me.playerNameLabel = New System.Windows.Forms.Label
        Me.endButton = New System.Windows.Forms.Button
        Me.dealButton = New System.Windows.Forms.Button
        Me.standButton = New System.Windows.Forms.Button
        Me.hitButton = New System.Windows.Forms.Button
        Me.doubleDownButton = New System.Windows.Forms.Button
        Me.playerCard5PictureBox = New System.Windows.Forms.PictureBox
        Me.photoPictureBox = New System.Windows.Forms.PictureBox
        Me.framePictureBox = New System.Windows.Forms.PictureBox
        Me.playerTotalLabel = New System.Windows.Forms.Label
        Me.playerCard4PictureBox = New System.Windows.Forms.PictureBox
        Me.playerCard3PictureBox = New System.Windows.Forms.PictureBox
        Me.playerCard2PictureBox = New System.Windows.Forms.PictureBox
        Me.playerCard1PictureBox = New System.Windows.Forms.PictureBox
        Me.dealerCard6PictureBox = New System.Windows.Forms.PictureBox
        Me.dealerCard5PictureBox = New System.Windows.Forms.PictureBox
        Me.gameOverTextBox = New System.Windows.Forms.TextBox
        Me.dealerCard4PictureBox = New System.Windows.Forms.PictureBox
        Me.dealerCard3PictureBox = New System.Windows.Forms.PictureBox
        Me.deckCard3PictureBox = New System.Windows.Forms.PictureBox
        Me.deckCard2PictureBox = New System.Windows.Forms.PictureBox
        Me.deckCard1PictureBox = New System.Windows.Forms.PictureBox
        Me.dealerCard2PictureBox = New System.Windows.Forms.PictureBox
        Me.dealerCard1PictureBox = New System.Windows.Forms.PictureBox
        CType(Me.playerCard6PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.betPanel.SuspendLayout()
        Me.recordPanel.SuspendLayout()
        CType(Me.playerCard5PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.photoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.framePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.playerCard4PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.playerCard3PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.playerCard2PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.playerCard1PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dealerCard6PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dealerCard5PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dealerCard4PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dealerCard3PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deckCard3PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deckCard2PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deckCard1PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dealerCard2PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dealerCard1PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lossesLabel
        '
        Me.lossesLabel.AutoSize = True
        Me.lossesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lossesLabel.ForeColor = System.Drawing.Color.Gold
        Me.lossesLabel.Location = New System.Drawing.Point(383, 5)
        Me.lossesLabel.Name = "lossesLabel"
        Me.lossesLabel.Size = New System.Drawing.Size(62, 20)
        Me.lossesLabel.TabIndex = 2
        Me.lossesLabel.Text = "Losses"
        '
        'tiesLabel
        '
        Me.tiesLabel.AutoSize = True
        Me.tiesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tiesLabel.ForeColor = System.Drawing.Color.Gold
        Me.tiesLabel.Location = New System.Drawing.Point(502, 5)
        Me.tiesLabel.Name = "tiesLabel"
        Me.tiesLabel.Size = New System.Drawing.Size(38, 20)
        Me.tiesLabel.TabIndex = 4
        Me.tiesLabel.Text = "Ties"
        '
        'playerCard6PictureBox
        '
        Me.playerCard6PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.playerCard6PictureBox.Location = New System.Drawing.Point(353, 240)
        Me.playerCard6PictureBox.Name = "playerCard6PictureBox"
        Me.playerCard6PictureBox.Size = New System.Drawing.Size(75, 95)
        Me.playerCard6PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.playerCard6PictureBox.TabIndex = 5
        Me.playerCard6PictureBox.TabStop = False
        Me.playerCard6PictureBox.Visible = False
        '
        'winsLabel
        '
        Me.winsLabel.AutoSize = True
        Me.winsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.winsLabel.ForeColor = System.Drawing.Color.Gold
        Me.winsLabel.Location = New System.Drawing.Point(269, 5)
        Me.winsLabel.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.winsLabel.Name = "winsLabel"
        Me.winsLabel.Size = New System.Drawing.Size(44, 20)
        Me.winsLabel.TabIndex = 1
        Me.winsLabel.Text = "Wins"
        '
        'betPanel
        '
        Me.betPanel.BackColor = System.Drawing.Color.Transparent
        Me.betPanel.BackgroundImage = CardGame.My.Resources.Resources.BorderPlaceYourBetBottom
        Me.betPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.betPanel.Controls.Add(Me.twentyFiveButton)
        Me.betPanel.Controls.Add(Me.clearBetButton)
        Me.betPanel.Controls.Add(Me.fiftyButton)
        Me.betPanel.Controls.Add(Me.myBetTextBox)
        Me.betPanel.Controls.Add(Me.myBetLabel)
        Me.betPanel.Controls.Add(Me.hundredButton)
        Me.betPanel.Controls.Add(Me.tenButton)
        Me.betPanel.Location = New System.Drawing.Point(69, 575)
        Me.betPanel.Name = "betPanel"
        Me.betPanel.Size = New System.Drawing.Size(606, 67)
        Me.betPanel.TabIndex = 25
        '
        'twentyFiveButton
        '
        Me.twentyFiveButton.BackColor = System.Drawing.Color.Transparent
        Me.twentyFiveButton.BackgroundImage = CardGame.My.Resources.Resources.coin2
        Me.twentyFiveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.twentyFiveButton.FlatAppearance.BorderSize = 0
        Me.twentyFiveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.twentyFiveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.twentyFiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.twentyFiveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.twentyFiveButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.twentyFiveButton.Location = New System.Drawing.Point(109, 0)
        Me.twentyFiveButton.Margin = New System.Windows.Forms.Padding(0)
        Me.twentyFiveButton.Name = "twentyFiveButton"
        Me.twentyFiveButton.Size = New System.Drawing.Size(60, 62)
        Me.twentyFiveButton.TabIndex = 6
        Me.twentyFiveButton.Text = "25"
        Me.twentyFiveButton.UseVisualStyleBackColor = False
        '
        'clearBetButton
        '
        Me.clearBetButton.BackColor = System.Drawing.Color.Transparent
        Me.clearBetButton.BackgroundImage = CardGame.My.Resources.Resources.ButtonSquare
        Me.clearBetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.clearBetButton.FlatAppearance.BorderSize = 0
        Me.clearBetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.clearBetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.clearBetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearBetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBetButton.Location = New System.Drawing.Point(455, 7)
        Me.clearBetButton.Name = "clearBetButton"
        Me.clearBetButton.Size = New System.Drawing.Size(81, 30)
        Me.clearBetButton.TabIndex = 10
        Me.clearBetButton.Text = "Clear"
        Me.clearBetButton.UseVisualStyleBackColor = False
        '
        'fiftyButton
        '
        Me.fiftyButton.BackColor = System.Drawing.Color.Transparent
        Me.fiftyButton.BackgroundImage = CardGame.My.Resources.Resources.coin3
        Me.fiftyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.fiftyButton.FlatAppearance.BorderSize = 0
        Me.fiftyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.fiftyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.fiftyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fiftyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fiftyButton.Location = New System.Drawing.Point(182, 0)
        Me.fiftyButton.Margin = New System.Windows.Forms.Padding(0)
        Me.fiftyButton.Name = "fiftyButton"
        Me.fiftyButton.Size = New System.Drawing.Size(60, 62)
        Me.fiftyButton.TabIndex = 7
        Me.fiftyButton.Text = "50"
        Me.fiftyButton.UseVisualStyleBackColor = False
        '
        'myBetTextBox
        '
        Me.myBetTextBox.AutoSize = False
        Me.myBetTextBox.BackColor = System.Drawing.SystemColors.InfoText
        Me.myBetTextBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.myBetTextBox.ForeColor = System.Drawing.Color.Orange
        Me.myBetTextBox.Location = New System.Drawing.Point(352, 3)
        Me.myBetTextBox.Multiline = True
        Me.myBetTextBox.Name = "myBetTextBox"
        Me.myBetTextBox.ReadOnly = True
        Me.myBetTextBox.Size = New System.Drawing.Size(64, 25)
        Me.myBetTextBox.TabIndex = 9
        Me.myBetTextBox.Text = "0"
        Me.myBetTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'myBetLabel
        '
        Me.myBetLabel.AutoSize = True
        Me.myBetLabel.BackColor = System.Drawing.Color.Transparent
        Me.myBetLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.myBetLabel.ForeColor = System.Drawing.Color.Gold
        Me.myBetLabel.Location = New System.Drawing.Point(355, 29)
        Me.myBetLabel.Name = "myBetLabel"
        Me.myBetLabel.Size = New System.Drawing.Size(60, 20)
        Me.myBetLabel.TabIndex = 7
        Me.myBetLabel.Text = "My Bet"
        '
        'hundredButton
        '
        Me.hundredButton.BackColor = System.Drawing.Color.Transparent
        Me.hundredButton.BackgroundImage = CardGame.My.Resources.Resources.coin4
        Me.hundredButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.hundredButton.FlatAppearance.BorderSize = 0
        Me.hundredButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.hundredButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.hundredButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hundredButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hundredButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.hundredButton.Location = New System.Drawing.Point(254, 0)
        Me.hundredButton.Margin = New System.Windows.Forms.Padding(0)
        Me.hundredButton.Name = "hundredButton"
        Me.hundredButton.Size = New System.Drawing.Size(61, 63)
        Me.hundredButton.TabIndex = 8
        Me.hundredButton.Text = "100"
        Me.hundredButton.UseVisualStyleBackColor = False
        '
        'tenButton
        '
        Me.tenButton.BackColor = System.Drawing.Color.Transparent
        Me.tenButton.BackgroundImage = CardGame.My.Resources.Resources.coin1
        Me.tenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tenButton.FlatAppearance.BorderSize = 0
        Me.tenButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.tenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.tenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tenButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tenButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.tenButton.Location = New System.Drawing.Point(33, 0)
        Me.tenButton.Margin = New System.Windows.Forms.Padding(0)
        Me.tenButton.Name = "tenButton"
        Me.tenButton.Size = New System.Drawing.Size(60, 62)
        Me.tenButton.TabIndex = 5
        Me.tenButton.Tag = "10"
        Me.tenButton.Text = "10"
        Me.tenButton.UseVisualStyleBackColor = False
        '
        'recordPanel
        '
        Me.recordPanel.BackColor = System.Drawing.Color.Transparent
        Me.recordPanel.BackgroundImage = CardGame.My.Resources.Resources.BorderPlaceYourBetTop
        Me.recordPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.recordPanel.Controls.Add(Me.lossesLabel)
        Me.recordPanel.Controls.Add(Me.tiesLabel)
        Me.recordPanel.Controls.Add(Me.winsLabel)
        Me.recordPanel.Controls.Add(Me.winTextBox)
        Me.recordPanel.Controls.Add(Me.tieTextBox)
        Me.recordPanel.Controls.Add(Me.lossTextBox)
        Me.recordPanel.Controls.Add(Me.myAccountLabel)
        Me.recordPanel.Controls.Add(Me.myAccountTextBox)
        Me.recordPanel.Location = New System.Drawing.Point(41, 27)
        Me.recordPanel.Name = "recordPanel"
        Me.recordPanel.Size = New System.Drawing.Size(655, 69)
        Me.recordPanel.TabIndex = 24
        '
        'winTextBox
        '
        Me.winTextBox.AutoSize = False
        Me.winTextBox.BackColor = System.Drawing.SystemColors.InfoText
        Me.winTextBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.winTextBox.ForeColor = System.Drawing.Color.DarkOrange
        Me.winTextBox.Location = New System.Drawing.Point(276, 31)
        Me.winTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 3)
        Me.winTextBox.Multiline = True
        Me.winTextBox.Name = "winTextBox"
        Me.winTextBox.ReadOnly = True
        Me.winTextBox.Size = New System.Drawing.Size(32, 28)
        Me.winTextBox.TabIndex = 2
        Me.winTextBox.Text = "0"
        Me.winTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tieTextBox
        '
        Me.tieTextBox.AutoSize = False
        Me.tieTextBox.BackColor = System.Drawing.SystemColors.InfoText
        Me.tieTextBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tieTextBox.ForeColor = System.Drawing.Color.DarkOrange
        Me.tieTextBox.Location = New System.Drawing.Point(503, 30)
        Me.tieTextBox.Multiline = True
        Me.tieTextBox.Name = "tieTextBox"
        Me.tieTextBox.ReadOnly = True
        Me.tieTextBox.Size = New System.Drawing.Size(32, 28)
        Me.tieTextBox.TabIndex = 4
        Me.tieTextBox.Text = "0"
        Me.tieTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lossTextBox
        '
        Me.lossTextBox.AutoSize = False
        Me.lossTextBox.BackColor = System.Drawing.SystemColors.InfoText
        Me.lossTextBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lossTextBox.ForeColor = System.Drawing.Color.DarkOrange
        Me.lossTextBox.Location = New System.Drawing.Point(394, 30)
        Me.lossTextBox.Multiline = True
        Me.lossTextBox.Name = "lossTextBox"
        Me.lossTextBox.ReadOnly = True
        Me.lossTextBox.Size = New System.Drawing.Size(32, 28)
        Me.lossTextBox.TabIndex = 3
        Me.lossTextBox.Text = "0"
        Me.lossTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'myAccountLabel
        '
        Me.myAccountLabel.AutoSize = True
        Me.myAccountLabel.BackColor = System.Drawing.Color.Transparent
        Me.myAccountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.myAccountLabel.ForeColor = System.Drawing.Color.Gold
        Me.myAccountLabel.Location = New System.Drawing.Point(105, 6)
        Me.myAccountLabel.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.myAccountLabel.Name = "myAccountLabel"
        Me.myAccountLabel.Size = New System.Drawing.Size(98, 20)
        Me.myAccountLabel.TabIndex = 6
        Me.myAccountLabel.Text = "My Account"
        '
        'myAccountTextBox
        '
        Me.myAccountTextBox.AutoSize = False
        Me.myAccountTextBox.BackColor = System.Drawing.SystemColors.InfoText
        Me.myAccountTextBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.myAccountTextBox.ForeColor = System.Drawing.Color.Orange
        Me.myAccountTextBox.Location = New System.Drawing.Point(112, 31)
        Me.myAccountTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 3)
        Me.myAccountTextBox.Multiline = True
        Me.myAccountTextBox.Name = "myAccountTextBox"
        Me.myAccountTextBox.ReadOnly = True
        Me.myAccountTextBox.Size = New System.Drawing.Size(82, 28)
        Me.myAccountTextBox.TabIndex = 1
        Me.myAccountTextBox.Text = "2000"
        Me.myAccountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'playerNameLabel
        '
        Me.playerNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.playerNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playerNameLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.playerNameLabel.Location = New System.Drawing.Point(284, 542)
        Me.playerNameLabel.Name = "playerNameLabel"
        Me.playerNameLabel.Size = New System.Drawing.Size(100, 23)
        Me.playerNameLabel.TabIndex = 26
        Me.playerNameLabel.Text = "Player 1"
        '
        'endButton
        '
        Me.endButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.endButton.BackColor = System.Drawing.Color.Transparent
        Me.endButton.BackgroundImage = CardGame.My.Resources.Resources.ButtonRound
        Me.endButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.endButton.FlatAppearance.BorderSize = 0
        Me.endButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.endButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.endButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.endButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.endButton.Location = New System.Drawing.Point(590, 653)
        Me.endButton.Name = "endButton"
        Me.endButton.Size = New System.Drawing.Size(112, 39)
        Me.endButton.TabIndex = 15
        Me.endButton.Text = "End Game"
        Me.endButton.UseVisualStyleBackColor = False
        '
        'dealButton
        '
        Me.dealButton.AutoSize = True
        Me.dealButton.BackColor = System.Drawing.Color.Transparent
        Me.dealButton.BackgroundImage = CardGame.My.Resources.Resources.ButtonRound
        Me.dealButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.dealButton.FlatAppearance.BorderSize = 0
        Me.dealButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.dealButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.dealButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dealButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dealButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dealButton.Location = New System.Drawing.Point(454, 654)
        Me.dealButton.Name = "dealButton"
        Me.dealButton.Size = New System.Drawing.Size(112, 39)
        Me.dealButton.TabIndex = 14
        Me.dealButton.Text = "Deal"
        Me.dealButton.UseVisualStyleBackColor = False
        '
        'standButton
        '
        Me.standButton.BackColor = System.Drawing.Color.Transparent
        Me.standButton.BackgroundImage = CardGame.My.Resources.Resources.ButtonRound
        Me.standButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.standButton.FlatAppearance.BorderSize = 0
        Me.standButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.standButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.standButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.standButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.standButton.ForeColor = System.Drawing.Color.Black
        Me.standButton.Location = New System.Drawing.Point(315, 655)
        Me.standButton.Name = "standButton"
        Me.standButton.Size = New System.Drawing.Size(112, 39)
        Me.standButton.TabIndex = 13
        Me.standButton.Text = "Stand"
        Me.standButton.UseVisualStyleBackColor = False
        '
        'hitButton
        '
        Me.hitButton.BackColor = System.Drawing.Color.Transparent
        Me.hitButton.BackgroundImage = CardGame.My.Resources.Resources.ButtonRound
        Me.hitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.hitButton.FlatAppearance.BorderSize = 0
        Me.hitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.hitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.hitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hitButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.hitButton.Location = New System.Drawing.Point(174, 655)
        Me.hitButton.Margin = New System.Windows.Forms.Padding(0)
        Me.hitButton.Name = "hitButton"
        Me.hitButton.Size = New System.Drawing.Size(112, 39)
        Me.hitButton.TabIndex = 12
        Me.hitButton.Text = "Hit"
        Me.hitButton.UseVisualStyleBackColor = False
        '
        'doubleDownButton
        '
        Me.doubleDownButton.BackColor = System.Drawing.Color.Transparent
        Me.doubleDownButton.BackgroundImage = CardGame.My.Resources.Resources.ButtonRound
        Me.doubleDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.doubleDownButton.FlatAppearance.BorderSize = 0
        Me.doubleDownButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.doubleDownButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.doubleDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.doubleDownButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doubleDownButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.doubleDownButton.Location = New System.Drawing.Point(37, 654)
        Me.doubleDownButton.Margin = New System.Windows.Forms.Padding(0)
        Me.doubleDownButton.Name = "doubleDownButton"
        Me.doubleDownButton.Size = New System.Drawing.Size(123, 38)
        Me.doubleDownButton.TabIndex = 11
        Me.doubleDownButton.Text = "Double Down"
        Me.doubleDownButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.doubleDownButton.UseVisualStyleBackColor = False
        Me.doubleDownButton.Visible = False
        '
        'playerCard5PictureBox
        '
        Me.playerCard5PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.playerCard5PictureBox.Location = New System.Drawing.Point(334, 240)
        Me.playerCard5PictureBox.Name = "playerCard5PictureBox"
        Me.playerCard5PictureBox.Size = New System.Drawing.Size(75, 95)
        Me.playerCard5PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.playerCard5PictureBox.TabIndex = 4
        Me.playerCard5PictureBox.TabStop = False
        Me.playerCard5PictureBox.Visible = False
        '
        'photoPictureBox
        '
        Me.photoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.photoPictureBox.ImageLocation = ""
        Me.photoPictureBox.Location = New System.Drawing.Point(297, 408)
        Me.photoPictureBox.Name = "photoPictureBox"
        Me.photoPictureBox.Size = New System.Drawing.Size(107, 111)
        Me.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.photoPictureBox.TabIndex = 17
        Me.photoPictureBox.TabStop = False
        '
        'framePictureBox
        '
        Me.framePictureBox.BackColor = System.Drawing.Color.Transparent
        Me.framePictureBox.BackgroundImage = CardGame.My.Resources.Resources.FrameOrange
        Me.framePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.framePictureBox.Location = New System.Drawing.Point(281, 392)
        Me.framePictureBox.Name = "framePictureBox"
        Me.framePictureBox.Size = New System.Drawing.Size(138, 143)
        Me.framePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.framePictureBox.TabIndex = 16
        Me.framePictureBox.TabStop = False
        '
        'playerTotalLabel
        '
        Me.playerTotalLabel.AutoSize = True
        Me.playerTotalLabel.Location = New System.Drawing.Point(239, 244)
        Me.playerTotalLabel.Name = "playerTotalLabel"
        Me.playerTotalLabel.Size = New System.Drawing.Size(9, 13)
        Me.playerTotalLabel.TabIndex = 6
        Me.playerTotalLabel.Text = "0"
        '
        'playerCard4PictureBox
        '
        Me.playerCard4PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.playerCard4PictureBox.Location = New System.Drawing.Point(316, 239)
        Me.playerCard4PictureBox.Name = "playerCard4PictureBox"
        Me.playerCard4PictureBox.Size = New System.Drawing.Size(75, 95)
        Me.playerCard4PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.playerCard4PictureBox.TabIndex = 3
        Me.playerCard4PictureBox.TabStop = False
        Me.playerCard4PictureBox.Visible = False
        '
        'playerCard3PictureBox
        '
        Me.playerCard3PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.playerCard3PictureBox.Location = New System.Drawing.Point(295, 239)
        Me.playerCard3PictureBox.Name = "playerCard3PictureBox"
        Me.playerCard3PictureBox.Size = New System.Drawing.Size(75, 95)
        Me.playerCard3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.playerCard3PictureBox.TabIndex = 2
        Me.playerCard3PictureBox.TabStop = False
        Me.playerCard3PictureBox.Visible = False
        '
        'playerCard2PictureBox
        '
        Me.playerCard2PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.playerCard2PictureBox.Location = New System.Drawing.Point(275, 239)
        Me.playerCard2PictureBox.Name = "playerCard2PictureBox"
        Me.playerCard2PictureBox.Size = New System.Drawing.Size(75, 95)
        Me.playerCard2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.playerCard2PictureBox.TabIndex = 1
        Me.playerCard2PictureBox.TabStop = False
        Me.playerCard2PictureBox.Visible = False
        '
        'playerCard1PictureBox
        '
        Me.playerCard1PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.playerCard1PictureBox.Location = New System.Drawing.Point(255, 239)
        Me.playerCard1PictureBox.Name = "playerCard1PictureBox"
        Me.playerCard1PictureBox.Size = New System.Drawing.Size(75, 95)
        Me.playerCard1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.playerCard1PictureBox.TabIndex = 0
        Me.playerCard1PictureBox.TabStop = False
        Me.playerCard1PictureBox.Visible = False
        '
        'dealerCard6PictureBox
        '
        Me.dealerCard6PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.dealerCard6PictureBox.Location = New System.Drawing.Point(325, 117)
        Me.dealerCard6PictureBox.Margin = New System.Windows.Forms.Padding(1, 1, 3, 3)
        Me.dealerCard6PictureBox.Name = "dealerCard6PictureBox"
        Me.dealerCard6PictureBox.Size = New System.Drawing.Size(75, 95)
        Me.dealerCard6PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dealerCard6PictureBox.TabIndex = 14
        Me.dealerCard6PictureBox.TabStop = False
        Me.dealerCard6PictureBox.Visible = False
        '
        'dealerCard5PictureBox
        '
        Me.dealerCard5PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.dealerCard5PictureBox.Location = New System.Drawing.Point(304, 117)
        Me.dealerCard5PictureBox.Name = "dealerCard5PictureBox"
        Me.dealerCard5PictureBox.Size = New System.Drawing.Size(75, 95)
        Me.dealerCard5PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dealerCard5PictureBox.TabIndex = 13
        Me.dealerCard5PictureBox.TabStop = False
        Me.dealerCard5PictureBox.Visible = False
        '
        'gameOverTextBox
        '
        Me.gameOverTextBox.AutoSize = False
        Me.gameOverTextBox.BackColor = System.Drawing.Color.Black
        Me.gameOverTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gameOverTextBox.ForeColor = System.Drawing.Color.White
        Me.gameOverTextBox.Location = New System.Drawing.Point(479, 503)
        Me.gameOverTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 3)
        Me.gameOverTextBox.Multiline = True
        Me.gameOverTextBox.Name = "gameOverTextBox"
        Me.gameOverTextBox.ReadOnly = True
        Me.gameOverTextBox.Size = New System.Drawing.Size(223, 30)
        Me.gameOverTextBox.TabIndex = 5
        Me.gameOverTextBox.Text = "Game Over"
        Me.gameOverTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dealerCard4PictureBox
        '
        Me.dealerCard4PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.dealerCard4PictureBox.Location = New System.Drawing.Point(285, 117)
        Me.dealerCard4PictureBox.Margin = New System.Windows.Forms.Padding(3, 3, 1, 3)
        Me.dealerCard4PictureBox.Name = "dealerCard4PictureBox"
        Me.dealerCard4PictureBox.Size = New System.Drawing.Size(75, 95)
        Me.dealerCard4PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dealerCard4PictureBox.TabIndex = 12
        Me.dealerCard4PictureBox.TabStop = False
        Me.dealerCard4PictureBox.Visible = False
        '
        'dealerCard3PictureBox
        '
        Me.dealerCard3PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.dealerCard3PictureBox.Location = New System.Drawing.Point(266, 117)
        Me.dealerCard3PictureBox.Name = "dealerCard3PictureBox"
        Me.dealerCard3PictureBox.Size = New System.Drawing.Size(75, 95)
        Me.dealerCard3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dealerCard3PictureBox.TabIndex = 11
        Me.dealerCard3PictureBox.TabStop = False
        Me.dealerCard3PictureBox.Visible = False
        '
        'deckCard3PictureBox
        '
        Me.deckCard3PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.deckCard3PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.deckCard3PictureBox.Location = New System.Drawing.Point(448, 112)
        Me.deckCard3PictureBox.Name = "deckCard3PictureBox"
        Me.deckCard3PictureBox.Size = New System.Drawing.Size(80, 101)
        Me.deckCard3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.deckCard3PictureBox.TabIndex = 8
        Me.deckCard3PictureBox.TabStop = False
        '
        'deckCard2PictureBox
        '
        Me.deckCard2PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.deckCard2PictureBox.Location = New System.Drawing.Point(438, 123)
        Me.deckCard2PictureBox.Name = "deckCard2PictureBox"
        Me.deckCard2PictureBox.Size = New System.Drawing.Size(81, 100)
        Me.deckCard2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.deckCard2PictureBox.TabIndex = 7
        Me.deckCard2PictureBox.TabStop = False
        '
        'deckCard1PictureBox
        '
        Me.deckCard1PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.deckCard1PictureBox.Location = New System.Drawing.Point(429, 132)
        Me.deckCard1PictureBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.deckCard1PictureBox.Name = "deckCard1PictureBox"
        Me.deckCard1PictureBox.Size = New System.Drawing.Size(80, 100)
        Me.deckCard1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.deckCard1PictureBox.TabIndex = 6
        Me.deckCard1PictureBox.TabStop = False
        '
        'dealerCard2PictureBox
        '
        Me.dealerCard2PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.dealerCard2PictureBox.Location = New System.Drawing.Point(248, 117)
        Me.dealerCard2PictureBox.Name = "dealerCard2PictureBox"
        Me.dealerCard2PictureBox.Size = New System.Drawing.Size(75, 95)
        Me.dealerCard2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dealerCard2PictureBox.TabIndex = 10
        Me.dealerCard2PictureBox.TabStop = False
        Me.dealerCard2PictureBox.Visible = False
        '
        'dealerCard1PictureBox
        '
        Me.dealerCard1PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.dealerCard1PictureBox.Location = New System.Drawing.Point(230, 117)
        Me.dealerCard1PictureBox.Name = "dealerCard1PictureBox"
        Me.dealerCard1PictureBox.Size = New System.Drawing.Size(75, 95)
        Me.dealerCard1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dealerCard1PictureBox.TabIndex = 9
        Me.dealerCard1PictureBox.TabStop = False
        Me.dealerCard1PictureBox.Visible = False
        '
        'BlackJackForm
        '
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CardGame.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(734, 706)
        Me.Controls.Add(Me.playerTotalLabel)
        Me.Controls.Add(Me.playerCard6PictureBox)
        Me.Controls.Add(Me.betPanel)
        Me.Controls.Add(Me.recordPanel)
        Me.Controls.Add(Me.playerNameLabel)
        Me.Controls.Add(Me.endButton)
        Me.Controls.Add(Me.dealButton)
        Me.Controls.Add(Me.standButton)
        Me.Controls.Add(Me.hitButton)
        Me.Controls.Add(Me.doubleDownButton)
        Me.Controls.Add(Me.playerCard5PictureBox)
        Me.Controls.Add(Me.photoPictureBox)
        Me.Controls.Add(Me.framePictureBox)
        Me.Controls.Add(Me.playerCard4PictureBox)
        Me.Controls.Add(Me.playerCard3PictureBox)
        Me.Controls.Add(Me.playerCard2PictureBox)
        Me.Controls.Add(Me.playerCard1PictureBox)
        Me.Controls.Add(Me.dealerCard6PictureBox)
        Me.Controls.Add(Me.dealerCard5PictureBox)
        Me.Controls.Add(Me.gameOverTextBox)
        Me.Controls.Add(Me.dealerCard4PictureBox)
        Me.Controls.Add(Me.dealerCard3PictureBox)
        Me.Controls.Add(Me.deckCard3PictureBox)
        Me.Controls.Add(Me.deckCard2PictureBox)
        Me.Controls.Add(Me.deckCard1PictureBox)
        Me.Controls.Add(Me.dealerCard2PictureBox)
        Me.Controls.Add(Me.dealerCard1PictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BlackJackForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BlackJack Casino"
        CType(Me.playerCard6PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.betPanel.ResumeLayout(False)
        Me.betPanel.PerformLayout()
        Me.recordPanel.ResumeLayout(False)
        Me.recordPanel.PerformLayout()
        CType(Me.playerCard5PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.photoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.framePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.playerCard4PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.playerCard3PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.playerCard2PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.playerCard1PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dealerCard6PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dealerCard5PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dealerCard4PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dealerCard3PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deckCard3PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deckCard2PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deckCard1PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dealerCard2PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dealerCard1PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lossesLabel As System.Windows.Forms.Label
    Friend WithEvents tiesLabel As System.Windows.Forms.Label
    Friend WithEvents playerCard6PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents winsLabel As System.Windows.Forms.Label
    Friend WithEvents betPanel As System.Windows.Forms.Panel
    Friend WithEvents twentyFiveButton As System.Windows.Forms.Button
    Friend WithEvents clearBetButton As System.Windows.Forms.Button
    Friend WithEvents fiftyButton As System.Windows.Forms.Button
    Friend WithEvents myBetTextBox As System.Windows.Forms.TextBox
    Friend WithEvents myBetLabel As System.Windows.Forms.Label
    Friend WithEvents hundredButton As System.Windows.Forms.Button
    Friend WithEvents tenButton As System.Windows.Forms.Button
    Friend WithEvents recordPanel As System.Windows.Forms.Panel
    Friend WithEvents winTextBox As System.Windows.Forms.TextBox
    Friend WithEvents tieTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lossTextBox As System.Windows.Forms.TextBox
    Friend WithEvents myAccountLabel As System.Windows.Forms.Label
    Friend WithEvents myAccountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents playerNameLabel As System.Windows.Forms.Label
    Friend WithEvents endButton As System.Windows.Forms.Button
    Friend WithEvents dealButton As System.Windows.Forms.Button
    Friend WithEvents standButton As System.Windows.Forms.Button
    Friend WithEvents hitButton As System.Windows.Forms.Button
    Friend WithEvents doubleDownButton As System.Windows.Forms.Button
    Friend WithEvents playerCard5PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents photoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents framePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents playerTotalLabel As System.Windows.Forms.Label
    Friend WithEvents playerCard4PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents playerCard3PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents playerCard2PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents playerCard1PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents dealerCard6PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents dealerCard5PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents gameOverTextBox As System.Windows.Forms.TextBox
    Friend WithEvents dealerCard4PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents dealerCard3PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents deckCard3PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents deckCard2PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents deckCard1PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents dealerCard2PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents dealerCard1PictureBox As System.Windows.Forms.PictureBox
End Class

