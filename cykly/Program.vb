Imports System

Module Program
    Sub Main(args As String())
        Dim cislo As Integer

        Do
            Console.Write("Zadej ��slo")
            cislo = Console.Readline
            Console.Writeline($"Zadan� ��slo je {cislo}")
        Loop
    End Sub
End Module
