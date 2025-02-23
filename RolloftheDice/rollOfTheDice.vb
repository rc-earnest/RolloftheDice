'Rudy Earnest
'RCET 2265
'Spring 2025
'Roll of the Dice
'https://github.com/rc-earnest/RolloftheDice.git
Option Explicit On
Option Strict On
Option Compare Text
Module rollOfTheDice

    Sub Main()
        Dim beanCounter(12) As Integer

        For i = 1 To 1000000
            beanCounter(RandomNumberBetween(2, 12)) += 1
        Next

        Console.WriteLine(StrDup(120, "_"))

        For i = 2 To 12
            Console.Write($"{CStr(i).PadLeft(8)}|")
        Next

        Console.WriteLine()
        Console.WriteLine(StrDup(120, "_"))

        For i = 2 To 12
            Console.Write($"{CStr(beanCounter(i)).PadLeft(8)}|")
        Next

        Console.WriteLine()
        Console.WriteLine(StrDup(120, "_"))
    End Sub
    Function randomNumberBetween(min As Integer, max As Integer) As Integer
        Randomize()
        Dim randomNumber As Single
        randomNumber = Rnd()
        randomNumber *= max - min + 1
        randomNumber += min - 1
        Return CInt(Math.Ceiling(randomNumber))
    End Function
End Module
