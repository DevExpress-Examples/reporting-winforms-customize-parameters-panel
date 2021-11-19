<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraReport1
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.orderDates = New DevExpress.XtraReports.Parameters.Parameter()
        Me.orderDates_Start = New DevExpress.XtraReports.Parameters.RangeStartParameter()
        Me.orderDates_End = New DevExpress.XtraReports.Parameters.RangeEndParameter()
        Me.company = New DevExpress.XtraReports.Parameters.Parameter()
        Me.customer = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel3, Me.xrLabel2, Me.xrLabel1})
        Me.Detail.Name = "Detail"
        '
        'xrLabel3
        '
        Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 45.99997!)
        Me.xrLabel3.Multiline = True
        Me.xrLabel3.Name = "xrLabel3"
        Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel3.SizeF = New System.Drawing.SizeF(650.0!, 23.0!)
        Me.xrLabel3.StylePriority.UseTextAlignment = False
        Me.xrLabel3.Text = "Customer: [?customer]"
        Me.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrLabel2
        '
        Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 22.99999!)
        Me.xrLabel2.Multiline = True
        Me.xrLabel2.Name = "xrLabel2"
        Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel2.SizeF = New System.Drawing.SizeF(650.0!, 23.0!)
        Me.xrLabel2.StylePriority.UseTextAlignment = False
        Me.xrLabel2.Text = "Company: [?company]"
        Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrLabel1
        '
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.xrLabel1.Multiline = True
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(650.0!, 23.0!)
        Me.xrLabel1.StylePriority.UseTextAlignment = False
        Me.xrLabel1.Text = "Order dates: [?orderDates_Start] - [?orderDates_End]"
        Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'orderDates
        '
        Me.orderDates.Description = "Order Dates:"
        Me.orderDates.Name = "orderDates"
        Me.orderDates.Type = GetType(Date)
        Me.orderDates.ValueSourceSettings = New DevExpress.XtraReports.Parameters.RangeParametersSettings(Me.orderDates_Start, Me.orderDates_End)
        '
        'orderDates_Start
        '
        Me.orderDates_Start.Name = "orderDates_Start"
        Me.orderDates_Start.ValueInfo = "2021-11-03"
        '
        'orderDates_End
        '
        Me.orderDates_End.Name = "orderDates_End"
        Me.orderDates_End.ValueInfo = "2021-11-03"
        '
        'company
        '
        Me.company.Description = "Company Name:"
        Me.company.Name = "company"
        '
        'customer
        '
        Me.customer.Description = "Customer Name:"
        Me.customer.Name = "customer"
        '
        'XtraReport1
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail})
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.orderDates, Me.company, Me.customer})
        Me.Version = "21.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents xrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents orderDates As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents orderDates_Start As DevExpress.XtraReports.Parameters.RangeStartParameter
    Friend WithEvents orderDates_End As DevExpress.XtraReports.Parameters.RangeEndParameter
    Friend WithEvents company As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents customer As DevExpress.XtraReports.Parameters.Parameter
End Class
