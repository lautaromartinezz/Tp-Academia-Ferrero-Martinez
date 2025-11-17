namespace WindowsForms
{
    partial class ReporteCursos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            reporteCursosViewer = new DevExpress.XtraPdfViewer.PdfViewer();
            SuspendLayout();
            // 
            // reporteCursosViewer
            // 
            reporteCursosViewer.Dock = DockStyle.Fill;
            reporteCursosViewer.Location = new Point(0, 0);
            reporteCursosViewer.Name = "reporteCursosViewer";
            reporteCursosViewer.Size = new Size(815, 733);
            reporteCursosViewer.TabIndex = 0;
            // 
            // ReporteCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 733);
            Controls.Add(reporteCursosViewer);
            Name = "ReporteCursos";
            Text = "ReporteCursos";
            Load += ReporteCursos_Load;
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraPdfViewer.PdfViewer reporteCursosViewer;
    }
}