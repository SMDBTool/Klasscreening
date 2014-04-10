Public Class Leerkracht
    Inherits Persoon
    Public Property InDienstTreding As Date

    Public Sub New(ByVal id As Integer, ByVal voornaam As String, ByVal familienaam As String, ByVal geboortedatum As Date, ByVal indiensttreding As Date, ByVal actief As String)
        Me.ID = id
        Me.VoorNaam = voornaam
        Me.FamilieNaam = familienaam
        Me.GeboorteDatum = geboortedatum
        Me.InDienstTreding = indiensttreding
        Me.Actief = actief
    End Sub
    Public Shared Function updateOLEDB(ByRef leerkracht As Leerkracht) As OleDb.OleDbCommand

        Dim commandText As String = "UPDATE TBL_Leerling SET" & vbCrLf & _
                                    "Voornaam = @Voornaam," & vbCrLf & "Familienaam = @Familienaam," & vbCrLf & "Geboortedatum = @Geboortedatum," & vbCrLf & "InDienstTreding = @InDienstTreding," & vbCrLf & _
                                    "Actief= @Actief " & _
                                    "Where ID = @ID;"

        Dim command As New OleDb.OleDbCommand(commandText)

        With leerkracht
            command.Parameters.AddWithValue("@Voornaam", .VoorNaam)
            command.Parameters.AddWithValue("@Familienaam", .FamilieNaam)
            command.Parameters.AddWithValue("@Geboortedatum", .GeboorteDatum)
            command.Parameters.AddWithValue("@InDienstTreding", .InDienstTreding)
            command.Parameters.AddWithValue("@Actief", .Actief)

            command.Parameters.AddWithValue("@ID", .ID)
        End With
        Dim tekst As String = command.CommandText
        Return command

    End Function

    Public Shared Function insertOLEDB(ByRef leerkracht As Leerkracht, ByVal actiefLijst As List(Of Actief)) As OleDb.OleDbCommand
        Dim commandText As String

        commandText = "INSERT INTO TBL_Leerkracht " & _
        "(Voornaam,Familienaam,Geboortedatum,InDienstTreding, " & vbCrLf & _
        "Actief)" & vbCrLf & _
        " values " & vbCrLf & _
        "(@Voornaam,@Familienaam,@Geboortedatum,@InDienstTreding," & vbCrLf & _
        "@Actief)"

        Dim command As New OleDb.OleDbCommand(commandText)

        With leerkracht
            command.Parameters.AddWithValue("@Voornaam", .VoorNaam)
            command.Parameters.AddWithValue("@Familienaam", .FamilieNaam)
            command.Parameters.AddWithValue("@Geboortedatum", .GeboorteDatum)
            command.Parameters.AddWithValue("@InDienstTreding", .InDienstTreding)
            command.Parameters.AddWithValue("@Actief", .Actief)
        End With

        Return command
    End Function
End Class
