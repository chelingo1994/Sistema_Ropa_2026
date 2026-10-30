using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using CapaRN;

namespace Sistema
{
    /// <summary>
    /// Ticket de venta para impresoras térmicas (80 mm o 58 mm) usando PrintDocument.
    /// </summary>
    public static class TicketVenta
    {
        #region Configuración (CAMBIAR POR LOS SUYOS)
        public static string Titulo = "NOTA DE VENTA";
        public static string EmpresaNombre = "TIENDA STYLE SHOP";
        public static string Sucursal = "Casa Matriz";
        public static string Direccion = "Av. Principal #123";
        public static string Zona = "Zona Central";
        public static string Telefono = "Teléfono 77875108";
        public static string Ciudad = "BERMEJO";
        public static string Nit = "1234567019";
        public static string Actividad = "Venta al por menor y mayorde prendas de vestir";
        public static string Leyenda = "En cumplimiento de la Ley N° 453 de 4 de diciembre de 2013, Ley general de los derechos de las usuarias y los usuarios y de las consumidoras y los consumidores";
        public static string Despedida = "¡GRACIAS POR SU COMPRA!";

        /// <summary>Ancho del papel: 80 o 58 (milímetros).</summary>
        public static int AnchoPapelMm = 80;

        /// <summary>Nombre de la impresora térmica. null = impresora predeterminada.</summary>
        public static string NombreImpresora = null;

        private const string Fuente = "Arial";
        #endregion

        /// <summary>
        /// Imprime el ticket. Con vistaPrevia = true muestra la vista previa en lugar de imprimir.
        /// </summary>
        public static void Imprimir(aventas venta, aclient cliente, List<litemven> items,
                                    string totalLiteral, bool vistaPrevia = false)
        {
            // Área imprimible real de las térmicas: 80 mm -> 72 mm, 58 mm -> 48 mm
            int anchoPapel = MmACentesimas(AnchoPapelMm);
            float anchoUtil = MmACentesimas(AnchoPapelMm == 58 ? 46 : 70);
            float x = (anchoPapel - anchoUtil) / 2f;

            // 1. Medir cuánto mide el ticket para no gastar papel en blanco
            float alto;
            using (Bitmap bmp = new Bitmap(1, 1))
            {
                bmp.SetResolution(100, 100);          // 1 pixel = 1/100 de pulgada, igual que la impresora
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.PageUnit = GraphicsUnit.Pixel;
                    alto = Dibujar(g, x, anchoUtil, venta, cliente, items, totalLiteral);
                }
            }

            // 2. Configurar el documento
            PrintDocument pd = new PrintDocument();
            pd.DocumentName = "Ticket " + venta.pavtcodven;
            if (!string.IsNullOrEmpty(NombreImpresora))
                pd.PrinterSettings.PrinterName = NombreImpresora;

            pd.DefaultPageSettings.PaperSize = new PaperSize("Ticket", anchoPapel, (int)alto + 40);
            pd.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
            pd.PrintPage += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.None;      // líneas nítidas en térmica
                Dibujar(e.Graphics, x, anchoUtil, venta, cliente, items, totalLiteral);
                e.HasMorePages = false;
            };

            // 3. Imprimir o mostrar vista previa
            if (vistaPrevia)
            {
                using (PrintPreviewDialog dlg = new PrintPreviewDialog())
                {
                    dlg.Document = pd;
                    dlg.Width = 500;
                    dlg.Height = 800;
                    dlg.ShowDialog();
                }
            }
            else
            {
                pd.PrintController = new StandardPrintController();   // sin ventana "Imprimiendo..."
                pd.Print();
            }
        }

        /// <summary>
        /// Dibuja el ticket y devuelve la altura total (en centésimas de pulgada).
        /// </summary>
        public static float Dibujar(Graphics g, float x, float ancho, aventas venta, aclient cliente,
                                    List<litemven> items, string totalLiteral)
        {
            bool angosto = AnchoPapelMm == 58;
            Font fNormal = new Font(Fuente, angosto ? 7f : 8f);
            Font fNegrita = new Font(Fuente, angosto ? 7f : 8f, FontStyle.Bold);
            Font fTitulo = new Font(Fuente, angosto ? 9f : 11f, FontStyle.Bold);
            Font fChica = new Font(Fuente, angosto ? 6f : 6.5f);
            Font fChicaB = new Font(Fuente, angosto ? 6f : 6.5f, FontStyle.Bold);

            StringFormat centro = new StringFormat { Alignment = StringAlignment.Center };
            StringFormat izquierda = new StringFormat { Alignment = StringAlignment.Near };
            StringFormat derecha = new StringFormat { Alignment = StringAlignment.Far };
            Brush negro = Brushes.Black;
            Pen linea = new Pen(Color.Black, 1);
            Pen punteada = new Pen(Color.Black, 1) { DashStyle = DashStyle.Dash };

            float y = 5;

            // Escribe un texto (con salto de línea automático) en un ancho dado
            Func<string, Font, StringFormat, float, float, float> Texto = (t, f, sf, xx, w) =>
            {
                SizeF tam = g.MeasureString(t ?? "", f, (int)w, sf);
                g.DrawString(t ?? "", f, negro, new RectangleF(xx, y, w, tam.Height + 1), sf);
                return tam.Height;
            };
            Action<string, Font> Centrado = (t, f) => { y += Texto(t, f, centro, x, ancho); };
            Action<string, string, Font> Par = (etiqueta, valor, f) =>
            {
                float h1 = Texto(etiqueta, f, izquierda, x, ancho * 0.6f);
                float h2 = Texto(valor, f, derecha, x + ancho * 0.4f, ancho * 0.6f);
                y += Math.Max(h1, h2);
            };
            Action Separador = () => { y += 3; g.DrawLine(punteada, x, y, x + ancho, y); y += 4; };

            // ================= ENCABEZADO =================
            Centrado(EmpresaNombre.ToUpper(), fTitulo);
            Centrado(Sucursal, fNormal);
            Centrado(Direccion, fNormal);
            Centrado(Zona, fNormal);
            Centrado(Telefono, fNormal);
            Centrado(Ciudad, fNormal);
            Centrado("NIT: " + Nit, fNormal);
            Centrado(Actividad, fChica);
            y += 4;
            Centrado(Titulo, fTitulo);
            Centrado("Nro.: " + NumeroVenta(venta.pavtcodven), fNegrita);
            Separador();

            // ================= DATOS DE LA VENTA =================
            Centrado("Fecha de Emisión: " + venta.cavtfechor.ToString("dd/MM/yyyy HH:mm"), fNormal);
            Centrado("Nombre/Razón Social: " + cliente.cacerazsoc, fNormal);
            Centrado("NIT/CI: " + cliente.cacenuidtr, fNormal);
            if (!string.IsNullOrWhiteSpace(cliente.cacedirecc))
                Centrado("Dirección: " + cliente.cacedirecc, fNormal);
            y += 4;

            // ================= DETALLE =================
            Centrado("DETALLE DE VENTA", fTitulo);
            y += 2;

            // Columnas: Cant. | Descripción | P.Unit | Subtotal
            float wCant = ancho * 0.12f, wDesc = ancho * 0.44f, wPre = ancho * 0.21f, wSub = ancho * 0.23f;
            float xCant = x, xDesc = x + wCant, xPre = xDesc + wDesc, xSub = xPre + wPre;
            float yTabla = y;

            // Encabezado de la tabla (fondo negro, letra blanca: se ve bien en térmica)
            float hEnc = g.MeasureString("Cant.", fChicaB).Height + 4;
            g.FillRectangle(negro, x, y, ancho, hEnc);
            g.DrawString("Cant.", fChicaB, Brushes.White, new RectangleF(xCant, y + 2, wCant, hEnc), centro);
            g.DrawString("Descripción", fChicaB, Brushes.White, new RectangleF(xDesc + 2, y + 2, wDesc, hEnc), izquierda);
            g.DrawString("P. Unit.", fChicaB, Brushes.White, new RectangleF(xPre, y + 2, wPre - 2, hEnc), derecha);
            g.DrawString("Subtotal", fChicaB, Brushes.White, new RectangleF(xSub, y + 2, wSub - 2, hEnc), derecha);
            y += hEnc + 3;

            foreach (litemven item in items)
            {
                string desc = item.capdnompro ?? "";
                if (!string.IsNullOrWhiteSpace(item.capdtalpro))
                    desc += " T/" + item.capdtalpro;

                float hDesc = Texto(desc, fChica, izquierda, xDesc + 2, wDesc - 4);
                Texto(item.cdevcantid.ToString(), fChica, centro, xCant, wCant);
                Texto(item.cdevpreuni.ToString("N2"), fChica, derecha, xPre, wPre - 2);
                Texto(item.cdevsubtot.ToString("N2"), fChica, derecha, xSub, wSub - 2);
                y += hDesc + 2;
            }
            y += 2;
            g.DrawRectangle(linea, x, yTabla, ancho - 1, y - yTabla);
            y += 5;

            // ================= TOTALES =================
            decimal total = items.Sum(i => i.cdevsubtot);
            Par("Subtotal Bs", total.ToString("N2"), fNormal);
            Par("Descuento Bs", 0m.ToString("N2"), fNormal);
            Par("TOTAL Bs", total.ToString("N2"), fTitulo);
            Par("Importe base crédito fiscal", total.ToString("N2"), fChica);
            y += 3;
            if (!string.IsNullOrWhiteSpace(totalLiteral))
                Centrado("Son: " + totalLiteral, fNormal);
            Separador();

            // ================= PIE =================
            Centrado(Leyenda, fChica);
            y += 6;
            Centrado(Despedida, fNegrita);
            y += 10;

            return y;
        }

        private static int MmACentesimas(double mm)
        {
            return (int)Math.Round(mm / 25.4 * 100);
        }
        private static string NumeroVenta(string codigo)
        {
            if (string.IsNullOrEmpty(codigo))
                return "";

            string parte = codigo.Substring(codigo.LastIndexOf('-') + 1);   // "000000000007"
            long numero;
            return long.TryParse(parte, out numero) ? numero.ToString() : parte;
        }
    }
}
