<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_INV_TARNSACTIONS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_INV_TARNSACTIONS))
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.btn_PREV = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_NEXT = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_QUERY = New DevExpress.XtraEditors.SimpleButton()
        Me.com_PAYMENT_METHOD = New System.Windows.Forms.ComboBox()
        Me.com_TAX_TYPE = New System.Windows.Forms.ComboBox()
        Me.com_TRANS_TYPE_CODE = New System.Windows.Forms.ComboBox()
        Me.com_TRANS_TYPE = New System.Windows.Forms.ComboBox()
        Me.btn_CLOSE = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_DELETE = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_NEW = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_SAVE = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_TRANS_DATE = New DevExpress.XtraEditors.DateEdit()
        Me.txt_UPDATE_DATE = New DevExpress.XtraEditors.TextEdit()
        Me.txt_UPDATE_USER = New DevExpress.XtraEditors.TextEdit()
        Me.txt_ENTRY_DATE = New DevExpress.XtraEditors.TextEdit()
        Me.txt_ENTRY_USER = New DevExpress.XtraEditors.TextEdit()
        Me.GridControl_INV_TARNSACTIONS_DETAILS = New DevExpress.XtraGrid.GridControl()
        Me.INVTRANSACTIONSDETAILSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView_INV_TARNSACTIONS_DETAILS = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.r_RMEOVE_RECORD = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colTRANS_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTRANS_YEAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTRANS_TYPE_CODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTRANS_NO_DETAILS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colITEM_CARD_CODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.r_INV_ITEM_CARDS = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colQTY_IN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQTY_OUT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colINDIVIDUAL_PRICE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDISCOUNT_PCNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDISCOUNT_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTAX_PCNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTAX_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTOTAL_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNET_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txt_NOTE = New DevExpress.XtraEditors.TextEdit()
        Me.com_REPRESENTATIVE = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.com_CUSTOMER = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txt_TRANS_NO = New DevExpress.XtraEditors.TextEdit()
        Me.txt_TRANS_YEAR = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.qq = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txt_TRANS_DATE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TRANS_DATE.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_UPDATE_DATE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_UPDATE_USER.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ENTRY_DATE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ENTRY_USER.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl_INV_TARNSACTIONS_DETAILS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVTRANSACTIONSDETAILSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView_INV_TARNSACTIONS_DETAILS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.r_RMEOVE_RECORD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.r_INV_ITEM_CARDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_NOTE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.com_REPRESENTATIVE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.com_CUSTOMER.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TRANS_NO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TRANS_YEAR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.btn_PREV)
        Me.LayoutControl1.Controls.Add(Me.btn_NEXT)
        Me.LayoutControl1.Controls.Add(Me.btn_QUERY)
        Me.LayoutControl1.Controls.Add(Me.com_PAYMENT_METHOD)
        Me.LayoutControl1.Controls.Add(Me.com_TAX_TYPE)
        Me.LayoutControl1.Controls.Add(Me.com_TRANS_TYPE_CODE)
        Me.LayoutControl1.Controls.Add(Me.com_TRANS_TYPE)
        Me.LayoutControl1.Controls.Add(Me.btn_CLOSE)
        Me.LayoutControl1.Controls.Add(Me.btn_DELETE)
        Me.LayoutControl1.Controls.Add(Me.btn_NEW)
        Me.LayoutControl1.Controls.Add(Me.btn_SAVE)
        Me.LayoutControl1.Controls.Add(Me.txt_TRANS_DATE)
        Me.LayoutControl1.Controls.Add(Me.txt_UPDATE_DATE)
        Me.LayoutControl1.Controls.Add(Me.txt_UPDATE_USER)
        Me.LayoutControl1.Controls.Add(Me.txt_ENTRY_DATE)
        Me.LayoutControl1.Controls.Add(Me.txt_ENTRY_USER)
        Me.LayoutControl1.Controls.Add(Me.GridControl_INV_TARNSACTIONS_DETAILS)
        Me.LayoutControl1.Controls.Add(Me.txt_NOTE)
        Me.LayoutControl1.Controls.Add(Me.com_REPRESENTATIVE)
        Me.LayoutControl1.Controls.Add(Me.com_CUSTOMER)
        Me.LayoutControl1.Controls.Add(Me.txt_TRANS_NO)
        Me.LayoutControl1.Controls.Add(Me.txt_TRANS_YEAR)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsView.RightToLeftMirroringApplied = True
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1348, 765)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'btn_PREV
        '
        Me.btn_PREV.ImageOptions.Image = CType(resources.GetObject("btn_PREV.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_PREV.Location = New System.Drawing.Point(429, 12)
        Me.btn_PREV.Name = "btn_PREV"
        Me.btn_PREV.Size = New System.Drawing.Size(110, 36)
        Me.btn_PREV.StyleController = Me.LayoutControl1
        Me.btn_PREV.TabIndex = 32
        Me.btn_PREV.Text = "previous"
        '
        'btn_NEXT
        '
        Me.btn_NEXT.ImageOptions.Image = CType(resources.GetObject("btn_NEXT.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_NEXT.Location = New System.Drawing.Point(672, 12)
        Me.btn_NEXT.Name = "btn_NEXT"
        Me.btn_NEXT.Size = New System.Drawing.Size(109, 36)
        Me.btn_NEXT.StyleController = Me.LayoutControl1
        Me.btn_NEXT.TabIndex = 31
        Me.btn_NEXT.Text = "next"
        '
        'btn_QUERY
        '
        Me.btn_QUERY.ImageOptions.Image = CType(resources.GetObject("btn_QUERY.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_QUERY.Location = New System.Drawing.Point(543, 12)
        Me.btn_QUERY.Name = "btn_QUERY"
        Me.btn_QUERY.Size = New System.Drawing.Size(125, 36)
        Me.btn_QUERY.StyleController = Me.LayoutControl1
        Me.btn_QUERY.TabIndex = 30
        Me.btn_QUERY.Text = "query"
        '
        'com_PAYMENT_METHOD
        '
        Me.com_PAYMENT_METHOD.FormattingEnabled = True
        Me.com_PAYMENT_METHOD.Location = New System.Drawing.Point(12, 199)
        Me.com_PAYMENT_METHOD.Name = "com_PAYMENT_METHOD"
        Me.com_PAYMENT_METHOD.Size = New System.Drawing.Size(1202, 21)
        Me.com_PAYMENT_METHOD.TabIndex = 29
        '
        'com_TAX_TYPE
        '
        Me.com_TAX_TYPE.FormattingEnabled = True
        Me.com_TAX_TYPE.Location = New System.Drawing.Point(12, 174)
        Me.com_TAX_TYPE.Name = "com_TAX_TYPE"
        Me.com_TAX_TYPE.Size = New System.Drawing.Size(1202, 21)
        Me.com_TAX_TYPE.TabIndex = 28
        '
        'com_TRANS_TYPE_CODE
        '
        Me.com_TRANS_TYPE_CODE.FormattingEnabled = True
        Me.com_TRANS_TYPE_CODE.Location = New System.Drawing.Point(12, 101)
        Me.com_TRANS_TYPE_CODE.Name = "com_TRANS_TYPE_CODE"
        Me.com_TRANS_TYPE_CODE.Size = New System.Drawing.Size(1202, 21)
        Me.com_TRANS_TYPE_CODE.TabIndex = 27
        '
        'com_TRANS_TYPE
        '
        Me.com_TRANS_TYPE.FormattingEnabled = True
        Me.com_TRANS_TYPE.Location = New System.Drawing.Point(12, 52)
        Me.com_TRANS_TYPE.Name = "com_TRANS_TYPE"
        Me.com_TRANS_TYPE.Size = New System.Drawing.Size(1202, 21)
        Me.com_TRANS_TYPE.TabIndex = 26
        '
        'btn_CLOSE
        '
        Me.btn_CLOSE.ImageOptions.SvgImage = CType(resources.GetObject("btn_CLOSE.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_CLOSE.Location = New System.Drawing.Point(12, 12)
        Me.btn_CLOSE.Name = "btn_CLOSE"
        Me.btn_CLOSE.Size = New System.Drawing.Size(106, 36)
        Me.btn_CLOSE.StyleController = Me.LayoutControl1
        Me.btn_CLOSE.TabIndex = 22
        Me.btn_CLOSE.Text = "close"
        '
        'btn_DELETE
        '
        Me.btn_DELETE.ImageOptions.Image = CType(resources.GetObject("btn_DELETE.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_DELETE.Location = New System.Drawing.Point(955, 12)
        Me.btn_DELETE.Name = "btn_DELETE"
        Me.btn_DELETE.Size = New System.Drawing.Size(139, 36)
        Me.btn_DELETE.StyleController = Me.LayoutControl1
        Me.btn_DELETE.TabIndex = 21
        Me.btn_DELETE.Text = "delete"
        '
        'btn_NEW
        '
        Me.btn_NEW.ImageOptions.Image = CType(resources.GetObject("btn_NEW.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_NEW.Location = New System.Drawing.Point(1220, 12)
        Me.btn_NEW.Name = "btn_NEW"
        Me.btn_NEW.Size = New System.Drawing.Size(116, 36)
        Me.btn_NEW.StyleController = Me.LayoutControl1
        Me.btn_NEW.TabIndex = 20
        Me.btn_NEW.Text = "new"
        '
        'btn_SAVE
        '
        Me.btn_SAVE.ImageOptions.Image = CType(resources.GetObject("btn_SAVE.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_SAVE.Location = New System.Drawing.Point(1098, 12)
        Me.btn_SAVE.Name = "btn_SAVE"
        Me.btn_SAVE.Size = New System.Drawing.Size(118, 36)
        Me.btn_SAVE.StyleController = Me.LayoutControl1
        Me.btn_SAVE.TabIndex = 19
        Me.btn_SAVE.Text = "save"
        '
        'txt_TRANS_DATE
        '
        Me.txt_TRANS_DATE.EditValue = Nothing
        Me.txt_TRANS_DATE.Location = New System.Drawing.Point(1050, 77)
        Me.txt_TRANS_DATE.Name = "txt_TRANS_DATE"
        Me.txt_TRANS_DATE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_TRANS_DATE.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_TRANS_DATE.Size = New System.Drawing.Size(164, 20)
        Me.txt_TRANS_DATE.StyleController = Me.LayoutControl1
        Me.txt_TRANS_DATE.TabIndex = 17
        '
        'txt_UPDATE_DATE
        '
        Me.txt_UPDATE_DATE.Enabled = False
        Me.txt_UPDATE_DATE.Location = New System.Drawing.Point(12, 733)
        Me.txt_UPDATE_DATE.Name = "txt_UPDATE_DATE"
        Me.txt_UPDATE_DATE.Size = New System.Drawing.Size(248, 20)
        Me.txt_UPDATE_DATE.StyleController = Me.LayoutControl1
        Me.txt_UPDATE_DATE.TabIndex = 16
        '
        'txt_UPDATE_USER
        '
        Me.txt_UPDATE_USER.Enabled = False
        Me.txt_UPDATE_USER.Location = New System.Drawing.Point(386, 733)
        Me.txt_UPDATE_USER.Name = "txt_UPDATE_USER"
        Me.txt_UPDATE_USER.Size = New System.Drawing.Size(250, 20)
        Me.txt_UPDATE_USER.StyleController = Me.LayoutControl1
        Me.txt_UPDATE_USER.TabIndex = 15
        '
        'txt_ENTRY_DATE
        '
        Me.txt_ENTRY_DATE.Enabled = False
        Me.txt_ENTRY_DATE.Location = New System.Drawing.Point(762, 733)
        Me.txt_ENTRY_DATE.Name = "txt_ENTRY_DATE"
        Me.txt_ENTRY_DATE.Size = New System.Drawing.Size(176, 20)
        Me.txt_ENTRY_DATE.StyleController = Me.LayoutControl1
        Me.txt_ENTRY_DATE.TabIndex = 14
        '
        'txt_ENTRY_USER
        '
        Me.txt_ENTRY_USER.Enabled = False
        Me.txt_ENTRY_USER.Location = New System.Drawing.Point(1064, 733)
        Me.txt_ENTRY_USER.Name = "txt_ENTRY_USER"
        Me.txt_ENTRY_USER.Size = New System.Drawing.Size(150, 20)
        Me.txt_ENTRY_USER.StyleController = Me.LayoutControl1
        Me.txt_ENTRY_USER.TabIndex = 13
        '
        'GridControl_INV_TARNSACTIONS_DETAILS
        '
        Me.GridControl_INV_TARNSACTIONS_DETAILS.DataSource = Me.INVTRANSACTIONSDETAILSBindingSource
        Me.GridControl_INV_TARNSACTIONS_DETAILS.Location = New System.Drawing.Point(12, 248)
        Me.GridControl_INV_TARNSACTIONS_DETAILS.MainView = Me.GridView_INV_TARNSACTIONS_DETAILS
        Me.GridControl_INV_TARNSACTIONS_DETAILS.Name = "GridControl_INV_TARNSACTIONS_DETAILS"
        Me.GridControl_INV_TARNSACTIONS_DETAILS.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.r_INV_ITEM_CARDS, Me.r_RMEOVE_RECORD})
        Me.GridControl_INV_TARNSACTIONS_DETAILS.Size = New System.Drawing.Size(1324, 481)
        Me.GridControl_INV_TARNSACTIONS_DETAILS.TabIndex = 12
        Me.GridControl_INV_TARNSACTIONS_DETAILS.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_INV_TARNSACTIONS_DETAILS})
        '
        'INVTRANSACTIONSDETAILSBindingSource
        '
        Me.INVTRANSACTIONSDETAILSBindingSource.DataSource = GetType(InvoiceTest.INV_TRANSACTIONS_DETAILS)
        '
        'GridView_INV_TARNSACTIONS_DETAILS
        '
        Me.GridView_INV_TARNSACTIONS_DETAILS.Appearance.HeaderPanel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView_INV_TARNSACTIONS_DETAILS.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView_INV_TARNSACTIONS_DETAILS.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView_INV_TARNSACTIONS_DETAILS.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridView_INV_TARNSACTIONS_DETAILS.Appearance.Row.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView_INV_TARNSACTIONS_DETAILS.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GridView_INV_TARNSACTIONS_DETAILS.Appearance.Row.Options.UseFont = True
        Me.GridView_INV_TARNSACTIONS_DETAILS.Appearance.Row.Options.UseForeColor = True
        Me.GridView_INV_TARNSACTIONS_DETAILS.Appearance.Row.Options.UseTextOptions = True
        Me.GridView_INV_TARNSACTIONS_DETAILS.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridView_INV_TARNSACTIONS_DETAILS.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colTRANS_NO, Me.colTRANS_YEAR, Me.colTRANS_TYPE_CODE, Me.colTRANS_NO_DETAILS, Me.colITEM_CARD_CODE, Me.colQTY_IN, Me.colQTY_OUT, Me.colINDIVIDUAL_PRICE, Me.colDISCOUNT_PCNT, Me.colDISCOUNT_AMT, Me.colTAX_PCNT, Me.colTAX_AMT, Me.colTOTAL_AMT, Me.colNET_AMT})
        Me.GridView_INV_TARNSACTIONS_DETAILS.GridControl = Me.GridControl_INV_TARNSACTIONS_DETAILS
        Me.GridView_INV_TARNSACTIONS_DETAILS.Name = "GridView_INV_TARNSACTIONS_DETAILS"
        Me.GridView_INV_TARNSACTIONS_DETAILS.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "DELETE"
        Me.GridColumn1.ColumnEdit = Me.r_RMEOVE_RECORD
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.TabStop = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 74
        '
        'r_RMEOVE_RECORD
        '
        Me.r_RMEOVE_RECORD.AutoHeight = False
        EditorButtonImageOptions2.Image = CType(resources.GetObject("EditorButtonImageOptions2.Image"), System.Drawing.Image)
        Me.r_RMEOVE_RECORD.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.r_RMEOVE_RECORD.Name = "r_RMEOVE_RECORD"
        Me.r_RMEOVE_RECORD.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'colTRANS_NO
        '
        Me.colTRANS_NO.FieldName = "TRANS_NO"
        Me.colTRANS_NO.Name = "colTRANS_NO"
        '
        'colTRANS_YEAR
        '
        Me.colTRANS_YEAR.FieldName = "TRANS_YEAR"
        Me.colTRANS_YEAR.Name = "colTRANS_YEAR"
        '
        'colTRANS_TYPE_CODE
        '
        Me.colTRANS_TYPE_CODE.FieldName = "TRANS_TYPE_CODE"
        Me.colTRANS_TYPE_CODE.Name = "colTRANS_TYPE_CODE"
        '
        'colTRANS_NO_DETAILS
        '
        Me.colTRANS_NO_DETAILS.FieldName = "TRANS_NO_DETAILS"
        Me.colTRANS_NO_DETAILS.Name = "colTRANS_NO_DETAILS"
        '
        'colITEM_CARD_CODE
        '
        Me.colITEM_CARD_CODE.Caption = "items"
        Me.colITEM_CARD_CODE.ColumnEdit = Me.r_INV_ITEM_CARDS
        Me.colITEM_CARD_CODE.FieldName = "ITEM_CARD_CODE"
        Me.colITEM_CARD_CODE.Name = "colITEM_CARD_CODE"
        Me.colITEM_CARD_CODE.Visible = True
        Me.colITEM_CARD_CODE.VisibleIndex = 1
        Me.colITEM_CARD_CODE.Width = 167
        '
        'r_INV_ITEM_CARDS
        '
        Me.r_INV_ITEM_CARDS.AutoHeight = False
        Me.r_INV_ITEM_CARDS.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.r_INV_ITEM_CARDS.Name = "r_INV_ITEM_CARDS"
        Me.r_INV_ITEM_CARDS.NullText = ""
        Me.r_INV_ITEM_CARDS.PopupView = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colQTY_IN
        '
        Me.colQTY_IN.Caption = "quantity"
        Me.colQTY_IN.FieldName = "QTY_IN"
        Me.colQTY_IN.Name = "colQTY_IN"
        Me.colQTY_IN.Visible = True
        Me.colQTY_IN.VisibleIndex = 2
        Me.colQTY_IN.Width = 167
        '
        'colQTY_OUT
        '
        Me.colQTY_OUT.Caption = "quantity"
        Me.colQTY_OUT.FieldName = "QTY_OUT"
        Me.colQTY_OUT.Name = "colQTY_OUT"
        Me.colQTY_OUT.Visible = True
        Me.colQTY_OUT.VisibleIndex = 3
        Me.colQTY_OUT.Width = 167
        '
        'colINDIVIDUAL_PRICE
        '
        Me.colINDIVIDUAL_PRICE.Caption = "price"
        Me.colINDIVIDUAL_PRICE.DisplayFormat.FormatString = "N3"
        Me.colINDIVIDUAL_PRICE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colINDIVIDUAL_PRICE.FieldName = "INDIVIDUAL_PRICE"
        Me.colINDIVIDUAL_PRICE.Name = "colINDIVIDUAL_PRICE"
        Me.colINDIVIDUAL_PRICE.Visible = True
        Me.colINDIVIDUAL_PRICE.VisibleIndex = 4
        Me.colINDIVIDUAL_PRICE.Width = 167
        '
        'colDISCOUNT_PCNT
        '
        Me.colDISCOUNT_PCNT.Caption = "discount %"
        Me.colDISCOUNT_PCNT.DisplayFormat.FormatString = "N2"
        Me.colDISCOUNT_PCNT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDISCOUNT_PCNT.FieldName = "DISCOUNT_PCNT"
        Me.colDISCOUNT_PCNT.Name = "colDISCOUNT_PCNT"
        Me.colDISCOUNT_PCNT.Visible = True
        Me.colDISCOUNT_PCNT.VisibleIndex = 5
        Me.colDISCOUNT_PCNT.Width = 167
        '
        'colDISCOUNT_AMT
        '
        Me.colDISCOUNT_AMT.Caption = "discount amount"
        Me.colDISCOUNT_AMT.DisplayFormat.FormatString = "N3"
        Me.colDISCOUNT_AMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDISCOUNT_AMT.FieldName = "DISCOUNT_AMT"
        Me.colDISCOUNT_AMT.Name = "colDISCOUNT_AMT"
        Me.colDISCOUNT_AMT.OptionsColumn.AllowEdit = False
        Me.colDISCOUNT_AMT.OptionsColumn.AllowFocus = False
        Me.colDISCOUNT_AMT.OptionsColumn.ReadOnly = True
        Me.colDISCOUNT_AMT.OptionsColumn.TabStop = False
        Me.colDISCOUNT_AMT.Visible = True
        Me.colDISCOUNT_AMT.VisibleIndex = 6
        Me.colDISCOUNT_AMT.Width = 167
        '
        'colTAX_PCNT
        '
        Me.colTAX_PCNT.Caption = "tax %"
        Me.colTAX_PCNT.DisplayFormat.FormatString = "N2"
        Me.colTAX_PCNT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTAX_PCNT.FieldName = "TAX_PCNT"
        Me.colTAX_PCNT.Name = "colTAX_PCNT"
        Me.colTAX_PCNT.OptionsColumn.AllowFocus = False
        Me.colTAX_PCNT.OptionsColumn.ReadOnly = True
        Me.colTAX_PCNT.OptionsColumn.TabStop = False
        Me.colTAX_PCNT.Visible = True
        Me.colTAX_PCNT.VisibleIndex = 7
        Me.colTAX_PCNT.Width = 167
        '
        'colTAX_AMT
        '
        Me.colTAX_AMT.Caption = "tax amount"
        Me.colTAX_AMT.DisplayFormat.FormatString = "N3"
        Me.colTAX_AMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTAX_AMT.FieldName = "TAX_AMT"
        Me.colTAX_AMT.Name = "colTAX_AMT"
        Me.colTAX_AMT.OptionsColumn.AllowEdit = False
        Me.colTAX_AMT.OptionsColumn.AllowFocus = False
        Me.colTAX_AMT.OptionsColumn.ReadOnly = True
        Me.colTAX_AMT.OptionsColumn.TabStop = False
        Me.colTAX_AMT.Visible = True
        Me.colTAX_AMT.VisibleIndex = 8
        Me.colTAX_AMT.Width = 167
        '
        'colTOTAL_AMT
        '
        Me.colTOTAL_AMT.Caption = "total amount"
        Me.colTOTAL_AMT.DisplayFormat.FormatString = "N3"
        Me.colTOTAL_AMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTOTAL_AMT.FieldName = "TOTAL_AMT"
        Me.colTOTAL_AMT.Name = "colTOTAL_AMT"
        Me.colTOTAL_AMT.OptionsColumn.AllowEdit = False
        Me.colTOTAL_AMT.OptionsColumn.AllowFocus = False
        Me.colTOTAL_AMT.OptionsColumn.ReadOnly = True
        Me.colTOTAL_AMT.OptionsColumn.TabStop = False
        Me.colTOTAL_AMT.Visible = True
        Me.colTOTAL_AMT.VisibleIndex = 9
        Me.colTOTAL_AMT.Width = 167
        '
        'colNET_AMT
        '
        Me.colNET_AMT.Caption = "net amount"
        Me.colNET_AMT.DisplayFormat.FormatString = "N3"
        Me.colNET_AMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNET_AMT.FieldName = "NET_AMT"
        Me.colNET_AMT.Name = "colNET_AMT"
        Me.colNET_AMT.OptionsColumn.AllowEdit = False
        Me.colNET_AMT.OptionsColumn.AllowFocus = False
        Me.colNET_AMT.OptionsColumn.ReadOnly = True
        Me.colNET_AMT.OptionsColumn.TabStop = False
        Me.colNET_AMT.Visible = True
        Me.colNET_AMT.VisibleIndex = 10
        Me.colNET_AMT.Width = 185
        '
        'txt_NOTE
        '
        Me.txt_NOTE.Location = New System.Drawing.Point(12, 224)
        Me.txt_NOTE.Name = "txt_NOTE"
        Me.txt_NOTE.Size = New System.Drawing.Size(1202, 20)
        Me.txt_NOTE.StyleController = Me.LayoutControl1
        Me.txt_NOTE.TabIndex = 10
        '
        'com_REPRESENTATIVE
        '
        Me.com_REPRESENTATIVE.Location = New System.Drawing.Point(12, 150)
        Me.com_REPRESENTATIVE.Name = "com_REPRESENTATIVE"
        Me.com_REPRESENTATIVE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.com_REPRESENTATIVE.Properties.NullText = ""
        Me.com_REPRESENTATIVE.Properties.PopupView = Me.SearchLookUpEdit2View
        Me.com_REPRESENTATIVE.Size = New System.Drawing.Size(1202, 20)
        Me.com_REPRESENTATIVE.StyleController = Me.LayoutControl1
        Me.com_REPRESENTATIVE.TabIndex = 8
        '
        'SearchLookUpEdit2View
        '
        Me.SearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit2View.Name = "SearchLookUpEdit2View"
        Me.SearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'com_CUSTOMER
        '
        Me.com_CUSTOMER.Location = New System.Drawing.Point(12, 126)
        Me.com_CUSTOMER.Name = "com_CUSTOMER"
        Me.com_CUSTOMER.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.com_CUSTOMER.Properties.NullText = ""
        Me.com_CUSTOMER.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.com_CUSTOMER.Size = New System.Drawing.Size(1202, 20)
        Me.com_CUSTOMER.StyleController = Me.LayoutControl1
        Me.com_CUSTOMER.TabIndex = 7
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'txt_TRANS_NO
        '
        Me.txt_TRANS_NO.Enabled = False
        Me.txt_TRANS_NO.Location = New System.Drawing.Point(12, 77)
        Me.txt_TRANS_NO.Name = "txt_TRANS_NO"
        Me.txt_TRANS_NO.Size = New System.Drawing.Size(694, 20)
        Me.txt_TRANS_NO.StyleController = Me.LayoutControl1
        Me.txt_TRANS_NO.TabIndex = 5
        '
        'txt_TRANS_YEAR
        '
        Me.txt_TRANS_YEAR.Enabled = False
        Me.txt_TRANS_YEAR.Location = New System.Drawing.Point(832, 77)
        Me.txt_TRANS_YEAR.Name = "txt_TRANS_YEAR"
        Me.txt_TRANS_YEAR.Size = New System.Drawing.Size(92, 20)
        Me.txt_TRANS_YEAR.StyleController = Me.LayoutControl1
        Me.txt_TRANS_YEAR.TabIndex = 4
        '
        'Root
        '
        Me.Root.AppearanceGroup.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Root.AppearanceGroup.Options.UseFont = True
        Me.Root.AppearanceItemCaption.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Root.AppearanceItemCaption.Options.UseFont = True
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.qq, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem7, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.LayoutControlItem18, Me.LayoutControlItem19, Me.LayoutControlItem8, Me.LayoutControlItem21, Me.LayoutControlItem22, Me.LayoutControlItem23, Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem6, Me.EmptySpaceItem1, Me.EmptySpaceItem2})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1348, 765)
        Me.Root.TextVisible = False
        '
        'qq
        '
        Me.qq.Control = Me.txt_TRANS_YEAR
        Me.qq.Location = New System.Drawing.Point(820, 65)
        Me.qq.Name = "qq"
        Me.qq.Size = New System.Drawing.Size(218, 24)
        Me.qq.Text = "year"
        Me.qq.TextSize = New System.Drawing.Size(110, 19)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txt_TRANS_NO
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 65)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(820, 24)
        Me.LayoutControlItem2.Text = "no."
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(110, 19)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.com_CUSTOMER
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 114)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(1328, 24)
        Me.LayoutControlItem4.Text = "customer"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(110, 19)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.com_REPRESENTATIVE
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 138)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(1328, 24)
        Me.LayoutControlItem5.Text = "representative"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(110, 19)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txt_NOTE
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 212)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(1328, 24)
        Me.LayoutControlItem7.Text = "note"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(110, 19)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.GridControl_INV_TARNSACTIONS_DETAILS
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 236)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(1328, 485)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txt_ENTRY_USER
        Me.LayoutControlItem10.Location = New System.Drawing.Point(1052, 721)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(276, 24)
        Me.LayoutControlItem10.Text = "entry user"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(110, 19)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txt_ENTRY_DATE
        Me.LayoutControlItem11.Location = New System.Drawing.Point(750, 721)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(302, 24)
        Me.LayoutControlItem11.Text = "entry date"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(110, 19)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txt_UPDATE_USER
        Me.LayoutControlItem12.Location = New System.Drawing.Point(374, 721)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(376, 24)
        Me.LayoutControlItem12.Text = "update user"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(110, 19)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txt_UPDATE_DATE
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 721)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(374, 24)
        Me.LayoutControlItem13.Text = "update date"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(110, 19)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txt_TRANS_DATE
        Me.LayoutControlItem14.Location = New System.Drawing.Point(1038, 65)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(290, 24)
        Me.LayoutControlItem14.Text = "date"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(110, 19)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.btn_SAVE
        Me.LayoutControlItem16.Location = New System.Drawing.Point(1086, 0)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(122, 40)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.btn_NEW
        Me.LayoutControlItem17.Location = New System.Drawing.Point(1208, 0)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(120, 40)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.btn_DELETE
        Me.LayoutControlItem18.Location = New System.Drawing.Point(943, 0)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(143, 40)
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.btn_CLOSE
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(110, 40)
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.com_TRANS_TYPE
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 40)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(1328, 25)
        Me.LayoutControlItem8.Text = "transaction type"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(110, 19)
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.com_TRANS_TYPE_CODE
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 89)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(1328, 25)
        Me.LayoutControlItem21.Text = "sale type"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(110, 19)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.com_TAX_TYPE
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 162)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(1328, 25)
        Me.LayoutControlItem22.Text = "tax type"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(110, 19)
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.com_PAYMENT_METHOD
        Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 187)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(1328, 25)
        Me.LayoutControlItem23.Text = "payment method"
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(110, 19)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.btn_QUERY
        Me.LayoutControlItem1.Location = New System.Drawing.Point(531, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(129, 40)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.btn_NEXT
        Me.LayoutControlItem3.Location = New System.Drawing.Point(660, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(113, 40)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.btn_PREV
        Me.LayoutControlItem6.Location = New System.Drawing.Point(417, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(114, 40)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(773, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(170, 40)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(110, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(307, 40)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'FRM_INV_TARNSACTIONS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1348, 765)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "FRM_INV_TARNSACTIONS"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txt_TRANS_DATE.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TRANS_DATE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_UPDATE_DATE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_UPDATE_USER.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ENTRY_DATE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ENTRY_USER.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl_INV_TARNSACTIONS_DETAILS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVTRANSACTIONSDETAILSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView_INV_TARNSACTIONS_DETAILS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.r_RMEOVE_RECORD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.r_INV_ITEM_CARDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_NOTE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.com_REPRESENTATIVE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.com_CUSTOMER.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TRANS_NO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TRANS_YEAR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txt_NOTE As DevExpress.XtraEditors.TextEdit
    Friend WithEvents com_REPRESENTATIVE As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents com_CUSTOMER As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txt_TRANS_NO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_TRANS_YEAR As DevExpress.XtraEditors.TextEdit
    Friend WithEvents qq As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txt_TRANS_DATE As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txt_UPDATE_DATE As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_UPDATE_USER As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_ENTRY_DATE As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_ENTRY_USER As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridControl_INV_TARNSACTIONS_DETAILS As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_INV_TARNSACTIONS_DETAILS As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btn_CLOSE As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_DELETE As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_NEW As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_SAVE As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents INVTRANSACTIONSDETAILSBindingSource As BindingSource
    Friend WithEvents colTRANS_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTRANS_YEAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTRANS_TYPE_CODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTRANS_NO_DETAILS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colITEM_CARD_CODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQTY_IN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQTY_OUT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colINDIVIDUAL_PRICE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDISCOUNT_PCNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDISCOUNT_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTAX_PCNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTAX_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTOTAL_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNET_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents r_INV_ITEM_CARDS As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents com_PAYMENT_METHOD As ComboBox
    Friend WithEvents com_TAX_TYPE As ComboBox
    Friend WithEvents com_TRANS_TYPE_CODE As ComboBox
    Friend WithEvents com_TRANS_TYPE As ComboBox
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents r_RMEOVE_RECORD As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btn_QUERY As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btn_PREV As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_NEXT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
End Class
