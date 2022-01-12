Namespace T227361

    Partial Class ProductsReport

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.tbProductHeader = New DevExpress.XtraReports.UI.XRTable()
            Me.GroupHeaderTitle = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.tcProductNameHeader = New DevExpress.XtraReports.UI.XRTableCell()
            Me.trProductHeader = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tcUnitsInStock = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.tcUnitPriceHeader = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tcUnitsOnOrderHeader = New DevExpress.XtraReports.UI.XRTableCell()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.tcUnitsOnOrder = New DevExpress.XtraReports.UI.XRTableCell()
            Me.trProductData = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tcProductName = New DevExpress.XtraReports.UI.XRTableCell()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.lbHeader = New DevExpress.XtraReports.UI.XRLabel()
            Me.tcUnitPrice = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tcUnitsInStockHeader = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tcDiscont = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tcDiscontHeader = New DevExpress.XtraReports.UI.XRTableCell()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.tbProductData = New DevExpress.XtraReports.UI.XRTable()
            Me.nWindDataSet1 = New T227361.NWindDataSet()
            Me.productsTableAdapter = New T227361.NWindDataSetTableAdapters.ProductsTableAdapter()
            CType((Me.tbProductHeader), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tbProductData), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.nWindDataSet1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' tbProductHeader
            ' 
            Me.tbProductHeader.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.tbProductHeader.Name = "tbProductHeader"
            Me.tbProductHeader.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.trProductHeader})
            Me.tbProductHeader.SizeF = New System.Drawing.SizeF(649.9999F, 25F)
            ' 
            ' GroupHeaderTitle
            ' 
            Me.GroupHeaderTitle.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.GroupHeaderTitle.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.tbProductHeader})
            Me.GroupHeaderTitle.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold)
            Me.GroupHeaderTitle.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
            Me.GroupHeaderTitle.HeightF = 25F
            Me.GroupHeaderTitle.Name = "GroupHeaderTitle"
            Me.GroupHeaderTitle.RepeatEveryPage = True
            Me.GroupHeaderTitle.StylePriority.UseBorders = False
            Me.GroupHeaderTitle.StylePriority.UseFont = False
            Me.GroupHeaderTitle.StylePriority.UseTextAlignment = False
            Me.GroupHeaderTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
            ' 
            ' tcProductNameHeader
            ' 
            Me.tcProductNameHeader.Name = "tcProductNameHeader"
            Me.tcProductNameHeader.Text = "Product Name"
            Me.tcProductNameHeader.Weight = 1.379807857084572R
            ' 
            ' trProductHeader
            ' 
            Me.trProductHeader.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tcProductNameHeader, Me.tcUnitPriceHeader, Me.tcUnitsInStockHeader, Me.tcUnitsOnOrderHeader, Me.tcDiscontHeader})
            Me.trProductHeader.Name = "trProductHeader"
            Me.trProductHeader.Weight = 1R
            ' 
            ' tcUnitsInStock
            ' 
            Me.tcUnitsInStock.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitsInStock")})
            Me.tcUnitsInStock.Name = "tcUnitsInStock"
            Me.tcUnitsInStock.StylePriority.UseTextAlignment = False
            Me.tcUnitsInStock.Text = "tcUnitsInStock"
            Me.tcUnitsInStock.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tcUnitsInStock.Weight = 0.46634616242358046R
            ' 
            ' Detail
            ' 
            Me.Detail.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.tbProductData})
            Me.Detail.HeightF = 25F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100F)
            Me.Detail.StylePriority.UseBorders = False
            Me.Detail.StylePriority.UsePadding = False
            Me.Detail.StylePriority.UseTextAlignment = False
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' tcUnitPriceHeader
            ' 
            Me.tcUnitPriceHeader.Name = "tcUnitPriceHeader"
            Me.tcUnitPriceHeader.Text = "Unit Price"
            Me.tcUnitPriceHeader.Weight = 0.4663460215732067R
            ' 
            ' tcUnitsOnOrderHeader
            ' 
            Me.tcUnitsOnOrderHeader.Name = "tcUnitsOnOrderHeader"
            Me.tcUnitsOnOrderHeader.Text = "Units On Order"
            Me.tcUnitsOnOrderHeader.Weight = 0.44903843327809806R
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lbHeader})
            Me.ReportHeader.HeightF = 50F
            Me.ReportHeader.Name = "ReportHeader"
            ' 
            ' tcUnitsOnOrder
            ' 
            Me.tcUnitsOnOrder.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitsOnOrder")})
            Me.tcUnitsOnOrder.Name = "tcUnitsOnOrder"
            Me.tcUnitsOnOrder.StylePriority.UseTextAlignment = False
            Me.tcUnitsOnOrder.Text = "tcUnitsOnOrder"
            Me.tcUnitsOnOrder.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tcUnitsOnOrder.Weight = 0.44903843327809811R
            ' 
            ' trProductData
            ' 
            Me.trProductData.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tcProductName, Me.tcUnitPrice, Me.tcUnitsInStock, Me.tcUnitsOnOrder, Me.tcDiscont})
            Me.trProductData.Name = "trProductData"
            Me.trProductData.Weight = 1R
            ' 
            ' tcProductName
            ' 
            Me.tcProductName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.ProductName")})
            Me.tcProductName.Name = "tcProductName"
            Me.tcProductName.StylePriority.UseTextAlignment = False
            Me.tcProductName.Text = "tcProductName"
            Me.tcProductName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tcProductName.Weight = 1.3798077514467915R
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' lbHeader
            ' 
            Me.lbHeader.Font = New System.Drawing.Font("Times New Roman", 36F)
            Me.lbHeader.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.lbHeader.Name = "lbHeader"
            Me.lbHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbHeader.SizeF = New System.Drawing.SizeF(650F, 50F)
            Me.lbHeader.StylePriority.UseFont = False
            Me.lbHeader.StylePriority.UseTextAlignment = False
            Me.lbHeader.Text = "Products Report"
            Me.lbHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' tcUnitPrice
            ' 
            Me.tcUnitPrice.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitPrice", "{0:c}")})
            Me.tcUnitPrice.Name = "tcUnitPrice"
            Me.tcUnitPrice.StylePriority.UseTextAlignment = False
            Me.tcUnitPrice.Text = "tcUnitPrice"
            Me.tcUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tcUnitPrice.Weight = 0.4663461624235804R
            ' 
            ' tcUnitsInStockHeader
            ' 
            Me.tcUnitsInStockHeader.Name = "tcUnitsInStockHeader"
            Me.tcUnitsInStockHeader.Text = "Units In Stock"
            Me.tcUnitsInStockHeader.Weight = 0.46634598636061309R
            ' 
            ' tcDiscont
            ' 
            Me.tcDiscont.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.Discontinued")})
            Me.tcDiscont.Name = "tcDiscont"
            Me.tcDiscont.StylePriority.UseTextAlignment = False
            Me.tcDiscont.Text = "tcDiscont"
            Me.tcDiscont.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.tcDiscont.Weight = 0.2384614904279494R
            ' 
            ' tcDiscontHeader
            ' 
            Me.tcDiscontHeader.Name = "tcDiscontHeader"
            Me.tcDiscontHeader.Text = "Discont."
            Me.tcDiscontHeader.Weight = 0.23846170170351017R
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' tbProductData
            ' 
            Me.tbProductData.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.tbProductData.Name = "tbProductData"
            Me.tbProductData.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.trProductData})
            Me.tbProductData.SizeF = New System.Drawing.SizeF(649.9999F, 25F)
            ' 
            ' nWindDataSet1
            ' 
            Me.nWindDataSet1.DataSetName = "NWindDataSet"
            Me.nWindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' productsTableAdapter
            ' 
            Me.productsTableAdapter.ClearBeforeFill = True
            ' 
            ' ProductsReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeaderTitle, Me.ReportHeader})
            Me.DataAdapter = Me.productsTableAdapter
            Me.DataMember = "Products"
            Me.DataSource = Me.nWindDataSet1
            Me.Version = "14.1"
            CType((Me.tbProductHeader), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tbProductData), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.nWindDataSet1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

'#End Region
        Private tbProductHeader As DevExpress.XtraReports.UI.XRTable

        Private trProductHeader As DevExpress.XtraReports.UI.XRTableRow

        Private tcProductNameHeader As DevExpress.XtraReports.UI.XRTableCell

        Private tcUnitPriceHeader As DevExpress.XtraReports.UI.XRTableCell

        Private tcUnitsInStockHeader As DevExpress.XtraReports.UI.XRTableCell

        Private tcUnitsOnOrderHeader As DevExpress.XtraReports.UI.XRTableCell

        Private tcDiscontHeader As DevExpress.XtraReports.UI.XRTableCell

        Private GroupHeaderTitle As DevExpress.XtraReports.UI.GroupHeaderBand

        Private tcUnitsInStock As DevExpress.XtraReports.UI.XRTableCell

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private tbProductData As DevExpress.XtraReports.UI.XRTable

        Private trProductData As DevExpress.XtraReports.UI.XRTableRow

        Private tcProductName As DevExpress.XtraReports.UI.XRTableCell

        Private tcUnitPrice As DevExpress.XtraReports.UI.XRTableCell

        Private tcUnitsOnOrder As DevExpress.XtraReports.UI.XRTableCell

        Private tcDiscont As DevExpress.XtraReports.UI.XRTableCell

        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand

        Private lbHeader As DevExpress.XtraReports.UI.XRLabel

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand

        Private nWindDataSet1 As T227361.NWindDataSet

        Private productsTableAdapter As T227361.NWindDataSetTableAdapters.ProductsTableAdapter
    End Class
End Namespace
