﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1GuiaPOO_Libreria
{
    public partial class frmLibreria : Form
    {
        public frmLibreria()
        {
            InitializeComponent();
        }

        int num;
        clsLibreria Libreria = new clsLibreria();
        List<clsProducto> ListaProductos = new List<clsProducto>();
        private void frmLibreria_Load(object sender, EventArgs e)
        {
            hideComponents();
        }

        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
            num++;

            clsProducto Product = new clsProducto();

            Product.Nombre = txtNombreProdu.Text;
            Product.Precio = float.Parse(txtPrecioProdu.Text);
            Product.Cantidad = int.Parse(txtCantProdu.Text);
            Product.CodigoDeBarras = int.Parse(txtCodBarras.Text);

            borrarTXTS();

            string infoProducto = Product.ProductInfo();
            ListaProductos.Add(Product);
            cbProductos.Items.Add(Product.Nombre);

            MessageBox.Show(infoProducto);
        }

        public void borrarTXTS()
        {
            txtCodBarras.Clear();
            txtPrecioProdu.Clear();
            txtCantProdu.Clear();
            txtNombreProdu.Clear();
        }
        public void hideComponents()
        {
            dataProductos.Hide();
            btnClosegrid.Hide();
        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            int i;
            i = 0;
            dataProductos.Rows.Clear();

            foreach (var producto in ListaProductos)
            {
               DataGridViewRow row = new DataGridViewRow();
               row.CreateCells(dataProductos);
               row.Cells[0].Value = ListaProductos[i].Nombre;
               row.Cells[1].Value = ListaProductos[i].Cantidad;
               dataProductos.Rows.Add(row);
               i++;
                
            }
            
            dataProductos.Show();
            btnClosegrid.Show();

        }

        private void btnClosegrid_Click(object sender, EventArgs e)
        {
            hideComponents();
        }

        private void cbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int cantidadVenta = int.Parse(txtcantVenta.Text);
                foreach(clsProducto producto in ListaProductos)
                {
                    if(cbProductos.SelectedItem.ToString() == producto.Nombre && txtcantVenta!=null)
                    {
                        int subtotal = Libreria.calcularVenta(cantidadVenta, producto.Precio);
                        txtSubtotal.Text = subtotal.ToString();
                    }

                }
                
            }catch(Exception ex)
            {
                MessageBox.Show("CARGUE LA CANTIDAD PORFAVOR Y VUELVA A SELECCIONAR EL PRODUCTO DESEADO");
            }
            
        }

        private void btnCargarVenta_Click(object sender, EventArgs e)
        {
            Libreria.TotalVendido += int.Parse(txtSubtotal.Text);
            MessageBox.Show($"El total vendido hasta ahora es de {Libreria.TotalVendido}");
            limpiarCamposVenta();
        }

        public void limpiarCamposVenta()
        {
            txtcantVenta.Clear();
            txtSubtotal.Clear();
            cbProductos.SelectedIndex=-1;
        }
    }
}
