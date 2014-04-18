Imports Klasscreeningsklassen
Imports System.Data.OleDb
Imports log4net
Imports log4net.Config
<Assembly: log4net.Config.XmlConfigurator(Watch:=True)> 

Public Class frmMain

    Public leerkrachtenLijst As New List(Of Leerkracht)
    Public leerlingenLijst As New List(Of Leerling)
    Public klassenLijst As New List(Of Klas)
    Public klasNaamLijst As New List(Of KlasNaam)
    Public klasLokalenLijst As New List(Of Lokaal)
    Public actiefLijst As New List(Of Actief)
    Public verhuisLijst As New List(Of Verhuis)

    Private Shared ReadOnly log As log4net.ILog = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

    Private Sub OphalenLijsten()

        GlobalVariables.conn.Open()
        actiefLijst = DBRoutines.LaadActief()
        klasNaamLijst = DBRoutines.LaadKlasNamen()
        klassenLijst = DBRoutines.LaadKlassen()
        leerkrachtenLijst = DBRoutines.LaadLeerkrachten()
        leerlingenLijst = DBRoutines.LaadLeerlingen(actiefLijst)
        klasLokalenLijst = DBRoutines.LaadLokalen()
        GlobalVariables.conn.Close()
    End Sub

    Private Sub tmiAfsluiten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmiAfsluiten.Click

        Me.Close()

    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Initialiseren van de opstart mogelijkheden, er moet eerst worden ingelogd om aan de verschillende opties te kunnen.
        ' Inloggen is nodig om in de logfiles een correcte naam te kunnen zetten.
        '---------------------------------------------------------------------------------------------------------------------

        OphalenLijsten()
        'For i As Integer = 1 To 100000


        '    log.Debug("Debug: Toepassing gestart.")
        '    log.Error("Error: Toepassing gestart.")
        '    log.Fatal("Fatal: Toepassing gestart.")
        '    log.Info("Info: Toepassing gestart.")
        '    log.Warn("Warn: Toepassing gestart.")
        'Next
    End Sub

    Private Sub tmiInloggen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmiInloggen.Click

        frmInloggen.ShowDialog()

    End Sub

    Public Sub EnableAlleMenuItems()
        Dim frmKlasscreening As New FrmKlasscreening()
        frmKlasscreening.MdiParent = Me
        frmKlasscreening.Show()
    End Sub

    Public Sub InitialiseerAlleMenuItems()

    End Sub

    Private Sub tmiLeerling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmiLeerling.Click

        ' frmleerlingen laden in de MDI parent (frmMain)
        Dim frmleerlingen As New frmLeerlingen(leerlingenLijst, actiefLijst)
        frmleerlingen.MdiParent = Me
        frmleerlingen.Show()

    End Sub


    Private Sub tmiSamenstellenKlassen_Click(sender As System.Object, e As System.EventArgs) Handles tmiSamenstellenKlassen.Click

        Dim test As New List(Of Persoon)

        test.AddRange(leerlingenLijst)
        test.AddRange(leerkrachtenLijst)

        Dim openstaandeLijst = From klas In klassenLijst
        Where klas.StopTijdStip Is Nothing
        Join leerling In test On klas.Deelnemer Equals leerling.ID
        Select New Verhuis(leerling, klasNaamLijst.Where(Function(x) x.ID = klas.Naam).FirstOrDefault, klas.ID)

        Dim frmKlassen As New FrmKlassen(openstaandeLijst.ToList, klasNaamLijst, leerlingenLijst, leerkrachtenLijst, klassenLijst)
        frmKlassen.MdiParent = Me
        frmKlassen.Show()
    End Sub

    Private Sub NieuwToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NieuwToolStripMenuItem.Click
        Dim frmKlasscreening As New FrmKlasscreening()
        frmKlasscreening.MdiParent = Me
        frmKlasscreening.Show()
    End Sub

    Private Sub LokaalToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LokaalToolStripMenuItem.Click

    End Sub
End Class