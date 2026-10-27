using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Toko_Obat
{
    public partial class Kasir_StrukDialog : Form
    {
        private string teksStruk = string.Empty;

        public Kasir_StrukDialog(string teksStruk)
        {
            InitializeComponent();
            this.teksStruk = teksStruk;
            rtbStruk.Text = teksStruk;

            this.Load += (s, e) => AturTengahStruk();
            this.Shown += (s, e) => AturTengahStruk();
            rtbStruk.Resize += (s, e) => AturTengahStruk();
        }

        private void AturTengahStruk()
        {
            try
            {
                using (Graphics g = rtbStruk.CreateGraphics())
                {
                    SizeF sz = g.MeasureString("==========================================", rtbStruk.Font);
                    int sisaLebar = rtbStruk.ClientSize.Width - (int)sz.Width;
                    int indent = Math.Max(15, sisaLebar / 2);

                    rtbStruk.SelectAll();
                    rtbStruk.SelectionIndent = indent;
                    rtbStruk.SelectionRightIndent = indent;
                    rtbStruk.DeselectAll();
                }
            }
            catch { }
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += Pd_PrintPage;

                using (PrintDialog pDialog = new PrintDialog())
                {
                    pDialog.Document = pd;
                    if (pDialog.ShowDialog() == DialogResult.OK)
                    {
                        pd.Print();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mencetak struk: " + ex.Message, "Error Print", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (e.Graphics != null)
            {
                using (Font font = new Font("Courier New", 9))
                {
                    SizeF sz = e.Graphics.MeasureString("==========================================", font);
                    float x = Math.Max(10, (e.PageBounds.Width - sz.Width) / 2);
                    e.Graphics.DrawString(teksStruk, font, Brushes.Black, new PointF(x, 20));
                }
            }
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
