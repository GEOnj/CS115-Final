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

        'Test Setup for List View Columns.
        ' ...Add(Description as String, Width in Pixels, Alignment)
        lvwTest.Columns.Add("Item Name", 200, HorizontalAlignment.Left)
        lvwTest.Columns.Add("Category", 150, HorizontalAlignment.Center)
        lvwTest.Columns.Add("Short Description", 500, HorizontalAlignment.Left)
        lvwTest.Columns.Add("Price", 90, HorizontalAlignment.Left)


        Dim item1 As New ListViewItem("Alienware MX11", 0)
        item1.SubItems.Add("Laptop (Computers)")
        item1.SubItems.Add("High-end gaming computer at a discount.")
        item1.SubItems.Add(Chr(36) & "775.00")

        lvwTest.Items.Add(item1)

        Dim item2 As New ListViewItem("Ford Model T", 1)
        item2.SubItems.Add("Automobiles")
        item2.SubItems.Add("The original mass-produced motor vehicle!")
        item2.SubItems.Add(Chr(36) & "20000.00")

        lvwTest.Items.Add(item2)

        'Test Data for pnlAd

        lblAdItem.Text = "Alienware MX11"
        picAdPicture.Image = Image.FromFile("../../My Project/DataFiles/lienware.jpg")
        picAdPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
                picComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        'FileOpen(1, "../../My Project/DataFiles/lienware.tlf", OpenMode.Input)
        rtbAdText.Text = File.ReadAllText("../../My Project/DataFiles/lienware.tlf")
        'FileClose(1)

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