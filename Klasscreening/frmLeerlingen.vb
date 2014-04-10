Imports Klasscreeningsklassen
Imports System.Data.OleDb

Public Class FrmLeerlingen

    Inherits FrmLeerkrachtenLeerlingen

    Private leerlingLijst As List(Of Leerling)
    Private actiefLijst As List(Of Actief)
    Private WithEvents frmleerlingtoevoegen As frmLeerlingToevoegen
    Private WithEvents frmleerlingenwijzigen As frmLeerlingWijzigen

    Public Sub New(ByVal leerlingenlijst As List(Of Leerling), ByVal actieflijst As List(Of Actief))

        InitializeComponent()

        Me.Text = "Klasscreening: Leerlingen"
        lblFilter1.Text = "Voornaam:"
        lblFilter2.Text = "Naam:"
        lblFilter3.Text = "Status:"

        Me.leerlingLijst = leerlingenlijst
        Me.actiefLijst = actieflijst

        cmbStatus.Items.AddRange(actieflijst.ToArray)
        cmbStatus.Items.Add("*")
        cmbStatus.SelectedIndex = 0

    End Sub

    Protected Overrides Sub btnToevoegen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToevoegen.Click

        frmleerlingtoevoegen = New frmLeerlingToevoegen(actiefLijst)
        frmleerlingtoevoegen.ShowDialog()

    End Sub

    Protected Overrides Sub btnWijzigen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWijzigen.Click, dgvLeerkrachtenLeerlingen.CellDoubleClick

        If dgvLeerkrachtenLeerlingen.SelectedRows IsNot Nothing Then

            Dim lln As Leerling = dgvLeerkrachtenLeerlingen.SelectedRows(0).DataBoundItem()

            frmleerlingenwijzigen = New frmLeerlingWijzigen(lln, actiefLijst)
            frmleerlingenwijzigen.ShowDialog()
        End If

    End Sub

    Public Sub ToevoegenLeerling(ByVal leerling As Leerling) Handles frmleerlingtoevoegen.leerlingToegevoegd
        leerlingLijst.Add(leerling)
        UpdateLeerlingenTabel()
    End Sub

   Protected Overrides Function VoorNaamFilter(ByVal persoon As Persoon) As Boolean

        Return MyBase.VoorNaamFilter(persoon)

    End Function

    Protected Overrides Function NaamFilter(ByVal persoon As Persoon) As Boolean

        Return MyBase.NaamFilter(persoon)

    End Function
    Protected Overrides Function StatusFilter(ByVal persoon As Persoon) As Boolean

        Return MyBase.StatusFilter(persoon)

    End Function

    Public Sub UpdateLeerlingenTabel() Handles MyBase.Load, frmleerlingenwijzigen.leerlingGewijzigd, cmbStatus.SelectedIndexChanged, txtFilter2.TextChanged, txtFilter1.TextChanged

        Dim gefilterdelijst = leerlingLijst.Where(Function(x) (VoorNaamFilter(x) AndAlso NaamFilter(x) AndAlso StatusFilter(x)))

        dgvLeerkrachtenLeerlingen.DataSource = gefilterdelijst.ToList

        With dgvLeerkrachtenLeerlingen
            .Columns("ID").DisplayIndex = 0
            .Columns("VoorNaam").DisplayIndex = 1
            .Columns("FamilieNaam").DisplayIndex = 2
            .Columns("GeboorteDatum").DisplayIndex = 3
            .Columns("InschrijvingsDatum").DisplayIndex = 4
            .Columns("OS_ASS").DisplayIndex = 5
            .Columns("OS_ADHD").DisplayIndex = 6
            .Columns("OS_GTS").DisplayIndex = 7
            .Columns("LS_Dyslexie").DisplayIndex = 8
            .Columns("LS_Dysorthografie").DisplayIndex = 9
            .Columns("LS_Dyscalculie").DisplayIndex = 10
            .Columns("LS_Andere").DisplayIndex = 11
            .Columns("Leervoorsprong").DisplayIndex = 12
            .Columns("Pestdader").DisplayIndex = 13
            .Columns("Pestslachtoffer").DisplayIndex = 14
            .Columns("Anderstalig").DisplayIndex = 15
            .Columns("Bisser").DisplayIndex = 16
            .Columns("Actief").DisplayIndex = 17
        End With

        dgvLeerkrachtenLeerlingen.Refresh()

    End Sub

    Protected Overrides Sub btnVerwijderen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerwijderen.Click
        If dgvLeerkrachtenLeerlingen.SelectedRows IsNot Nothing Then

            Dim result = MessageBox.Show("Ben je zeker dat je de leerling wenst te verwijderen? (inactief is mogelijk)", "Leerling staat op punt verwijderd te worden", _
                                 MessageBoxButtons.YesNo, _
                                 MessageBoxIcon.Question)


            If result = DialogResult.Yes Then
                Dim lln = leerlingLijst.Where(Function(x) (x.ID = dgvLeerkrachtenLeerlingen.SelectedCells(0).Value)).First

                Dim deleteFromTblCommand As New OleDbCommand("DELETE FROM TBL_Leerling WHERE ID =" & lln.ID.ToString, GlobalVariables.conn)

                Dim connection As Data.OleDb.OleDbConnection = Klasscreeningsklassen.GlobalVariables.conn
                connection.Open()
                deleteFromTblCommand.Connection = connection
                deleteFromTblCommand.ExecuteNonQuery()
                connection.Close()

                leerlingLijst.Remove(lln)
                UpdateLeerlingenTabel()

            End If
        End If
    End Sub
End Class