<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepreciation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDepreciation))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplay = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.picTruck = New System.Windows.Forms.PictureBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblSelectItem = New System.Windows.Forms.Label()
        Me.btnCalculateDepreciation = New System.Windows.Forms.Button()
        Me.grpDepreciationType = New System.Windows.Forms.GroupBox()
        Me.radDoubleDeclining = New System.Windows.Forms.RadioButton()
        Me.radStraightLine = New System.Windows.Forms.RadioButton()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.lblFoodTruck = New System.Windows.Forms.Label()
        Me.lblPresentValue = New System.Windows.Forms.Label()
        Me.lblYearDepreciation = New System.Windows.Forms.Label()
        Me.lblTotalDepreciation = New System.Windows.Forms.Label()
        Me.lstPresentValue = New System.Windows.Forms.ListBox()
        Me.lstYearDepreciation = New System.Windows.Forms.ListBox()
        Me.lstYear = New System.Windows.Forms.ListBox()
        Me.lstTotalDepreciation = New System.Windows.Forms.ListBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lstInventoryId = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picTruck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDepreciationType.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(684, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDisplay, Me.mnuClear, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuDisplay
        '
        Me.mnuDisplay.Name = "mnuDisplay"
        Me.mnuDisplay.Size = New System.Drawing.Size(180, 22)
        Me.mnuDisplay.Text = "&Display Inventory"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(180, 22)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(180, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'picTruck
        '
        Me.picTruck.BackgroundImage = CType(resources.GetObject("picTruck.BackgroundImage"), System.Drawing.Image)
        Me.picTruck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picTruck.Location = New System.Drawing.Point(2, 30)
        Me.picTruck.Name = "picTruck"
        Me.picTruck.Size = New System.Drawing.Size(193, 223)
        Me.picTruck.TabIndex = 1
        Me.picTruck.TabStop = False
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.ForeColor = System.Drawing.Color.Gray
        Me.lblYear.Location = New System.Drawing.Point(117, 302)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(60, 32)
        Me.lblYear.TabIndex = 9
        Me.lblYear.Text = "Present" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Year"
        Me.lblYear.Visible = False
        '
        'lblSelectItem
        '
        Me.lblSelectItem.AutoSize = True
        Me.lblSelectItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectItem.ForeColor = System.Drawing.Color.Gray
        Me.lblSelectItem.Location = New System.Drawing.Point(221, 80)
        Me.lblSelectItem.Name = "lblSelectItem"
        Me.lblSelectItem.Size = New System.Drawing.Size(155, 16)
        Me.lblSelectItem.TabIndex = 3
        Me.lblSelectItem.Text = "Select Inventory Item:"
        '
        'btnCalculateDepreciation
        '
        Me.btnCalculateDepreciation.BackColor = System.Drawing.Color.OrangeRed
        Me.btnCalculateDepreciation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateDepreciation.ForeColor = System.Drawing.Color.White
        Me.btnCalculateDepreciation.Location = New System.Drawing.Point(320, 202)
        Me.btnCalculateDepreciation.Name = "btnCalculateDepreciation"
        Me.btnCalculateDepreciation.Size = New System.Drawing.Size(196, 34)
        Me.btnCalculateDepreciation.TabIndex = 6
        Me.btnCalculateDepreciation.Text = "Calculate Depreciation"
        Me.btnCalculateDepreciation.UseVisualStyleBackColor = False
        '
        'grpDepreciationType
        '
        Me.grpDepreciationType.Controls.Add(Me.radDoubleDeclining)
        Me.grpDepreciationType.Controls.Add(Me.radStraightLine)
        Me.grpDepreciationType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDepreciationType.ForeColor = System.Drawing.Color.Gray
        Me.grpDepreciationType.Location = New System.Drawing.Point(420, 80)
        Me.grpDepreciationType.Name = "grpDepreciationType"
        Me.grpDepreciationType.Size = New System.Drawing.Size(223, 103)
        Me.grpDepreciationType.TabIndex = 4
        Me.grpDepreciationType.TabStop = False
        Me.grpDepreciationType.Text = "Select Depreciation Method:"
        '
        'radDoubleDeclining
        '
        Me.radDoubleDeclining.AutoSize = True
        Me.radDoubleDeclining.Location = New System.Drawing.Point(7, 48)
        Me.radDoubleDeclining.Name = "radDoubleDeclining"
        Me.radDoubleDeclining.Size = New System.Drawing.Size(206, 20)
        Me.radDoubleDeclining.TabIndex = 1
        Me.radDoubleDeclining.TabStop = True
        Me.radDoubleDeclining.Text = "Double-Declining Balance"
        Me.radDoubleDeclining.UseVisualStyleBackColor = True
        '
        'radStraightLine
        '
        Me.radStraightLine.AutoSize = True
        Me.radStraightLine.Location = New System.Drawing.Point(7, 21)
        Me.radStraightLine.Name = "radStraightLine"
        Me.radStraightLine.Size = New System.Drawing.Size(112, 20)
        Me.radStraightLine.TabIndex = 0
        Me.radStraightLine.TabStop = True
        Me.radStraightLine.Text = "Straight-Line"
        Me.radStraightLine.UseVisualStyleBackColor = True
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItem.ForeColor = System.Drawing.Color.Gray
        Me.lblItem.Location = New System.Drawing.Point(274, 254)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(277, 16)
        Me.lblItem.TabIndex = 7
        Me.lblItem.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblItem.Visible = False
        '
        'lblFoodTruck
        '
        Me.lblFoodTruck.AutoSize = True
        Me.lblFoodTruck.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblFoodTruck.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodTruck.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblFoodTruck.Location = New System.Drawing.Point(217, 30)
        Me.lblFoodTruck.Name = "lblFoodTruck"
        Me.lblFoodTruck.Size = New System.Drawing.Size(436, 39)
        Me.lblFoodTruck.TabIndex = 2
        Me.lblFoodTruck.Text = "Chef Shack Burger Food Truck"
        '
        'lblPresentValue
        '
        Me.lblPresentValue.AutoSize = True
        Me.lblPresentValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPresentValue.ForeColor = System.Drawing.Color.Gray
        Me.lblPresentValue.Location = New System.Drawing.Point(236, 302)
        Me.lblPresentValue.Name = "lblPresentValue"
        Me.lblPresentValue.Size = New System.Drawing.Size(60, 32)
        Me.lblPresentValue.TabIndex = 9
        Me.lblPresentValue.Text = "Present" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Value"
        Me.lblPresentValue.Visible = False
        '
        'lblYearDepreciation
        '
        Me.lblYearDepreciation.AutoSize = True
        Me.lblYearDepreciation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearDepreciation.ForeColor = System.Drawing.Color.Gray
        Me.lblYearDepreciation.Location = New System.Drawing.Point(355, 302)
        Me.lblYearDepreciation.Name = "lblYearDepreciation"
        Me.lblYearDepreciation.Size = New System.Drawing.Size(96, 32)
        Me.lblYearDepreciation.TabIndex = 10
        Me.lblYearDepreciation.Text = "Year" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Depreciation"
        Me.lblYearDepreciation.Visible = False
        '
        'lblTotalDepreciation
        '
        Me.lblTotalDepreciation.AutoSize = True
        Me.lblTotalDepreciation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDepreciation.ForeColor = System.Drawing.Color.Gray
        Me.lblTotalDepreciation.Location = New System.Drawing.Point(474, 302)
        Me.lblTotalDepreciation.Name = "lblTotalDepreciation"
        Me.lblTotalDepreciation.Size = New System.Drawing.Size(96, 32)
        Me.lblTotalDepreciation.TabIndex = 11
        Me.lblTotalDepreciation.Text = "Total" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Depreciation" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblTotalDepreciation.Visible = False
        '
        'lstPresentValue
        '
        Me.lstPresentValue.ForeColor = System.Drawing.Color.Gray
        Me.lstPresentValue.FormattingEnabled = True
        Me.lstPresentValue.Location = New System.Drawing.Point(239, 337)
        Me.lstPresentValue.Name = "lstPresentValue"
        Me.lstPresentValue.Size = New System.Drawing.Size(88, 82)
        Me.lstPresentValue.TabIndex = 12
        '
        'lstYearDepreciation
        '
        Me.lstYearDepreciation.ForeColor = System.Drawing.Color.Gray
        Me.lstYearDepreciation.FormattingEnabled = True
        Me.lstYearDepreciation.Location = New System.Drawing.Point(358, 337)
        Me.lstYearDepreciation.Name = "lstYearDepreciation"
        Me.lstYearDepreciation.Size = New System.Drawing.Size(88, 82)
        Me.lstYearDepreciation.TabIndex = 13
        '
        'lstYear
        '
        Me.lstYear.ForeColor = System.Drawing.Color.Gray
        Me.lstYear.FormattingEnabled = True
        Me.lstYear.Location = New System.Drawing.Point(120, 337)
        Me.lstYear.Name = "lstYear"
        Me.lstYear.Size = New System.Drawing.Size(88, 82)
        Me.lstYear.TabIndex = 10
        '
        'lstTotalDepreciation
        '
        Me.lstTotalDepreciation.ForeColor = System.Drawing.Color.Gray
        Me.lstTotalDepreciation.FormattingEnabled = True
        Me.lstTotalDepreciation.Location = New System.Drawing.Point(477, 337)
        Me.lstTotalDepreciation.Name = "lstTotalDepreciation"
        Me.lstTotalDepreciation.Size = New System.Drawing.Size(88, 82)
        Me.lstTotalDepreciation.TabIndex = 14
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.ForeColor = System.Drawing.Color.Gray
        Me.lblQuantity.Location = New System.Drawing.Point(363, 270)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(88, 16)
        Me.lblQuantity.TabIndex = 15
        Me.lblQuantity.Text = "XXXXXXXXX"
        Me.lblQuantity.Visible = False
        '
        'lstInventoryId
        '
        Me.lstInventoryId.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstInventoryId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstInventoryId.ForeColor = System.Drawing.Color.Gray
        Me.lstInventoryId.FormattingEnabled = True
        Me.lstInventoryId.ItemHeight = 16
        Me.lstInventoryId.Location = New System.Drawing.Point(224, 99)
        Me.lstInventoryId.Name = "lstInventoryId"
        Me.lstInventoryId.Size = New System.Drawing.Size(152, 84)
        Me.lstInventoryId.TabIndex = 16
        '
        'frmDepreciation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 431)
        Me.Controls.Add(Me.lstInventoryId)
        Me.Controls.Add(Me.lblPresentValue)
        Me.Controls.Add(Me.lstPresentValue)
        Me.Controls.Add(Me.lblYearDepreciation)
        Me.Controls.Add(Me.lblTotalDepreciation)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.lstTotalDepreciation)
        Me.Controls.Add(Me.btnCalculateDepreciation)
        Me.Controls.Add(Me.lstYearDepreciation)
        Me.Controls.Add(Me.picTruck)
        Me.Controls.Add(Me.lstYear)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblFoodTruck)
        Me.Controls.Add(Me.lblSelectItem)
        Me.Controls.Add(Me.grpDepreciationType)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmDepreciation"
        Me.Text = "Compute Depreciation by Method"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picTruck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDepreciationType.ResumeLayout(False)
        Me.grpDepreciationType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuDisplay As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents picTruck As PictureBox
    Friend WithEvents lblYear As Label
    Friend WithEvents lblSelectItem As Label
    Friend WithEvents btnCalculateDepreciation As Button
    Friend WithEvents grpDepreciationType As GroupBox
    Friend WithEvents radDoubleDeclining As RadioButton
    Friend WithEvents radStraightLine As RadioButton
    Friend WithEvents lblItem As Label
    Friend WithEvents lblFoodTruck As Label
    Friend WithEvents lblPresentValue As Label
    Friend WithEvents lblYearDepreciation As Label
    Friend WithEvents lblTotalDepreciation As Label
    Friend WithEvents lstPresentValue As ListBox
    Friend WithEvents lstYearDepreciation As ListBox
    Friend WithEvents lstYear As ListBox
    Friend WithEvents lstTotalDepreciation As ListBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lstInventoryId As ListBox
End Class
