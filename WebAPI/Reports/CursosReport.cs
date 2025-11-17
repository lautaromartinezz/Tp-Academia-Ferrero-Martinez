using DevExpress.XtraReports.UI;
using DTOs;

namespace WebAPI.Reports
{
    public class CursosReport : XtraReport
    {
        private TopMarginBand topMarginBand1;
        private DetailBand detailBand1;
        private BottomMarginBand bottomMarginBand1;

        public CursosReport(IEnumerable<CursoDTO> data)
        {
            DataSource = data;

            var detail = new DetailBand();
            Bands.Add(detail);

            var label = new XRLabel
            {
                ExpressionBindings = { new ExpressionBinding("BeforePrint", "Text", "[Nombre]") }
            };

            detail.Controls.Add(label);
        }

        private void InitializeComponent()
        {
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // detailBand1
            // 
            this.detailBand1.Name = "detailBand1";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // CursosReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.detailBand1,
            this.bottomMarginBand1});
            this.Version = "25.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
    }
}