Partial Public Class StartForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartForm))
        Me.optionsButton = New System.Windows.Forms.Button
        Me.exitButton = New System.Windows.Forms.Button
        Me.newGameButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'optionsButton
        '
        Me.optionsButton.BackColor = System.Drawing.Color.Transparent
        Me.optionsButton.BackgroundImage = CardGame.My.Resources.Resources.ButtonSquare
        Me.optionsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.optionsButton.FlatAppearance.BorderSize = 0
        Me.optionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.optionsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optionsButton.Location = New System.Drawing.Point(490, 292)
        Me.optionsButton.Name = "optionsButton"
        Me.optionsButton.Size = New System.Drawing.Size(153, 36)
        Me.optionsButton.TabIndex = 2
        Me.optionsButton.Text = "Options"
        Me.optionsButton.UseVisualStyleBackColor = False
        '
        'exitButton
        '
        Me.exitButton.BackColor = System.Drawing.Color.Transparent
        Me.exitButton.BackgroundImage = CardGame.My.Resources.Resources.ButtonSquare
        Me.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.exitButton.FlatAppearance.BorderSize = 0
        Me.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(490, 357)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(153, 34)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = False
        '
        'newGameButton
        '
        Me.newGameButton.BackColor = System.Drawing.Color.Transparent
        Me.newGameButton.BackgroundImage = CardGame.My.Resources.Resources.ButtonSquare
        Me.newGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.newGameButton.FlatAppearance.BorderSize = 0
        Me.newGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.newGameButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newGameButton.Location = New System.Drawing.Point(490, 229)
        Me.newGameButton.Name = "newGameButton"
        Me.newGameButton.Size = New System.Drawing.Size(153, 34)
        Me.newGameButton.TabIndex = 1
        Me.newGameButton.Text = "New Game"
        Me.newGameButton.UseVisualStyleBackColor = False
        '
        'StartForm
        '
        Me.BackgroundImage = CardGame.My.Resources.Resources.SplashPage
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(734, 623)
        Me.Controls.Add(Me.optionsButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.newGameButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StartForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BlackJack Casino"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents optionsButton As System.Windows.Forms.Button
    Private WithEvents exitButton As System.Windows.Forms.Button
    Private WithEvents newGameButton As System.Windows.Forms.Button
End Class
