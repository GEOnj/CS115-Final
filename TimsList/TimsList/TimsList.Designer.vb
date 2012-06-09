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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTimsList))
        Me.picDoggie = New System.Windows.Forms.PictureBox()
        Me.lblTimsList = New System.Windows.Forms.Label()
        Me.cmbCategorySelect = New System.Windows.Forms.ComboBox()
        Me.lblCategorySelect = New System.Windows.Forms.Label()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.lblPriceRange = New System.Windows.Forms.Label()
        Me.lblDash = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.lblSortBy = New System.Windows.Forms.Label()
        Me.cmbSortOrder = New System.Windows.Forms.ComboBox()
        Me.lvwList = New System.Windows.Forms.ListView()
        Me.pnlAd = New System.Windows.Forms.Panel()
        Me.pnlAdPicture = New System.Windows.Forms.Panel()
        Me.lblEnlargePic = New System.Windows.Forms.Label()
        Me.picAdPicture = New System.Windows.Forms.PictureBox()
        Me.lblAdItem = New System.Windows.Forms.Label()
        Me.llbBack = New System.Windows.Forms.LinkLabel()
        Me.lblTimsListVertClone4 = New System.Windows.Forms.Label()
        Me.lblTimsListVertClone3 = New System.Windows.Forms.Label()
        Me.lblTimsListVertClone2 = New System.Windows.Forms.Label()
        Me.lblTimsListVertClone = New System.Windows.Forms.Label()
        Me.lblAdCategory = New System.Windows.Forms.Label()
        Me.lblTimsListVert = New System.Windows.Forms.Label()
        Me.rtbAdText = New System.Windows.Forms.RichTextBox()
        Me.picComputer = New System.Windows.Forms.PictureBox()
        Me.lblTimsListOverlay = New System.Windows.Forms.Label()
        Me.lblCreatedBy = New System.Windows.Forms.Label()
        CType(Me.picDoggie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSearch.SuspendLayout()
        Me.pnlAd.SuspendLayout()
        Me.pnlAdPicture.SuspendLayout()
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
        Me.cmbCategorySelect.ForeColor = System.Drawing.Color.Black
        Me.cmbCategorySelect.Items.AddRange(New Object() {"All Categories", "Automobiles", "Cellular Phones", "Farm/Garden", "Furniture", "Laptop Computers", "Sporting"})
        Me.cmbCategorySelect.Location = New System.Drawing.Point(58, 3)
        Me.cmbCategorySelect.Name = "cmbCategorySelect"
        Me.cmbCategorySelect.Size = New System.Drawing.Size(172, 21)
        Me.cmbCategorySelect.TabIndex = 3
        '
        'lblCategorySelect
        '
        Me.lblCategorySelect.AutoSize = True
        Me.lblCategorySelect.ForeColor = System.Drawing.Color.Black
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
        Me.txtMin.MaxLength = 7
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(72, 20)
        Me.txtMin.TabIndex = 5
        Me.txtMin.Text = "Min"
        '
        'txtMax
        '
        Me.txtMax.ForeColor = System.Drawing.Color.DarkGray
        Me.txtMax.Location = New System.Drawing.Point(433, 6)
        Me.txtMax.MaxLength = 7
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(71, 20)
        Me.txtMax.TabIndex = 6
        Me.txtMax.Text = "Max"
        '
        'lblPriceRange
        '
        Me.lblPriceRange.AutoSize = True
        Me.lblPriceRange.ForeColor = System.Drawing.Color.Black
        Me.lblPriceRange.Location = New System.Drawing.Point(239, 9)
        Me.lblPriceRange.Name = "lblPriceRange"
        Me.lblPriceRange.Size = New System.Drawing.Size(81, 13)
        Me.lblPriceRange.TabIndex = 9
        Me.lblPriceRange.Text = "Price Range:  $"
        '
        'lblDash
        '
        Me.lblDash.AutoSize = True
        Me.lblDash.ForeColor = System.Drawing.Color.Black
        Me.lblDash.Location = New System.Drawing.Point(404, 9)
        Me.lblDash.Name = "lblDash"
        Me.lblDash.Size = New System.Drawing.Size(25, 13)
        Me.lblDash.TabIndex = 10
        Me.lblDash.Text = "—  $"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Lime
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(518, 4)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 12
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(599, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "&Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'pnlSearch
        '
        Me.pnlSearch.BackColor = System.Drawing.Color.DarkTurquoise
        Me.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSearch.Controls.Add(Me.lblSortBy)
        Me.pnlSearch.Controls.Add(Me.cmbSortOrder)
        Me.pnlSearch.Controls.Add(Me.cmbCategorySelect)
        Me.pnlSearch.Controls.Add(Me.btnClear)
        Me.pnlSearch.Controls.Add(Me.lblCategorySelect)
        Me.pnlSearch.Controls.Add(Me.btnSearch)
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
        Me.lblSortBy.ForeColor = System.Drawing.Color.Black
        Me.lblSortBy.Location = New System.Drawing.Point(689, 9)
        Me.lblSortBy.Name = "lblSortBy"
        Me.lblSortBy.Size = New System.Drawing.Size(44, 13)
        Me.lblSortBy.TabIndex = 16
        Me.lblSortBy.Text = "Sort By:"
        '
        'cmbSortOrder
        '
        Me.cmbSortOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSortOrder.ForeColor = System.Drawing.Color.Black
        Me.cmbSortOrder.FormattingEnabled = True
        Me.cmbSortOrder.Items.AddRange(New Object() {"Item Name (A-Z)", "Item Name (Z-A)", "Category (A-Z)", "Category (Z-A)", "Price (Low to High)", "Price (High to Low)"})
        Me.cmbSortOrder.Location = New System.Drawing.Point(739, 3)
        Me.cmbSortOrder.Name = "cmbSortOrder"
        Me.cmbSortOrder.Size = New System.Drawing.Size(151, 21)
        Me.cmbSortOrder.TabIndex = 14
        '
        'lvwList
        '
        Me.lvwList.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwList.BackColor = System.Drawing.Color.Bisque
        Me.lvwList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwList.FullRowSelect = True
        Me.lvwList.GridLines = True
        Me.lvwList.HideSelection = False
        Me.lvwList.LabelWrap = False
        Me.lvwList.Location = New System.Drawing.Point(12, 129)
        Me.lvwList.MultiSelect = False
        Me.lvwList.Name = "lvwList"
        Me.lvwList.Size = New System.Drawing.Size(994, 535)
        Me.lvwList.TabIndex = 21
        Me.lvwList.UseCompatibleStateImageBehavior = False
        Me.lvwList.View = System.Windows.Forms.View.Details
        '
        'pnlAd
        '
        Me.pnlAd.BackColor = System.Drawing.Color.Chartreuse
        Me.pnlAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAd.Controls.Add(Me.pnlAdPicture)
        Me.pnlAd.Controls.Add(Me.lblAdItem)
        Me.pnlAd.Controls.Add(Me.llbBack)
        Me.pnlAd.Controls.Add(Me.lblTimsListVertClone4)
        Me.pnlAd.Controls.Add(Me.lblTimsListVertClone3)
        Me.pnlAd.Controls.Add(Me.lblTimsListVertClone2)
        Me.pnlAd.Controls.Add(Me.lblTimsListVertClone)
        Me.pnlAd.Controls.Add(Me.lblAdCategory)
        Me.pnlAd.Controls.Add(Me.lblTimsListVert)
        Me.pnlAd.Controls.Add(Me.rtbAdText)
        Me.pnlAd.Location = New System.Drawing.Point(97, 225)
        Me.pnlAd.Name = "pnlAd"
        Me.pnlAd.Size = New System.Drawing.Size(909, 425)
        Me.pnlAd.TabIndex = 26
        Me.pnlAd.Visible = False
        '
        'pnlAdPicture
        '
        Me.pnlAdPicture.Controls.Add(Me.lblEnlargePic)
        Me.pnlAdPicture.Controls.Add(Me.picAdPicture)
        Me.pnlAdPicture.Location = New System.Drawing.Point(22, 98)
        Me.pnlAdPicture.Name = "pnlAdPicture"
        Me.pnlAdPicture.Size = New System.Drawing.Size(431, 229)
        Me.pnlAdPicture.TabIndex = 10
        '
        'lblEnlargePic
        '
        Me.lblEnlargePic.AutoSize = True
        Me.lblEnlargePic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnlargePic.Location = New System.Drawing.Point(79, 31)
        Me.lblEnlargePic.Name = "lblEnlargePic"
        Me.lblEnlargePic.Size = New System.Drawing.Size(141, 13)
        Me.lblEnlargePic.TabIndex = 2
        Me.lblEnlargePic.Text = "Click to Enlarge Picture"
        '
        'picAdPicture
        '
        Me.picAdPicture.BackColor = System.Drawing.Color.Transparent
        Me.picAdPicture.Location = New System.Drawing.Point(23, 16)
        Me.picAdPicture.Name = "picAdPicture"
        Me.picAdPicture.Size = New System.Drawing.Size(292, 149)
        Me.picAdPicture.TabIndex = 1
        Me.picAdPicture.TabStop = False
        '
        'lblAdItem
        '
        Me.lblAdItem.AutoSize = True
        Me.lblAdItem.BackColor = System.Drawing.Color.Transparent
        Me.lblAdItem.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdItem.Location = New System.Drawing.Point(3, 0)
        Me.lblAdItem.Name = "lblAdItem"
        Me.lblAdItem.Size = New System.Drawing.Size(297, 45)
        Me.lblAdItem.TabIndex = 2
        Me.lblAdItem.Text = "Temporary Text"
        '
        'llbBack
        '
        Me.llbBack.AutoSize = True
        Me.llbBack.BackColor = System.Drawing.Color.Transparent
        Me.llbBack.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llbBack.LinkColor = System.Drawing.Color.Blue
        Me.llbBack.Location = New System.Drawing.Point(621, 19)
        Me.llbBack.Name = "llbBack"
        Me.llbBack.Size = New System.Drawing.Size(87, 23)
        Me.llbBack.TabIndex = 3
        Me.llbBack.TabStop = True
        Me.llbBack.Text = "<<- Back"
        '
        'lblTimsListVertClone4
        '
        Me.lblTimsListVertClone4.BackColor = System.Drawing.Color.Transparent
        Me.lblTimsListVertClone4.Font = New System.Drawing.Font("Arial Black", 32.0!)
        Me.lblTimsListVertClone4.ForeColor = System.Drawing.Color.White
        Me.lblTimsListVertClone4.Location = New System.Drawing.Point(538, -60)
        Me.lblTimsListVertClone4.Name = "lblTimsListVertClone4"
        Me.lblTimsListVertClone4.Size = New System.Drawing.Size(53, 522)
        Me.lblTimsListVertClone4.TabIndex = 9
        Me.lblTimsListVertClone4.Text = "TIMSLIST"
        Me.lblTimsListVertClone4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimsListVertClone3
        '
        Me.lblTimsListVertClone3.BackColor = System.Drawing.Color.Transparent
        Me.lblTimsListVertClone3.Font = New System.Drawing.Font("Arial Black", 32.0!)
        Me.lblTimsListVertClone3.ForeColor = System.Drawing.Color.Black
        Me.lblTimsListVertClone3.Location = New System.Drawing.Point(597, -46)
        Me.lblTimsListVertClone3.Name = "lblTimsListVertClone3"
        Me.lblTimsListVertClone3.Size = New System.Drawing.Size(53, 522)
        Me.lblTimsListVertClone3.TabIndex = 8
        Me.lblTimsListVertClone3.Text = "TIMSLIST"
        Me.lblTimsListVertClone3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimsListVertClone2
        '
        Me.lblTimsListVertClone2.BackColor = System.Drawing.Color.Transparent
        Me.lblTimsListVertClone2.Font = New System.Drawing.Font("Arial Black", 32.0!)
        Me.lblTimsListVertClone2.ForeColor = System.Drawing.Color.Black
        Me.lblTimsListVertClone2.Location = New System.Drawing.Point(701, -60)
        Me.lblTimsListVertClone2.Name = "lblTimsListVertClone2"
        Me.lblTimsListVertClone2.Size = New System.Drawing.Size(53, 522)
        Me.lblTimsListVertClone2.TabIndex = 7
        Me.lblTimsListVertClone2.Text = "TIMSLIST"
        Me.lblTimsListVertClone2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimsListVertClone
        '
        Me.lblTimsListVertClone.BackColor = System.Drawing.Color.Transparent
        Me.lblTimsListVertClone.Font = New System.Drawing.Font("Arial Black", 32.0!)
        Me.lblTimsListVertClone.ForeColor = System.Drawing.Color.Black
        Me.lblTimsListVertClone.Location = New System.Drawing.Point(770, -84)
        Me.lblTimsListVertClone.Name = "lblTimsListVertClone"
        Me.lblTimsListVertClone.Size = New System.Drawing.Size(53, 522)
        Me.lblTimsListVertClone.TabIndex = 6
        Me.lblTimsListVertClone.Text = "TIMSLIST"
        Me.lblTimsListVertClone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAdCategory
        '
        Me.lblAdCategory.AutoSize = True
        Me.lblAdCategory.BackColor = System.Drawing.Color.Transparent
        Me.lblAdCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdCategory.Location = New System.Drawing.Point(30, 49)
        Me.lblAdCategory.Name = "lblAdCategory"
        Me.lblAdCategory.Size = New System.Drawing.Size(61, 15)
        Me.lblAdCategory.TabIndex = 5
        Me.lblAdCategory.Text = "Category: "
        '
        'lblTimsListVert
        '
        Me.lblTimsListVert.BackColor = System.Drawing.Color.Transparent
        Me.lblTimsListVert.Font = New System.Drawing.Font("Arial Black", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimsListVert.ForeColor = System.Drawing.Color.Black
        Me.lblTimsListVert.Location = New System.Drawing.Point(851, -84)
        Me.lblTimsListVert.Name = "lblTimsListVert"
        Me.lblTimsListVert.Size = New System.Drawing.Size(53, 481)
        Me.lblTimsListVert.TabIndex = 4
        Me.lblTimsListVert.Text = "TIMSLIST"
        Me.lblTimsListVert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rtbAdText
        '
        Me.rtbAdText.BackColor = System.Drawing.SystemColors.Window
        Me.rtbAdText.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbAdText.Location = New System.Drawing.Point(459, 98)
        Me.rtbAdText.Name = "rtbAdText"
        Me.rtbAdText.Size = New System.Drawing.Size(377, 283)
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
        'lblCreatedBy
        '
        Me.lblCreatedBy.AutoSize = True
        Me.lblCreatedBy.BackColor = System.Drawing.Color.Transparent
        Me.lblCreatedBy.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreatedBy.Location = New System.Drawing.Point(244, -3)
        Me.lblCreatedBy.Name = "lblCreatedBy"
        Me.lblCreatedBy.Size = New System.Drawing.Size(562, 12)
        Me.lblCreatedBy.TabIndex = 29
        Me.lblCreatedBy.Text = "Created By: Andrew Ruiz, Jovanni Navia, Tye Tinsley, Chentel Smith -- CS115 Secti" & _
            "on A, Spring Quarter 2012"
        '
        'frmTimsList
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1018, 676)
        Me.Controls.Add(Me.pnlAd)
        Me.Controls.Add(Me.lblCreatedBy)
        Me.Controls.Add(Me.picComputer)
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
        Me.pnlAdPicture.ResumeLayout(False)
        Me.pnlAdPicture.PerformLayout()
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
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents lvwList As System.Windows.Forms.ListView
    Friend WithEvents pnlAd As System.Windows.Forms.Panel
    Friend WithEvents lblAdItem As System.Windows.Forms.Label
    Friend WithEvents picAdPicture As System.Windows.Forms.PictureBox
    Friend WithEvents llbBack As System.Windows.Forms.LinkLabel
    Friend WithEvents cmbSortOrder As System.Windows.Forms.ComboBox
    Friend WithEvents picComputer As System.Windows.Forms.PictureBox
    Friend WithEvents lblSortBy As System.Windows.Forms.Label
    Friend WithEvents lblTimsListOverlay As System.Windows.Forms.Label
    Friend WithEvents lblTimsListVert As System.Windows.Forms.Label
    Friend WithEvents lblAdCategory As System.Windows.Forms.Label
    Friend WithEvents lblTimsListVertClone As System.Windows.Forms.Label
    Friend WithEvents lblTimsListVertClone3 As System.Windows.Forms.Label
    Friend WithEvents lblTimsListVertClone2 As System.Windows.Forms.Label
    Friend WithEvents lblTimsListVertClone4 As System.Windows.Forms.Label
    Friend WithEvents rtbAdText As System.Windows.Forms.RichTextBox
    Friend WithEvents pnlAdPicture As System.Windows.Forms.Panel
    Friend WithEvents lblEnlargePic As System.Windows.Forms.Label
    Friend WithEvents lblCreatedBy As System.Windows.Forms.Label

End Class
