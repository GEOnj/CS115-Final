'-=======================================================================================
'|  Project:        CS115 Final
'|  Title:          Our Tim's List Project
'|  File Name:      TimsList.sln, .exe
'|  Date Completed: TBD
'|  
'|  Authors:        Andrew Ruiz, Jovanni Navia, Tye Tinsley, Chentel Smith
'|  Course:         CS 115, Section A, Spring 20120
'|  
'|  Description:    This is our really cool program that does some really neat things
'|                  that we can't really tell you what they do yet because they are kinda
'|                  not finished but sometime soon they will be finished and then we can
'|                  write a complete description about this really cool program that we
'|                  created for this really cool class by this really neat instructor
'|                  who sets the foundation for all of our future programming endeavors.
'|                  
'|                  Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam 
'|                  nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat 
'|                  volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation 
'|                  ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo 
'|                  consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate 
'|                  velit esse molestie consequat, vel illum dolore eu feugiat nulla 
'|                  facilisis at vero eros et accumsan et iusto odio dignissim qui 
'|                  blandit praesent luptatum zzril delenit augue duis dolore te feugait 
'|                  nulla facilisi. Nam liber tempor cum soluta nobis eleifend option 
'|                  congue nihil imperdiet doming id quod mazim placerat facer possim 
'|                  assum. Typi non habent claritatem insitam; est usus legentis in iis 
'|                  qui facit eorum claritatem. Investigationes demonstraverunt lectores 
'|                  legere me lius quod ii legunt saepius. Claritas est etiam processus 
'|                  dynamicus, qui sequitur mutationem consuetudium lectorum. Mirum est 
'|                  notare quam littera gothica, quam nunc putamus parum claram, 
'|                  anteposuerit litterarum formas humanitatis per seacula quarta decima 
'|                  et quinta decima. Eodem modo typi, qui nunc nobis videntur parum 
'|                  clari, fiant sollemnes in futurum.  That means placholder text or
'|                  latin.
'|                  
'|
'+=======================================================================================
'|
'|  Known Bugs:     - Start Bug list here.
'|                  -
'|                  -
'|                  -
'|                  -
'|                  
'+=======================================================================================

Option Strict On
Option Explicit On

Imports System.IO

Public Class frmTimsList

    Const cshtOUTER_MARGIN As Short = 10
    Const cshtINNER_MARGIN As Short = 5

    Dim cbolPicFS As Boolean = False

    '=========================================================================
    'Class Wide File IO variables
    '=========================================================================

    'Catagories array's
    Dim cstrAutoFiles() As String
    Dim cstrCellFiles() As String
    Dim cstrFnGFiles() As String
    Dim cstrFurnFiles() As String
    Dim cstrLapPCFiles() As String
    Dim cstrSportFiles() As String

    'Counters for catagories array index
    Dim cshtX As Short = 1 'ask tim what takes more mem a variable or casting to a short might not need
    Dim cshtAutoCnt As Short = 1
    Dim cshtCellPhnCnt As Short = 1
    Dim cshtFnGCnt As Short = 1
    Dim cshtFurnCnt As Short = 1
    Dim cshtLapPCCnt As Short = 1
    Dim cshtSportCnt As Short = 1


    Private Sub TimsList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Const shtTEXT_MARGIN = 8
        Const shtBORDER As Short = 2

        '=====================================================================
        'Public File IO variables
        '=====================================================================

        Dim strAllFiles() As String
        Dim strHolder As String

        Const shtLIST As Short = 1
        Dim shtMaxIndex As Short 'Max index for AllFiles array
        Dim shtCount1 As Short = 1 'file number holder
        Dim shtCount2 As Short = 1 'file line number holder/counter

        '================================================================================

        ' Description:
        '  Sets locations of objects definitively

        picDoggie.Left = CshtOUTER_MARGIN
        picDoggie.Top = CshtOUTER_MARGIN

        lblTimsList.Left = picDoggie.Left + picDoggie.Width
        lblTimsList.Top = CshtOUTER_MARGIN

        picComputer.Left = lblTimsList.Left + lblTimsList.Width
        picComputer.Top = CshtOUTER_MARGIN
        picComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        'May Need to add Marquee information here...

        'Creates a neat "highlighting" effect of the title
        lblTimsListOverlay.Parent = lblTimsList
        lblTimsListOverlay.Top = 1
        lblTimsListOverlay.Left = 1

        'Sets individual locations of objects inside of pnlSearch
        lblCategorySelect.Top = shtTEXT_MARGIN
        lblCategorySelect.Left = cshtINNER_MARGIN

        cmbCategorySelect.Top = cshtINNER_MARGIN
        cmbCategorySelect.Left = lblCategorySelect.Width + cshtINNER_MARGIN

        lblPriceRange.Top = shtTEXT_MARGIN
        lblPriceRange.Left = cmbCategorySelect.Left + cmbCategorySelect.Width + cshtINNER_MARGIN

        txtMin.Top = cshtINNER_MARGIN
        txtMin.Left = lblPriceRange.Left + lblPriceRange.Width

        lblDash.Top = shtTEXT_MARGIN
        lblDash.Left = txtMin.Left + txtMin.Width

        txtMax.Top = cshtINNER_MARGIN
        txtMax.Left = lblDash.Left + lblDash.Width

        btnSearch.Top = cshtINNER_MARGIN - CInt(shtBORDER / 2)
        btnSearch.Left = txtMax.Left + txtMax.Width + CshtOUTER_MARGIN

        btnClearSearch.Top = cshtINNER_MARGIN - CInt(shtBORDER / 2)
        btnClearSearch.Left = btnSearch.Left + btnSearch.Width + cshtINNER_MARGIN

        lblSortBy.Top = shtTEXT_MARGIN
        lblSortBy.Left = btnClearSearch.Left + btnClearSearch.Width + CshtOUTER_MARGIN * 3

        cmbSortOrder.Top = cshtINNER_MARGIN
        cmbSortOrder.Left = lblSortBy.Left + lblSortBy.Width

        'Sets Combo Boxes to their initial indexes
        cmbCategorySelect.SelectedIndex = 0
        cmbSortOrder.SelectedIndex = 0

        'Sets pnlSearch size according to inner objects, also location of pnlSearch.
        pnlSearch.Top = CshtOUTER_MARGIN + picDoggie.Height + cshtINNER_MARGIN
        pnlSearch.Left = CshtOUTER_MARGIN
        pnlSearch.Width = Me.ClientSize.Width - CshtOUTER_MARGIN * 2
        pnlSearch.Height = cmbCategorySelect.Height + cshtINNER_MARGIN * 2 + shtBORDER

        'Sets lvwList location
        lvwList.Top = pnlSearch.Top + pnlSearch.Height + cshtINNER_MARGIN
        lvwList.Left = CshtOUTER_MARGIN
        lvwList.Width = Me.ClientSize.Width - CshtOUTER_MARGIN * 2
        lvwList.Height = Me.ClientSize.Height - CshtOUTER_MARGIN * 2 - cshtINNER_MARGIN * 2 - pnlSearch.Height - picDoggie.Height

        'pnlAd Size and Position
        pnlAd.Top = lvwList.Top
        pnlAd.Left = lvwList.Left
        pnlAd.Width = lvwList.Width
        pnlAd.Height = lvwList.Height
        pnlAd.BackColor = Color.Beige

        'Sets location and sizes of items inside of pnlAd
        lblAdItem.Top = 0
        lblAdItem.Left = cshtINNER_MARGIN

        lblAdCategory.Top = lblAdItem.Height
        lblAdCategory.Left = CshtOUTER_MARGIN

        pnlAdPicture.Top = lblAdCategory.Top + lblAdCategory.Height + cshtINNER_MARGIN
        pnlAdPicture.Left = CshtOUTER_MARGIN
        pnlAdPicture.Height = pnlAd.Height - lblAdItem.Height - lblAdCategory.Height - cshtINNER_MARGIN * 3
        pnlAdPicture.Width = pnlAd.Width - lblTimsListVert.Width - rtbAdText.Width - CshtOUTER_MARGIN * 3
        pnlAdPicture.BorderStyle = BorderStyle.FixedSingle
        pnlAdPicture.BackColor = Color.LightGray

        picAdPicture.Top = 0
        picAdPicture.Left = 0
        picAdPicture.Size = pnlAdPicture.Size
        picAdPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom

        lblEnlargePic.Top = 0
        lblEnlargePic.Left = CInt((pnlAdPicture.Width - lblEnlargePic.Width) / 2)
        lblEnlargePic.BackColor = Color.DarkGray
        lblEnlargePic.ForeColor = Color.White

        rtbAdText.Top = pnlAdPicture.Top
        rtbAdText.Left = pnlAdPicture.Left + pnlAdPicture.Width + CshtOUTER_MARGIN
        rtbAdText.Height = pnlAdPicture.Height

        'Sets location of lblTimsListVert and Clones to create "outline" effect
        lblTimsListVert.Top = 0
        lblTimsListVert.Left = pnlAd.Width - lblTimsListVert.Width - cshtINNER_MARGIN
        lblTimsList.Height = pnlAd.Height

        lblTimsListVertClone.Parent = lblTimsListVert
        lblTimsListVertClone.Size = lblTimsListVert.Size
        lblTimsListVertClone.Top = 4
        lblTimsListVertClone.Left = 4

        lblTimsListVertClone2.Parent = lblTimsListVertClone
        lblTimsListVertClone2.Size = lblTimsListVert.Size
        lblTimsListVertClone2.Top = 0
        lblTimsListVertClone2.Left = -4

        lblTimsListVertClone3.Parent = lblTimsListVertClone2
        lblTimsListVertClone3.Size = lblTimsListVert.Size
        lblTimsListVertClone3.Top = -4
        lblTimsListVertClone3.Left = 4

        lblTimsListVertClone4.Parent = lblTimsListVertClone3
        lblTimsListVertClone4.Size = lblTimsListVert.Size
        lblTimsListVertClone4.Top = 2
        lblTimsListVertClone4.Left = -2
        lblTimsListVertClone4.ForeColor = Color.Gold

        llbBack.Top = rtbAdText.Top - llbBack.Height
        llbBack.Left = lblTimsListVert.Left - llbBack.Width - cshtINNER_MARGIN - shtBORDER

        '================================================================================
        '================================================================================
        '================================================================================

        'Test Setup for List View Columns.
        ' ...Add(Description as String, Width in Pixels, Alignment)
        lvwList.Columns.Add("Item Name", 220, HorizontalAlignment.Left)
        lvwList.Columns.Add("Category", 170, HorizontalAlignment.Center)
        lvwList.Columns.Add("Short Description", 500, HorizontalAlignment.Left)
        lvwList.Columns.Add("Price", 90, HorizontalAlignment.Left)
        lvwList.Columns.Add("Long Description", 0)
        lvwList.Columns.Add("Picture Filename", 0)
        lvwList.Columns.Add("Preferred Contact", 0)
        lvwList.Columns.Add("Contact Info", 0)


        '+====================================================================
        '|  Opens List.tlf and gets the value of the first line which sets
        '|  cshtAllFiles (Index to whatever that number is + 1) that should
        '|  set a max to the array to hold file numbers
        '+====================================================================
        FileOpen(shtLIST, "../../Bin/Data/List.tlf", OpenMode.Input)
        shtMaxIndex = CShort(LineInput(shtLIST))
        ReDim strAllFiles(shtMaxIndex)
        For shtCount1 = cshtX To (shtMaxIndex)
            strAllFiles(shtCount1) = LineInput(shtLIST)
        Next shtCount1
        FileClose(shtLIST)

        '+====================================================================
        '|  Filters through files and finds catagorys max index while
        '|  assigning file path to array
        '+====================================================================
        For shtCount1 = cshtX To shtMaxIndex
            FileOpen(shtCount1, "../../Bin/Data/" & strAllFiles(shtCount1), OpenMode.Input)
            'resets file line counter to defualt when reading next file increment
            shtCount2 = 1
            Do While EOF(shtCount1) = False
                strHolder = LineInput(shtCount1)
                'checks catagorey line in file (line 4)
                If shtCount2 = 4 And strHolder.Contains("Automobiles") Then
                    ReDim Preserve cstrAutoFiles(cshtAutoCnt)
                    cstrAutoFiles(cshtAutoCnt) = "../../Bin/Data/" & strAllFiles(shtCount1)
                    cshtAutoCnt += CShort(1)
                ElseIf shtCount2 = 4 And strHolder.Contains("Cellular Phones") Then
                    ReDim Preserve cstrCellFiles(cshtCellPhnCnt)
                    cstrCellFiles(cshtCellPhnCnt) = "../../Bin/Data/" & strAllFiles(shtCount1)
                    cshtCellPhnCnt += CShort(1)
                ElseIf shtCount2 = 4 And strHolder.Contains("Farm/Garden") Then
                    ReDim Preserve cstrFnGFiles(cshtFnGCnt)
                    cstrFnGFiles(cshtFnGCnt) = "../../Bin/Data/" & strAllFiles(shtCount1)
                    cshtFnGCnt += CShort(1)
                ElseIf shtCount2 = 4 And strHolder.Contains("Furniture") Then
                    ReDim Preserve cstrFurnFiles(cshtFurnCnt)
                    cstrFurnFiles(cshtFurnCnt) = "../../Bin/Data/" & strAllFiles(shtCount1)
                    cshtFurnCnt += CShort(1)
                ElseIf shtCount2 = 4 And strHolder.Contains("Laptop Computers") Then
                    ReDim Preserve cstrLapPCFiles(cshtLapPCCnt)
                    cstrLapPCFiles(cshtLapPCCnt) = "../../Bin/Data/" & strAllFiles(shtCount1)
                    cshtLapPCCnt += CShort(1)
                ElseIf shtCount2 = 4 And strHolder.Contains("Sporting") Then
                    ReDim Preserve cstrSportFiles(cshtSportCnt)
                    cstrSportFiles(cshtSportCnt) = "../../Bin/Data/" & strAllFiles(shtCount1)
                    cshtSportCnt += CShort(1)
                End If
                shtCount2 += CShort(1)
            Loop
            FileClose(shtCount1)
        Next shtCount1

        '================================================================================
        '================================================================================
        '================================================================================

    End Sub

    Private Sub AdShow()
        'Updates pnlAd and Inner Objects to display the selected Ad.

        lblAdItem.Text = lvwList.SelectedItems.Item(0).Text
        lblAdCategory.Text = "In Category: " & lvwList.SelectedItems.Item(0).SubItems(1).Text
        rtbAdText.Text = lvwList.SelectedItems.Item(0).SubItems(2).Text & Chr(13) & Chr(13) & _
            "Item Description:" & Chr(13) & lvwList.SelectedItems.Item(0).SubItems(4).Text _
            & Chr(13) & "Contact Information:" & Chr(13) _
            & lvwList.SelectedItems.Item(0).SubItems(7).Text & Chr(13) _
            & lvwList.SelectedItems.Item(0).SubItems(6).Text & Chr(13) & Chr(13) & _
            "Price: " & lvwList.SelectedItems.Item(0).SubItems(3).Text
        picAdPicture.Image = Image.FromFile("../../bin/Data/" & lvwList.SelectedItems.Item(0).SubItems(5).Text)
        pnlAd.Visible = True

    End Sub

    Private Sub lvwList_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lvwList.KeyPress
        'If the Enter button is pressed on the lvwList, it opens the currently selected ad.

        If Asc(e.KeyChar) = 13 Then
            Call AdShow()
        End If

    End Sub

    Private Sub lvwList_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvwList.MouseClick
        'If a user clicks on an item in lvwList, then it displays the selected ad.

        AdShow()

    End Sub

    'Private Sub lvwList_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvwList.MouseMove
    '   'Ensures the tooltip is removed if no item is currently being hovered over.
    '    If lvwList.GetItemAt(e.X, e.Y) Is Nothing Then
    '        tipList.RemoveAll()
    '    End If
    'End Sub

    Private Sub txtMin_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMin.GotFocus
        'Clears txtMin when the user "first" selects into the box

        If txtMin.Text = "Min" Then
            txtMin.Text = String.Empty
            txtMin.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtMax_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMax.GotFocus
        'Clears txtMax when the user "first" clicks into the box

        If txtMax.Text = "Max" Then
            txtMax.Text = String.Empty
            txtMax.ForeColor = Color.Black
        End If

    End Sub

    Private Sub txtMin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMin.KeyPress
        'Ensures only numbers are entered into the txtMin Box, also allows "enter" to start the search
        'Calls: btnSearch_Click

        e.Handled = Not Char.IsDigit(e.KeyChar) Xor Asc(e.KeyChar) = 8 Xor Asc(e.KeyChar) = 13
        If Asc(e.KeyChar) = 13 Then
            Call btnSearch_Click(sender, e)
        End If

    End Sub

    Private Sub txtMax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMax.KeyPress
        'Ensures only numbers are entered into the txtMax Box, also allows "Enter" to start the search
        'Calls: btnSearch_Click

        e.Handled = Not Char.IsDigit(e.KeyChar) Xor Asc(e.KeyChar) = 8 Xor Asc(e.KeyChar) = 13
        If Asc(e.KeyChar) = 13 Then
            Call btnSearch_Click(sender, e)
        End If

    End Sub

    Private Sub txtMin_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMin.LostFocus
        'Sets txtMin to defaults if user clears the field or enters nothing.

        If txtMin.Text = String.Empty Then
            txtMin.ForeColor = Color.DarkGray
            txtMin.Text = "Min"
        End If

    End Sub

    Private Sub txtMax_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMax.LostFocus
        'Sets txtMax to default if user clears field or enters nothing.

        If txtMax.Text = String.Empty Then
            txtMax.ForeColor = Color.DarkGray
            txtMax.Text = "Max"
        End If

    End Sub

    Private Sub llbBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles llbBack.Click
        'Hides pnlAd when user is finished viewing add and returns focus to lvwList

        pnlAd.Visible = False
        lvwList.Focus()

    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        'Will eventually sort through data files and display appropriate information to lvwList.
        'Also, hides pnlAd in case if user changes their mind about the type of product they're interested in.
        'Currently outputs to rtbTest as String data.
        'Calls: ShrinkPicture, PopList, **Sort Function**

        rtbTest.Text = "Searched>>>" & Chr(13) & "Category: " & cmbCategorySelect.SelectedItem.ToString & Chr(9) & "Min Price: " & txtMin.Text & Chr(9) & "Max Price: " & txtMax.Text
        pnlAd.Visible = False
        ShrinkPicture()
        PopList()
        rtbTest.Text = String.Concat(rtbTest.Text & Chr(13) & "Returned: " & lvwList.Items.Count & " Results.")
        'Call Ad Sorting by selected sort Type.
        lvwList.Focus()


    End Sub

    Private Sub btnClearSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClearSearch.Click
        'Sets the search values back to their defaults values. Does not affect sorting.
        'Calls txtMin_LostFocus and txtMax_LostFocus

        lvwList.Items.Clear()
        pnlAd.Visible = False
        cmbCategorySelect.SelectedIndex = 0
        txtMin.Text = String.Empty
        Call txtMin_LostFocus(sender, e)
        txtMax.Text = String.Empty
        Call txtMax_LostFocus(sender, e)

    End Sub

    '+====================================================================
    '|  Calls privat sub sGetList 
    '|  
    '+====================================================================
    Private Sub PopList()
        lvwList.Items.Clear()
        Select Case cmbCategorySelect.SelectedIndex
            Case 0
                sGetList(cshtAutoCnt, cstrAutoFiles)
                sGetList(cshtCellPhnCnt, cstrCellFiles)
                sGetList(cshtFnGCnt, cstrFnGFiles)
                sGetList(cshtFurnCnt, cstrFurnFiles)
                sGetList(cshtLapPCCnt, cstrLapPCFiles)
                sGetList(cshtSportCnt, cstrSportFiles)
            Case 1
                sGetList(cshtAutoCnt, cstrAutoFiles)
            Case 2
                sGetList(cshtCellPhnCnt, cstrCellFiles)
            Case 3
                sGetList(cshtFnGCnt, cstrFnGFiles)
            Case 4
                sGetList(cshtFurnCnt, cstrFurnFiles)
            Case 5
                sGetList(cshtLapPCCnt, cstrLapPCFiles)
            Case 6
                sGetList(cshtSportCnt, cstrSportFiles)
        End Select

    End Sub

    Private Sub ShrinkPicture()
        'Shrinks the picture when clicking the image or find it button.
        'Called by btnSearch_Click

        pnlAdPicture.Top = lblAdCategory.Top + lblAdCategory.Height + cshtINNER_MARGIN
        pnlAdPicture.Left = cshtOUTER_MARGIN
        pnlAdPicture.Height = pnlAd.Height - lblAdItem.Height - lblAdCategory.Height - cshtINNER_MARGIN * 3
        pnlAdPicture.Width = pnlAd.Width - lblTimsListVert.Width - rtbAdText.Width - cshtOUTER_MARGIN * 3
        picAdPicture.Top = 0
        picAdPicture.Left = 0
        picAdPicture.Size = pnlAdPicture.Size
        lblEnlargePic.Text = "Click the Picture to Enlarge"
        lblEnlargePic.Left = CInt((pnlAdPicture.Width - lblEnlargePic.Width) / 2)
        cbolPicFS = False

    End Sub

    Private Sub picAdPicture_Click(sender As Object, e As System.EventArgs) Handles picAdPicture.Click
        'Enlarge or Shrink the picAdPicture when clicked.

        If cbolPicFS = False Then
            pnlAdPicture.Size = pnlAd.Size
            pnlAdPicture.Top = -1 'Handles border of pnlAdPicture to not display
            pnlAdPicture.Left = -1 'Handles border of pnlAdPicture to not display
            picAdPicture.Size = pnlAdPicture.Size
            lblEnlargePic.Text = "Click the Picture to Shrink"
            lblEnlargePic.Left = CInt((pnlAdPicture.Width - lblEnlargePic.Width) / 2)
            cbolPicFS = True
        Else
            ShrinkPicture()
        End If

    End Sub

    '+====================================================================
    '|  Filters through passed array and assigns it to list view sub 
    '|  catagories. Also, it evaluates the price of an item. It returns
    '|  a max value if the price is invalid, putting it at the "bottom"
    '|  of a search pile. If the price of the item is between a user inputted
    '|  min and max then the item is displayed.
    '+====================================================================
    Private Sub sGetList(ByVal Index As Short, ByRef CatArray() As String)

        Dim strName As String
        Dim strShrtDesc As String
        Dim strLngDesc As String
        Dim strPic As String
        Dim strPrefCont As String
        Dim strCont As String
        Dim strCat As String
        Dim strHolder As String
        Dim strPrice As String

        Dim shtDescLeng As Short
        Dim shtTotLines As Short
        Dim shtCount1 As Short

        Dim sngPrice As Single
        Dim sngMin As Single
        Dim sngMax As Single

        For i = cshtX To (Index - cshtX)
            FileOpen(i, CatArray(i), OpenMode.Input)
            shtCount1 = 1
            Do While EOF(i) = False
                strHolder = LineInput(i)
                If shtCount1 = 1 Then
                    shtTotLines = CShort(strHolder)
                    shtDescLeng = (shtTotLines - CShort(11))
                ElseIf shtCount1 = 2 Then
                    strName = strHolder.Trim
                ElseIf shtCount1 = 4 Then
                    strCat = strHolder.Trim
                ElseIf shtCount1 = 5 Then
                    strShrtDesc = strHolder.Trim
                ElseIf shtCount1 = 6 Then
                    strPrefCont = strHolder.Trim
                ElseIf shtCount1 >= 8 And shtCount1 <= (shtDescLeng + CShort(8)) Then
                    'strLngDesc &= strHolder.Trim & Chr(32)
                    strLngDesc &= strHolder.Trim & Chr(13)
                ElseIf shtCount1 = (shtDescLeng + CShort(9)) Then
                    strPrice = strHolder.Trim
                ElseIf shtCount1 = (shtDescLeng + CShort(10)) Then
                    strCont = strHolder.Trim
                ElseIf shtCount1 = (shtDescLeng + CShort(11)) Then
                    strPic = strHolder.Trim
                End If
                shtCount1 += CShort(1)
            Loop

            'Checks if txtMin and txtMax have their default values and
            'Outputs a predetermined min/max value. If the text boxes
            'contain user-inputted data, they are converted to singles.

            If txtMin.Text = "Min" And txtMax.Text = "Max" Then
                sngMin = 0
                sngMax = Single.MaxValue
            ElseIf txtMin.Text = "Min" Then
                sngMin = 0
                sngMax = CSng(txtMax.Text)
            ElseIf txtMax.Text = "Max" Then
                sngMin = CSng(txtMin.Text)
                sngMax = Single.MaxValue
            Else
                sngMin = CSng(txtMin.Text)
                sngMax = CSng(txtMax.Text)
            End If

            'Checks if strPrice can be converted into a single.
            'If it cannot then the value will change to the user
            'inputted maximum value so the listing will stll appear.
            Try
                sngPrice = CSng(strPrice)
            Catch ex As Exception
                sngPrice = sngMax
            End Try

            'Outputs the line item provided it meets the price restrictions.
            If sngPrice >= sngMin And sngPrice <= sngMax Then
                Dim item As New ListViewItem(strName, i)
                item.SubItems.Add(strCat)
                item.SubItems.Add(strShrtDesc)
                item.SubItems.Add(Chr(36) & strPrice)
                item.SubItems.Add(strLngDesc)
                item.SubItems.Add(strPic)
                item.SubItems.Add(strPrefCont)
                item.SubItems.Add(strCont)
                lvwList.Items.Add(item)
            End If

            strLngDesc = String.Empty
            FileClose(i)

        Next i
    End Sub

    Private Sub cmbCategorySelect_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCategorySelect.SelectedIndexChanged
        'Clears lvwList when a new category selection is made.

        lvwList.Items.Clear()

    End Sub

End Class

'+=======================================================================================
'|     Working with a Listview from MSDN
'+=======================================================================================
'
'
'[Visual Basic] 
'Private Sub CreateMyListView()
'    ' Create a new ListView control.
'    Dim listView1 As New ListView()
'    listView1.Bounds = New Rectangle(New Point(10, 10), New Size(300, 200))

'    ' Set the view to show details.
'    listView1.View = View.Details
'    ' Allow the user to edit item text.
'    listView1.LabelEdit = True
'    ' Allow the user to rearrange columns.
'    listView1.AllowColumnReorder = True
'    ' Display check boxes.
'    listView1.CheckBoxes = True
'    ' Select the item and subitems when selection is made.
'    listView1.FullRowSelect = True
'    ' Display grid lines.
'    listView1.GridLines = True
'    ' Sort the items in the list in ascending order.
'    listView1.Sorting = SortOrder.Ascending

'    ' Create three items and three sets of subitems for each item.
'    Dim item As New ListViewItem("item", 0)
'    ' Place a check mark next to the item.
'    item.Checked = True
'    item.SubItems.Add("1")
'    item.SubItems.Add("2")
'    item.SubItems.Add("3")
'    Dim item2 As New ListViewItem("item2", 1)
'    item2.SubItems.Add("4")
'    item2.SubItems.Add("5")
'    item2.SubItems.Add("6")
'    Dim item3 As New ListViewItem("item3", 0)
'    ' Place a check mark next to the item.
'    item3.Checked = True
'    item3.SubItems.Add("7")
'    item3.SubItems.Add("8")
'    item3.SubItems.Add("9")

'    ' Create columns for the items and subitems.
'    listView1.Columns.Add("Item Column", -2, HorizontalAlignment.Left)
'    listView1.Columns.Add("Column 2", -2, HorizontalAlignment.Left)
'    listView1.Columns.Add("Column 3", -2, HorizontalAlignment.Left)
'    listView1.Columns.Add("Column 4", -2, HorizontalAlignment.Center)

'    'Add the items to the ListView.
'    listView1.Items.AddRange(New ListViewItem() {item, item2, item3})

'    ' Create two ImageList objects.
'    Dim imageListSmall As New ImageList()
'    Dim imageListLarge As New ImageList()

'    ' Initialize the ImageList objects with bitmaps.
'    imageListSmall.Images.Add(Bitmap.FromFile("C:\MySmallImage1.bmp"))
'    imageListSmall.Images.Add(Bitmap.FromFile("C:\MySmallImage2.bmp"))
'    imageListLarge.Images.Add(Bitmap.FromFile("C:\MyLargeImage1.bmp"))
'    imageListLarge.Images.Add(Bitmap.FromFile("C:\MyLargeImage2.bmp"))

'    'Assign the ImageList objects to the ListView.
'    listView1.LargeImageList = imageListLarge
'    listView1.SmallImageList = imageListSmall

'    ' Add the ListView to the control collection.
'    Me.Controls.Add(listView1)
'End Sub 'CreateMyListView