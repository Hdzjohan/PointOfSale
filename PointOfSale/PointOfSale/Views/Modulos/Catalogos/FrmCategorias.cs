﻿using PointOfSale.Controllers;
using PointOfSale.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.Views.Modulos.Catalogos
{
    public partial class FrmCategorias : Form
    {
        private dynamic objeto;
        private CategoriaController categoriaController;
        bool ModoCreate;

        public FrmCategorias()
        {
            InitializeComponent();
            categoriaController = new CategoriaController();
            ModoCreate = true;
        }

        public FrmCategorias(dynamic objeto)
        {
            InitializeComponent();
            categoriaController = new CategoriaController();
            this.objeto = objeto;

            if (this.objeto != null)
            {
                objeto = (Categoria)this.objeto;
                TxtClave.Text = objeto.CategoriaId;
            }

        }

        private void TxtClave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LlenaCampos();
            }
        }

        private void LlenaCampos()
        {
            if (objeto == null)
                ModoCreate = true;
            else
            {
                ModoCreate = false;
                TxtClave.Text = objeto.CategoriaId;
                TxtNombre.Text = objeto.Nombre;

            }


        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            InsertOrUpdate();
        }

        private void InsertOrUpdate()
        {
            if (ModoCreate)
            {
                if (TxtClave.Text.Trim().Length == 0)
                    return;

                objeto = new Categoria();
                objeto.CategoriaId = TxtClave.Text.Trim();
                objeto.Nombre = TxtNombre.Text.Trim();
                if (categoriaController.InsertOne(objeto))
                    Ambiente.Mensaje(Ambiente.CatalgoErrores[202]);
                else
                    Ambiente.Mensaje(Ambiente.CatalgoErrores[101]);
                Close();
            }
            else
            {
                objeto.Nombre = TxtNombre.Text.Trim();
                if (categoriaController.Update(objeto))
                    Ambiente.Mensaje(Ambiente.CatalgoErrores[202]);
                else
                    Ambiente.Mensaje(Ambiente.CatalgoErrores[101]);

                Close();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {

        }
    }
}
