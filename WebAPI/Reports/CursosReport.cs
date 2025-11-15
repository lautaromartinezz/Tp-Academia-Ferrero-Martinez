using DevExpress.XtraReports.UI;
using DTOs;

namespace WebAPI.Reports
{
    public class CursosReport : XtraReport
    {
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
    }
}