using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraReports.UI;

namespace WebAPI.Reports
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public int idUsuario; // El que llega de afuera es el id del usuario
        public XtraReport1(int idUsuarioDado)
        {
            idUsuario = idUsuarioDado;
            InitializeComponent();
            // Parameters["IdPersona"].Value = 1;
        }
    }
}
