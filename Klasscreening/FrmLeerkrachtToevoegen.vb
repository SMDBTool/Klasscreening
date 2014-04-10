Imports Klasscreeningsklassen

Public Class FrmLeerkrachtToevoegen

    Inherits FrmLeerkrachtToevoegenWijzigen

    Private _actiefLijst As List(Of Actief)
    Private _leerkrachtenLijst As List(Of Leerling)

    Public Delegate Sub ToevoegenLeerkracht(ByVal leerkracht As Leerkracht)
    Public Event leerkrachtToegevoegd As ToevoegenLeerkracht

    Public Sub New(ByVal actieflijst As List(Of Actief))

        InitializeComponent()
        Me._actiefLijst = actieflijst

        cboLeerkrachtActief.Items.AddRange(actieflijst.ToArray)
        Me.Text = "Toevoegen van een nieuwe Leerkracht"

    End Sub

    Public Overrides Sub btnToevoegen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        If txtLeerkrachtNaam.Text = "" OrElse txtLeerkrachtVoornaam.Text = "" Then Exit Sub

        ' De 0 die voor ID staat in deze constructor is een tijdelijke waarde
        ' de definitieve waarde wordt (na wegschrijven), teruggelezen uit de database
        Dim leerkracht As New Leerkracht(0, _
                                     txtLeerkrachtVoornaam.Text, _
                                     txtLeerkrachtNaam.Text, _
        dtpLeerkrachtGeboortedatum.Value.Date, _
        dtpLeerkrachtInschrijvingsdatum.Value.Date, _
                cboLeerkrachtActief.Text)


        Dim zoektermen As String = String.Format("WHERE Voornaam LIKE '{0}' and Familienaam like '{1}'", leerkracht.VoorNaam, leerkracht.FamilieNaam)

        Dim connection As Data.OleDb.OleDbConnection = Klasscreeningsklassen.GlobalVariables.conn
        connection.Open()
        Dim updateCommand As Data.OleDb.OleDbCommand = Klasscreeningsklassen.Leerkracht.insertOLEDB(leerkracht, _actiefLijst)
        updateCommand.Connection = connection
        updateCommand.ExecuteNonQuery()


        RaiseEvent leerkrachtToegevoegd(DBRoutines.LaadLeerkracht(_actiefLijst, zoektermen))

        connection.Close()

        Me.Close()

    End Sub


End Class