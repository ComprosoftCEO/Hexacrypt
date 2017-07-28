Public Class MainForm

    'Encrypt Button
    Private Sub EncryptButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EncryptButton.Click

        'Show the loading bar
        LoadingLabel.Visible = True
        Application.DoEvents()

        OutputTextBox.Text = Hexacrypt_Encrypt(InputTextBox.Text, KeyTextBox.Text)

        'Hide the loading bar
        LoadingLabel.Visible = False

    End Sub

    'Decrypt Button
    Private Sub DecryptButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecryptButton.Click

        'Show the loading bar
        LoadingLabel.Visible = True
        Application.DoEvents()

        'Stop the program if there is an error decrypting
        Try
            OutputTextBox.Text = Hexacrypt_Decrypt(InputTextBox.Text, KeyTextBox.Text)
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
