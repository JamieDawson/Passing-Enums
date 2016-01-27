<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.comboSports = New System.Windows.Forms.ComboBox()
        Me.btnAnalyze = New System.Windows.Forms.Button()
        Me.listEnumValues = New System.Windows.Forms.ListBox()
        Me.listEnumNames = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'comboSports
        '
        Me.comboSports.FormattingEnabled = True
        Me.comboSports.Items.AddRange(New Object() {"baseball", "basketball", "football"})
        Me.comboSports.Location = New System.Drawing.Point(12, 21)
        Me.comboSports.Name = "comboSports"
        Me.comboSports.Size = New System.Drawing.Size(291, 21)
        Me.comboSports.TabIndex = 0
        '
        'btnAnalyze
        '
        Me.btnAnalyze.Location = New System.Drawing.Point(84, 48)
        Me.btnAnalyze.Name = "btnAnalyze"
        Me.btnAnalyze.Size = New System.Drawing.Size(142, 26)
        Me.btnAnalyze.TabIndex = 1
        Me.btnAnalyze.Text = "Analyze Sport"
        Me.btnAnalyze.UseVisualStyleBackColor = True
        '
        'listEnumValues
        '
        Me.listEnumValues.FormattingEnabled = True
        Me.listEnumValues.Location = New System.Drawing.Point(12, 94)
        Me.listEnumValues.Name = "listEnumValues"
        Me.listEnumValues.Size = New System.Drawing.Size(120, 95)
        Me.listEnumValues.TabIndex = 2
        '
        'listEnumNames
        '
        Me.listEnumNames.FormattingEnabled = True
        Me.listEnumNames.Location = New System.Drawing.Point(151, 94)
        Me.listEnumNames.Name = "listEnumNames"
        Me.listEnumNames.Size = New System.Drawing.Size(120, 95)
        Me.listEnumNames.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 223)
        Me.Controls.Add(Me.listEnumNames)
        Me.Controls.Add(Me.listEnumValues)
        Me.Controls.Add(Me.btnAnalyze)
        Me.Controls.Add(Me.comboSports)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents comboSports As ComboBox
    Friend WithEvents btnAnalyze As Button
    Friend WithEvents listEnumValues As ListBox
    Friend WithEvents listEnumNames As ListBox
End Class
