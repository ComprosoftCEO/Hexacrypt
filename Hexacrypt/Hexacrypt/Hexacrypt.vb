''' <summary>
''' Handles the Hexacrypt encryption and decryption algorithm.
''' 
''' Includes 2 functions: Hexacrypt_Encrypt and Hexacrypt_Decrypt.
''' </summary>
''' <remarks></remarks>
Module Hexacrypt


    'All characters allowed in the message
    Private AllChars As String = My.Resources.AllChars.ToString
    Private AllChar_Array As Char() = AllChars.ToCharArray()
    Private CHAR_COUNT As Integer = AllChars.Length

    'How much garbage to add on to the string
    Private Const GARBAGE = 10

    Private FilterError As Boolean



    ''' <summary>
    ''' Filter out illegal characters from a string
    ''' </summary>
    ''' <param name="input">The string to filter</param>
    ''' <returns>The filtered string</returns>
    Private Function FilterCharacters(ByVal input As String) As String

        'Temporary string to return
        Dim TempString As String = ""

        'Run through and filter the characters
        For Each c As Char In input
            If (AllChars.IndexOf(c) < 0) Then
                If FilterError = False Then
                    FilterError = True
                    MessageBox.Show("One or more illegal characters have been filtered out from the input. The message will still encode, but without the illegal characters included.", "Illegal Characters Filtered", MessageBoxButtons.OK, MessageBoxIcon.Question)
                End If
            Else
                TempString += c
            End If
        Next

        Return TempString

    End Function





    'Do a pseudo xor for the string
    ''' <summary>
    ''' Do a pseudo xor for the string.
    ''' </summary>
    ''' <param name="input">The input string to PseudoXOR</param>
    ''' <param name="rand">The random object to use</param>
    ''' <remarks></remarks>
    Private Sub PseudoXor(ByRef input As String, ByRef rand As Rand64)

        Dim pxor As String
        Dim index As Integer
        Dim input_arr As Char() = input.ToCharArray

        For i = 0 To input.Length - 1
            pxor = rand.shuffleString(AllChars)
            index = pxor.IndexOf(input_arr(i))
            input_arr(i) = (pxor.Substring(AllChars.Length - (index) - 1, 1))
        Next

        input = New String(input_arr)

    End Sub



    ''' <summary>
    ''' Append random garbage onto the front of the string, as well as two 
    ''' chars to indicate the amount of garbage to remove.
    ''' </summary>
    ''' <param name="input">The string to add garbage to</param>
    ''' <param name="rand">The random number generator to use for the garbage</param>
    Private Sub AddGarbage(ByRef input As String, ByRef rand As Rand64)

        'String used for encoding garbage count
        Dim countString As String = rand.shuffleString(AllChars)

        'Add characters to the front and back of the string
        rand.randomSeed()

        Dim Front As Integer = rand.nextInt(GARBAGE) + 1
        For i = 1 To Front
            input = AllChar_Array(rand.nextInt(CHAR_COUNT)) & input
        Next

        Dim Back As Integer = rand.nextInt(GARBAGE) + 1
        For i = 1 To Back
            input = input & AllChar_Array(rand.nextInt(CHAR_COUNT))
        Next


        'Finally, add on the two characters at the end
        input = input & countString.Substring(Front, 1) & countString.Substring(Back, 1)
    End Sub





    'Remove the extra characters added onto the string
    ''' <summary>
    ''' Remove any garbage appended to the string. Throws an error if unsuccessful.
    ''' </summary>
    ''' <param name="input">The string to remove garbage from</param>
    ''' <param name="rand">The random object used to generate the string</param>
    ''' <exception cref="ArgumentException">Invalid message or key</exception>
    ''' <remarks></remarks>
    Private Sub RemoveGarbage(ByRef input As String, ByRef rand As Rand64)

        'String used for encoding garbage count
        Dim countString As String = rand.shuffleString(AllChars)

        'And get the number of characters to remove
        Dim Back = countString.IndexOf(input.Substring(input.Length - 1, 1))
        Dim Front = countString.IndexOf(input.Substring(input.Length - 2, 1))

        'Test for error
        If (Front < 1 Or Front > GARBAGE Or Back < 1 Or Back > GARBAGE) Then
            Throw New ArgumentException("Invalid encrypted message & key combination!")
        End If

        'Pull these extra characters off
        input = input.Substring(Front, ((input.Length - Back) - Front) - 2)

    End Sub



    ''' <summary>
    ''' Encrypt a message using Hexacrypt
    ''' </summary>
    ''' <param name="message">The message to encrypt</param>
    ''' <param name="key">Secret key to use to encrypt</param>
    ''' <returns>Encrypted message</returns>
    ''' <remarks></remarks>
    Public Function Hexacrypt_Encrypt(ByVal message As String, ByVal key As String) As String

        Dim rand As New Rand64()
        Dim seed As UInt64

        'First do sum filter
        FilterError = False
        message = FilterCharacters(message)
        key = FilterCharacters(key)

        seed = Hash8.Hash8(key)

        'Run the main algorithm
        rand.reseed(seed)
        PseudoXor(message, rand)
        message = StrReverse(message)
        rand.reseed(seed)
        AddGarbage(message, rand)

        'Append a checksum
        Dim checksum As Char = AllChar_Array(Hash8.Hash8_Checksum(key + message) Mod CHAR_COUNT)
        message = checksum + message

        rand.reseed(seed)
        PseudoXor(message, rand)

        Return message

    End Function



    ''' <summary>
    ''' Decrypt a message using Hexacrypt
    ''' </summary>
    ''' <param name="message">The message to decrypt</param>
    ''' <param name="key">The key to decrypt with</param>
    ''' <returns>The decrypted message. Throws an error on invalid!</returns>
    ''' <exception cref="ArgumentException">Invalid message or key</exception>
    Public Function Hexacrypt_Decrypt(ByVal message As String, ByVal key As String) As String

        Dim rand As New Rand64()
        Dim seed As UInt64

        'First do sum filter
        FilterError = False
        message = FilterCharacters(message)
        key = FilterCharacters(key)

        seed = Hash8.Hash8(key)

        'Run the main algorithm
        rand.reseed(seed)
        PseudoXor(message, rand)

        'Verify the checksum
        'Remove first character, as this is NOT part of the checksum
        Dim checksum As Char = AllChar_Array(Hash8.Hash8_Checksum(key + message.Substring(1)) Mod CHAR_COUNT)
        If (checksum <> message.Substring(0, 1)) Then
            Throw New ArgumentException("Invalid encrypted message & key combination!")
        End If

        'Remove the checksum
        message = message.Substring(1)

        'We gucci. Carry on
        rand.reseed(seed)
        RemoveGarbage(message, rand)
        message = StrReverse(message)
        rand.reseed(seed)
        PseudoXor(message, rand)

        Return message
    End Function

End Module
