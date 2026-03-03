Imports System

Module Program
    Structure Buch
        Public ISBN As String
        Public Titel As String
        Public Autor As String
        Public Status As String
    End Structure

    Structure Benutzer
        Public Id As String
        Public Name As String
    End Structure

    Dim bücher As New List(Of Buch)
    Dim benutzer As New List(Of Benutzer)

    Sub Main()

        Ladetestdaten()

        Dim auswahl As String = " "

        Do
            Console.WriteLine("===== Bibliothekssystem =====")
            Console.WriteLine("1 - Alle Bücher anzeigen")
            Console.WriteLine("2 - Alle Benutzer anzeigen")
            Console.WriteLine("3 - Neuer Benutzer")
            Console.WriteLine("4 - Buch ausleihen")
            Console.WriteLine("5 - Buch zurückgeben")
            Console.WriteLine("6 - Programm beenden")
            Console.Write("Auswahl: ")

            auswahl = Console.ReadLine()
            Console.WriteLine()

            Select Case auswahl
                Case "1"
                    AlleBücher()
                Case "2"
                    AlleBenutzer()
                Case "3"
                    NeuerBenutzer()
                Case "4"
                    BuchAusleihen()
                Case "5"
                    BuchZurückgeben()
                Case "6"
                    Console.WriteLine("Programm beendet")
                Case Else
                    Console.WriteLine("Ungültige Eingabe")
            End Select

            Console.WriteLine()

        Loop While auswahl <> "6"
    End Sub
End Module
