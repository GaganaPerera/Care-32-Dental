using System;
using System.IO;
using System.Windows.Forms;
using Kimtoo.Reports; // Add this using directive

namespace Care_32_Dental
{
    public partial class bill : Form
    {
        public bill()
        {
            InitializeComponent();
        }

        private void btnbill_Click(object sender, EventArgs e)
        {
            // Gather data from form
            string patient = txtpatient.Text.Trim();
            string treatment = txttreatment.Text.Trim();
            string doctor = txtdoc.Text.Trim();
            string amount = txtamt.Text.Trim();
            string notes = textBox1.Text.Trim();
            string date = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            // Create a new report
            var report = new Kimtoo.Reports.Report();

            // Add content to the report
            report.AddString("Care 32 Dental Clinic", fontSize: 16, bold: true, align: "center");
            report.AddString($"Date: {date}", align: "center");
            report.AddLine();
            report.AddString($"Patient: {patient}");
            report.AddString($"Treatment: {treatment}");
            report.AddString($"Doctor: {doctor}");
            report.AddString($"Amount: ₹{amount}", bold: true);
            if (!string.IsNullOrWhiteSpace(notes))
                report.AddString($"Notes: {notes}");
            report.AddLine();
            report.AddString("Thank you for your visit!", align: "center");

            // Save to desktop
            string filePath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                $"Bill_{DateTime.Now:yyyyMMdd_HHmmss}.pdf"
            );
            report.SaveAs(filePath);

            MessageBox.Show($"Bill generated successfully at:\n{filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
