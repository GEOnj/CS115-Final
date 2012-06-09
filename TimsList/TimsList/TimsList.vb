'-=======================================================================================
'|  Project:        CS115 Final
'|  Title:          Our Tim's List Project
'|  File Name:      TimsList.sln, .exe
'|  Date Completed: TBD
'|  
'|  Authors:        Andrew Ruiz, Jovanni Navia, Tye Tinsley, Chentel Smith
'|  Course:         CS 115, Section A, Spring 2012
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
'|                  clari, fiant sollemnes in futurum.  That means placholder text in
'|                  latin.
'|                  
'|
'+=======================================================================================
'|
'|  Known Bugs:     - Some Item names are too long for the pnlAd
'|                      * Resolved
'|                  - If an Ad's Actual number of lines and the First line do not match
'|                      then the program will display the previous Ad's picture.
'|                  - If rtbOutput is hidden, ads do not display...
'|                  -
'|                  -
'|                  
'+=======================================================================================

Option Strict On
Option Explicit On

'Imports System.IO

Public Class frmTimsList

    Private CurrentSortColumn As Integer

    'Varibles used for placement of objects.
    'Used by ShrinkPicture() and frmTimsList_Load
    Const cshtOUTER_MARGIN As Short = 10
    Const cshtINNER_MARGIN As Short = 5

    'If false, the Ad picture is not enlarged.
    'Used by ShrinkPicture() and picAdPicture_Click
    Dim cbolPicFS As Boolean = False

    '--------------------------------------------
    ' Class Wide File IO Variables
    '--------------------------------------------

    'Location of Data Files
    Dim cstrFileLoc As String = "../../Bin/Data/"

    'Arrays for each Catagory
    Dim cstrAutoFiles() As String
    Dim cstrCellFiles() As String
    Dim cstrFnGFiles() As String
    Dim cstrFurnFiles() As String
    Dim cstrLapPCFiles() As String
    Dim cstrSportFiles() As String

    'Counters for Catagories array index
    Dim cshtX As Short = 1
    Dim cshtAutoCnt As Short = 1
    Dim cshtCellPhnCnt As Short = 1
    Dim cshtFnGCnt As Short = 1
    Dim cshtFurnCnt As Short = 1
    Dim cshtLapPCCnt As Short = 1
    Dim cshtSportCnt As Short = 1


    Private Sub frmTimsList_Load(ByVal sender As Object, _
                                ByVal e As System.EventArgs) Handles Me.Load
        '+-------------------------------------------------------------------------------
        '| Description: When the form first loads, this event sets the location and
        '|              of all properties of all objects to their initial values.
        '|              The event also populates the Class Wide Category Arrays with
        '|              the information from List.tlf.
        '|
        '| Please Note: There are still many properties set by TimsList.Designer.vb
        '+-------------------------------------------------------------------------------

        Const shtTEXT_MARGIN = 8
        Const shtBORDER As Short = 2

        '--------------------------------------------
        'Public File IO variables
        '--------------------------------------------

        Dim strAllFiles() As String
        Dim strHolder As String

        Const shtLIST As Short = 1
        Dim shtMaxIndex As Short 'Max index for AllFiles array
        Dim shtCount1 As Short = 1 'file number holder
        Dim shtCount2 As Short = 1 'file line number holder/counter

        '--------------------------------------------

        'Sets locations of most objects with frmTimsList as parent

        lblTimsList.Text = "Welcome to Tim's List!"

        picDoggie.Left = CInt((Me.ClientSize.Width - cshtOUTER_MARGIN * 2 - picDoggie.Width - picComputer.Width - lblTimsList.Width) / 2)
        picDoggie.Top = cshtOUTER_MARGIN

        lblTimsList.Left = picDoggie.Left + picDoggie.Width
        lblTimsList.Top = cshtOUTER_MARGIN

        picComputer.Left = lblTimsList.Left + lblTimsList.Width
        picComputer.Top = cshtOUTER_MARGIN
        picComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom

        lblCreatedBy.Top = Me.ClientSize.Height - lblCreatedBy.Height
        lblCreatedBy.Left = CInt((Me.ClientSize.Width - lblCreatedBy.Width) / 2) _
                                + cshtINNER_MARGIN

        'Creates a neat "highlighting" effect of the title
        lblTimsListOverlay.Parent = lblTimsList
        lblTimsListOverlay.Top = 1
        lblTimsListOverlay.Left = 1
        lblTimsListOverlay.Text = lblTimsList.Text

        'Sets individual locations of objects inside of pnlSearch
        lblCategorySelect.Top = shtTEXT_MARGIN
        lblCategorySelect.Left = cshtINNER_MARGIN

        cmbCategorySelect.Top = cshtINNER_MARGIN
        cmbCategorySelect.Left = lblCategorySelect.Width + cshtINNER_MARGIN

        lblPriceRange.Top = shtTEXT_MARGIN
        lblPriceRange.Left = cmbCategorySelect.Left + cmbCategorySelect.Width _
                                + cshtINNER_MARGIN

        txtMin.Top = cshtINNER_MARGIN
        txtMin.Left = lblPriceRange.Left + lblPriceRange.Width

        lblDash.Top = shtTEXT_MARGIN
        lblDash.Left = txtMin.Left + txtMin.Width

        txtMax.Top = cshtINNER_MARGIN
        txtMax.Left = lblDash.Left + lblDash.Width

        btnSearch.Top = cshtINNER_MARGIN - CInt(shtBORDER / 2)
        btnSearch.Left = txtMax.Left + txtMax.Width + cshtOUTER_MARGIN

        btnClear.Top = cshtINNER_MARGIN - CInt(shtBORDER / 2)
        btnClear.Left = btnSearch.Left + btnSearch.Width + cshtINNER_MARGIN

        lblSortBy.Top = shtTEXT_MARGIN
        lblSortBy.Left = btnClear.Left + btnClear.Width + cshtOUTER_MARGIN * 3

        cmbSortOrder.Top = cshtINNER_MARGIN
        cmbSortOrder.Left = lblSortBy.Left + lblSortBy.Width

        'Sets Combo Boxes to their initial indexes
        cmbCategorySelect.SelectedIndex = 0
        cmbSortOrder.SelectedIndex = 0

        'Sets pnlSearch size according to inner objects, also location of pnlSearch.
        pnlSearch.Top = cshtOUTER_MARGIN + picDoggie.Height + cshtINNER_MARGIN
        pnlSearch.Left = cshtOUTER_MARGIN
        pnlSearch.Width = Me.ClientSize.Width - cshtOUTER_MARGIN * 2
        pnlSearch.Height = cmbCategorySelect.Height + cshtINNER_MARGIN * 2 + shtBORDER

        'Sets lvwList location
        lvwList.Top = pnlSearch.Top + pnlSearch.Height + cshtINNER_MARGIN
        lvwList.Left = cshtOUTER_MARGIN
        lvwList.Width = Me.ClientSize.Width - cshtOUTER_MARGIN * 2
        lvwList.Height = Me.ClientSize.Height - cshtOUTER_MARGIN - cshtINNER_MARGIN * 2 _
                            - pnlSearch.Height - picDoggie.Height - lblCreatedBy.Height

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
        lblAdCategory.Left = cshtOUTER_MARGIN

        pnlAdPicture.Top = lblAdCategory.Top + lblAdCategory.Height + cshtINNER_MARGIN
        pnlAdPicture.Left = cshtOUTER_MARGIN
        pnlAdPicture.Height = pnlAd.Height - lblAdItem.Height - lblAdCategory.Height _
                                - cshtINNER_MARGIN * 3
        pnlAdPicture.Width = pnlAd.Width - lblTimsListVert.Width - rtbAdText.Width _
                                - cshtOUTER_MARGIN * 3
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
        rtbAdText.Left = pnlAdPicture.Left + pnlAdPicture.Width + cshtOUTER_MARGIN
        rtbAdText.Height = pnlAdPicture.Height

        'Sets location of lblTimsListVert and Clones to create "outline" effect
        lblTimsListVert.Top = CInt((pnlAd.Height - lblTimsListVert.Height) / 2)
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

        'Creates all columns for lvwList.
        lvwList.Columns.Add("Item Name", 220, HorizontalAlignment.Left)
        lvwList.Columns.Add("Category", 170, HorizontalAlignment.Center)
        lvwList.Columns.Add("Short Description", 500, HorizontalAlignment.Left)
        lvwList.Columns.Add("Price", 90, HorizontalAlignment.Left)
        lvwList.Columns.Add("Long Description", 0)
        lvwList.Columns.Add("Picture Filename", 0)
        lvwList.Columns.Add("Preferred Contact", 0)
        lvwList.Columns.Add("Contact Info", 0)

        'Opens List.tlf, gets the value of the first line which sets 
        'cshtAllFiles(Index to first line + 1). 
        'This sets a maximum to the array to hold file numbers
        FileOpen(shtLIST, cstrFileLoc & "List.tlf", OpenMode.Input)
        shtMaxIndex = CShort(LineInput(shtLIST))
        ReDim strAllFiles(shtMaxIndex)
        For shtCount1 = cshtX To (shtMaxIndex)
            strAllFiles(shtCount1) = LineInput(shtLIST)
        Next shtCount1
        FileClose(shtLIST)

        'Filters through files, finds every Catagories Max Index while 
        'assigning the file path of an item to the array
        For shtCount1 = cshtX To shtMaxIndex
            FileOpen(shtCount1, cstrFileLoc & strAllFiles(shtCount1), OpenMode.Input)
            'Resets file line counter to defualt when reading next file increment
            shtCount2 = 1
            Do While EOF(shtCount1) = False
                strHolder = LineInput(shtCount1)
                'Checks Catagory line in file (line 4)
                If shtCount2 = 4 And strHolder.Contains("Automobiles") Then
                    ReDim Preserve cstrAutoFiles(cshtAutoCnt)
                    cstrAutoFiles(cshtAutoCnt) = cstrFileLoc & strAllFiles(shtCount1)
                    cshtAutoCnt += CShort(1)
                ElseIf shtCount2 = 4 And strHolder.Contains("Cellular Phones") Then
                    ReDim Preserve cstrCellFiles(cshtCellPhnCnt)
                    cstrCellFiles(cshtCellPhnCnt) = cstrFileLoc & strAllFiles(shtCount1)
                    cshtCellPhnCnt += CShort(1)
                ElseIf shtCount2 = 4 And strHolder.Contains("Farm/Garden") Then
                    ReDim Preserve cstrFnGFiles(cshtFnGCnt)
                    cstrFnGFiles(cshtFnGCnt) = cstrFileLoc & strAllFiles(shtCount1)
                    cshtFnGCnt += CShort(1)
                ElseIf shtCount2 = 4 And strHolder.Contains("Furniture") Then
                    ReDim Preserve cstrFurnFiles(cshtFurnCnt)
                    cstrFurnFiles(cshtFurnCnt) = cstrFileLoc & strAllFiles(shtCount1)
                    cshtFurnCnt += CShort(1)
                ElseIf shtCount2 = 4 And strHolder.Contains("Laptop Computers") Then
                    ReDim Preserve cstrLapPCFiles(cshtLapPCCnt)
                    cstrLapPCFiles(cshtLapPCCnt) = cstrFileLoc & strAllFiles(shtCount1)
                    cshtLapPCCnt += CShort(1)
                ElseIf shtCount2 = 4 And strHolder.Contains("Sporting") Then
                    ReDim Preserve cstrSportFiles(cshtSportCnt)
                    cstrSportFiles(cshtSportCnt) = cstrFileLoc & strAllFiles(shtCount1)
                    cshtSportCnt += CShort(1)
                End If
                shtCount2 += CShort(1)
            Loop
            FileClose(shtCount1)
        Next shtCount1

    End Sub

    Private Sub AdShow()
        '+-------------------------------------------------------------------------------
        '| Description: Updates pnlAd and Inner Objects to display the selected Ad.
        '|
        '| Called By:   lvwList_KeyPress, lvwList_Click
        '+-------------------------------------------------------------------------------

        Dim strDblSpace As String = Chr(13) & Chr(13)
        Dim lviSelItem As ListViewItem = lvwList.SelectedItems.Item(0)

        lblAdItem.Text = lviSelItem.Text
        lblAdCategory.Text = "In Category: " & lviSelItem.SubItems(1).Text
        rtbAdText.Text = lviSelItem.SubItems(2).Text & strDblSpace & _
            "Item Description:" & Chr(13) & lviSelItem.SubItems(4).Text & Chr(13) & _
            "Contact Information:" & Chr(13) & _
            lviSelItem.SubItems(7).Text & Chr(13) & _
            lviSelItem.SubItems(6).Text & strDblSpace & _
            "Price: " & lviSelItem.SubItems(3).Text
        picAdPicture.Image = Image.FromFile(cstrFileLoc & lviSelItem.SubItems(5).Text)
        pnlAd.Visible = True
        rtbAdText.Focus()

    End Sub

    Private Sub lvwList_KeyPress(ByVal sender As Object, _
                                ByVal e As System.Windows.Forms.KeyPressEventArgs) _
                                Handles lvwList.KeyPress
        '+-------------------------------------------------------------------------------
        '| Description: If the enter button is pressed on lvwList, the currently
        '|              selected ad will open.
        '|
        '| Calls:       AdShow()
        '+-------------------------------------------------------------------------------

        If Asc(e.KeyChar) = 13 Then
            Call AdShow()
        End If

    End Sub

    Private Sub lvwList_MouseClick(ByVal sender As Object, _
                                ByVal e As System.Windows.Forms.MouseEventArgs) _
                                Handles lvwList.MouseClick
        '+-------------------------------------------------------------------------------
        '| Description: When a user clicks on a listing in lvwList, this will display
        '|              the intended ad.
        '|
        '| Calls:       AdShow()
        '+-------------------------------------------------------------------------------

        AdShow()

    End Sub

    'Private Sub lvwList_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvwList.MouseMove
    '   'Ensures the tooltip is removed if no item is currently being hovered over.
    '    If lvwList.GetItemAt(e.X, e.Y) Is Nothing Then
    '        tipList.RemoveAll()
    '    End If
    'End Sub

    Private Sub txtMin_GotFocus(ByVal sender As Object, _
                                ByVal e As System.EventArgs) Handles txtMin.GotFocus
        '+-------------------------------------------------------------------------------
        '| Description: Clears txtMin when the user clicks into the box if there is not
        '|              a number currently entered.
        '+-------------------------------------------------------------------------------

        If txtMin.Text = "Min" Then
            txtMin.Text = String.Empty
            txtMin.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtMax_GotFocus(ByVal sender As Object, _
                                ByVal e As System.EventArgs) Handles txtMax.GotFocus
        '+-------------------------------------------------------------------------------
        '| Description: Clears txtMax when the user clicks into the box if there is not
        '|              a number currently entered.
        '+-------------------------------------------------------------------------------

        If txtMax.Text = "Max" Then
            txtMax.Text = String.Empty
            txtMax.ForeColor = Color.Black
        End If

    End Sub

    Private Sub txtMin_KeyPress(ByVal sender As Object, _
                                ByVal e As System.Windows.Forms.KeyPressEventArgs) _
                                Handles txtMin.KeyPress
        '+-------------------------------------------------------------------------------
        '| Description: Ensures only numbers, enter, or backspace can be input into 
        '|              txtMin. If enter is pressed a search is started.
        '|
        '| Calls:       btnSearch_Click
        '+-------------------------------------------------------------------------------

        e.Handled = Not Char.IsDigit(e.KeyChar) Xor Asc(e.KeyChar) = 8 _
                                Xor Asc(e.KeyChar) = 13

        If Asc(e.KeyChar) = 13 Then
            Call btnSearch_Click(sender, e)
        End If

    End Sub

    Private Sub txtMax_KeyPress(ByVal sender As Object, _
                                ByVal e As System.Windows.Forms.KeyPressEventArgs) _
                                Handles txtMax.KeyPress
        '+-------------------------------------------------------------------------------
        '| Description: Ensures only numbers, enter, or backspace may be input into 
        '|              txtMax. If enter is pressed a search is started.
        '|
        '| Calls:       btnSearch_Click
        '+-------------------------------------------------------------------------------

        e.Handled = Not Char.IsDigit(e.KeyChar) Xor Asc(e.KeyChar) = 8 _
                                Xor Asc(e.KeyChar) = 13

        If Asc(e.KeyChar) = 13 Then
            Call btnSearch_Click(sender, e)
        End If

    End Sub

    Private Sub txtMin_LostFocus(ByVal sender As Object, _
                                ByVal e As System.EventArgs) Handles txtMin.LostFocus
        '+-------------------------------------------------------------------------------
        '| Description: Sets txtMin to its initial value if the user clears the field
        '|              or does not enter anything.
        '|
        '| Called By:   btnClear_Click
        '+-------------------------------------------------------------------------------

        If txtMin.Text = String.Empty Then
            txtMin.ForeColor = Color.DarkGray
            txtMin.Text = "Min"
        End If

    End Sub

    Private Sub txtMax_LostFocus(ByVal sender As Object, _
                                ByVal e As System.EventArgs) Handles txtMax.LostFocus
        '+-------------------------------------------------------------------------------
        '| Description: Sets txtMax to its initial value if the user clears the field
        '|              or does not enter anything.
        '|
        '| Called By:   btnClear_Click
        '+-------------------------------------------------------------------------------

        If txtMax.Text = String.Empty Then
            txtMax.ForeColor = Color.DarkGray
            txtMax.Text = "Max"
        End If

    End Sub

    Private Sub llbBack_Click(ByVal sender As Object, _
                                ByVal e As System.EventArgs) Handles llbBack.Click
        '+-------------------------------------------------------------------------------
        '| Description: Hides pnlAd when the user is finished viewing an ad and then
        '|              returns focus to lvwList.
        '+-------------------------------------------------------------------------------

        pnlAd.Visible = False
        lvwList.Focus()

    End Sub

    Private Function fCheckValues() As Boolean
        '+-------------------------------------------------------------------------------
        '| Description: Checks the values entered into txtMin and txtMax, then compares
        '|              the two values. If the value entered into txtMin is greater
        '|              than the value of txtMax then it shows a message box which
        '|              instructs the user to confirm their values; this will also
        '|              cause the function to return false
        '+-------------------------------------------------------------------------------

        Dim sngMin As Single
        Dim sngMax As Single

        If txtMin.Text <> "Min" And txtMax.Text <> "Max" Then
            'Checks that both txtMin and txtMax are changed then converts them to singles
            sngMin = CSng(txtMin.Text)
            sngMax = CSng(txtMax.Text)

            If sngMin > sngMax Then 'Checks if sngMin is greater than sngMax.
                MessageBox.Show("PROTIP:" & Chr(13) & _
                                "When entering a price range, please ensure your " & _
                                "minimum price is lower than your maximum price.", _
                                "Invalid Price Range Entries")
                Return False
            Else
                Return True 'Returns True if sngMax is greater than sngMin.
            End If
        Else
            Return True 'Returns True if a sngMin or sngMax value are not set.
        End If

    End Function

    Private Sub btnSearch_Click(ByVal sender As Object, _
                                ByVal e As System.EventArgs) Handles btnSearch.Click
        '+-------------------------------------------------------------------------------
        '| Description: Populates lvwList with Ads if the program detects no issues.
        '|              First it will call fCheckValues() and if it's true, then the
        '|              procedure will continue to run. Next, it will ensure the Ads'
        '|              picture is returned to normal size. Finally, lvwList gains focus.
        '|
        '| Calls:       fCheckValues, ShrinkPicture, PopList
        '| Called By:   txtMin_KeyPress, txtMax_KeyPress
        '+-------------------------------------------------------------------------------

        If fCheckValues() = True Then
            pnlAd.Visible = False
            ShrinkPicture()
            PopList()
            lvwList.Focus()
        End If

    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, _
                                ByVal e As System.EventArgs) Handles btnClear.Click
        '+-------------------------------------------------------------------------------
        '| Description: Sets the Search Parameters back to their initial values but
        '|              does not affect the chosen sort method.
        '|
        '| Calls:       txtMin_LostFocus, txtMax_LostFocus
        '+-------------------------------------------------------------------------------

        lvwList.Items.Clear()
        pnlAd.Visible = False
        cmbCategorySelect.SelectedIndex = 0
        txtMin.Text = String.Empty
        Call txtMin_LostFocus(sender, e)
        txtMax.Text = String.Empty
        Call txtMax_LostFocus(sender, e)

    End Sub

    Private Sub ShrinkPicture()
        '+-------------------------------------------------------------------------------
        '| Description: Shrinks the picture back to it's "Normal" size
        '|                  
        '| Called By:   btnSearch_Click, picAdPicture_Click
        '+-------------------------------------------------------------------------------

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

    Private Sub picAdPicture_Click(ByVal sender As Object, _
                                ByVal e As System.EventArgs) Handles picAdPicture.Click
        '+-------------------------------------------------------------------------------
        '| Description: Enlarges or normalizes picAdPicture when clicked. If picture is
        '|              returned to normal size then changes focus to rtbAdText.
        '|                  
        '| Calls:       ShrinkPicture
        '+-------------------------------------------------------------------------------

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
            rtbAdText.Focus()
        End If

    End Sub

    Private Sub PopList()
        '+-------------------------------------------------------------------------------
        '| Description: Populates lvwList with ad information depending on which category
        '|              the user has selected.
        '|
        '| Calls:       sGetList
        '+-------------------------------------------------------------------------------

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

    Private Sub sGetList(ByVal Index As Short, ByRef CatArray() As String)
        '+-------------------------------------------------------------------------------
        '| Description: Filters through selected array passed from PopList and then
        '|              starts creating individual lines for each item. While 
        '|              creating individual lines an evaluation of the price occurs
        '|              to compare it with the user inputted price range. If the
        '|              price of an item cannot be converted to a number, it is then
        '|              assigned the maximum price the user has input.
        '|
        '| Called By:   PopList
        '+-------------------------------------------------------------------------------

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

    Private Sub cmbCategorySelect_SelectedIndexChanged(ByVal sender As Object, _
                                ByVal e As System.EventArgs) _
                                Handles cmbCategorySelect.SelectedIndexChanged
        '+-------------------------------------------------------------------------------
        '| Description: Clears lvwList when the user selects a new search category.
        '+-------------------------------------------------------------------------------

        lvwList.Items.Clear()

    End Sub

    Private Sub lvwList_ColumnWidthChanging(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnWidthChangingEventArgs) Handles lvwList.ColumnWidthChanging

        Dim intCol0 = lvwList.Columns(0).Width
        Dim intCol1 = lvwList.Columns(1).Width
        Dim intCol2 = lvwList.Columns(2).Width
        Dim intCol3 = lvwList.Columns(3).Width
        Dim intCol4 = lvwList.Columns(4).Width
        Dim intCol5 = lvwList.Columns(5).Width
        Dim intCol6 = lvwList.Columns(6).Width
        Dim intCol7 = lvwList.Columns(7).Width

        e.Cancel = True
        Select Case e.ColumnIndex
            Case 0
                e.NewWidth = intCol0
            Case 1
                e.NewWidth = intCol1
            Case 2
                e.NewWidth = intCol2
            Case 3
                e.NewWidth = intCol3
            Case 4
                e.NewWidth = intCol4
            Case 5
                e.NewWidth = intCol5
            Case 6
                e.NewWidth = intCol6
            Case 7
                e.NewWidth = intCol7
        End Select
    End Sub

    Private Sub cmbSortOrder_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSortOrder.SelectedIndexChanged
        ' Index 0 = Sort by Name A-Z
        ' Index 1 = Sort by Name Z-A
        ' Index 2 = Sort Category A-Z
        ' Index 3 = Sort Category Z-A
        ' Index 4 = Sort Price Low - High
        ' Index 5 = Sort Price High - Low

        If cmbSortOrder.SelectedIndex = 0 Then
            lvwList.Sorting = SortOrder.Ascending
            PerformSortOnColumn(0)
        ElseIf cmbSortOrder.SelectedIndex = 1 Then
            lvwList.Sorting = SortOrder.Descending
            PerformSortOnColumn(0)
        ElseIf cmbSortOrder.SelectedIndex = 2 Then
            lvwList.Sorting = SortOrder.Ascending
            PerformSortOnColumn(1)
        ElseIf cmbSortOrder.SelectedIndex = 3 Then
            lvwList.Sorting = SortOrder.Descending
            PerformSortOnColumn(1)
        ElseIf cmbSortOrder.SelectedIndex = 4 Then
            lvwList.Sorting = SortOrder.Ascending
            PerformSortOnColumn(3)
        ElseIf cmbSortOrder.SelectedIndex = 5 Then
            lvwList.Sorting = SortOrder.Descending
            PerformSortOnColumn(3)
        End If
    End Sub

    Private Sub SortTimsListByColumn(ByVal column As Integer)

        If CurrentSortColumn = column Then
            If lvwList.Sorting = SortOrder.Descending Then
                lvwList.Sorting = SortOrder.Ascending
            Else
                lvwList.Sorting = SortOrder.Descending
            End If
        Else
            lvwList.Sorting = SortOrder.Ascending
        End If

        PerformSortOnColumn(column)
    End Sub

    Private Sub PerformSortOnColumn(ByVal column As Integer)
        CurrentSortColumn = column
        If column = 3 Then
            lvwList.ListViewItemSorter = New listViewSorterByAmount(column, lvwList.Sorting)
        Else
            lvwList.ListViewItemSorter = New listViewSorterByString(column, lvwList.Sorting)
        End If
        lvwList.Sort()
    End Sub

    ' This code allows the columns within lvwList to be Sorted back and forth between Ascending and Descending order.

    Private Sub lvwList_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwList.ColumnClick
        SortTimsListByColumn(e.Column)
    End Sub

End Class
'
' Description Block set to 90 Columns when autotabbed
'+-------------------------------------------------------------------------------
'| Description: 
'|                  
'+-------------------------------------------------------------------------------
