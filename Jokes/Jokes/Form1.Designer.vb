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
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.btnPunchLine = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblSetUp = New System.Windows.Forms.Label()
        Me.lblPunchLine = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(12, 147)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(75, 23)
        Me.btnSetup.TabIndex = 0
        Me.btnSetup.Text = "Setup"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'btnPunchLine
        '
        Me.btnPunchLine.Location = New System.Drawing.Point(12, 187)
        Me.btnPunchLine.Name = "btnPunchLine"
        Me.btnPunchLine.Size = New System.Drawing.Size(75, 23)
        Me.btnPunchLine.TabIndex = 1
        Me.btnPunchLine.Text = "PunchLine"
        Me.btnPunchLine.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(12, 227)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblSetUp
        '
        Me.lblSetUp.AutoSize = True
        Me.lblSetUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSetUp.Location = New System.Drawing.Point(12, 18)
        Me.lblSetUp.Name = "lblSetUp"
        Me.lblSetUp.Size = New System.Drawing.Size(60, 20)
        Me.lblSetUp.TabIndex = 3
        Me.lblSetUp.Text = "SetUp"
        Me.lblSetUp.Visible = False
        '
        'lblPunchLine
        '
        Me.lblPunchLine.AutoSize = True
        Me.lblPunchLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPunchLine.Location = New System.Drawing.Point(12, 74)
        Me.lblPunchLine.Name = "lblPunchLine"
        Me.lblPunchLine.Size = New System.Drawing.Size(87, 20)
        Me.lblPunchLine.TabIndex = 4
        Me.lblPunchLine.Text = "Punchline"
        Me.lblPunchLine.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 262)
        Me.Controls.Add(Me.lblPunchLine)
        Me.Controls.Add(Me.lblSetUp)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPunchLine)
        Me.Controls.Add(Me.btnSetup)
        Me.Name = "Form1"
        Me.Text = "0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSetup As System.Windows.Forms.Button
    Friend WithEvents btnPunchLine As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblSetUp As System.Windows.Forms.Label
    Friend WithEvents lblPunchLine As System.Windows.Forms.Label

End Class
