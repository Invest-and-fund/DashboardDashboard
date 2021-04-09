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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.bFinance = New System.Windows.Forms.Button()
        Me.bOMA = New System.Windows.Forms.Button()
        Me.bOfflineLender = New System.Windows.Forms.Button()
        Me.bOperations = New System.Windows.Forms.Button()
        Me.bSupport = New System.Windows.Forms.Button()
        Me.bMandates = New System.Windows.Forms.Button()
        Me.lEnvironment = New System.Windows.Forms.Label()
        Me.bMailchimp = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bLoanLenders = New System.Windows.Forms.Button()
        Me.bHoldings = New System.Windows.Forms.Button()
        Me.bMIData = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.lEnvironment.ForeColor = System.Drawing.Color.White
        Me.lEnvironment.Location = New System.Drawing.Point(56, 55)
        Me.lEnvironment.Name = "lEnvironment"
        Me.lEnvironment.Size = New System.Drawing.Size(137, 20)
        Me.lEnvironment.TabIndex = 6
        Me.lEnvironment.Text = "...environment..."
        Me.lEnvironment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bMailchimp
        '
        Me.bMailchimp.Location = New System.Drawing.Point(26, 435)
        Me.bMailchimp.Name = "bMailchimp"
        Me.bMailchimp.Size = New System.Drawing.Size(152, 52)
        Me.bMailchimp.TabIndex = 7
        Me.bMailchimp.Text = "Mailchimp Curator"
        Me.bMailchimp.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(12, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(219, 50)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lEnvironment)
        Me.Panel1.Location = New System.Drawing.Point(377, -29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(251, 739)
        Me.Panel1.TabIndex = 9
        '
        'bLoanLenders
        '
        Me.bLoanLenders.Location = New System.Drawing.Point(26, 493)
        Me.bLoanLenders.Name = "bLoanLenders"
        Me.bLoanLenders.Size = New System.Drawing.Size(152, 52)
        Me.bLoanLenders.TabIndex = 10
        Me.bLoanLenders.Text = "Loan Lenders"
        Me.bLoanLenders.UseVisualStyleBackColor = True
        '
        'bHoldings
        '
        Me.bHoldings.Location = New System.Drawing.Point(26, 551)
        Me.bHoldings.Name = "bHoldings"
        Me.bHoldings.Size = New System.Drawing.Size(152, 52)
        Me.bHoldings.TabIndex = 11
        Me.bHoldings.Text = "Current Loan Holdings"
        Me.bHoldings.UseVisualStyleBackColor = True
        '
        'bMIData
        '
        Me.bMIData.Location = New System.Drawing.Point(26, 609)
        Me.bMIData.Name = "bMIData"
        Me.bMIData.Size = New System.Drawing.Size(152, 52)
        Me.bMIData.TabIndex = 12
        Me.bMIData.Text = "MI Data"
        Me.bMIData.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(616, 697)
        Me.Controls.Add(Me.bMIData)
        Me.Controls.Add(Me.bHoldings)
        Me.Controls.Add(Me.bLoanLenders)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bMailchimp)
        Me.Controls.Add(Me.bMandates)
        Me.Controls.Add(Me.bSupport)
        Me.Controls.Add(Me.bOperations)
        Me.Controls.Add(Me.bOfflineLender)
        Me.Controls.Add(Me.bOMA)
        Me.Controls.Add(Me.bFinance)
        Me.Name = "Form1"
        Me.Text = "Invest and Fund Dashboard"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bFinance As Button
    Friend WithEvents bOMA As Button
    Friend WithEvents bOfflineLender As Button
    Friend WithEvents bOperations As Button
    Friend WithEvents bSupport As Button
    Friend WithEvents bMandates As Button
    Friend WithEvents lEnvironment As Label
    Friend WithEvents bMailchimp As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents bLoanLenders As Button
    Friend WithEvents bHoldings As Button
    Friend WithEvents bMIData As Button
End Class
