Imports System.Data.OleDb
Imports Klasscreeningsklassen

Public Class FrmLeerkrachtenLeerlingen

    Protected Overridable Sub btnToevoegen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub btnAfsluiten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAfsluiten.Click

        Me.Close()

    End Sub

    Protected Overridable Sub btnWijzigen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Protected Overridable Sub btnVerwijderen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnWisFilters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWisFilters.Click

        txtFilter2.Clear()
        txtFilter1.Clear()

    End Sub

    Protected Overridable Function VoorNaamFilter(ByVal persoon As Persoon) As Boolean

        If persoon.VoorNaam Like "*" & txtFilter1.Text.Trim & "*" Then
            Return True
        End If

        Return False

    End Function
    Protected Overridable Function NaamFilter(ByVal persoon As Persoon) As Boolean

        If persoon.FamilieNaam Like "*" & txtFilter2.Text.Trim & "*" Then
            Return True
        End If

        Return False

    End Function
    Protected Overridable Function StatusFilter(ByVal persoon As Persoon) As Boolean

        If cmbStatus.Text = "*" Then
            Return True

        ElseIf cmbStatus.Text = persoon.Actief Then
            Return True
        Else
            Return False
        End If

        Return False

    End Function


End Class