using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web.Extensions;

namespace WebAPI.Reports
{
    public class CustomReportStorage : ReportStorageWebExtension
    {
        private readonly string reportsDirectory;

        public CustomReportStorage()
        {
            reportsDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Reports");

            if (!Directory.Exists(reportsDirectory))
                Directory.CreateDirectory(reportsDirectory);
        }

        public override bool CanSetData(string url)
        {
            return true; 
        }

        public override bool IsValidUrl(string url)
        {
            return !string.IsNullOrWhiteSpace(url);
        }

        public override byte[] GetData(string url)
        {
            var filePath = Path.Combine(reportsDirectory, url + ".repx");

            if (!File.Exists(filePath))
                throw new FileNotFoundException("Reporte no encontrado", filePath);

            return File.ReadAllBytes(filePath);
        }

        public override Dictionary<string, string> GetUrls()
        {
            var files = Directory.GetFiles(reportsDirectory, "*.repx");
            var dict = new Dictionary<string, string>();

            foreach (var file in files)
            {
                var name = Path.GetFileNameWithoutExtension(file);
                dict[name] = name;
            }

            return dict;
        }

        public override void SetData(XtraReport report, string url)
        {
            var filePath = Path.Combine(reportsDirectory, url + ".repx");
            report.SaveLayoutToXml(filePath);
        }
    }
}
