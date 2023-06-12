using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diav0._0._1
{
    public partial class FormNuevoCliente : Form
    {
        private BUE.Cliente nuevoCliente;
        private BLL.ManageCliente gestorCliente;
        public FormNuevoCliente()
        {
            InitializeComponent();
            nuevoCliente = new BUE.Cliente();
            gestorCliente = new BLL.ManageCliente();
        }

        private void FormNuevoCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtDni.Text) 
                || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }else
            {
                if (txtDni.Text.All(char.IsDigit))
                {
                    int dnibuff = int.Parse(txtDni.Text);
                    if (gestorCliente.ExisteClienteDni(dnibuff))
                    {
                        MessageBox.Show("El dni ya esta registrado");
                        txtDni.Text = "";
                    }
                    else
                    {
                        nuevoCliente.Apellido = txtApellido.Text;
                        nuevoCliente.Nombre = txtNombre.Text;
                        nuevoCliente.Dni = dnibuff;
                        nuevoCliente.Email = txtEmail.Text;
                        try
                        {
                            if (gestorCliente.GuardarClienteNuevo(nuevoCliente))
                            {
                                MessageBox.Show("Guardado con exito");
                                this.Close();
                            }
                        }
                        catch (Exception) {

                            MessageBox.Show("Error al guardar en la base de datos");
                            this.Close();
                        }


                      

                    }
                }
                else { 
                    MessageBox.Show("El DNI debe ser un valor numerico");
                    txtDni.Text = "";
                }
                   

            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
