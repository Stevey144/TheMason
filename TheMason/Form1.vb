Imports System.Globalization.CultureInfo
Public Class Form1
    Private Sub OrdersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles OrdersBindingNavigatorSaveItem.Click

        Dim Validation As Boolean = Me.Validate()

        If Validation Then

            Try

                Me.OrdersBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.TheMasonDataSet)
                MsgBox("Record Saved Successfully")
                TheMasonDataSet.Clear()
                Me.OrdersTableAdapter.Fill(Me.TheMasonDataSet.Orders)
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

        Dim combo As List(Of String) = New List(Of String)()

        combo.Add("MR")
        combo.Add("MRS")

        ComboBox1.Items.Add(combo)

        ComboBox1.DisplayMember = "ToString"
        ComboBox1.DataSource = combo

        Me.OrdersTableAdapter.Fill(Me.TheMasonDataSet.Orders)


        Dim selectedValues = ""

        If OrdersBindingSource.Count > 0 Then
            If ComboBox1.SelectedItem = "" Then
                ComboBox1.SelectedIndex = 0
            Else
                selectedValues = ComboBox1.SelectedItem.ToString()
            End If
        End If



        If combo.Contains(selectedValues) Then
            ComboBox1.SelectedItem = selectedValues
        Else
            ComboBox1.SelectedIndex = 0
        End If

        txtWeeks.Text = "7"

        If OrdersBindingSource.Count < 1 Then
            OrdersBindingSource.AddNew()
        End If

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
                TheMasonDataSet.Clear()
                Me.OrdersTableAdapter.Fill(Me.TheMasonDataSet.Orders)
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

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        If (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
            OrdersBindingSource.RemoveCurrent()
            Try
                Me.Validate()
                OrdersBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(Me.TheMasonDataSet)
                MessageBox.Show("The record has been deleted.")
                If OrdersBindingSource.Count < 1 Then
                    MessageBox.Show("USE THE PLUS ICON (+) ON THE NAVIGATOR TO ADD A NEW RECORD.")
                End If
                OrdersBindingSource.AddNew()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub
End Class