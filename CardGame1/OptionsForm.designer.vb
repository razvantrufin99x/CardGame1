Partial Public Class OptionsForm
    Inherits System.Windows.Forms.Form

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub

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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OptionsForm))
        Me.defaultImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.previewLabel = New System.Windows.Forms.Label
        Me.optionCancelButton = New System.Windows.Forms.Button
        Me.okButton = New System.Windows.Forms.Button
        Me.optionsLabel = New System.Windows.Forms.Label
        Me.defaultImageListView = New System.Windows.Forms.ListView
        Me.playerPictureLabel = New System.Windows.Forms.Label
        Me.SelectFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.playerNameLabel = New System.Windows.Forms.Label
        Me.playerNameTextBox = New System.Windows.Forms.TextBox
        Me.playerPictureBox = New System.Windows.Forms.PictureBox
        Me.iconPictureBox = New System.Windows.Forms.PictureBox
        CType(Me.playerPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'defaultImageList
        '
        Me.defaultImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.defaultImageList.ImageSize = New System.Drawing.Size(130, 130)
        Me.defaultImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'previewLabel
        '
        Me.previewLabel.AutoSize = True
        Me.previewLabel.BackColor = System.Drawing.Color.Transparent
        Me.previewLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.previewLabel.ForeColor = System.Drawing.Color.White
        Me.previewLabel.Location = New System.Drawing.Point(448, 173)
        Me.previewLabel.Name = "previewLabel"
        Me.previewLabel.Size = New System.Drawing.Size(89, 25)
        Me.previewLabel.TabIndex = 17
        Me.previewLabel.Text = "Preview"
        '
        'optionCancelButton
        '
        Me.optionCancelButton.BackgroundImage = CardGame.My.Resources.Resources.ButtonSquare
        Me.optionCancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.optionCancelButton.FlatAppearance.BorderSize = 0
        Me.optionCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.optionCancelButton.Location = New System.Drawing.Point(338, 465)
        Me.optionCancelButton.Name = "optionCancelButton"
        Me.optionCancelButton.Size = New System.Drawing.Size(108, 50)
        Me.optionCancelButton.TabIndex = 4
        Me.optionCancelButton.Text = "Cancel"
        '
        'okButton
        '
        Me.okButton.BackgroundImage = CardGame.My.Resources.Resources.ButtonSquare
        Me.okButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.okButton.FlatAppearance.BorderSize = 0
        Me.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.okButton.Location = New System.Drawing.Point(205, 465)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(108, 50)
        Me.okButton.TabIndex = 3
        Me.okButton.Text = "OK"
        '
        'optionsLabel
        '
        Me.optionsLabel.AutoSize = True
        Me.optionsLabel.BackColor = System.Drawing.Color.Transparent
        Me.optionsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optionsLabel.ForeColor = System.Drawing.Color.White
        Me.optionsLabel.Location = New System.Drawing.Point(19, 9)
        Me.optionsLabel.Name = "optionsLabel"
        Me.optionsLabel.Size = New System.Drawing.Size(314, 39)
        Me.optionsLabel.TabIndex = 0
        Me.optionsLabel.Text = "BlackJack Options"
        '
        'defaultImageListView
        '
        Me.defaultImageListView.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.defaultImageListView.BackColor = System.Drawing.Color.Silver
        Me.defaultImageListView.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.defaultImageListView.LargeImageList = Me.defaultImageList
        Me.defaultImageListView.Location = New System.Drawing.Point(212, 173)
        Me.defaultImageListView.Margin = New System.Windows.Forms.Padding(0)
        Me.defaultImageListView.MultiSelect = False
        Me.defaultImageListView.Name = "defaultImageListView"
        Me.defaultImageListView.Size = New System.Drawing.Size(207, 191)
        Me.defaultImageListView.TabIndex = 2
        '
        'playerPictureLabel
        '
        Me.playerPictureLabel.AutoSize = True
        Me.playerPictureLabel.BackColor = System.Drawing.Color.Transparent
        Me.playerPictureLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playerPictureLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.playerPictureLabel.Location = New System.Drawing.Point(21, 239)
        Me.playerPictureLabel.Name = "playerPictureLabel"
        Me.playerPictureLabel.Size = New System.Drawing.Size(154, 25)
        Me.playerPictureLabel.TabIndex = 4
        Me.playerPictureLabel.Text = "Player Picture"
        Me.playerPictureLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'playerNameLabel
        '
        Me.playerNameLabel.AutoSize = True
        Me.playerNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.playerNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playerNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.playerNameLabel.Location = New System.Drawing.Point(22, 86)
        Me.playerNameLabel.Name = "playerNameLabel"
        Me.playerNameLabel.Size = New System.Drawing.Size(140, 25)
        Me.playerNameLabel.TabIndex = 2
        Me.playerNameLabel.Text = "Player Name"
        Me.playerNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'playerNameTextBox
        '
        Me.playerNameTextBox.BackColor = System.Drawing.Color.Silver
        Me.playerNameTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.playerNameTextBox.Location = New System.Drawing.Point(213, 83)
        Me.playerNameTextBox.Name = "playerNameTextBox"
        Me.playerNameTextBox.Size = New System.Drawing.Size(171, 32)
        Me.playerNameTextBox.TabIndex = 1
        Me.playerNameTextBox.Text = "Player 1"
        '
        'playerPictureBox
        '
        Me.playerPictureBox.BackColor = System.Drawing.Color.Silver
        Me.playerPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.playerPictureBox.Location = New System.Drawing.Point(437, 205)
        Me.playerPictureBox.Name = "playerPictureBox"
        Me.playerPictureBox.Size = New System.Drawing.Size(127, 117)
        Me.playerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.playerPictureBox.TabIndex = 3
        Me.playerPictureBox.TabStop = False
        '
        'iconPictureBox
        '
        Me.iconPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.iconPictureBox.BackgroundImage = CardGame.My.Resources.Resources.StartMenuIcon
        Me.iconPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.iconPictureBox.Location = New System.Drawing.Point(549, 0)
        Me.iconPictureBox.Name = "iconPictureBox"
        Me.iconPictureBox.Size = New System.Drawing.Size(156, 144)
        Me.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconPictureBox.TabIndex = 18
        Me.iconPictureBox.TabStop = False
        '
        'OptionsForm
        '
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = CardGame.My.Resources.Resources.backGreen
        Me.ClientSize = New System.Drawing.Size(700, 599)
        Me.Controls.Add(Me.playerNameTextBox)
        Me.Controls.Add(Me.optionCancelButton)
        Me.Controls.Add(Me.okButton)
        Me.Controls.Add(Me.optionsLabel)
        Me.Controls.Add(Me.defaultImageListView)
        Me.Controls.Add(Me.playerPictureLabel)
        Me.Controls.Add(Me.playerPictureBox)
        Me.Controls.Add(Me.playerNameLabel)
        Me.Controls.Add(Me.iconPictureBox)
        Me.Controls.Add(Me.previewLabel)
        Me.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OptionsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BlackJack Options"
        CType(Me.playerPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents defaultImageList As System.Windows.Forms.ImageList
    Private WithEvents previewLabel As System.Windows.Forms.Label
    Private WithEvents optionCancelButton As System.Windows.Forms.Button
    Private WithEvents okButton As System.Windows.Forms.Button
    Private WithEvents optionsLabel As System.Windows.Forms.Label
    Private WithEvents defaultImageListView As System.Windows.Forms.ListView
    Private WithEvents playerPictureLabel As System.Windows.Forms.Label
    Private WithEvents SelectFileDialog As System.Windows.Forms.OpenFileDialog
    Private WithEvents playerNameLabel As System.Windows.Forms.Label
    Friend WithEvents playerNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents playerPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents iconPictureBox As System.Windows.Forms.PictureBox
End Class