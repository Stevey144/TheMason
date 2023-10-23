Imports System.Globalization.CultureInfo
Public Class Form1
    Private Sub OrdersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles OrdersBindingNavigatorSaveItem.Click

        Dim Validation As Boolean = Me.Validate()

        If Validation Then

            Try

                Me.OrdersBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.TheMasonDataSet)
                MsgBox("Record Saved Successfully")
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
        txtWeeks.Text = "7"
    End Sub


    Private Sub Previous_Click(sender As Object, e As EventArgs) Handles Previous.Click
        OrdersBindingSource.MovePrevious()
    End Sub

    Private Sub NextData_Click(sender As Object, e As EventArgs) Handles NextData.Click
        OrdersBindingSource.MoveNext()
    End Sub

    Protected Sub ReloadData()
        Me.OrdersTableAdapter.Fill(Me.TheMasonDataSet.Orders)
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click

        Dim Validation As Boolean = Me.Validate()

        If Validation Then

            Try

                Me.OrdersBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.TheMasonDataSet)
                MsgBox("Record Saved Successfully")

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
            Me.Controls.Clear()
            InitializeComponent()
            Form1_Load(sender, e)
            MsgBox("Please Enter An Order ID to Search")
            Refresh()
        Else
            If IsNumeric(OrderIDFilterValue.Text) Then
                OrdersBindingSource.Filter = "OrderID = " + OrderIDFilterValue.Text
            Else
                MsgBox("The Value you have entered is not a numeric value")
            End If
        End If
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        Application.Exit()
    End Sub


    Private Sub InscriptionTextBox_MouseDown(sender As Object, e As MouseEventArgs) Handles InscriptionTextBox.MouseDown
        ToolTip2.Show("0.00", InscriptionTextBox)
    End Sub

    Private Sub SundriesTextBox_MouseDown(sender As Object, e As MouseEventArgs) Handles SundriesTextBox.MouseDown
        ToolTip3.Show("0.00", SundriesTextBox)
    End Sub

    Private Sub txtWeeks_Leave(sender As Object, e As EventArgs) Handles txtWeeks.Leave
        Dim getRecordDate As DateTime = DateTime.Parse(RecordDateDateTimePicker.Text)
        txtNewDate.Text = getRecordDate.AddDays(49)
    End Sub

End Class