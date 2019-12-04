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
        Me.bFinance = New System.Windows.Forms.Button()
        Me.bOMA = New System.Windows.Forms.Button()
        Me.bOfflineLender = New System.Windows.Forms.Button()
        Me.bOperations = New System.Windows.Forms.Button()
        Me.bSupport = New System.Windows.Forms.Button()
        Me.bMandates = New System.Windows.Forms.Button()
        Me.lEnvironment = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bFinance
        '
        Me.bFinance.Location = New System.Drawing.Point(26, 87)
        Me.bFinance.Name = "bFinance"
        Me.bFinance.Size = New System.Drawing.Size(152, 52)
        Me.bFinance.TabIndex = 0
        Me.bFinance.Text = "Finance Dashboard"
        Me.bFinance.UseVisualStyleBackColor = True
        '
        'bOMA
        '
        Me.bOMA.Location = New System.Drawing.Point(26, 145)
        Me.bOMA.Name = "bOMA"
        Me.bOMA.Size = New System.Drawing.Size(152, 52)
        Me.bOMA.TabIndex = 1
        Me.bOMA.Text = "OMA"
        Me.bOMA.UseVisualStyleBackColor = True
        '
        'bOfflineLender
        '
        Me.bOfflineLender.Location = New System.Drawing.Point(26, 203)
        Me.bOfflineLender.Name = "bOfflineLender"
        Me.bOfflineLender.Size = New System.Drawing.Size(152, 52)
        Me.bOfflineLender.TabIndex = 2
        Me.bOfflineLender.Text = "Offline Lender"
        Me.bOfflineLender.UseVisualStyleBackColor = True
        '
        'bOperations
        '
        Me.bOperations.Location = New System.Drawing.Point(26, 261)
        Me.bOperations.Name = "bOperations"
        Me.bOperations.Size = New System.Drawing.Size(152, 52)
        Me.bOperations.TabIndex = 3
        Me.bOperations.Text = "Operations Dashboard"
        Me.bOperations.UseVisualStyleBackColor = True
        '
        'bSupport
        '
        Me.bSupport.Location = New System.Drawing.Point(26, 319)
        Me.bSupport.Name = "bSupport"
        Me.bSupport.Size = New System.Drawing.Size(152, 52)
        Me.bSupport.TabIndex = 4
        Me.bSupport.Text = "Support Dashboard"
        Me.bSupport.UseVisualStyleBackColor = True
        '
        'bMandates
        '
        Me.bMandates.Location = New System.Drawing.Point(26, 377)
        Me.bMandates.Name = "bMandates"
        Me.bMandates.Size = New System.Drawing.Size(152, 52)
        Me.bMandates.TabIndex = 5
        Me.bMandates.Text = "Mandates"
        Me.bMandates.UseVisualStyleBackColor = True
        '
        'lEnvironment
        '
        Me.lEnvironment.AutoSize = True
        Me.lEnvironment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lEnvironment.Location = New System.Drawing.Point(32, 37)
        Me.lEnvironment.Name = "lEnvironment"
        Me.lEnvironment.Size = New System.Drawing.Size(137, 20)
        Me.lEnvironment.TabIndex = 6
        Me.lEnvironment.Text = "...environment..."
        Me.lEnvironment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 498)
        Me.Controls.Add(Me.lEnvironment)
        Me.Controls.Add(Me.bMandates)
        Me.Controls.Add(Me.bSupport)
        Me.Controls.Add(Me.bOperations)
        Me.Controls.Add(Me.bOfflineLender)
        Me.Controls.Add(Me.bOMA)
        Me.Controls.Add(Me.bFinance)
        Me.Name = "Form1"
        Me.Text = "Invest and Fund Dashboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bFinance As Button
    Friend WithEvents bOMA As Button
    Friend WithEvents bOfflineLender As Button
    Friend WithEvents bOperations As Button
    Friend WithEvents bSupport As Button
    Friend WithEvents bMandates As Button
    Friend WithEvents lEnvironment As Label
End Class
