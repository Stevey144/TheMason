<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OrderID = New System.Windows.Forms.TextBox()
        Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TheMasonDataSet = New TheMason.TheMasonDataSet()
        Me.RecordCount = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Previous = New System.Windows.Forms.Button()
        Me.Add_Data = New System.Windows.Forms.Button()
        Me.NextPage = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Close = New System.Windows.Forms.Button()
        Me.OrdersTableAdapter = New TheMason.TheMasonDataSetTableAdapters.OrdersTableAdapter()
        Me.TableAdapterManager = New TheMason.TheMasonDataSetTableAdapters.TableAdapterManager()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TheMasonDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = " Order ID"
        '
        'OrderID
        '
        Me.OrderID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "OrderID", True))
        Me.OrderID.Location = New System.Drawing.Point(112, 31)
        Me.OrderID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OrderID.Multiline = True
        Me.OrderID.Name = "OrderID"
        Me.OrderID.Size = New System.Drawing.Size(140, 39)
        Me.OrderID.TabIndex = 6
        '
        'OrdersBindingSource
        '
        Me.OrdersBindingSource.DataMember = "Orders"
        Me.OrdersBindingSource.DataSource = Me.TheMasonDataSet
        '
        'TheMasonDataSet
        '
        Me.TheMasonDataSet.DataSetName = "TheMasonDataSet"
        Me.TheMasonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RecordCount
        '
        Me.RecordCount.AutoSize = True
        Me.RecordCount.Location = New System.Drawing.Point(405, 50)
        Me.RecordCount.Name = "RecordCount"
        Me.RecordCount.Size = New System.Drawing.Size(0, 20)
        Me.RecordCount.TabIndex = 9
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "FirstName", True))
        Me.TextBox1.Location = New System.Drawing.Point(234, 93)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(175, 46)
        Me.TextBox1.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(424, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "LastName"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(234, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "FirstName"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "LastName", True))
        Me.TextBox2.Location = New System.Drawing.Point(424, 93)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(185, 46)
        Me.TextBox2.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(831, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Record Date"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "RecordDate", True))
        Me.TextBox3.Location = New System.Drawing.Point(964, 77)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(208, 44)
        Me.TextBox3.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(112, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Title"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "CompanyName", True))
        Me.TextBox4.Location = New System.Drawing.Point(112, 164)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(497, 36)
        Me.TextBox4.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(112, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 20)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Address"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(108, 460)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 20)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Mobile"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(831, 148)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 20)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Grave Owner"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(833, 204)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(125, 20)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Application Sent"
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "PlanGone", True))
        Me.TextBox6.Location = New System.Drawing.Point(1126, 176)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(170, 46)
        Me.TextBox6.TabIndex = 27
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Address", True))
        Me.TextBox7.Location = New System.Drawing.Point(186, 223)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(418, 36)
        Me.TextBox7.TabIndex = 29
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(831, 356)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 20)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Paid Date"
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Address3", True))
        Me.TextBox8.Location = New System.Drawing.Point(186, 351)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(418, 41)
        Me.TextBox8.TabIndex = 31
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(831, 252)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 20)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Inscription"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(21, 318)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(0, 20)
        Me.Label16.TabIndex = 34
        Me.Label16.Tag = "Contact Person"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(102, 394)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 20)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "Town-City"
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Address1", True))
        Me.TextBox10.Location = New System.Drawing.Point(186, 263)
        Me.TextBox10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox10.Multiline = True
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(418, 42)
        Me.TextBox10.TabIndex = 36
        '
        'TextBox11
        '
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Town", True))
        Me.TextBox11.Location = New System.Drawing.Point(106, 416)
        Me.TextBox11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox11.Multiline = True
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(297, 42)
        Me.TextBox11.TabIndex = 38
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(833, 289)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 20)
        Me.Label19.TabIndex = 39
        Me.Label19.Text = "Sundries"
        '
        'TextBox13
        '
        Me.TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Address2", True))
        Me.TextBox13.Location = New System.Drawing.Point(186, 309)
        Me.TextBox13.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox13.Multiline = True
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(418, 38)
        Me.TextBox13.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(338, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 20)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = " Order Details"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "OrderDetails", True))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(502, 28)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(252, 28)
        Me.ComboBox2.TabIndex = 44
        '
        'ComboBox3
        '
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Title", True))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(112, 93)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(107, 28)
        Me.ComboBox3.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(104, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 20)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Company Name"
        '
        'TextBox14
        '
        Me.TextBox14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "PostCode", True))
        Me.TextBox14.Location = New System.Drawing.Point(409, 416)
        Me.TextBox14.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox14.Multiline = True
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(195, 44)
        Me.TextBox14.TabIndex = 47
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(405, 394)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 20)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Post Code"
        '
        'TextBox15
        '
        Me.TextBox15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Mobile", True))
        Me.TextBox15.Location = New System.Drawing.Point(112, 482)
        Me.TextBox15.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox15.Multiline = True
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(258, 42)
        Me.TextBox15.TabIndex = 49
        '
        'TextBox16
        '
        Me.TextBox16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "HomeNo", True))
        Me.TextBox16.Location = New System.Drawing.Point(375, 482)
        Me.TextBox16.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox16.Multiline = True
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(234, 42)
        Me.TextBox16.TabIndex = 50
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(371, 460)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 20)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "Home No"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(108, 526)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(70, 20)
        Me.Label20.TabIndex = 52
        Me.Label20.Text = "Work No"
        '
        'TextBox17
        '
        Me.TextBox17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "WorkNo", True))
        Me.TextBox17.Location = New System.Drawing.Point(108, 548)
        Me.TextBox17.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox17.Multiline = True
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(258, 42)
        Me.TextBox17.TabIndex = 53
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(377, 526)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(48, 20)
        Me.Label21.TabIndex = 54
        Me.Label21.Text = "Email"
        '
        'TextBox18
        '
        Me.TextBox18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Email", True))
        Me.TextBox18.Location = New System.Drawing.Point(381, 548)
        Me.TextBox18.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox18.Multiline = True
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(228, 42)
        Me.TextBox18.TabIndex = 55
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.OrdersBindingSource, "GraveOwner", True))
        Me.CheckBox1.Location = New System.Drawing.Point(1016, 149)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(22, 21)
        Me.CheckBox1.TabIndex = 56
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.OrdersBindingSource, "PlanYn", True))
        Me.CheckBox2.Location = New System.Drawing.Point(1016, 203)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(22, 21)
        Me.CheckBox2.TabIndex = 57
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OrdersBindingSource, "Inscription", True))
        Me.NumericUpDown1.DecimalPlaces = 2
        Me.NumericUpDown1.Location = New System.Drawing.Point(1016, 263)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(110, 26)
        Me.NumericUpDown1.TabIndex = 58
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OrdersBindingSource, "Sundries", True))
        Me.NumericUpDown2.DecimalPlaces = 2
        Me.NumericUpDown2.Location = New System.Drawing.Point(1016, 293)
        Me.NumericUpDown2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(110, 26)
        Me.NumericUpDown2.TabIndex = 59
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "DatePaid", True))
        Me.TextBox5.Location = New System.Drawing.Point(1103, 338)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(193, 54)
        Me.TextBox5.TabIndex = 60
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.OrdersBindingSource, "Paid", True))
        Me.CheckBox3.Location = New System.Drawing.Point(1016, 355)
        Me.CheckBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(22, 21)
        Me.CheckBox3.TabIndex = 61
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Previous
        '
        Me.Previous.Location = New System.Drawing.Point(128, 595)
        Me.Previous.Name = "Previous"
        Me.Previous.Size = New System.Drawing.Size(124, 37)
        Me.Previous.TabIndex = 62
        Me.Previous.Text = "Previous"
        Me.Previous.UseVisualStyleBackColor = True
        '
        'Add_Data
        '
        Me.Add_Data.Location = New System.Drawing.Point(424, 595)
        Me.Add_Data.Name = "Add_Data"
        Me.Add_Data.Size = New System.Drawing.Size(124, 37)
        Me.Add_Data.TabIndex = 63
        Me.Add_Data.Text = "Add New"
        Me.Add_Data.UseVisualStyleBackColor = True
        '
        'NextPage
        '
        Me.NextPage.Location = New System.Drawing.Point(285, 595)
        Me.NextPage.Name = "NextPage"
        Me.NextPage.Size = New System.Drawing.Size(124, 37)
        Me.NextPage.TabIndex = 64
        Me.NextPage.Text = "Next "
        Me.NextPage.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(570, 595)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(124, 37)
        Me.Save.TabIndex = 65
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Location = New System.Drawing.Point(128, 638)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(124, 37)
        Me.Delete.TabIndex = 66
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Close
        '
        Me.Close.Location = New System.Drawing.Point(285, 638)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(124, 37)
        Me.Close.TabIndex = 67
        Me.Close.Text = "Close"
        Me.Close.UseVisualStyleBackColor = True
        '
        'OrdersTableAdapter
        '
        Me.OrdersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.OrdersTableAdapter = Me.OrdersTableAdapter
        Me.TableAdapterManager.UpdateOrder = TheMason.TheMasonDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1410, 779)
        Me.Controls.Add(Me.Close)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.NextPage)
        Me.Controls.Add(Me.Add_Data)
        Me.Controls.Add(Me.Previous)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TextBox18)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.TextBox17)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBox16)
        Me.Controls.Add(Me.TextBox15)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RecordCount)
        Me.Controls.Add(Me.OrderID)
        Me.Controls.Add(Me.Label3)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TheMasonDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents OrderID As TextBox
    Friend WithEvents RecordCount As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents Previous As Button
    Friend WithEvents Add_Data As Button
    Friend WithEvents NextPage As Button
    Friend WithEvents Save As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Close As Button
    Friend WithEvents TheMasonDataSet As TheMasonDataSet
    Friend WithEvents OrdersBindingSource As BindingSource
    Friend WithEvents OrdersTableAdapter As TheMasonDataSetTableAdapters.OrdersTableAdapter
    Friend WithEvents TableAdapterManager As TheMasonDataSetTableAdapters.TableAdapterManager
End Class
