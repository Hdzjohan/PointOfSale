﻿using PointOfSale.Controllers;
using PointOfSale.Controllers.EvironmentController;
using PointOfSale.Models;
using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PointOfSale.Views.Modulos.Reportes
{
    public partial class FrmReportes : Form
    {
        private ReporteController reporteController;
        private Reporte reporte;
        private StiReport report;

        public FrmReportes()
        {
            InitializeComponent();
            InicializaReporteador();
            reporteController = new ReporteController();
        }

        private void InicializaReporteador()
        {
            Reports.corteController = new Controllers.CorteController();
            Reports.clienteController = new Controllers.ClienteController();
            Reports.compraController = new Controllers.CompraController();
            Reports.comprapController = new Controllers.ComprapController();
            Reports.flujoController = new Controllers.FlujoController();
            Reports.productoController = new Controllers.ProductoController();
            Reports.proveedorController = new Controllers.ProveedorController();
            Reports.ventaController = new Controllers.VentaController();
            Reports.ventapController = new Controllers.VentapController();
            Reports.empresaController = new Controllers.EmpresaController();
            Reports.empresa = Reports.empresaController.SelectTopOne();
        }

        private void BtnCierresCaja_Click(object sender, EventArgs e)
        {
            Ambiente.ShowReport(Ambiente.Empresa.FormatoCierres);
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
           //Ambiente.ShowReport()
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            Reports.Compras();
        }


        private void BtnComprasXdia_Click(object sender, EventArgs e)
        {
            Reports.Compras();
        }

        private void BtnEgresosVSIngresos_Click(object sender, EventArgs e)
        {
            using (var form = new FrmParamData())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Reports.IngresosVsEgresos(FrmParamData.Inicial.Date, FrmParamData.Final.Date, form.TodasLasFechas);
                }
            }
        }

        private void BtnExistencias_Click(object sender, EventArgs e)
        {
            Reports.Existencias();
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            Reports.Productos();
        }

        private void BtnProdConPrecio_Click(object sender, EventArgs e)
        {
            Reports.ProductosConPrecio();
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            Reports.Proveedores();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            var o = new FrmTest();
            o.MdiParent = MdiParent;
            o.Show();
        }

        private void BtnClientXMonXSal_Click(object sender, EventArgs e)
        {
            Reports.ClientesXmonedero();
        }

        private void BtnVentasACosto_Click(object sender, EventArgs e)
        {
            using (var form = new FrmParamData())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Reports.VentasAcosto(FrmParamData.Inicial.Date, FrmParamData.Final.Date, form.TodasLasFechas);
                }
            }
        }

        private void BtnVentasDelDia_Click(object sender, EventArgs e)
        {
            Reports.Ventas();
        }

        private void BtnVentasDetalladas_Click(object sender, EventArgs e)
        {
            Reports.VentasDetallada();
        }
    }
}
