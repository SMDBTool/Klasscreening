Public Class Persoon
    Public Property ID As Integer
    Public Property VoorNaam As String
    Public Property FamilieNaam As String
    Public Property GeboorteDatum As Date
    Public Property Actief As String
    Public Const AfgestudeerdNummer As Integer = 7
    Public Const grensLeerkrachten As Integer = 10000

    Public Overrides Function ToString() As String
        'Return MyBase.ToString()
        If ID < 10000 Then
            Return String.Format("{0}, {1} *", FamilieNaam, VoorNaam)
        Else
            Return String.Format("{0}, {1}", FamilieNaam, VoorNaam)
        End If
    End Function
    Public Function UpdateActiefWithAfgestudeerd() As OleDb.OleDbCommand
        Dim commando As New OleDb.OleDbCommand

        commando.Connection = GlobalVariables.conn
        If ID < grensLeerkrachten Then
            commando.CommandText = String.Format("UPDATE TBL_Leerkracht SET Actief = {0} WHERE ID = {1}", AfgestudeerdNummer, ID)
        Else
            commando.CommandText = String.Format("UPDATE TBL_Leerling SET Actief = {0} WHERE ID = {1}", AfgestudeerdNummer, ID)
        End If
        Return commando
    End Function
End Class
