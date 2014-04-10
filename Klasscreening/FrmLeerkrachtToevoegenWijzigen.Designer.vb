<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLeerkrachtToevoegenWijzigen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboLeerkrachtActief = New System.Windows.Forms.ComboBox()
        Me.dtpLeerkrachtInschrijvingsdatum = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpLeerkrachtGeboortedatum = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLeerkrachtNaam = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLeerkrachtVoornaam = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLeerkrachtId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnToevoegen = New System.Windows.Forms.Button()
        Me.btnAnnuleren = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboLeerkrachtActief)
        Me.GroupBox1.Controls.Add(Me.dtpLeerkrachtInschrijvingsdatum)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dtpLeerkrachtGeboortedatum)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtLeerkrachtNaam)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtLeerkrachtVoornaam)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtLeerkrachtId)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(677, 117)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Algemeen"
        '
        'cboLeerkrachtActief
        '
        Me.cboLeerkrachtActief.FormattingEnabled = True
        Me.cboLeerkrachtActief.Location = New System.Drawing.Point(154, 77)
        Me.cboLeerkrachtActief.Name = "cboLeerkrachtActief"
        Me.cboLeerkrachtActief.Size = New System.Drawing.Size(181, 21)
        Me.cboLeerkrachtActief.TabIndex = 12
        '
        'dtpLeerkrachtInschrijvingsdatum
        '
        Me.dtpLeerkrachtInschrijvingsdatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpLeerkrachtInschrijvingsdatum.Location = New System.Drawing.Point(462, 47)
        Me.dtpLeerkrachtInschrijvingsdatum.Name = "dtpLeerkrachtInschrijvingsdatum"
        Me.dtpLeerkrachtInschrijvingsdatum.Size = New System.Drawing.Size(200, 20)
        Me.dtpLeerkrachtInschrijvingsdatum.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(373, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "IndienstTreding:"
        '
        'dtpLeerkrachtGeboortedatum
        '
        Me.dtpLeerkrachtGeboortedatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpLeerkrachtGeboortedatum.Location = New System.Drawing.Point(462, 19)
        Me.dtpLeerkrachtGeboortedatum.Name = "dtpLeerkrachtGeboortedatum"
        Me.dtpLeerkrachtGeboortedatum.Size = New System.Drawing.Size(200, 20)
        Me.dtpLeerkrachtGeboortedatum.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(373, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Geboortedatum:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(110, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Actief:"
        '
        'txtLeerkrachtNaam
        '
        Me.txtLeerkrachtNaam.Location = New System.Drawing.Point(154, 50)
        Me.txtLeerkrachtNaam.Name = "txtLeerkrachtNaam"
        Me.txtLeerkrachtNaam.Size = New System.Drawing.Size(181, 20)
        Me.txtLeerkrachtNaam.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(110, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Naam:"
        '
        'txtLeerkrachtVoornaam
        '
        Me.txtLeerkrachtVoornaam.Location = New System.Drawing.Point(154, 22)
        Me.txtLeerkrachtVoornaam.Name = "txtLeerkrachtVoornaam"
        Me.txtLeerkrachtVoornaam.Size = New System.Drawing.Size(181, 20)
        Me.txtLeerkrachtVoornaam.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Voornaam:"
        '
        'txtLeerkrachtId
        '
        Me.txtLeerkrachtId.Enabled = False
        Me.txtLeerkrachtId.Location = New System.Drawing.Point(30, 22)
        Me.txtLeerkrachtId.Name = "txtLeerkrachtId"
        Me.txtLeerkrachtId.Size = New System.Drawing.Size(44, 20)
        Me.txtLeerkrachtId.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID:"
        '
        'btnToevoegen
        '
        Me.btnToevoegen.Location = New System.Drawing.Point(388, 135)
        Me.btnToevoegen.Name = "btnToevoegen"
        Me.btnToevoegen.Size = New System.Drawing.Size(146, 31)
        Me.btnToevoegen.TabIndex = 16
        Me.btnToevoegen.Text = "Toevoegen"
        Me.btnToevoegen.UseVisualStyleBackColor = True
        '
        'btnAnnuleren
        '
        Me.btnAnnuleren.Location = New System.Drawing.Point(540, 135)
        Me.btnAnnuleren.Name = "btnAnnuleren"
        Me.btnAnnuleren.Size = New System.Drawing.Size(146, 31)
        Me.btnAnnuleren.TabIndex = 15
        Me.btnAnnuleren.Text = "Annuleren"
        Me.btnAnnuleren.UseVisualStyleBackColor = True
        '
        'FrmLeerkrachtToevoegenWijzigen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 176)
        Me.Controls.Add(Me.btnToevoegen)
        Me.Controls.Add(Me.btnAnnuleren)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmLeerkrachtToevoegenWijzigen"
        Me.Text = "FrmLeerkrachtToevoegenWijzigen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboLeerkrachtActief As System.Windows.Forms.ComboBox
    Friend WithEvents dtpLeerkrachtInschrijvingsdatum As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpLeerkrachtGeboortedatum As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLeerkrachtNaam As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLeerkrachtVoornaam As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLeerkrachtId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnToevoegen As System.Windows.Forms.Button
    Friend WithEvents btnAnnuleren As System.Windows.Forms.Button
End Class
