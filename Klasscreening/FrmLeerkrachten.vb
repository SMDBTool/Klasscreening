Imports Klasscreeningsklassen
Imports System.Data.OleDb

Public Class FrmLeerkrachten

    Inherits FrmLeerkrachtenLeerlingen

    Private Leerkrachtenlijst As List(Of Leerkracht)
    Private actiefLijst As List(Of Actief)
    Private WithEvents frmleerkrachttoevoegen As FrmLeerkrachtToevoegen
    'Private WithEvents frmleerkrachtwijzigen As frmLeerkrachtWijzigen

    Public Sub New(ByVal leerkrachtenlijst As List(Of Leerkracht), ByVal actieflijst As List(Of Actief))

        InitializeComponent()

        Me.Text = "Klasscreening: Leerkrachten"
        lblFilter1.Text = "Voornaam:"
        lblFilter2.Text = "Naam:"
        lblFilter3.Text = "Status:"

        Me.Leerkrachtenlijst = leerkrachtenlijst
        Me.actiefLijst = actieflijst

        cmbStatus.Items.AddRange(actieflijst.ToArray)
        cmbStatus.Items.Add("*")
        cmbStatus.SelectedIndex = 0

    End Sub

    Public Sub ToevoegenLeerkracht(ByVal leerkracht As Leerkracht) Handles frmleerkrachttoevoegen.leerkrachtToegevoegd
        Leerkrachtenlijst.Add(leerkracht)
        UpdateLeerkrachtenTabel()
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

    Protected Overrides Sub btnToevoegen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToevoegen.Click

        FrmLeerkrachtToevoegen = New FrmLeerkrachtToevoegen(actiefLijst)
        frmleerkrachttoevoegen.ShowDialog()

    End Sub

    Public Sub UpdateLeerkrachtenTabel() Handles MyBase.Load, cmbStatus.SelectedIndexChanged, txtFilter2.TextChanged, txtFilter1.TextChanged

        Dim gefilterdelijst = Leerkrachtenlijst.Where(Function(x) (VoorNaamFilter(x) AndAlso NaamFilter(x) AndAlso StatusFilter(x)))


        dgvLeerkrachtenLeerlingen.DataSource = gefilterdelijst.ToList

        With dgvLeerkrachtenLeerlingen
            .Columns("ID").DisplayIndex = 0
            .Columns("VoorNaam").DisplayIndex = 1
            .Columns("FamilieNaam").DisplayIndex = 2
            .Columns("GeboorteDatum").DisplayIndex = 3
            .Columns("IndienstTreding").DisplayIndex = 4
            .Columns("Actief").DisplayIndex = 5
        End With

        dgvLeerkrachtenLeerlingen.Refresh()

    End Sub

End Class