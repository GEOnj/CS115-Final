Imports Microsoft.VisualBasic

Public Class listViewSorterByString
    Implements IComparer

    Private intSortColumn As Integer = 0
    Private columnSortOrder As SortOrder

    Public Sub New(ByVal columnNumber As Integer, ByVal colSortOrder As SortOrder)
        intSortColumn = columnNumber
        columnSortOrder = colSortOrder
    End Sub

    ' This function compares the item data within the columns of lvwList specifically the String datatypes
    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
        Dim item1, item2 As ListViewItem
        item1 = CType(x, ListViewItem)
        item2 = CType(y, ListViewItem)

        Dim strCompareValueOne As String
        Dim strCompareValueTwo As String

        If intSortColumn > 0 Then
            strCompareValueOne = item1.SubItems(intSortColumn).Text.ToUpper()
            strCompareValueTwo = item2.SubItems(intSortColumn).Text.ToUpper()
        Else
            strCompareValueOne = item1.Text.ToUpper()
            strCompareValueTwo = item2.Text.ToUpper()
        End If


        If columnSortOrder = SortOrder.Ascending Then
            ' If the sort column is greater than ZERO then we are sorting based on a subitem, not the main column
            Return String.Compare(strCompareValueOne, strCompareValueTwo)
        Else
            ' If the sort column is greater than ZERO then we are sorting based on a subitem, not the main column
            Return String.Compare(strCompareValueTwo, strCompareValueOne)
        End If

    End Function
End Class

Public Class listViewSorterByAmount
    Implements IComparer

    Private intSortColumn As Integer = 0
    Private columnSortOrder As SortOrder

    Public Sub New(ByVal columnNumber As Integer, ByVal colSortOrder As SortOrder)
        intSortColumn = columnNumber
        columnSortOrder = colSortOrder
    End Sub

    ' This function compares the item data within the columns of lvwList specifically the  datatypes
    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
        Dim item1, item2 As ListViewItem
        item1 = CType(x, ListViewItem)
        item2 = CType(y, ListViewItem)

        Dim dblCompareValueOne As Double = 0
        Dim dblCompareValueTwo As Double = 0

        If intSortColumn > 0 Then
            If IsNumeric(item1.SubItems(intSortColumn).Text) = True Then
                dblCompareValueOne = CDbl(item1.SubItems(intSortColumn).Text)
            End If
            If IsNumeric(item2.SubItems(intSortColumn).Text) = True Then
                dblCompareValueTwo = CDbl(item2.SubItems(intSortColumn).Text)
            End If
        Else
            If IsNumeric(item1.Text) = True Then
                dblCompareValueOne = CDbl(item1.Text)
            End If
            If IsNumeric(item2.Text) = True Then
                dblCompareValueTwo = CDbl(item2.Text)
            End If
        End If


        If columnSortOrder = SortOrder.Ascending Then
            ' If the sort column is greater than ZERO then we are sorting based on a subitem, not the main column
            If dblCompareValueOne > dblCompareValueTwo Then
                Return 1
            ElseIf dblCompareValueOne = dblCompareValueTwo Then
                Return 0
            Else
                Return -1
            End If
        Else
            ' If the sort column is greater than ZERO then we are sorting based on a subitem, not the main column
            If dblCompareValueOne < dblCompareValueTwo Then
                Return 1
            ElseIf dblCompareValueOne = dblCompareValueTwo Then
                Return 0
            Else
                Return -1
            End If
        End If

    End Function
End Class
