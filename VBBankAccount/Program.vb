Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Welcome to United Banking Software!")
        Console.WriteLine()

        Dim rand As Random
        Dim clientList As List(Of Client)
        Dim checkingList As List(Of Checking)
        Dim savingsList As List(Of Savings)

        clientList.Add(ClientMaker())
        Dim checking As New Checking(clientList.First(), 1400)
        checkingList.Add(checking)
        'Without DIM on preceding line
        savingsList.Add(New Savings(clientList(0), 595, 100))

        Dim goAgain As Boolean
        goAgain = True

        Do While goAgain = True

        Loop

    End Sub

    Sub MenuPrinter()
        Console.WriteLine()
        Console.WriteLine("Please enter the number for your transaction type")
        Console.WriteLine("1. View Client Information")
        Console.WriteLine("2. View Account Balance")
        Console.WriteLine("3. Deposit Funds")
        Console.WriteLine("4. Withdraw Funds")
        Console.WriteLine("5. Exit")
        Console.WriteLine()
    End Sub

    Sub LowerMenuPrinter()
        Console.WriteLine("a. Checking Account")
        Console.WriteLine("b. Banking Account")
        Console.WriteLine()
    End Sub

    Function ClientMaker()
        Dim name As String
        Dim userName As String
        Dim acctNum As Int32

        Console.WriteLine("What is your name?")
        name = Console.ReadLine()

        Console.WriteLine("What is your unique user name?")
        userName = Console.ReadLine()

        Console.WriteLine("What is your account number?")
        acctNum = Integer.Parse(Console.ReadLine())

        Dim newClient As New Client
        With newClient
            .AcctName = name
            .UserName = userName
            .UserID = acctNum
        End With

        Return newClient
    End Function

End Module
