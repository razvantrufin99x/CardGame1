Public Class OptionsForm

    ''' <summary>
    ''' Performs setup actions when the form loads
    ''' </summary>
    Private Sub OptionsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Loads the player image from file and displays the image in the "preview" box
            playerPictureBox.Image = Image.FromFile(My.Settings.PlayerImage)

            'Loads the path name for the other images
            Dim image1 As String = My.Settings.DefaultImage1
            Dim image2 As String = My.Settings.DefaultImage2
            Dim image3 As String = My.Settings.DefaultImage3
            Dim image4 As String = My.Settings.DefaultImage4

            'Loads each image and displays it in the image list
            defaultImageList.Images.Add(image1, Image.FromFile(image1))
            defaultImageListView.Items.Add(image1, image1)
            defaultImageList.Images.Add(image2, Image.FromFile(image2))
            defaultImageListView.Items.Add(image2, image2)
            defaultImageList.Images.Add(image3, Image.FromFile(image3))
            defaultImageListView.Items.Add(image3, image3)
            defaultImageList.Images.Add(image4, Image.FromFile(image4))
            defaultImageListView.Items.Add(image4, image4)
            defaultImageListView.Items(0).Text = ""
            defaultImageListView.Items(1).Text = ""
            defaultImageListView.Items(2).Text = ""
            defaultImageListView.Items(3).Text = ""
        Catch ex As OutOfMemoryException
            MsgBox("Images did not load properly.  Verify that images are in the correct location")
        End Try
    End Sub

    ''' <summary>
    ''' Invoked when a user selects an image in the scroll list
    ''' </summary>
    Private Sub PlayerDefaultImageList_ItemActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles defaultImageListView.ItemActivate
        'Selects an image from the image scroll list
        Dim items As ListView.SelectedListViewItemCollection = defaultImageListView.SelectedItems
        My.Settings.PlayerImage = items(0).ImageKey
        playerPictureBox.Image = Image.FromFile(My.Settings.PlayerImage)
    End Sub

    ''' <summary>
    ''' Cancels any changes made in the option form
    ''' </summary>
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optionCancelButton.Click
        My.Settings.Reload()
        Me.Close()
    End Sub

    ''' <summary>
    ''' Saves current changes made in the options form
    ''' </summary>
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okButton.Click
        'Saves the player name to the settings file
        My.Settings.PlayerName = playerNameTextBox.Text
        'Saves the values in the setting file to be used in the game
        My.Settings.Save()
        Me.Close()
    End Sub
End Class
