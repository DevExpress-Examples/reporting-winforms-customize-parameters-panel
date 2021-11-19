using System;
using System.Windows.Forms;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.Expressions;
using DevExpress.XtraReports.UI;
using Orientation = DevExpress.XtraReports.Parameters.Orientation;

namespace CustomizeParameterPanel {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            var report = new XtraReport1();
            
            ParameterPanelFluentBuilder.Begin(report)
                .AddGroupItem(g0 => g0
                    .WithTitle("Select dates")
                    .AddParameterItem(report.Parameters[0], p0 => p0
                        .WithLabelOrientation(Orientation.Vertical)))
                .AddGroupItem(g1 => g1
                    .WithTitle("Select a customer")
                    .WithOrientation(Orientation.Horizontal)
                    .WithShowExpandButton(true)
                    .AddParameterItem(report.Parameters[1], p1 => p1
                        .WithLabelOrientation(Orientation.Vertical))
                    .AddSeparatorItem()
                    .AddParameterItem(report.Parameters[2], p2 => p2
                        .WithLabelOrientation(Orientation.Vertical)))
            .End();

            report.Parameters["customer"].ExpressionBindings.Add(
                new BasicExpressionBinding() {
                    PropertyName = "Enabled",
                    Expression = "!IsNullOrEmpty(?company)",
                }
            );
            
            report.ShowPreview();
        }
    }
}
