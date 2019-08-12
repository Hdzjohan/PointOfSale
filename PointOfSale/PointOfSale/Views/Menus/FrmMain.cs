﻿
using PointOfSale.CFDI33;
using PointOfSale.Controllers;
using PointOfSale.Views.Menus;
using PointOfSale.Views.Modulos.Catalogos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DYM.Views
{
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnLogistica_Click(object sender, EventArgs e)
        {
            var form = new FrmMenuLogistica
            {
                MdiParent = MdiParent.MdiParent
            };
            form.Show();
        }

        private void BtnPuntoVenta_Click(object sender, EventArgs e)
        {
            var form = new FrmMenuPuntoVenta
            {
                MdiParent = MdiParent.MdiParent
            };
            form.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            var o = new FrmBusinessManager();
            o.MdiParent = this.MdiParent;
            o.Show();
        }

        private void BtnConfiguracion_Click(object sender, EventArgs e)
        {
            var o = new FrmMenuConfig();
            o.MdiParent = this.MdiParent;
            o.Show();

        }

        private void BtnSalida_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnReportesGraficas_Click(object sender, EventArgs e)
        {
           // Ambiente.EscribirTraspaso("");
            return;
            EmpresaController empresaController = new EmpresaController();
            var empresa = empresaController.SelectTopOne();
            var file = "CS11082019";

            Ambiente.CrearDirectorio(empresa.DirectorioTrabajo + file);
            Ambiente.CopiarFile(empresa.RutaPlantillaTraspaso, empresa.DirectorioTrabajo+file+ @"\TRASPASO.XLSX", true);
            Ambiente.CopiarFile(empresa.RutaPlantillaDetalleTraspaso, empresa.DirectorioTrabajo+ file+ @"\TRASPASOP.XLSX", true);
            //Escribir platillas

            //Comprimir 
            Ambiente.ComprimirDirectorio(empresa.DirectorioTrabajo + file,empresa.DirectorioTraspasos+file+".zip");

        }
    }
}
