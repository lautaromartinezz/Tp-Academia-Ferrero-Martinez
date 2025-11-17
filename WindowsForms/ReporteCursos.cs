using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class ReporteCursos : Form
    {
        private string _userId;
        public string UserId { get { return _userId; } set { _userId = value; } }
        public ReporteCursos()
        {
            InitializeComponent();
        }

        private async void ReporteCursos_Load(object sender, EventArgs e)
        {
            var client = new HttpClient();  
            
            var bytes = await client.GetByteArrayAsync("https://localhost:7111/cursos/report/" + UserId);

            using var ms = new MemoryStream(bytes);

            reporteCursosViewer.LoadDocument(ms);
        }
    }
}
