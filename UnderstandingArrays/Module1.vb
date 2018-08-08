Module Module1

    Sub Main()

        'Dim numbers(0 To 4) As Integer
        'Dim numbers(4) As Integer

        'numbers(0) = 4
        'numbers(1) = 8
        'numbers(2) = 16
        'numbers(3) = 32
        'numbers(4) = 64

        'Console.WriteLine(numbers.Length)
        'Console.ReadLine()

        Dim numbers() As Integer = {4, 8, 16, 32, 64}

        For index = 0 To numbers.Length - 1
            Console.WriteLine(numbers(index))
        Next

        Dim names() As String = {"Eddie", "Alex", "Michael", "David"}
        For Each name As String In names
            Console.WriteLine(name)
        Next

        Dim myText As String = "You can get want you want out of life " &
            "if you help enough other people get what they want"

        Dim charArray() As Char = myText.ToCharArray()

        Array.Reverse(charArray)
        For Each item As String In charArray
            Console.Write(item)
        Next

        Console.ReadLine()


    End Sub

End Module
