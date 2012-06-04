'-=======================================================================================
'| Generic Header
'|
'|
'|
'+=======================================================================================
'|
'|  Known Bugs: The buttons, they do nothing!
'|
'|
'|
'|
'|
'+=======================================================================================
'|
'|  To Do: Everything...
'|
'|
'|
'+=======================================================================================

Option Strict On
Option Explicit On

Imports System.IO

Public Class frmTimsList

    Private Sub TimsList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Const shtOUTER_MARGIN As Short = 10
        Const shtINNER_MARGIN As Short = 5
        Const shtBORDER As Short = 2

        ' Description:
        '  Sets locations of objects definitively

        picDoggie.Left = shtOUTER_MARGIN
        picDoggie.Top = shtOUTER_MARGIN

        lblTimsList.Left = picDoggie.Left + picDoggie.Width
        lblTimsList.Top = shtOUTER_MARGIN

        picComputer.Left = lblTimsList.Left + lblTimsList.Width
        picComputer.Top = shtOUTER_MARGIN
        'May Need to add Marquee information here...

        'Creates a neat "highlighting" effect of the title
        lblTimsListOverlay.Parent = lblTimsList
        lblTimsListOverlay.Top = 1
        lblTimsListOverlay.Left = 1

        'Sets individual locations of objects inside of pnlSearch
        cmbCategorySelect.Top = shtINNER_MARGIN
        'Causes the combo box to default to the text, "Select a Category!"
        cmbCategorySelect.SelectedIndex = 0

        'Sets pnlSearch size according to inner objects, also location of pnlSearch.
        pnlSearch.Top = shtOUTER_MARGIN + picDoggie.Height + shtINNER_MARGIN
        pnlSearch.Left = shtOUTER_MARGIN
        pnlSearch.Width = Me.ClientSize.Width - shtOUTER_MARGIN * 2
        pnlSearch.Height = cmbCategorySelect.Height + shtINNER_MARGIN * 2 + shtBORDER

        'Sets lvwList location
        lvwList.Top = pnlSearch.Top + pnlSearch.Height + shtINNER_MARGIN
        lvwList.Left = shtOUTER_MARGIN
        lvwList.Width = Me.ClientSize.Width - shtOUTER_MARGIN * 2
        lvwList.Height = Me.ClientSize.Height - shtOUTER_MARGIN * 2 - shtINNER_MARGIN * 2 - pnlSearch.Height - picDoggie.Height




        'Test Setup for List View Columns.
        ' ...Add(Description as String, Width in Pixels, Alignment)
        lvwList.Columns.Add("Item Name", 220, HorizontalAlignment.Left)
        lvwList.Columns.Add("Category", 170, HorizontalAlignment.Center)
        lvwList.Columns.Add("Short Description", 500, HorizontalAlignment.Left)
        lvwList.Columns.Add("Price", 100, HorizontalAlignment.Left)
        lvwList.Columns.Add("Long Description", 0)
        lvwList.Columns.Add("Picture Filename", 0)


        Dim item1 As New ListViewItem("Alienware MX11", 0)
        item1.SubItems.Add("Laptop (Computers)")
        item1.SubItems.Add("High-end gaming computer at a discount.")
        item1.SubItems.Add(Chr(36) & "775.00")
        item1.SubItems.Add("ASDFASDFASDFASDFASDFASDFSAf")
        item1.SubItems.Add("lienware.jpg")

        lvwList.Items.Add(item1)

        Dim item2 As New ListViewItem("Ford Model T", 1)
        item2.SubItems.Add("Automobiles")
        item2.SubItems.Add("The original mass-produced motor vehicle!")
        item2.SubItems.Add(Chr(36) & "20000.00")
        item2.SubItems.Add("a46246856t5A#EG")
        item2.SubItems.Add("modelt.jpg")

        lvwList.Items.Add(item2)

        'Test Data for pnlAd

        lblAdItem.Text = "Alienware MX11"
        picAdPicture.Image = Image.FromFile("../../My Project/DataFiles/lienware.jpg")
        picAdPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        picComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        rtbAdText.Text = File.ReadAllText("../../My Project/DataFiles/lienware.tlf")

    End Sub


    Private Sub lvwList_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvwList.MouseClick
        'Test output for selecting an item and updating pnlAd objects with correct information.
        lblAdItem.Text = lvwList.SelectedItems.Item(0).Text
        rtbAdText.Text = "Category:" & lvwList.SelectedItems.Item(0).SubItems(1).Text & Chr(13) & Chr(13) & _
            "'Long' Description:" & Chr(13) & lvwList.SelectedItems.Item(0).SubItems(4).Text & Chr(13) & Chr(13) & _
            "Price: " & lvwList.SelectedItems.Item(0).SubItems(3).Text
        picAdPicture.Image = Image.FromFile("../../My Project/DataFiles/" & lvwList.SelectedItems.Item(0).SubItems(5).Text)
        pnlAd.Visible = True
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

    Private Sub btnFindIt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFindIt.Click
        'Will eventually sort through data files and display to lvwList appropriate information.
        'Also, hides pnlAd in case if user changes their mind about the type of product they're interested in.
        'Currently outputs to rtbTest as String data.

        rtbTest.Text = "Searched>>>" & Chr(13) & "Category: " & cmbCategorySelect.SelectedItem.ToString & Chr(9) & "Min Price: " & txtMin.Text & Chr(9) & "Max Price: " & txtMax.Text
        pnlAd.Visible = False

    End Sub

    Private Sub btnClearSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClearSearch.Click
        'Sets the search values back to their defaults values. Does not affect sorting.
        'Calls txtMin_LostFocus and txtMax_LostFocus

        cmbCategorySelect.SelectedIndex = 0
        txtMin.Text = String.Empty
        Call txtMin_LostFocus(sender, e)
        txtMax.Text = String.Empty
        Call txtMax_LostFocus(sender, e)
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
'    Dim item1 As New ListViewItem("item1", 0)
'    ' Place a check mark next to the item.
'    item1.Checked = True
'    item1.SubItems.Add("1")
'    item1.SubItems.Add("2")
'    item1.SubItems.Add("3")
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
'    listView1.Items.AddRange(New ListViewItem() {item1, item2, item3})

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