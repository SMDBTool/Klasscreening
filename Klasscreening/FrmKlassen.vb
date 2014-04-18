Imports Klasscreeningsklassen


Public Class FrmKlassen

    Private _verhuisLijst As List(Of Verhuis)
    Private _klasNaamLijst As List(Of KlasNaam)
    Private _klassenLijst As List(Of Klas)
    Private _leerlingenLijst As List(Of Leerling)
    Private _leerkrachtenLijst As List(Of Leerkracht)
    Private Shared ReadOnly log As log4net.ILog = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
    Private sb As System.Text.StringBuilder

    Public Sub New(verhuislijst As List(Of Verhuis), klasNaamLijst As List(Of KlasNaam), ByRef leerlingenlijst As List(Of Leerling), ByRef leerkrachtenlijst As List(Of Leerkracht), ByRef klaslijst As List(Of Klas))
        InitializeComponent()
        sb = New System.Text.StringBuilder

        Me._verhuisLijst = verhuislijst
        Me._klasNaamLijst = klasNaamLijst
        Me._leerlingenLijst = leerlingenlijst
        Me._leerkrachtenLijst = leerkrachtenlijst
        Me._klassenLijst = klaslijst

        cboVan.Items.AddRange(klasNaamLijst.ToArray)
        cboNaar.Items.AddRange(klasNaamLijst.ToArray)


        '2 nieuwe klasnamen, nieuwe leerling en afgestudeerd.. bij beide anders handelen
        'afgestudeerd = gn nieuwe record + status leerling aanpassen
        'nieuwe leerling = gn record update enkel nieuwe record
        '2 nieuwe klasnamen, nieuwe leerling en afgestudeerd.. bij beide anders handelen
        'afgestudeerd = gn nieuwe record + status leerling aanpassen
        'nieuwe leerling = gn record update enkel nieuwe record

        cboVan.SelectedIndex = 1
        cboNaar.SelectedIndex = 1
    End Sub

    Public Sub updateVanLijst() Handles cboVan.SelectedIndexChanged
        lstVan.Items.Clear()

        Dim van = From verhuisElement In _verhuisLijst
                  Where verhuisElement.NaarKlas.ID = CType(cboVan.SelectedItem, KlasNaam).ID
                  Select verhuisElement

        lstVan.Items.AddRange(van.ToArray)
    End Sub
    Public Sub updateNaarLijst() Handles cboNaar.SelectedIndexChanged
        lstNaar.Items.Clear()

        Dim naar = From verhuisElement In _verhuisLijst
                  Where verhuisElement.NaarKlas.ID = CType(cboNaar.SelectedItem, KlasNaam).ID
                  Select verhuisElement

        lstNaar.Items.AddRange(naar.ToArray)
    End Sub

    Private Sub btnEnkeleVanNaar_Click(sender As System.Object, e As System.EventArgs) Handles btnEnkeleVanNaar.Click

        Dim verhuisLijst As New List(Of Verhuis)

        For Each item In lstVan.SelectedItems
            verhuisLijst.Add(CType(item, Verhuis))
        Next

        For Each verhuisElement In verhuisLijst
            verhuisElement.NaarKlas = CType(cboNaar.SelectedItem, KlasNaam)
        Next verhuisElement

        updateAlleLijsten()

    End Sub

    Private Sub btnEnkeleNaarVan_Click(sender As System.Object, e As System.EventArgs) Handles btnEnkeleNaarVan.Click
        Dim verhuisLijst As New List(Of Verhuis)

        For Each item In lstNaar.SelectedItems
            verhuisLijst.Add(CType(item, Verhuis))
        Next

        For Each verhuisElement In verhuisLijst
            verhuisElement.NaarKlas = CType(cboVan.SelectedItem, KlasNaam)
        Next verhuisElement

        updateAlleLijsten()
    End Sub

    Private Sub btnAlleVanNaar_Click(sender As System.Object, e As System.EventArgs) Handles btnAlleVanNaar.Click
        Dim verhuisLijst As New List(Of Verhuis)

        For Each item In lstVan.Items
            verhuisLijst.Add(CType(item, Verhuis))
        Next

        For Each verhuisElement In verhuisLijst
            verhuisElement.NaarKlas = CType(cboNaar.SelectedItem, KlasNaam)
        Next verhuisElement

        updateAlleLijsten()
    End Sub

    Private Sub btnAlleNaarVan_Click(sender As System.Object, e As System.EventArgs) Handles btnAlleNaarVan.Click
        Dim verhuisLijst As New List(Of Verhuis)

        For Each item In lstNaar.Items
            verhuisLijst.Add(CType(item, Verhuis))
        Next

        For Each verhuisElement In verhuisLijst
            verhuisElement.NaarKlas = CType(cboVan.SelectedItem, KlasNaam)
        Next verhuisElement

        updateAlleLijsten()
    End Sub
    Private Sub updateAlleLijsten()
        updateNaarLijst()
        updateVanLijst()
        updateGewijzigdeLijst()
    End Sub
    Private Sub updateGewijzigdeLijst()

        lstGewijzigde.Items.Clear()

        Dim gewijzigde = From verhuisde In _verhuisLijst
                         Where verhuisde.NaarKlas.ID <> verhuisde.VanKlas.ID
                         Select verhuisde.ToStringGewijzigd(_klasNaamLijst)

        lstGewijzigde.Items.AddRange(gewijzigde.ToArray)
    End Sub

    Private Sub btnBewaar_Click(sender As System.Object, e As System.EventArgs) Handles btnBewaar.Click

        Dim gewijzigde = From verhuisde In _verhuisLijst
                         Where verhuisde.NaarKlas.ID <> verhuisde.VanKlas.ID AndAlso verhuisde.NaarKlas.Naam <> "Afgestudeerd"
                         Select verhuisde
        Dim afgestudeerde = From verhuisde In _verhuisLijst
                         Where verhuisde.NaarKlas.ID <> verhuisde.VanKlas.ID AndAlso verhuisde.NaarKlas.Naam = "Afgestudeerd"
                         Select verhuisde
        Dim instromers = From verhuisde In _verhuisLijst
                         Where verhuisde.NaarKlas.ID <> verhuisde.VanKlas.ID AndAlso verhuisde.VanKlas.Naam = "NieuweLeerling"
                         Select verhuisde

        Dim tijdstip As Date = dtpUitvoerdatum.Value

        GlobalVariables.conn.Open()

        For Each verhuisde In gewijzigde
            verhuisVanKlasNaarKlas(verhuisde, tijdstip)
        Next

        For Each afgestudeerdeLeerling In afgestudeerde
            Afstuderen(afgestudeerdeLeerling, tijdstip)
        Next

        For Each nieuweNaarKlas In instromers
            instromen(nieuweNaarKlas, tijdstip)
        Next

        GlobalVariables.conn.Close()

        updateAlleLijsten()

    End Sub
    Private Sub verhuisVanKlasNaarKlas(ByRef verhuisde As Verhuis, tijdstip As Date)
        Dim update, insert, hoogste As OleDb.OleDbCommand
        Dim hoogsteIndex, indexKlassenLijst, indexVanVorigeKlas As Integer

        'Updaten van Klassenlijst + verwijderen ahv de index
        indexVanVorigeKlas = verhuisde.VorigeKlasID

        Dim elementUitKlassenLijst = From x In _klassenLijst
                                     Where x.ID = indexVanVorigeKlas
                                     Distinct


        indexKlassenLijst = _klassenLijst.IndexOf(elementUitKlassenLijst.First)

        'Aanmaken en uitvoeren van SQL opdrachten
        update = Verhuis.UpdateVerhuis(verhuisde, tijdstip)
        insert = Verhuis.InsertVerhuis(verhuisde, tijdstip)
        hoogste = Verhuis.HoogsteID

        update.ExecuteNonQuery()
        insert.ExecuteNonQuery()

        'Uitlezen van nieuwe ingevoegd element in de TBL_Klas om hetzelfde element in de List(of Klas) toe te voegen
        Dim reader As OleDb.OleDbDataReader = hoogste.ExecuteReader()

        While reader.Read()
            hoogsteIndex = reader(0)
        End While

        With verhuisde
            'Updaten van oud klaselement in de lijst met stoptijdstip en dit element verwijderen
            _klassenLijst(indexKlassenLijst).StopTijdStip = tijdstip
            _klassenLijst.RemoveAt(indexKlassenLijst)
            'Nieuw element toevoegen aan de List(Of Klas).. met juiste index
            _klassenLijst.Add(New Klas(hoogsteIndex, .NaarKlas.ID, .persoon.ID, tijdstip, Nothing, Verhuis.KiesJaarVolgensDatum(tijdstip)))
        End With

        'Persoon blijft in school --> element blijft bestaan, maar verhuis vind nu plaats
        verhuisde.VanKlas = verhuisde.NaarKlas
        verhuisde.VorigeKlasID = hoogsteIndex

        'Loggen van SQL commandos
        sb.Append("verhuisVanKlasNaarKlas" + vbCrLf + vbTab)
        sb.Append(update.CommandText + vbCrLf + vbTab)
        sb.Append(insert.CommandText + vbCrLf + vbTab)
        sb.Append(hoogste.CommandText + "-----------------> +" + hoogsteIndex.ToString)
        log.Info(sb)
        sb.Clear()


    End Sub
    Private Sub Afstuderen(ByRef verhuisde As Verhuis, tijdstip As Date)
        Dim updateKlas, updatePersoon As OleDb.OleDbCommand
        Dim verhuiselement As Verhuis = verhuisde
        Dim indexKlassenLijst, indexVanVorigeKlas As Integer

        verhuisde.VanKlas = verhuisde.NaarKlas
        indexVanVorigeKlas = verhuisde.VorigeKlasID

        Dim elementUitKlassenLijst = From x In _klassenLijst
                              Where x.ID = indexVanVorigeKlas
                              Distinct

        indexKlassenLijst = _klassenLijst.IndexOf(elementUitKlassenLijst.First)

        updateKlas = Verhuis.UpdateVerhuis(verhuisde, tijdstip)
        updatePersoon = verhuisde.persoon.UpdateActiefWithAfgestudeerd
        verhuisde.persoon.Actief = "Afgestudeerd"

        updateKlas.ExecuteNonQuery()
        updatePersoon.ExecuteNonQuery()

        _klassenLijst(indexKlassenLijst).StopTijdStip = tijdstip
        _klassenLijst.RemoveAt(indexKlassenLijst)




        sb.Append("Afstuderen" + vbCrLf + vbTab)
        sb.Append(updateKlas.CommandText + vbCrLf + vbTab)
        sb.Append(updatePersoon.CommandText)
        log.Info(sb)
        sb.Clear()


    End Sub
    Private Sub instromen(ByRef verhuisde As Verhuis, tijdstip As Date)
        Dim insert, hoogste As OleDb.OleDbCommand
        Dim verhuiselement As Verhuis = verhuisde
        Dim hoogsteIndex, indexKlassenLijst, indexVanVorigeKlas As Integer

        verhuisde.VanKlas = verhuisde.NaarKlas
        indexVanVorigeKlas = verhuisde.VorigeKlasID
        Dim elementUitKlassenLijst = From x In _klassenLijst
                             Where x.ID = indexVanVorigeKlas
                             Distinct

        indexKlassenLijst = _klassenLijst.IndexOf(elementUitKlassenLijst.First)

        insert = Verhuis.InsertVerhuis(verhuisde, tijdstip)
        hoogste = Verhuis.HoogsteID

        insert.ExecuteNonQuery()

        Dim reader As OleDb.OleDbDataReader = hoogste.ExecuteReader()

        While reader.Read()
            hoogsteIndex = reader(0)
        End While

        With verhuisde
            _klassenLijst.Add(New Klas(hoogsteIndex, .NaarKlas.ID, .persoon.ID, tijdstip, Nothing, Verhuis.KiesJaarVolgensDatum(tijdstip)))
        End With

        sb.Append("instromen:" + vbCrLf + vbTab)
        sb.Append(insert.CommandText + vbCrLf + vbTab)
        sb.Append(hoogste.CommandText + vbTab * 2 + "----> +" + vbTab * 2 + hoogsteIndex)
        log.Info(sb)
        sb.Clear()

    End Sub
End Class