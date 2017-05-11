Public Class MainForm

    'Encrypt Button
    Private Sub EncryptButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EncryptButton.Click

        'Show the loading bar
        LoadingLabel.Visible = True
        Application.DoEvents()

        'Get the filtered string
        Dim TempMessage As String = FilterCharacters(InputTextBox.Text)
        Dim TempKey As String = FilterCharacters(KeyTextBox.Text)

        Dim EncryptedMessage As String = PseudoXor(TempMessage, TempKey)

        EncryptedMessage = AddExtraCharacters(EncryptedMessage, TempKey)
        OutputTextBox.Text = EncryptedMessage

        'Hide the loading bar
        LoadingLabel.Visible = False

    End Sub

    'Decrypt Button
    Private Sub DecryptButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecryptButton.Click

        'Show the loading bar
        LoadingLabel.Visible = True
        Application.DoEvents()

        'Get the filtered string
        Dim TempMessage As String = FilterCharacters(InputTextBox.Text)
        Dim TempKey As String = FilterCharacters(KeyTextBox.Text)

        'Stop the program if there is an error decrypting
        Try
            Dim DecryptedMessage As String = RemoveExtraChars(TempMessage, TempKey)

            DecryptedMessage = PseudoXor(DecryptedMessage, TempKey)
            OutputTextBox.Text = DecryptedMessage
        Catch
            MessageBox.Show("Error! Please enter a valid message to decrypt.", "Enter Valid Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Hide the loading bar
        LoadingLabel.Visible = False

    End Sub

    'Clear Button
    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        InputTextBox.Text = ""
        KeyTextBox.Text = ""
        OutputTextBox.Text = ""
    End Sub
End Class
