<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLeerkrachtenLeerlingen
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
        Me.components = New System.ComponentModel.Container()
        Me.dgvLeerkrachtenLeerlingen = New System.Windows.Forms.DataGridView()
        Me.btnToevoegen = New System.Windows.Forms.Button()
        Me.btnWijzigen = New System.Windows.Forms.Button()
        Me.btnVerwijderen = New System.Windows.Forms.Button()
        Me.btnAfsluiten = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.lblFilter1 = New System.Windows.Forms.Label()
        Me.txtFilter1 = New System.Windows.Forms.TextBox()
        Me.lblFilter2 = New System.Windows.Forms.Label()
        Me.txtFilter2 = New System.Windows.Forms.TextBox()
        Me.lblFilter3 = New System.Windows.Forms.Label()
        Me.btnWisFilters = New System.Windows.Forms.Button()
        CType(Me.dgvLeerkrachtenLeerlingen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLeerkrachtenLeerlingen
        '
        Me.dgvLeerkrachtenLeerlingen.AllowUserToAddRows = False
        Me.dgvLeerkrachtenLeerlingen.AllowUserToDeleteRows = False
        Me.dgvLeerkrachtenLeerlingen.AllowUserToOrderColumns = True
        Me.dgvLeerkrachtenLeerlingen.AllowUserToResizeColumns = False
        Me.dgvLeerkrachtenLeerlingen.AllowUserToResizeRows = False
        Me.dgvLeerkrachtenLeerlingen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvLeerkrachtenLeerlingen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLeerkrachtenLeerlingen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLeerkrachtenLeerlingen.Location = New System.Drawing.Point(12, 32)
        Me.dgvLeerkrachtenLeerlingen.MultiSelect = False
        Me.dgvLeerkrachtenLeerlingen.Name = "dgvLeerkrachtenLeerlingen"
        Me.dgvLeerkrachtenLeerlingen.ReadOnly = True
        Me.dgvLeerkrachtenLeerlingen.RowHeadersVisible = False
        Me.dgvLeerkrachtenLeerlingen.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvLeerkrachtenLeerlingen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLeerkrachtenLeerlingen.Size = New System.Drawing.Size(1139, 513)
        Me.dgvLeerkrachtenLeerlingen.TabIndex = 0
        '
        'btnToevoegen
        '
        Me.btnToevoegen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnToevoegen.Location = New System.Drawing.Point(12, 551)
        Me.btnToevoegen.Name = "btnToevoegen"
        Me.btnToevoegen.Size = New System.Drawing.Size(154, 38)
        Me.btnToevoegen.TabIndex = 5
        Me.btnToevoegen.Text = "Toevoegen"
        Me.btnToevoegen.UseVisualStyleBackColor = True
        '
        'btnWijzigen
        '
        Me.btnWijzigen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnWijzigen.Location = New System.Drawing.Point(172, 551)
        Me.btnWijzigen.Name = "btnWijzigen"
        Me.btnWijzigen.Size = New System.Drawing.Size(154, 38)
        Me.btnWijzigen.TabIndex = 6
        Me.btnWijzigen.Text = "Wijzigen"
        Me.btnWijzigen.UseVisualStyleBackColor = True
        '
        'btnVerwijderen
        '
        Me.btnVerwijderen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVerwijderen.Location = New System.Drawing.Point(332, 551)
        Me.btnVerwijderen.Name = "btnVerwijderen"
        Me.btnVerwijderen.Size = New System.Drawing.Size(154, 38)
        Me.btnVerwijderen.TabIndex = 7
        Me.btnVerwijderen.Text = "Verwijderen"
        Me.btnVerwijderen.UseVisualStyleBackColor = True
        '
        'btnAfsluiten
        '
        Me.btnAfsluiten.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAfsluiten.Location = New System.Drawing.Point(997, 551)
        Me.btnAfsluiten.Name = "btnAfsluiten"
        Me.btnAfsluiten.Size = New System.Drawing.Size(154, 38)
        Me.btnAfsluiten.TabIndex = 8
        Me.btnAfsluiten.Text = "Afsluiten"
        Me.btnAfsluiten.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(693, 5)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(217, 21)
        Me.cmbStatus.TabIndex = 9
        '
        'lblFilter1
        '
        Me.lblFilter1.AutoSize = True
        Me.lblFilter1.Location = New System.Drawing.Point(9, 9)
        Me.lblFilter1.Name = "lblFilter1"
        Me.lblFilter1.Size = New System.Drawing.Size(48, 13)
        Me.lblFilter1.TabIndex = 10
        Me.lblFilter1.Text = "lblFilter1:"
        '
        'txtFilter1
        '
        Me.txtFilter1.Location = New System.Drawing.Point(73, 6)
        Me.txtFilter1.Name = "txtFilter1"
        Me.txtFilter1.Size = New System.Drawing.Size(223, 20)
        Me.txtFilter1.TabIndex = 11
        '
        'lblFilter2
        '
        Me.lblFilter2.AutoSize = True
        Me.lblFilter2.Location = New System.Drawing.Point(302, 9)
        Me.lblFilter2.Name = "lblFilter2"
        Me.lblFilter2.Size = New System.Drawing.Size(48, 13)
        Me.lblFilter2.TabIndex = 12
        Me.lblFilter2.Text = "lblFilter2:"
        '
        'txtFilter2
        '
        Me.txtFilter2.Location = New System.Drawing.Point(346, 6)
        Me.txtFilter2.Name = "txtFilter2"
        Me.txtFilter2.Size = New System.Drawing.Size(259, 20)
        Me.txtFilter2.TabIndex = 13
        '
        'lblFilter3
        '
        Me.lblFilter3.AutoSize = True
        Me.lblFilter3.Location = New System.Drawing.Point(639, 9)
        Me.lblFilter3.Name = "lblFilter3"
        Me.lblFilter3.Size = New System.Drawing.Size(48, 13)
        Me.lblFilter3.TabIndex = 12
        Me.lblFilter3.Text = "lblFilter3:"
        '
        'btnWisFilters
        '
        Me.btnWisFilters.Location = New System.Drawing.Point(611, 6)
        Me.btnWisFilters.Name = "btnWisFilters"
        Me.btnWisFilters.Size = New System.Drawing.Size(23, 20)
        Me.btnWisFilters.TabIndex = 14
        Me.btnWisFilters.Text = "X"
        Me.btnWisFilters.UseVisualStyleBackColor = True
        '
        'FrmLeerkrachtenLeerlingen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1163, 601)
        Me.Controls.Add(Me.btnWisFilters)
        Me.Controls.Add(Me.txtFilter2)
        Me.Controls.Add(Me.lblFilter3)
        Me.Controls.Add(Me.lblFilter2)
        Me.Controls.Add(Me.txtFilter1)
        Me.Controls.Add(Me.lblFilter1)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.btnAfsluiten)
        Me.Controls.Add(Me.btnVerwijderen)
        Me.Controls.Add(Me.btnWijzigen)
        Me.Controls.Add(Me.btnToevoegen)
        Me.Controls.Add(Me.dgvLeerkrachtenLeerlingen)
        Me.Name = "FrmLeerkrachtenLeerlingen"
        Me.Text = "Leerlingen"
        CType(Me.dgvLeerkrachtenLeerlingen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvLeerkrachtenLeerlingen As System.Windows.Forms.DataGridView
    Friend WithEvents btnToevoegen As System.Windows.Forms.Button
    Friend WithEvents btnWijzigen As System.Windows.Forms.Button
    Friend WithEvents btnVerwijderen As System.Windows.Forms.Button
    Friend WithEvents btnAfsluiten As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblFilter1 As System.Windows.Forms.Label
    Friend WithEvents txtFilter1 As System.Windows.Forms.TextBox
    Friend WithEvents lblFilter2 As System.Windows.Forms.Label
    Friend WithEvents txtFilter2 As System.Windows.Forms.TextBox
    Friend WithEvents lblFilter3 As System.Windows.Forms.Label
    Friend WithEvents btnWisFilters As System.Windows.Forms.Button
End Class
