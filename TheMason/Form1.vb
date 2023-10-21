Imports System.Data.OleDb
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Protected Sub SearchData_Click(sender As Object, e As EventArgs)

        If OrderID.Text = "" Then
            MsgBox("Please Enter An Order ID")

        Else
            If IsNumeric(OrderID.Text) Then
                Using Con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\STEPHEN\Documents\TheMason.accdb")
                    Using cmd As New OleDbCommand("Select * from Orders WHERE Offer_ID = " + OrderID.Text, Con)

                        Dim da As New OleDbDataAdapter(cmd)
                        Dim dt As New DataTable()
                        da.Fill(dt)

                        If dt.Rows.Count > 0 Then

                        Else

                        End If

                    End Using
                End Using

            Else
                MsgBox("The Value you have entered is not numeric value")
            End If


        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.OrdersTableAdapter.Fill(Me.TheMasonDataSet.Orders)
    End Sub


    Private Sub Previous_Click(sender As Object, e As EventArgs) Handles Previous.Click
        OrdersBindingSource.MovePrevious()
    End Sub

    Private Sub Add_Data_Click(sender As Object, e As EventArgs) Handles Add_Data.Click
        OrdersBindingSource.AddNew()
    End Sub

    Private Sub NextPage_Click(sender As Object, e As EventArgs) Handles NextPage.Click
        OrdersBindingSource.MoveNext()
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Try
            Me.OrdersBindingSource.EndEdit()
            Me.OrdersTableAdapter.Update(Me.TheMasonDataSet.Orders)
            MsgBox("Record Saved Successfully")
        Catch ErrorOccured As Exception
            MsgBox(ErrorOccured)
            Exit Sub
        End Try
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        Me.Dispose()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub
End Class
