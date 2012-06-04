<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimsList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTimsList))
        Me.picDoggie = New System.Windows.Forms.PictureBox()
        Me.lblTimsList = New System.Windows.Forms.Label()
        Me.cmbCategorySelect = New System.Windows.Forms.ComboBox()
        Me.lblCategorySelect = New System.Windows.Forms.Label()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.lblPriceRange = New System.Windows.Forms.Label()
        Me.lblDash = New System.Windows.Forms.Label()
        Me.btnFindIt = New System.Windows.Forms.Button()
        Me.btnClearSearch = New System.Windows.Forms.Button()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.lblSortBy = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.cmbSortOrder = New System.Windows.Forms.ComboBox()
        Me.rtbTest = New System.Windows.Forms.RichTextBox()
        Me.lvwList = New System.Windows.Forms.ListView()
        Me.pnlAd = New System.Windows.Forms.Panel()
        Me.llbBack = New System.Windows.Forms.LinkLabel()
        Me.lblAdItem = New System.Windows.Forms.Label()
        Me.picAdPicture = New System.Windows.Forms.PictureBox()
        Me.rtbAdText = New System.Windows.Forms.RichTextBox()
        Me.picComputer = New System.Windows.Forms.PictureBox()
        Me.tipList = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblTimsListOverlay = New System.Windows.Forms.Label()
        CType(Me.picDoggie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSearch.SuspendLayout()
        Me.pnlAd.SuspendLayout()
        CType(Me.picAdPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picComputer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picDoggie
        '
        Me.picDoggie.Image = CType(resources.GetObject("picDoggie.Image"), System.Drawing.Image)
        Me.picDoggie.Location = New System.Drawing.Point(12, 12)
        Me.picDoggie.Name = "picDoggie"
        Me.picDoggie.Size = New System.Drawing.Size(45, 46)
        Me.picDoggie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDoggie.TabIndex = 0
        Me.picDoggie.TabStop = False
        '
        'lblTimsList
        '
        Me.lblTimsList.AutoSize = True
        Me.lblTimsList.BackColor = System.Drawing.Color.Transparent
        Me.lblTimsList.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimsList.ForeColor = System.Drawing.Color.Orange
        Me.lblTimsList.Location = New System.Drawing.Point(63, 9)
        Me.lblTimsList.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTimsList.Name = "lblTimsList"
        Me.lblTimsList.Size = New System.Drawing.Size(158, 45)
        Me.lblTimsList.TabIndex = 1
        Me.lblTimsList.Text = "Tim's List"
        '
        'cmbCategorySelect
        '
        Me.cmbCategorySelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategorySelect.Items.AddRange(New Object() {"Select a Category", "Automobiles", "Cellular Phones", "Farm/Garden", "Furniture", "Laptop Computers", "Sporting"})
        Me.cmbCategorySelect.Location = New System.Drawing.Point(58, 3)
        Me.cmbCategorySelect.Name = "cmbCategorySelect"
        Me.cmbCategorySelect.Size = New System.Drawing.Size(172, 21)
        Me.cmbCategorySelect.TabIndex = 3
        '
        'lblCategorySelect
        '
        Me.lblCategorySelect.AutoSize = True
        Me.lblCategorySelect.Location = New System.Drawing.Point(3, 6)
        Me.lblCategorySelect.Name = "lblCategorySelect"
        Me.lblCategorySelect.Size = New System.Drawing.Size(52, 13)
        Me.lblCategorySelect.TabIndex = 4
        Me.lblCategorySelect.Text = "Category:"
        '
        'txtMin
        '
        Me.txtMin.ForeColor = System.Drawing.Color.DarkGray
        Me.txtMin.Location = New System.Drawing.Point(326, 6)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(72, 20)
        Me.txtMin.TabIndex = 5
        Me.txtMin.Text = "Min"
        '
        'txtMax
        '
        Me.txtMax.ForeColor = System.Drawing.Color.DarkGray
        Me.txtMax.Location = New System.Drawing.Point(433, 6)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(71, 20)
        Me.txtMax.TabIndex = 6
        Me.txtMax.Text = "Max"
        '
        'lblPriceRange
        '
        Me.lblPriceRange.AutoSize = True
        Me.lblPriceRange.Location = New System.Drawing.Point(239, 9)
        Me.lblPriceRange.Name = "lblPriceRange"
        Me.lblPriceRange.Size = New System.Drawing.Size(81, 13)
        Me.lblPriceRange.TabIndex = 9
        Me.lblPriceRange.Text = "Price Range:  $"
        '
        'lblDash
        '
        Me.lblDash.AutoSize = True
        Me.lblDash.Location = New System.Drawing.Point(404, 9)
        Me.lblDash.Name = "lblDash"
        Me.lblDash.Size = New System.Drawing.Size(25, 13)
        Me.lblDash.TabIndex = 10
        Me.lblDash.Text = "—  $"
        '
        'btnFindIt
        '
        Me.btnFindIt.Location = New System.Drawing.Point(518, 4)
        Me.btnFindIt.Name = "btnFindIt"
        Me.btnFindIt.Size = New System.Drawing.Size(75, 23)
        Me.btnFindIt.TabIndex = 12
        Me.btnFindIt.Text = "&Find It"
        Me.btnFindIt.UseVisualStyleBackColor = True
        '
        'btnClearSearch
        '
        Me.btnClearSearch.Location = New System.Drawing.Point(599, 4)
        Me.btnClearSearch.Name = "btnClearSearch"
        Me.btnClearSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnClearSearch.TabIndex = 13
        Me.btnClearSearch.Text = "&Clear Entires"
        Me.btnClearSearch.UseVisualStyleBackColor = True
        '
        'pnlSearch
        '
        Me.pnlSearch.BackColor = System.Drawing.Color.DarkTurquoise
        Me.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSearch.Controls.Add(Me.lblSortBy)
        Me.pnlSearch.Controls.Add(Me.btnReset)
        Me.pnlSearch.Controls.Add(Me.cmbSortOrder)
        Me.pnlSearch.Controls.Add(Me.cmbCategorySelect)
        Me.pnlSearch.Controls.Add(Me.btnClearSearch)
        Me.pnlSearch.Controls.Add(Me.lblCategorySelect)
        Me.pnlSearch.Controls.Add(Me.btnFindIt)
        Me.pnlSearch.Controls.Add(Me.txtMin)
        Me.pnlSearch.Controls.Add(Me.txtMax)
        Me.pnlSearch.Controls.Add(Me.lblDash)
        Me.pnlSearch.Controls.Add(Me.lblPriceRange)
        Me.pnlSearch.Location = New System.Drawing.Point(12, 64)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(994, 59)
        Me.pnlSearch.TabIndex = 14
        '
        'lblSortBy
        '
        Me.lblSortBy.AutoSize = True
        Me.lblSortBy.Location = New System.Drawing.Point(689, 9)
        Me.lblSortBy.Name = "lblSortBy"
        Me.lblSortBy.Size = New System.Drawing.Size(44, 13)
        Me.lblSortBy.TabIndex = 16
        Me.lblSortBy.Text = "Sort By:"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(896, 4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(84, 23)
        Me.btnReset.TabIndex = 15
        Me.btnReset.Text = "Reset Sorting"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'cmbSortOrder
        '
        Me.cmbSortOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSortOrder.FormattingEnabled = True
        Me.cmbSortOrder.Items.AddRange(New Object() {"Choose a Sorting Method", "Item Name (A-Z)", "Item Name (Z-A)", "Category (A-Z)", "Category (Z-A)", "Price (Low to High)", "Price (High to Low)"})
        Me.cmbSortOrder.Location = New System.Drawing.Point(739, 3)
        Me.cmbSortOrder.Name = "cmbSortOrder"
        Me.cmbSortOrder.Size = New System.Drawing.Size(151, 21)
        Me.cmbSortOrder.TabIndex = 14
        '
        'rtbTest
        '
        Me.rtbTest.BackColor = System.Drawing.Color.Orange
        Me.rtbTest.Location = New System.Drawing.Point(438, 12)
        Me.rtbTest.Name = "rtbTest"
        Me.rtbTest.ReadOnly = True
        Me.rtbTest.Size = New System.Drawing.Size(568, 43)
        Me.rtbTest.TabIndex = 20
        Me.rtbTest.Text = "Used to output different debugging information. Will not be included in final rel" & _
            "ease. Or it could be turned into a scrolling marquee of our names :P"
        '
        'lvwList
        '
        Me.lvwList.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwList.BackColor = System.Drawing.Color.Bisque
        Me.lvwList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwList.FullRowSelect = True
        Me.lvwList.HideSelection = False
        Me.lvwList.HoverSelection = True
        Me.lvwList.LabelWrap = False
        Me.lvwList.Location = New System.Drawing.Point(12, 129)
        Me.lvwList.MultiSelect = False
        Me.lvwList.Name = "lvwList"
        Me.lvwList.Scrollable = False
        Me.lvwList.Size = New System.Drawing.Size(994, 535)
        Me.lvwList.TabIndex = 21
        Me.lvwList.UseCompatibleStateImageBehavior = False
        Me.lvwList.View = System.Windows.Forms.View.Details
        '
        'pnlAd
        '
        Me.pnlAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAd.Controls.Add(Me.llbBack)
        Me.pnlAd.Controls.Add(Me.lblAdItem)
        Me.pnlAd.Controls.Add(Me.picAdPicture)
        Me.pnlAd.Controls.Add(Me.rtbAdText)
        Me.pnlAd.Location = New System.Drawing.Point(126, 225)
        Me.pnlAd.Name = "pnlAd"
        Me.pnlAd.Size = New System.Drawing.Size(867, 425)
        Me.pnlAd.TabIndex = 26
        Me.pnlAd.Visible = False
        '
        'llbBack
        '
        Me.llbBack.AutoSize = True
        Me.llbBack.Location = New System.Drawing.Point(735, 15)
        Me.llbBack.Name = "llbBack"
        Me.llbBack.Size = New System.Drawing.Size(101, 13)
        Me.llbBack.TabIndex = 3
        Me.llbBack.TabStop = True
        Me.llbBack.Text = "<<-  Go Back to List"
        '
        'lblAdItem
        '
        Me.lblAdItem.AutoSize = True
        Me.lblAdItem.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdItem.Location = New System.Drawing.Point(3, 0)
        Me.lblAdItem.Name = "lblAdItem"
        Me.lblAdItem.Size = New System.Drawing.Size(297, 45)
        Me.lblAdItem.TabIndex = 2
        Me.lblAdItem.Text = "Temporary Text"
        '
        'picAdPicture
        '
        Me.picAdPicture.Location = New System.Drawing.Point(11, 48)
        Me.picAdPicture.Name = "picAdPicture"
        Me.picAdPicture.Size = New System.Drawing.Size(442, 333)
        Me.picAdPicture.TabIndex = 1
        Me.picAdPicture.TabStop = False
        '
        'rtbAdText
        '
        Me.rtbAdText.BackColor = System.Drawing.SystemColors.Window
        Me.rtbAdText.Location = New System.Drawing.Point(459, 48)
        Me.rtbAdText.Name = "rtbAdText"
        Me.rtbAdText.Size = New System.Drawing.Size(377, 333)
        Me.rtbAdText.TabIndex = 0
        Me.rtbAdText.Text = ""
        '
        'picComputer
        '
        Me.picComputer.Image = CType(resources.GetObject("picComputer.Image"), System.Drawing.Image)
        Me.picComputer.Location = New System.Drawing.Point(216, 12)
        Me.picComputer.Name = "picComputer"
        Me.picComputer.Size = New System.Drawing.Size(54, 50)
        Me.picComputer.TabIndex = 27
        Me.picComputer.TabStop = False
        '
        'tipList
        '
        Me.tipList.AutoPopDelay = 5000
        Me.tipList.InitialDelay = 250
        Me.tipList.IsBalloon = True
        Me.tipList.ReshowDelay = 100
        Me.tipList.ToolTipTitle = "ACK"
        Me.tipList.UseAnimation = False
        Me.tipList.UseFading = False
        '
        'lblTimsListOverlay
        '
        Me.lblTimsListOverlay.AutoSize = True
        Me.lblTimsListOverlay.BackColor = System.Drawing.Color.Transparent
        Me.lblTimsListOverlay.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimsListOverlay.ForeColor = System.Drawing.Color.Black
        Me.lblTimsListOverlay.Location = New System.Drawing.Point(277, 9)
        Me.lblTimsListOverlay.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTimsListOverlay.Name = "lblTimsListOverlay"
        Me.lblTimsListOverlay.Size = New System.Drawing.Size(158, 45)
        Me.lblTimsListOverlay.TabIndex = 28
        Me.lblTimsListOverlay.Text = "Tim's List"
        '
        'frmTimsList
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1018, 676)
        Me.Controls.Add(Me.picComputer)
        Me.Controls.Add(Me.pnlAd)
        Me.Controls.Add(Me.rtbTest)
        Me.Controls.Add(Me.lvwList)
        Me.Controls.Add(Me.pnlSearch)
        Me.Controls.Add(Me.lblTimsList)
        Me.Controls.Add(Me.picDoggie)
        Me.Controls.Add(Me.lblTimsListOverlay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmTimsList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Our Tim's List Project"
        CType(Me.picDoggie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.pnlAd.ResumeLayout(False)
        Me.pnlAd.PerformLayout()
        CType(Me.picAdPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picComputer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picDoggie As System.Windows.Forms.PictureBox
    Friend WithEvents lblTimsList As System.Windows.Forms.Label
    Friend WithEvents cmbCategorySelect As System.Windows.Forms.ComboBox
    Friend WithEvents lblCategorySelect As System.Windows.Forms.Label
    Friend WithEvents txtMin As System.Windows.Forms.TextBox
    Friend WithEvents txtMax As System.Windows.Forms.TextBox
    Friend WithEvents lblPriceRange As System.Windows.Forms.Label
    Friend WithEvents lblDash As System.Windows.Forms.Label
    Friend WithEvents btnFindIt As System.Windows.Forms.Button
    Friend WithEvents btnClearSearch As System.Windows.Forms.Button
    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents rtbTest As System.Windows.Forms.RichTextBox
    Friend WithEvents lvwList As System.Windows.Forms.ListView
    Friend WithEvents pnlAd As System.Windows.Forms.Panel
    Friend WithEvents lblAdItem As System.Windows.Forms.Label
    Friend WithEvents picAdPicture As System.Windows.Forms.PictureBox
    Friend WithEvents rtbAdText As System.Windows.Forms.RichTextBox
    Friend WithEvents llbBack As System.Windows.Forms.LinkLabel
    Friend WithEvents cmbSortOrder As System.Windows.Forms.ComboBox
    Friend WithEvents picComputer As System.Windows.Forms.PictureBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents lblSortBy As System.Windows.Forms.Label
    Friend WithEvents tipList As System.Windows.Forms.ToolTip
    Friend WithEvents lblTimsListOverlay As System.Windows.Forms.Label

End Class
