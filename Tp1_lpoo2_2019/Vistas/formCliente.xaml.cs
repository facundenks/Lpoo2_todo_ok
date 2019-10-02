﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using ClasesBase;

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para formCliente.xaml
    /// </summary>
    public partial class formCliente : Window
    {
        Cliente oCliente = new Cliente();

        public formCliente()
        {
            InitializeComponent();
        }

        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (txtEmail.Text.Length == 0)
            {
                MessageBox.Show("Enter an email.");
                txtEmail.Focus();
            }
            else if (!Regex.IsMatch(txtEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                MessageBox.Show("Enter a valid email.");
                txtEmail.Select(0, txtEmail.Text.Length);
                txtEmail.Focus();
            }
            else
            {
                if (txtApellido.Text != "" && txtDni.Text != "" && txtEmail.Text != "" && txtNombre.Text != "" && txtTelefono.Text != "")
                {

                    oCliente.Cli_dni = txtDni.Text;
                    oCliente.Cli_nombre = txtNombre.Text;
                    oCliente.Cli_apellido = txtApellido.Text;
                    oCliente.Cli_email = txtEmail.Text;
                    oCliente.Cli_telefono = txtTelefono.Text;

                    limpiar();

                    MessageBox.Show("Nombre: " + oCliente.Cli_nombre + "\n Apellido: " + oCliente.Cli_apellido
                    + "\n DNI: " + oCliente.Cli_dni + "\n Email: " + oCliente.Cli_email + "\n Telefono: " + oCliente.Cli_telefono);
                }
                else {
                    MessageBox.Show("Completar todos los campos");
                }
            }
        }

        private void limpiar() {
            txtApellido.Clear();
            txtDni.Clear();
            txtEmail.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            limpiar();
        }

        
    }
}
