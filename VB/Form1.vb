Imports DevExpress.XtraReports.Parameters
Imports DevExpress.XtraReports.Expressions
Imports DevExpress.XtraReports.UI
Imports Orientation = DevExpress.XtraReports.Parameters.Orientation

Public Class Form1
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim report = New XtraReport1()

		ParameterPanelFluentBuilder.Begin(report).
			AddGroupItem(Function(g0) g0.
				WithTitle("Select dates").
				AddParameterItem(report.Parameters(0), Function(p0) p0.
					WithLabelOrientation(Orientation.Vertical))).
			AddGroupItem(Function(g1) g1.
				WithTitle("Select a customer").
				WithOrientation(Orientation.Horizontal).
				WithShowExpandButton(True).
				AddParameterItem(report.Parameters(1), Function(p1) p1.
					WithLabelOrientation(Orientation.Vertical)).
				AddSeparatorItem().
				AddParameterItem(report.Parameters(2), Function(p2) p2.
					WithLabelOrientation(Orientation.Vertical))).
			End()

		report.Parameters("customer").ExpressionBindings.Add(
			New BasicExpressionBinding() With {
				.PropertyName = "Enabled",
				.Expression = "!IsNullOrEmpty(?company)"
		})

		report.ShowPreview()
	End Sub
End Class
