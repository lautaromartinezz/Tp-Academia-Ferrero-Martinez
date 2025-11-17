using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;

namespace WebAPI.Reports
{
    public partial class ReporteCursos : DevExpress.XtraReports.UI.XtraReport
    {
        public ReporteCursos(int idUsuarioDado)
        {
            InitializeComponent();
            this.IdPersona.ExpressionBindings.AddRange(new DevExpress.XtraReports.Expressions.BasicExpressionBinding[] {
            new DevExpress.XtraReports.Expressions.BasicExpressionBinding("Value", idUsuarioDado.ToString())});
            Random random = new Random();
            this.invoiceNumber.Text = random.Next(1,10000).ToString();

        }
    }
}
