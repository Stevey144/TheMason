Public Class Form1
    Private Sub OrdersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles OrdersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OrdersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TheMasonDataSet)

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
        Me.Validate()
        Me.OrdersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TheMasonDataSet)
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        If OrdersBindingSource.Count < 1 Then
            MsgBox("No Record Found")
        Else
            Me.OrdersBindingSource.RemoveCurrent()
        End If

    End Sub

End Class