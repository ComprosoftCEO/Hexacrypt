Module Hash8

    '0-255 shuffled in any (random) order suffices
    Private hashTable() As Byte = {
       98, 6, 85, 150, 36, 23, 112, 164, 135, 207, 169, 5, 26, 64, 165, 219,
       61, 20, 68, 89, 130, 63, 52, 102, 24, 229, 132, 245, 80, 216, 195, 115,
       90, 168, 156, 203, 177, 120, 2, 190, 188, 7, 100, 185, 174, 243, 162, 10,
      237, 18, 253, 225, 8, 208, 172, 244, 255, 126, 101, 79, 145, 235, 228, 121,
      123, 251, 67, 250, 161, 0, 107, 97, 241, 111, 181, 82, 249, 33, 69, 55,
       59, 153, 29, 9, 213, 167, 84, 93, 30, 46, 94, 75, 151, 114, 73, 222,
      197, 96, 210, 45, 16, 227, 248, 202, 51, 152, 252, 125, 81, 206, 215, 186,
       39, 158, 178, 187, 131, 136, 1, 49, 50, 17, 141, 91, 47, 129, 60, 99,
      154, 35, 86, 171, 105, 34, 38, 200, 147, 58, 77, 118, 173, 246, 76, 254,
      133, 232, 196, 144, 198, 124, 53, 4, 108, 74, 223, 234, 134, 230, 157, 139,
      189, 205, 199, 128, 176, 19, 211, 236, 127, 192, 231, 70, 233, 88, 146, 44,
      183, 201, 22, 83, 13, 214, 116, 109, 159, 32, 95, 226, 140, 220, 57, 12,
      221, 31, 209, 182, 143, 92, 149, 184, 148, 62, 113, 65, 37, 27, 106, 166,
        3, 14, 204, 72, 21, 41, 56, 66, 28, 193, 40, 217, 25, 54, 179, 117,
      238, 87, 240, 155, 180, 170, 242, 212, 191, 163, 78, 218, 137, 194, 175, 110,
       43, 119, 224, 71, 122, 142, 42, 160, 104, 48, 247, 103, 15, 11, 138, 239
    }


    ''' <summary>
    ''' Generate a 64-bit hash using a Pearson Hashing algorithm
    ''' </summary>
    ''' <param name="input">The string to hash</param>
    ''' <returns>64-Bit hash</returns>
    ''' <remarks></remarks>
    Public Function Hash8(ByVal input As String) As UInt64

        'Dynamically define the uniion
        Dim retVal As UInt64 = 0
        Dim hashChar, startChar As Byte
        Dim inputArr As Char() = input.ToCharArray()

        For i As Integer = 0 To Len(New UInt64) - 1

            'Start char should be first char in string, or 0
            If (input.Length > 0) Then : startChar = Convert.ToByte(inputArr(0))
            Else : startChar = 0 : End If

            hashChar = hashTable((startChar + i) Mod 256)
            For j As Integer = 0 To input.Length - 1

                startChar = Convert.ToByte(inputArr(j))
                hashChar = hashTable(hashChar Xor startChar)
            Next
            retVal <<= 8
            retVal = retVal Or hashChar
        Next

        Return retVal
    End Function




    ''' <summary>
    ''' Generate a single byte hash using a Pearson Hashing algorithm
    ''' </summary>
    ''' <param name="input">The string to hash</param>
    ''' <returns>Hash byte</returns>
    ''' <remarks></remarks>
    Public Function Hash8_Checksum(ByVal input As String) As Byte

        'Dynamically define the uniion
        Dim retVal As Byte = 0
        Dim hashChar, startChar As Byte
        Dim inputArr As Char() = input.ToCharArray()


        'Start char should be first char in string, or 0
        If (input.Length > 0) Then : startChar = Convert.ToByte(inputArr(0))
        Else : startChar = 0 : End If

        hashChar = hashTable((startChar + 0) Mod 256)
        For j As Integer = 0 To input.Length - 1
            startChar = Convert.ToByte(inputArr(j))
            hashChar = hashTable(hashChar Xor startChar)
        Next
        retVal = retVal Or hashChar

        Return retVal

    End Function

End Module
