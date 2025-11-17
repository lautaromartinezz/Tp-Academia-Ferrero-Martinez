using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;

namespace WebAPI.Reports
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1(int idUsuarioDado)
        {
            InitializeComponent();
            this.IdPersona.ExpressionBindings.AddRange(new DevExpress.XtraReports.Expressions.BasicExpressionBinding[] {
            new DevExpress.XtraReports.Expressions.BasicExpressionBinding("Value", idUsuarioDado.ToString())});
            
            
        }
    }
}
