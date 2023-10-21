Public Class Form1
    Private Sub OrdersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles OrdersBindingNavigatorSaveItem.Click

        Dim Validation As Boolean = Me.Validate()

        If Validation Then

            Try

                Me.OrdersBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.TheMasonDataSet)
                MsgBox("Record Saved Successfully")
                OrdersBindingSource.MoveLast()

            Catch ex As Exception

                MsgBox(ex.ToString())
                Me.OrdersTableAdapter.Fill(Me.TheMasonDataSet.Orders)

            End Try

        End If

        If OrderIDTextBox.Text = "" Then
            MsgBox("Order ID Field is  Required")
        End If

        If IsNumeric(OrderIDTextBox.Text) <> True And OrderIDTextBox.Text <> "" Then
            MsgBox("The Value you have Entered is not A numeric Value")
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TheMasonDataSet.Orders' table. You can move, or remove it, as needed.
        Me.OrdersTableAdapter.Fill(Me.TheMasonDataSet.Orders)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub AddressTextBox_TextChanged(sender As Object, e As EventArgs) Handles AddressTextBox.TextChanged

    End Sub

    Private Sub Previous_Click(sender As Object, e As EventArgs) Handles Previous.Click
        OrdersBindingSource.MovePrevious()
    End Sub

    Private Sub NextData_Click(sender As Object, e As EventArgs) Handles NextData.Click
        OrdersBindingSource.MoveNext()
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click

        Dim Validation As Boolean = Me.Validate()

        If Validation Then

            Try

                Me.OrdersBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.TheMasonDataSet)
                MsgBox("Record Saved Successfully")
                OrdersBindingSource.MoveLast()

            Catch ex As Exception

                MsgBox(ex.ToString())
                Me.OrdersTableAdapter.Fill(Me.TheMasonDataSet.Orders)

            End Try

        End If

        If OrderIDTextBox.Text = "" Then
            MsgBox("Order ID Field is  Required")
        End If

        If IsNumeric(OrderIDTextBox.Text) <> True And OrderIDTextBox.Text <> "" Then
            MsgBox("The Value you have Entered is not A numeric Value")
        End If


    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        If OrdersBindingSource.Count < 1 Then
            MsgBox("No Record Found")
        Else
            Me.OrdersBindingSource.RemoveCurrent()
            Me.TableAdapterManager.UpdateAll(Me.TheMasonDataSet)
            MsgBox("Record Delete Successfully")
        End If

    End Sub


    Private Sub FilterByOrderID_Click(sender As Object, e As EventArgs) Handles FilterByOrderID.Click
        If OrderIDFilterValue.Text = "" Then
            MsgBox("Please Enter An Order ID to Search")
        Else
            OrdersBindingSource.Filter = "OrderID = " + OrderIDFilterValue.Text
        End If
    End Sub
End Class