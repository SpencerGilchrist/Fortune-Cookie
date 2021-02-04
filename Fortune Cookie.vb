Module Module1

    Sub Main()
LineFirst:
        System.Threading.Thread.Sleep(500)
        Console.Clear()
        Console.WriteLine("Press Q to get a fortune, or W to quit.")

        Select Case Console.ReadKey.Key

            Case ConsoleKey.Q
                System.Threading.Thread.Sleep(500)
                Console.Clear()

            Case ConsoleKey.W
                Console.Clear()
                Console.WriteLine("Have a nice Day!")
                System.Threading.Thread.Sleep(2000)
                GoTo LineLast

        End Select

        Console.Clear()
        Randomize()
        Dim value As Integer
        'This Picks a random number between 1 and 6
        value = CInt(Int((6 * Rnd() + 1)))

        If value = 1 Then
            Console.WriteLine("Wild Boars will appear in your yard tonight! Prepare, Fortify, and Defend")
            Console.ReadLine()

        ElseIf value = 2 Then
            Console.WriteLine("Watch out for the Blue Toyota Corola at the intersection of 5th and Ceder.")
            Console.Read()

        ElseIf value = 3 Then
            Console.WriteLine("Zuckerburg is watching...")
            Console.Read()

        ElseIf value = 4 Then
            Console.WriteLine("When you go to lunch tomorrow don't order chicken.")
            Console.Read()

        ElseIf value = 5 Then
            Console.WriteLine("Don't go to the bank on Oak Ave between 2:15 PM to 2:35 PM.")
            Console.Read()

        ElseIf value = 6 Then
            Console.WriteLine("Buy Stock!")
            Console.Read()

        End If


LineLast:

    End Sub

End Module
