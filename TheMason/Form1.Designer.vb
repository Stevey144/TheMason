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
        Dim OrderIDLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim CompanyNameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim TownLabel As System.Windows.Forms.Label
        Dim PostCodeLabel As System.Windows.Forms.Label
        Dim MobileLabel As System.Windows.Forms.Label
        Dim HomeNoLabel As System.Windows.Forms.Label
        Dim WorkNoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim RecordDateLabel As System.Windows.Forms.Label
        Dim OrderDetailsLabel As System.Windows.Forms.Label
        Dim GraveOwnerLabel As System.Windows.Forms.Label
        Dim PlanYnLabel As System.Windows.Forms.Label
        Dim PlanGoneLabel As System.Windows.Forms.Label
        Dim InscriptionLabel As System.Windows.Forms.Label
        Dim SundriesLabel As System.Windows.Forms.Label
        Dim PaidLabel As System.Windows.Forms.Label
        Dim DatePaidLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TheMasonDataSet = New TheMason.TheMasonDataSet()
        Me.lblNewDate = New System.Windows.Forms.Label()
        Me.txtNewDate = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtWeeks = New System.Windows.Forms.TextBox()
        Me.Close = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.NextData = New System.Windows.Forms.Button()
        Me.Previous = New System.Windows.Forms.Button()
        Me.OrderIDTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.CompanyNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Address1TextBox = New System.Windows.Forms.TextBox()
        Me.Address2TextBox = New System.Windows.Forms.TextBox()
        Me.Address3TextBox = New System.Windows.Forms.TextBox()
        Me.TownTextBox = New System.Windows.Forms.TextBox()
        Me.PostCodeTextBox = New System.Windows.Forms.TextBox()
        Me.MobileTextBox = New System.Windows.Forms.TextBox()
        Me.HomeNoTextBox = New System.Windows.Forms.TextBox()
        Me.WorkNoTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.RecordDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.OrderDetailsTextBox = New System.Windows.Forms.TextBox()
        Me.GraveOwnerCheckBox = New System.Windows.Forms.CheckBox()
        Me.PlanYnCheckBox = New System.Windows.Forms.CheckBox()
        Me.PlanGoneDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.InscriptionTextBox = New System.Windows.Forms.TextBox()
        Me.SundriesTextBox = New System.Windows.Forms.TextBox()
        Me.PaidCheckBox = New System.Windows.Forms.CheckBox()
        Me.DatePaidDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.OrdersTableAdapter = New TheMason.TheMasonDataSetTableAdapters.OrdersTableAdapter()
        Me.TableAdapterManager = New TheMason.TheMasonDataSetTableAdapters.TableAdapterManager()
        Me.OrdersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.OrdersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.FilterByOrderID = New System.Windows.Forms.Button()
        Me.OrderIDFilterValue = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        OrderIDLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        CompanyNameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        TownLabel = New System.Windows.Forms.Label()
        PostCodeLabel = New System.Windows.Forms.Label()
        MobileLabel = New System.Windows.Forms.Label()
        HomeNoLabel = New System.Windows.Forms.Label()
        WorkNoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        RecordDateLabel = New System.Windows.Forms.Label()
        OrderDetailsLabel = New System.Windows.Forms.Label()
        GraveOwnerLabel = New System.Windows.Forms.Label()
        PlanYnLabel = New System.Windows.Forms.Label()
        PlanGoneLabel = New System.Windows.Forms.Label()
        InscriptionLabel = New System.Windows.Forms.Label()
        SundriesLabel = New System.Windows.Forms.Label()
        PaidLabel = New System.Windows.Forms.Label()
        DatePaidLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TheMasonDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OrdersBindingNavigator.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OrderIDLabel
        '
        OrderIDLabel.AutoSize = True
        OrderIDLabel.Location = New System.Drawing.Point(26, 50)
        OrderIDLabel.Name = "OrderIDLabel"
        OrderIDLabel.Size = New System.Drawing.Size(74, 20)
        OrderIDLabel.TabIndex = 0
        OrderIDLabel.Text = "Order ID:"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(26, 107)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(42, 20)
        TitleLabel.TabIndex = 2
        TitleLabel.Text = "Title:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(262, 107)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(90, 20)
        FirstNameLabel.TabIndex = 4
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(493, 107)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(90, 20)
        LastNameLabel.TabIndex = 6
        LastNameLabel.Text = "Last Name:"
        '
        'CompanyNameLabel
        '
        CompanyNameLabel.AutoSize = True
        CompanyNameLabel.Location = New System.Drawing.Point(26, 189)
        CompanyNameLabel.Name = "CompanyNameLabel"
        CompanyNameLabel.Size = New System.Drawing.Size(126, 20)
        CompanyNameLabel.TabIndex = 8
        CompanyNameLabel.Text = "Company Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(26, 297)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(72, 20)
        AddressLabel.TabIndex = 10
        AddressLabel.Text = "Address:"
        '
        'TownLabel
        '
        TownLabel.AutoSize = True
        TownLabel.Location = New System.Drawing.Point(26, 491)
        TownLabel.Name = "TownLabel"
        TownLabel.Size = New System.Drawing.Size(82, 20)
        TownLabel.TabIndex = 18
        TownLabel.Text = "Town-City:"
        '
        'PostCodeLabel
        '
        PostCodeLabel.AutoSize = True
        PostCodeLabel.Location = New System.Drawing.Point(370, 491)
        PostCodeLabel.Name = "PostCodeLabel"
        PostCodeLabel.Size = New System.Drawing.Size(87, 20)
        PostCodeLabel.TabIndex = 20
        PostCodeLabel.Text = "Post Code:"
        '
        'MobileLabel
        '
        MobileLabel.AutoSize = True
        MobileLabel.Location = New System.Drawing.Point(26, 573)
        MobileLabel.Name = "MobileLabel"
        MobileLabel.Size = New System.Drawing.Size(59, 20)
        MobileLabel.TabIndex = 22
        MobileLabel.Text = "Mobile:"
        '
        'HomeNoLabel
        '
        HomeNoLabel.AutoSize = True
        HomeNoLabel.Location = New System.Drawing.Point(379, 573)
        HomeNoLabel.Name = "HomeNoLabel"
        HomeNoLabel.Size = New System.Drawing.Size(80, 20)
        HomeNoLabel.TabIndex = 24
        HomeNoLabel.Text = "Home No:"
        '
        'WorkNoLabel
        '
        WorkNoLabel.AutoSize = True
        WorkNoLabel.Location = New System.Drawing.Point(26, 651)
        WorkNoLabel.Name = "WorkNoLabel"
        WorkNoLabel.Size = New System.Drawing.Size(74, 20)
        WorkNoLabel.TabIndex = 26
        WorkNoLabel.Text = "Work No:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(379, 651)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(52, 20)
        EmailLabel.TabIndex = 28
        EmailLabel.Text = "Email:"
        '
        'RecordDateLabel
        '
        RecordDateLabel.AutoSize = True
        RecordDateLabel.Location = New System.Drawing.Point(1020, 133)
        RecordDateLabel.Name = "RecordDateLabel"
        RecordDateLabel.Size = New System.Drawing.Size(104, 20)
        RecordDateLabel.TabIndex = 30
        RecordDateLabel.Text = "Record Date:"
        '
        'OrderDetailsLabel
        '
        OrderDetailsLabel.AutoSize = True
        OrderDetailsLabel.Location = New System.Drawing.Point(493, 50)
        OrderDetailsLabel.Name = "OrderDetailsLabel"
        OrderDetailsLabel.Size = New System.Drawing.Size(106, 20)
        OrderDetailsLabel.TabIndex = 32
        OrderDetailsLabel.Text = "Order Details:"
        '
        'GraveOwnerLabel
        '
        GraveOwnerLabel.AutoSize = True
        GraveOwnerLabel.Location = New System.Drawing.Point(1020, 189)
        GraveOwnerLabel.Name = "GraveOwnerLabel"
        GraveOwnerLabel.Size = New System.Drawing.Size(106, 20)
        GraveOwnerLabel.TabIndex = 34
        GraveOwnerLabel.Text = "Grave Owner:"
        '
        'PlanYnLabel
        '
        PlanYnLabel.AutoSize = True
        PlanYnLabel.Location = New System.Drawing.Point(1020, 240)
        PlanYnLabel.Name = "PlanYnLabel"
        PlanYnLabel.Size = New System.Drawing.Size(125, 20)
        PlanYnLabel.TabIndex = 36
        PlanYnLabel.Text = "Application Sent"
        '
        'PlanGoneLabel
        '
        PlanGoneLabel.AutoSize = True
        PlanGoneLabel.Location = New System.Drawing.Point(1020, 305)
        PlanGoneLabel.Name = "PlanGoneLabel"
        PlanGoneLabel.Size = New System.Drawing.Size(88, 20)
        PlanGoneLabel.TabIndex = 38
        PlanGoneLabel.Text = "Plan Gone:"
        '
        'InscriptionLabel
        '
        InscriptionLabel.AutoSize = True
        InscriptionLabel.Location = New System.Drawing.Point(1020, 363)
        InscriptionLabel.Name = "InscriptionLabel"
        InscriptionLabel.Size = New System.Drawing.Size(86, 20)
        InscriptionLabel.TabIndex = 40
        InscriptionLabel.Text = "Inscription:"
        '
        'SundriesLabel
        '
        SundriesLabel.AutoSize = True
        SundriesLabel.Location = New System.Drawing.Point(1020, 428)
        SundriesLabel.Name = "SundriesLabel"
        SundriesLabel.Size = New System.Drawing.Size(76, 20)
        SundriesLabel.TabIndex = 42
        SundriesLabel.Text = "Sundries:"
        '
        'PaidLabel
        '
        PaidLabel.AutoSize = True
        PaidLabel.Location = New System.Drawing.Point(1020, 505)
        PaidLabel.Name = "PaidLabel"
        PaidLabel.Size = New System.Drawing.Size(44, 20)
        PaidLabel.TabIndex = 44
        PaidLabel.Text = "Paid:"
        '
        'DatePaidLabel
        '
        DatePaidLabel.AutoSize = True
        DatePaidLabel.Location = New System.Drawing.Point(1020, 573)
        DatePaidLabel.Name = "DatePaidLabel"
        DatePaidLabel.Size = New System.Drawing.Size(83, 20)
        DatePaidLabel.TabIndex = 46
        DatePaidLabel.Text = "Date Paid:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.lblNewDate)
        Me.GroupBox1.Controls.Add(Me.txtNewDate)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.txtWeeks)
        Me.GroupBox1.Controls.Add(Me.Close)
        Me.GroupBox1.Controls.Add(Me.Delete)
        Me.GroupBox1.Controls.Add(Me.Save)
        Me.GroupBox1.Controls.Add(Me.NextData)
        Me.GroupBox1.Controls.Add(Me.Previous)
        Me.GroupBox1.Controls.Add(OrderIDLabel)
        Me.GroupBox1.Controls.Add(Me.OrderIDTextBox)
        Me.GroupBox1.Controls.Add(TitleLabel)
        Me.GroupBox1.Controls.Add(FirstNameLabel)
        Me.GroupBox1.Controls.Add(Me.FirstNameTextBox)
        Me.GroupBox1.Controls.Add(LastNameLabel)
        Me.GroupBox1.Controls.Add(Me.LastNameTextBox)
        Me.GroupBox1.Controls.Add(CompanyNameLabel)
        Me.GroupBox1.Controls.Add(Me.CompanyNameTextBox)
        Me.GroupBox1.Controls.Add(AddressLabel)
        Me.GroupBox1.Controls.Add(Me.AddressTextBox)
        Me.GroupBox1.Controls.Add(Me.Address1TextBox)
        Me.GroupBox1.Controls.Add(Me.Address2TextBox)
        Me.GroupBox1.Controls.Add(Me.Address3TextBox)
        Me.GroupBox1.Controls.Add(TownLabel)
        Me.GroupBox1.Controls.Add(Me.TownTextBox)
        Me.GroupBox1.Controls.Add(PostCodeLabel)
        Me.GroupBox1.Controls.Add(Me.PostCodeTextBox)
        Me.GroupBox1.Controls.Add(MobileLabel)
        Me.GroupBox1.Controls.Add(Me.MobileTextBox)
        Me.GroupBox1.Controls.Add(HomeNoLabel)
        Me.GroupBox1.Controls.Add(Me.HomeNoTextBox)
        Me.GroupBox1.Controls.Add(WorkNoLabel)
        Me.GroupBox1.Controls.Add(Me.WorkNoTextBox)
        Me.GroupBox1.Controls.Add(EmailLabel)
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Controls.Add(RecordDateLabel)
        Me.GroupBox1.Controls.Add(Me.RecordDateDateTimePicker)
        Me.GroupBox1.Controls.Add(OrderDetailsLabel)
        Me.GroupBox1.Controls.Add(Me.OrderDetailsTextBox)
        Me.GroupBox1.Controls.Add(GraveOwnerLabel)
        Me.GroupBox1.Controls.Add(Me.GraveOwnerCheckBox)
        Me.GroupBox1.Controls.Add(PlanYnLabel)
        Me.GroupBox1.Controls.Add(Me.PlanYnCheckBox)
        Me.GroupBox1.Controls.Add(PlanGoneLabel)
        Me.GroupBox1.Controls.Add(Me.PlanGoneDateTimePicker)
        Me.GroupBox1.Controls.Add(InscriptionLabel)
        Me.GroupBox1.Controls.Add(Me.InscriptionTextBox)
        Me.GroupBox1.Controls.Add(SundriesLabel)
        Me.GroupBox1.Controls.Add(Me.SundriesTextBox)
        Me.GroupBox1.Controls.Add(PaidLabel)
        Me.GroupBox1.Controls.Add(Me.PaidCheckBox)
        Me.GroupBox1.Controls.Add(DatePaidLabel)
        Me.GroupBox1.Controls.Add(Me.DatePaidDateTimePicker)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1512, 820)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = ""
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Title", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(30, 130)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(203, 28)
        Me.ComboBox1.TabIndex = 57
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
        'lblNewDate
        '
        Me.lblNewDate.AutoSize = True
        Me.lblNewDate.Location = New System.Drawing.Point(1020, 92)
        Me.lblNewDate.Name = "lblNewDate"
        Me.lblNewDate.Size = New System.Drawing.Size(79, 20)
        Me.lblNewDate.TabIndex = 56
        Me.lblNewDate.Text = "New Date"
        '
        'txtNewDate
        '
        Me.txtNewDate.Location = New System.Drawing.Point(1140, 86)
        Me.txtNewDate.Name = "txtNewDate"
        Me.txtNewDate.Size = New System.Drawing.Size(200, 26)
        Me.txtNewDate.TabIndex = 55
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(1020, 50)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(58, 20)
        Me.lblName.TabIndex = 54
        Me.lblName.Text = "Weeks"
        '
        'txtWeeks
        '
        Me.txtWeeks.Location = New System.Drawing.Point(1140, 43)
        Me.txtWeeks.Name = "txtWeeks"
        Me.txtWeeks.Size = New System.Drawing.Size(200, 26)
        Me.txtWeeks.TabIndex = 53
        '
        'Close
        '
        Me.Close.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Close.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Close.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Close.Location = New System.Drawing.Point(726, 755)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(147, 50)
        Me.Close.TabIndex = 52
        Me.Close.Text = "Close"
        Me.Close.UseVisualStyleBackColor = False
        '
        'Delete
        '
        Me.Delete.BackColor = System.Drawing.Color.Maroon
        Me.Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.ForeColor = System.Drawing.Color.Snow
        Me.Delete.Location = New System.Drawing.Point(558, 755)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(147, 50)
        Me.Delete.TabIndex = 51
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = False
        '
        'Save
        '
        Me.Save.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Save.Location = New System.Drawing.Point(383, 755)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(147, 50)
        Me.Save.TabIndex = 50
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = False
        '
        'NextData
        '
        Me.NextData.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NextData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextData.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.NextData.Location = New System.Drawing.Point(205, 755)
        Me.NextData.Name = "NextData"
        Me.NextData.Size = New System.Drawing.Size(147, 50)
        Me.NextData.TabIndex = 49
        Me.NextData.Text = "Next"
        Me.NextData.UseVisualStyleBackColor = False
        '
        'Previous
        '
        Me.Previous.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Previous.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Previous.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Previous.Location = New System.Drawing.Point(32, 755)
        Me.Previous.Name = "Previous"
        Me.Previous.Size = New System.Drawing.Size(147, 50)
        Me.Previous.TabIndex = 48
        Me.Previous.Text = "Previous"
        Me.Previous.UseVisualStyleBackColor = False
        '
        'OrderIDTextBox
        '
        Me.OrderIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "OrderID", True))
        Me.OrderIDTextBox.Location = New System.Drawing.Point(116, 36)
        Me.OrderIDTextBox.Multiline = True
        Me.OrderIDTextBox.Name = "OrderIDTextBox"
        Me.OrderIDTextBox.Size = New System.Drawing.Size(200, 43)
        Me.OrderIDTextBox.TabIndex = 1
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(266, 130)
        Me.FirstNameTextBox.Multiline = True
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(200, 44)
        Me.FirstNameTextBox.TabIndex = 5
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(497, 130)
        Me.LastNameTextBox.Multiline = True
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(177, 44)
        Me.LastNameTextBox.TabIndex = 7
        '
        'CompanyNameTextBox
        '
        Me.CompanyNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "CompanyName", True))
        Me.CompanyNameTextBox.Location = New System.Drawing.Point(30, 215)
        Me.CompanyNameTextBox.Multiline = True
        Me.CompanyNameTextBox.Name = "CompanyNameTextBox"
        Me.CompanyNameTextBox.Size = New System.Drawing.Size(644, 55)
        Me.CompanyNameTextBox.TabIndex = 9
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(104, 282)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(570, 43)
        Me.AddressTextBox.TabIndex = 11
        '
        'Address1TextBox
        '
        Me.Address1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Address1", True))
        Me.Address1TextBox.Location = New System.Drawing.Point(104, 331)
        Me.Address1TextBox.Multiline = True
        Me.Address1TextBox.Name = "Address1TextBox"
        Me.Address1TextBox.Size = New System.Drawing.Size(570, 52)
        Me.Address1TextBox.TabIndex = 13
        '
        'Address2TextBox
        '
        Me.Address2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Address2", True))
        Me.Address2TextBox.Location = New System.Drawing.Point(104, 389)
        Me.Address2TextBox.Multiline = True
        Me.Address2TextBox.Name = "Address2TextBox"
        Me.Address2TextBox.Size = New System.Drawing.Size(570, 44)
        Me.Address2TextBox.TabIndex = 15
        '
        'Address3TextBox
        '
        Me.Address3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Address3", True))
        Me.Address3TextBox.Location = New System.Drawing.Point(104, 442)
        Me.Address3TextBox.Multiline = True
        Me.Address3TextBox.Name = "Address3TextBox"
        Me.Address3TextBox.Size = New System.Drawing.Size(570, 41)
        Me.Address3TextBox.TabIndex = 17
        '
        'TownTextBox
        '
        Me.TownTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Town", True))
        Me.TownTextBox.Location = New System.Drawing.Point(30, 514)
        Me.TownTextBox.Multiline = True
        Me.TownTextBox.Name = "TownTextBox"
        Me.TownTextBox.Size = New System.Drawing.Size(322, 45)
        Me.TownTextBox.TabIndex = 19
        '
        'PostCodeTextBox
        '
        Me.PostCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "PostCode", True))
        Me.PostCodeTextBox.Location = New System.Drawing.Point(374, 516)
        Me.PostCodeTextBox.Multiline = True
        Me.PostCodeTextBox.Name = "PostCodeTextBox"
        Me.PostCodeTextBox.Size = New System.Drawing.Size(300, 45)
        Me.PostCodeTextBox.TabIndex = 21
        '
        'MobileTextBox
        '
        Me.MobileTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Mobile", True))
        Me.MobileTextBox.Location = New System.Drawing.Point(30, 599)
        Me.MobileTextBox.Multiline = True
        Me.MobileTextBox.Name = "MobileTextBox"
        Me.MobileTextBox.Size = New System.Drawing.Size(322, 43)
        Me.MobileTextBox.TabIndex = 23
        '
        'HomeNoTextBox
        '
        Me.HomeNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "HomeNo", True))
        Me.HomeNoTextBox.Location = New System.Drawing.Point(383, 601)
        Me.HomeNoTextBox.Multiline = True
        Me.HomeNoTextBox.Name = "HomeNoTextBox"
        Me.HomeNoTextBox.Size = New System.Drawing.Size(291, 41)
        Me.HomeNoTextBox.TabIndex = 25
        '
        'WorkNoTextBox
        '
        Me.WorkNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "WorkNo", True))
        Me.WorkNoTextBox.Location = New System.Drawing.Point(30, 674)
        Me.WorkNoTextBox.Multiline = True
        Me.WorkNoTextBox.Name = "WorkNoTextBox"
        Me.WorkNoTextBox.Size = New System.Drawing.Size(322, 42)
        Me.WorkNoTextBox.TabIndex = 27
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(383, 674)
        Me.EmailTextBox.Multiline = True
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(291, 45)
        Me.EmailTextBox.TabIndex = 29
        '
        'RecordDateDateTimePicker
        '
        Me.RecordDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OrdersBindingSource, "RecordDate", True))
        Me.RecordDateDateTimePicker.Location = New System.Drawing.Point(1140, 127)
        Me.RecordDateDateTimePicker.Name = "RecordDateDateTimePicker"
        Me.RecordDateDateTimePicker.Size = New System.Drawing.Size(275, 26)
        Me.RecordDateDateTimePicker.TabIndex = 31
        '
        'OrderDetailsTextBox
        '
        Me.OrderDetailsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "OrderDetails", True))
        Me.OrderDetailsTextBox.Location = New System.Drawing.Point(619, 33)
        Me.OrderDetailsTextBox.Multiline = True
        Me.OrderDetailsTextBox.Name = "OrderDetailsTextBox"
        Me.OrderDetailsTextBox.Size = New System.Drawing.Size(324, 46)
        Me.OrderDetailsTextBox.TabIndex = 33
        '
        'GraveOwnerCheckBox
        '
        Me.GraveOwnerCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.OrdersBindingSource, "GraveOwner", True))
        Me.GraveOwnerCheckBox.Location = New System.Drawing.Point(1179, 185)
        Me.GraveOwnerCheckBox.Name = "GraveOwnerCheckBox"
        Me.GraveOwnerCheckBox.Size = New System.Drawing.Size(17, 24)
        Me.GraveOwnerCheckBox.TabIndex = 35
        Me.GraveOwnerCheckBox.UseVisualStyleBackColor = True
        '
        'PlanYnCheckBox
        '
        Me.PlanYnCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.OrdersBindingSource, "PlanYn", True))
        Me.PlanYnCheckBox.Location = New System.Drawing.Point(1179, 236)
        Me.PlanYnCheckBox.Name = "PlanYnCheckBox"
        Me.PlanYnCheckBox.Size = New System.Drawing.Size(17, 24)
        Me.PlanYnCheckBox.TabIndex = 37
        Me.PlanYnCheckBox.UseVisualStyleBackColor = True
        '
        'PlanGoneDateTimePicker
        '
        Me.PlanGoneDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OrdersBindingSource, "PlanGone", True))
        Me.PlanGoneDateTimePicker.Location = New System.Drawing.Point(1140, 300)
        Me.PlanGoneDateTimePicker.Name = "PlanGoneDateTimePicker"
        Me.PlanGoneDateTimePicker.Size = New System.Drawing.Size(275, 26)
        Me.PlanGoneDateTimePicker.TabIndex = 39
        '
        'InscriptionTextBox
        '
        Me.InscriptionTextBox.AccessibleDescription = ""
        Me.InscriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Inscription", True))
        Me.InscriptionTextBox.Location = New System.Drawing.Point(1140, 363)
        Me.InscriptionTextBox.Multiline = True
        Me.InscriptionTextBox.Name = "InscriptionTextBox"
        Me.InscriptionTextBox.Size = New System.Drawing.Size(151, 30)
        Me.InscriptionTextBox.TabIndex = 41
        Me.InscriptionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SundriesTextBox
        '
        Me.SundriesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Sundries", True))
        Me.SundriesTextBox.Location = New System.Drawing.Point(1140, 425)
        Me.SundriesTextBox.Multiline = True
        Me.SundriesTextBox.Name = "SundriesTextBox"
        Me.SundriesTextBox.Size = New System.Drawing.Size(151, 28)
        Me.SundriesTextBox.TabIndex = 43
        Me.SundriesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PaidCheckBox
        '
        Me.PaidCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.OrdersBindingSource, "Paid", True))
        Me.PaidCheckBox.Location = New System.Drawing.Point(1179, 501)
        Me.PaidCheckBox.Name = "PaidCheckBox"
        Me.PaidCheckBox.Size = New System.Drawing.Size(30, 24)
        Me.PaidCheckBox.TabIndex = 45
        Me.PaidCheckBox.UseVisualStyleBackColor = True
        '
        'DatePaidDateTimePicker
        '
        Me.DatePaidDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OrdersBindingSource, "DatePaid", True))
        Me.DatePaidDateTimePicker.Location = New System.Drawing.Point(1140, 568)
        Me.DatePaidDateTimePicker.Name = "DatePaidDateTimePicker"
        Me.DatePaidDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.DatePaidDateTimePicker.TabIndex = 47
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
        'OrdersBindingNavigator
        '
        Me.OrdersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.OrdersBindingNavigator.BindingSource = Me.OrdersBindingSource
        Me.OrdersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.OrdersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.OrdersBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.OrdersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.OrdersBindingNavigatorSaveItem})
        Me.OrdersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.OrdersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.OrdersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.OrdersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.OrdersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.OrdersBindingNavigator.Name = "OrdersBindingNavigator"
        Me.OrdersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.OrdersBindingNavigator.Size = New System.Drawing.Size(1524, 33)
        Me.OrdersBindingNavigator.TabIndex = 1
        Me.OrdersBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(54, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 33)
        '
        'OrdersBindingNavigatorSaveItem
        '
        Me.OrdersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OrdersBindingNavigatorSaveItem.Image = CType(resources.GetObject("OrdersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.OrdersBindingNavigatorSaveItem.Name = "OrdersBindingNavigatorSaveItem"
        Me.OrdersBindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 28)
        Me.OrdersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'FilterByOrderID
        '
        Me.FilterByOrderID.Location = New System.Drawing.Point(847, 7)
        Me.FilterByOrderID.Name = "FilterByOrderID"
        Me.FilterByOrderID.Size = New System.Drawing.Size(135, 33)
        Me.FilterByOrderID.TabIndex = 2
        Me.FilterByOrderID.Text = "Search"
        Me.FilterByOrderID.UseVisualStyleBackColor = True
        '
        'OrderIDFilterValue
        '
        Me.OrderIDFilterValue.Location = New System.Drawing.Point(674, 10)
        Me.OrderIDFilterValue.Name = "OrderIDFilterValue"
        Me.OrderIDFilterValue.Size = New System.Drawing.Size(131, 26)
        Me.OrderIDFilterValue.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(485, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Search By Order ID"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1524, 861)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OrderIDFilterValue)
        Me.Controls.Add(Me.FilterByOrderID)
        Me.Controls.Add(Me.OrdersBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TheMasonDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OrdersBindingNavigator.ResumeLayout(False)
        Me.OrdersBindingNavigator.PerformLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TheMasonDataSet As TheMasonDataSet
    Friend WithEvents OrdersBindingSource As BindingSource
    Friend WithEvents OrdersTableAdapter As TheMasonDataSetTableAdapters.OrdersTableAdapter
    Friend WithEvents TableAdapterManager As TheMasonDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OrdersBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents OrdersBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents OrderIDTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents CompanyNameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents Address1TextBox As TextBox
    Friend WithEvents Address2TextBox As TextBox
    Friend WithEvents Address3TextBox As TextBox
    Friend WithEvents TownTextBox As TextBox
    Friend WithEvents PostCodeTextBox As TextBox
    Friend WithEvents MobileTextBox As TextBox
    Friend WithEvents HomeNoTextBox As TextBox
    Friend WithEvents WorkNoTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents RecordDateDateTimePicker As DateTimePicker
    Friend WithEvents OrderDetailsTextBox As TextBox
    Friend WithEvents GraveOwnerCheckBox As CheckBox
    Friend WithEvents PlanYnCheckBox As CheckBox
    Friend WithEvents PlanGoneDateTimePicker As DateTimePicker
    Friend WithEvents InscriptionTextBox As TextBox
    Friend WithEvents SundriesTextBox As TextBox
    Friend WithEvents PaidCheckBox As CheckBox
    Friend WithEvents DatePaidDateTimePicker As DateTimePicker
    Friend WithEvents Close As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Save As Button
    Friend WithEvents NextData As Button
    Friend WithEvents Previous As Button
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Label1 As Label
    Friend WithEvents OrderIDFilterValue As TextBox
    Friend WithEvents FilterByOrderID As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents ToolTip3 As ToolTip
    Friend WithEvents lblNewDate As Label
    Friend WithEvents txtNewDate As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtWeeks As TextBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
