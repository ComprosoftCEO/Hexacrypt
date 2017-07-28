''' <summary>
''' Pseudo-Random Number Generator for Hexacrypt. Created by Bryan McClain
''' </summary>
Public Class Rand64

    'Constants needed for algorithm
    Private Const MULTIPLER As UInt64 = 6364136223846793005
    Private Const INCREMENT As UInt64 = 1442695040888963407
    Private Const ORDER As Integer = 32
    Private Const ARRAY_MASK As Integer = 31


    'Public constants
    Public Const MIN_VALUE = UInt64.MinValue
    Public Const MAX_VALUE = UInt64.MaxValue


    'Used for generating random seeds
    '  Seeded with date
    Private Shared seeder As Rand64 =
        New Rand64(CLng(DateTime.UtcNow.Subtract(New DateTime(1970, 1, 1)).TotalMilliseconds))

    'Array of random numbers, and position in that array
    Private arr(ORDER - 1) As UInt64
    Private arrPos As Integer


    ''' <summary>
    ''' Create a new Rand64 object, seeded with a completely random seed
    ''' </summary>
    ''' <remarks></remarks>
    Sub New()
        randomSeed()
    End Sub


    ''' <summary>
    ''' Create a new Rand64 object, but specify the seed to use
    ''' </summary>
    ''' <param name="seed">Seed for random number generator</param>
    ''' <remarks></remarks>
    Sub New(ByVal seed As UInt64)
        reseed(seed)
    End Sub



    ''' <summary>
    ''' Reseed the random number generator
    ''' </summary>
    ''' <param name="seed">New seed</param>
    Public Sub reseed(ByVal seed As UInt64)

        'Use Linear congruential generator to fill array
        For i As Integer = 0 To ORDER - 1
            seed = (seed * MULTIPLER + INCREMENT)
            arr(i) = seed

            'Switch bits
            seed = (seed << 32) Or (seed >> 32)
        Next

        arrPos = 0

    End Sub

    ''' <summary>
    ''' Reseed the random number generator with a random seed
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub randomSeed()
        reseed(seeder.nextInt())
    End Sub



    ''' <summary>
    ''' Get the next random number, as unsigned 64-bit integer
    ''' </summary>
    ''' <returns>Random 64-bit integer</returns>
    ''' <remarks></remarks>
    Public Function nextInt() As UInt64
        arrPos = (arrPos + 1) And ARRAY_MASK
        arr(arrPos) += (arr((arrPos + 5) And ARRAY_MASK) + arr((arrPos + 19) And ARRAY_MASK))
        Return arr(arrPos)
    End Function




    ''' <summary>
    ''' Get the next random number, as unsigned 64-bit integer.
    ''' 
    ''' The number returned is between 0 (inclusive) and max (exclusive).
    ''' Entering 0 will return a number from 0 to MAX
    ''' 
    ''' </summary>
    ''' <param name="max">The max value (exclusive) to return</param>
    ''' <returns>Random number from 0 (inclusive) to max (exclusive)</returns>
    ''' <remarks></remarks>
    Public Function nextInt(ByVal max As UInt64)
        If (max > 0) Then
            Return nextInt() Mod max
        Else
            Return nextInt()
        End If
    End Function



    ''' <summary>
    ''' Shuffle a string using this random object
    ''' </summary>
    ''' <param name="input">The string to shuffle</param>
    ''' <returns>The shuffled string</returns>
    Public Function shuffleString(ByVal input As String) As String

        Dim retVal As String = ""
        Dim strlen As UInt64 = input.Length
        Dim index As Integer

        While (strlen > 0)
            index = nextInt(strlen)
            retVal += input.Substring(index, 1)
            input = input.Remove(index, 1)
            strlen = input.Length
        End While

        Return retVal

    End Function

End Class
