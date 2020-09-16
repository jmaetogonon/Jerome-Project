<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblItemP = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.grpOutput = New System.Windows.Forms.GroupBox()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblShipping = New System.Windows.Forms.Label()
        Me.lblShip = New System.Windows.Forms.Label()
        Me.lblSalesTax = New System.Windows.Forms.Label()
        Me.lblSales = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblSub = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpOutput.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblItemP
        '
        Me.lblItemP.AutoSize = True
        Me.lblItemP.Location = New System.Drawing.Point(85, 41)
        Me.lblItemP.Name = "lblItemP"
        Me.lblItemP.Size = New System.Drawing.Size(56, 13)
        Me.lblItemP.TabIndex = 0
        Me.lblItemP.Text = "Item price:"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(88, 57)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(55, 20)
        Me.txtPrice.TabIndex = 1
        '
        'grpOutput
        '
        Me.grpOutput.Controls.Add(Me.lblTotalDue)
        Me.grpOutput.Controls.Add(Me.lblTotal)
        Me.grpOutput.Controls.Add(Me.lblShipping)
        Me.grpOutput.Controls.Add(Me.lblShip)
        Me.grpOutput.Controls.Add(Me.lblSalesTax)
        Me.grpOutput.Controls.Add(Me.lblSales)
        Me.grpOutput.Controls.Add(Me.lblSubtotal)
        Me.grpOutput.Controls.Add(Me.lblSub)
        Me.grpOutput.Location = New System.Drawing.Point(34, 93)
        Me.grpOutput.Name = "grpOutput"
        Me.grpOutput.Size = New System.Drawing.Size(160, 152)
        Me.grpOutput.TabIndex = 12
        Me.grpOutput.TabStop = False
        '
        'lblTotalDue
        '
        Me.lblTotalDue.BackColor = System.Drawing.SystemColors.Info
        Me.lblTotalDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalDue.Location = New System.Drawing.Point(79, 108)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(63, 20)
        Me.lblTotalDue.TabIndex = 9
        Me.lblTotalDue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(18, 112)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(55, 13)
        Me.lblTotal.TabIndex = 8
        Me.lblTotal.Text = "Total due:"
        '
        'lblShipping
        '
        Me.lblShipping.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShipping.Location = New System.Drawing.Point(79, 79)
        Me.lblShipping.Name = "lblShipping"
        Me.lblShipping.Size = New System.Drawing.Size(63, 20)
        Me.lblShipping.TabIndex = 7
        Me.lblShipping.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblShip
        '
        Me.lblShip.AutoSize = True
        Me.lblShip.Location = New System.Drawing.Point(18, 83)
        Me.lblShip.Name = "lblShip"
        Me.lblShip.Size = New System.Drawing.Size(51, 13)
        Me.lblShip.TabIndex = 6
        Me.lblShip.Text = "Shipping:"
        '
        'lblSalesTax
        '
        Me.lblSalesTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSalesTax.Location = New System.Drawing.Point(79, 50)
        Me.lblSalesTax.Name = "lblSalesTax"
        Me.lblSalesTax.Size = New System.Drawing.Size(63, 20)
        Me.lblSalesTax.TabIndex = 5
        Me.lblSalesTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSales
        '
        Me.lblSales.AutoSize = True
        Me.lblSales.Location = New System.Drawing.Point(18, 54)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(53, 13)
        Me.lblSales.TabIndex = 4
        Me.lblSales.Text = "Sales tax:"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubtotal.Location = New System.Drawing.Point(79, 21)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(63, 20)
        Me.lblSubtotal.TabIndex = 3
        Me.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSub
        '
        Me.lblSub.AutoSize = True
        Me.lblSub.Location = New System.Drawing.Point(18, 25)
        Me.lblSub.Name = "lblSub"
        Me.lblSub.Size = New System.Drawing.Size(49, 13)
        Me.lblSub.TabIndex = 2
        Me.lblSub.Text = "Subtotal:"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(34, 263)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 10
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(119, 263)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(228, 323)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.grpOutput)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblItemP)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "   Jerome's"
        Me.grpOutput.ResumeLayout(False)
        Me.grpOutput.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblItemP As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents grpOutput As GroupBox
    Friend WithEvents lblTotalDue As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblShipping As Label
    Friend WithEvents lblShip As Label
    Friend WithEvents lblSalesTax As Label
    Friend WithEvents lblSales As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblSub As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
End Class
