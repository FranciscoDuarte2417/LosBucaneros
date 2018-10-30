using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LosBucanerosApp
{
    public partial class FrmAjustesAlmacenEquipos : Form
    {

        string status;
        string auxiliar;
        int error;
        string Nombre, Apellido, Permiso;
        string foto, foto2, idequipo,imei, marca, modelo, nombre, compania, cargador, cable,audifonos,protector,esnuevo,nofactura,autoriza,preciopublico,preciobucaneros,comentarios,estatus,pagomensual,equipopagado,meses;

        private void dgvEquipos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
        }

        private void dgvEquipos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblcont.Font = new Font("Times New Roman", 15.75f , FontStyle.Bold);
            lblcont.Text = "Equipos: " + dgvEquipos.RowCount;
            try
            {
                for (int count = 0; count < dgvEquipos.Rows.Count; count++)
                {
                    if (dgvEquipos.Rows[count].Cells["Imei"].ToString() != "")
                    {
                        dgvEquipos.Rows[count].Cells["Imei"].Style.ForeColor = Color.Red;
                    }

                    if (dgvEquipos.Rows[count].Cells["Compania"].ToString() != "TELCEL")
                    {
                        dgvEquipos.Rows[count].Cells["Compania"].Style.ForeColor = Color.Blue;
                    }
                    else if (dgvEquipos.Rows[count].Cells["Compania"].ToString() != "MOVISTAR")
                    {
                        dgvEquipos.Rows[count].Cells["Compania"].Style.ForeColor = Color.Green;
                    }
                    else if (dgvEquipos.Rows[count].Cells["Compania"].ToString() != "ATT")
                    {
                        dgvEquipos.Rows[count].Cells["Compania"].Style.ForeColor = Color.Orange;
                    }
                    else if (dgvEquipos.Rows[count].Cells["Compania"].ToString() != "UNEFON")
                    {
                        dgvEquipos.Rows[count].Cells["Compania"].Style.ForeColor = Color.Yellow;
                    }

                    



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbCamara_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Desea Reemplazar la foto del equipoco con Imei : " + imei, "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)

            {
                FrmFoto objmostrarfoto = new FrmFoto(Objequipos.Imei + "_" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString(), "imgEquipos");
                objmostrarfoto.ShowDialog();
                if (ClsAlmacenEquipos.existe == 1)
                {
                    DeleteFileFromS3();
                    //manda llamar el metodo de la clase
                    Objequipos.Id = Convert.ToInt32(idequipo);
                    Objequipos.Fotonombre = ClsAlmacenEquipos.fotoruta;
                    Objequipos.updateDeviceimage();
                    if (Objequipos.resultado == 1)
                    {

                        MessageBox.Show("Foto Actualizada Con Exito", "Almacenamiento Exitoso");
                        dgvEquipos.DataSource = null;
                        CargarGrid();
                        limpiarcampos();
                    }
                    else
                    {
                        MessageBox.Show("No se actualizo la foto");
                        limpiarcampos();
                    }


                }
            }
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
            txtModelo.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNombre.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtFactura_TextChanged(object sender, EventArgs e)
        {
            txtFactura.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtAutoriza_TextChanged(object sender, EventArgs e)
        {
            txtAutoriza.CharacterCasing = CharacterCasing.Upper;
        }

        private void pbCamara_MouseLeave(object sender, EventArgs e)
        {
            pbCamara.Image = LosBucanerosApp.Properties.Resources.camara2;
        }

        private void pbbajas_MouseHover(object sender, EventArgs e)
        {
            pbbajas.Image = LosBucanerosApp.Properties.Resources.baja2;
        }

        private void pbbajas_MouseLeave(object sender, EventArgs e)
        {
            pbbajas.Image = LosBucanerosApp.Properties.Resources.baja;
        }

        private void pbbajas_Click(object sender, EventArgs e)
        {
            lbltitulo.Text = "BAJAS - EQUIPOS";
            lbltitulo.ForeColor = Color.Red;
            auxiliar = "bajas";


            limpiarcampos();
            pbCamara.Visible = true;
            gbAltasEquipos.Enabled = true;
           

            int index = cmbCompania.FindString(compania);
            cmbCompania.SelectedIndex = index;

            int index2 = cmbMarca.FindString(marca);
            cmbMarca.SelectedIndex = index;



            txtImei.Text = imei;
            txtModelo.Text = modelo;
            txtNombre.Text = nombre;
            txtFactura.Text = nofactura;
            if (preciopublico.Length == 6)
            {
                preciopublico = "00" + preciopublico;
            }
            if (preciobucaneros.Length == 6)
            {
                preciobucaneros = "00" + preciobucaneros;
            }
            txtPrecioPublico.Text = preciopublico;
            txtPrecioBucaneros.Text = preciobucaneros;
            txtComentarios.Text = comentarios;
            txtAutoriza.Text = autoriza;


            if (cargador == "SI")
            {
                chkCargador.Checked = true;

            }
            else
            {
                chkCargador.Checked = false;

            }

            if (cable == "SI")
            {
                chkCable.Checked = true;

            }
            else
            {
                chkCable.Checked = false;

            }

            if (audifonos == "SI")
            {
                chkAudifonos.Checked = true;

            }
            else
            {
                chkAudifonos.Checked = false;

            }


            if (protector == "SI")
            {
                chkProtector.Checked = true;

            }
            else
            {
                chkProtector.Checked = false;

            }

            if (esnuevo == "SI")
            {
                chkEsNuevo.Checked = true;

            }
            else
            {
                chkEsNuevo.Checked = false;
                chkEsNuevo.Checked = false;
                txtFactura.Enabled = false;
                txtAutoriza.Enabled = true;

            }

            txtImei.Enabled = false;
            cmbMarca.Enabled = false;
            txtModelo.Enabled = false;
            txtNombre.Enabled = false;
            cmbCompania.Enabled = false;
            chkCable.Enabled = false;
            chkCargador.Enabled = false;
            chkAudifonos.Enabled = false;
            chkProtector.Enabled = false;
            chkEsNuevo.Enabled = false;
            txtFactura.Enabled = false;
            pbCamara.Enabled = false;
            txtAutoriza.Enabled = false;
            txtPrecioBucaneros.Enabled = false;
            txtPrecioPublico.Enabled = false;
            label16.Text = "Motivo: ";
            txtComentarios.Text = "";
            txtComentarios.Enabled = true;



        }

        private void txtBuscaOperadores_TextChanged(object sender, EventArgs e)
        {
            if (cmbcriteriobusqueda.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccionar un criterio de busqueda valido");
                txtBuscaOperadores.Text = "";
            }
            else if (cmbcriteriobusqueda.SelectedIndex == 0)
            {
                (dgvEquipos.DataSource as DataTable).DefaultView.RowFilter = string.Format("Imei LIKE '%{0}%'", txtBuscaOperadores.Text);
            }
            else if (cmbcriteriobusqueda.SelectedIndex == 1)
            {
                (dgvEquipos.DataSource as DataTable).DefaultView.RowFilter = string.Format("Modelo LIKE '%{0}%'", txtBuscaOperadores.Text);
            }
            else if (cmbcriteriobusqueda.SelectedIndex == 2)
            {
                (dgvEquipos.DataSource as DataTable).DefaultView.RowFilter = string.Format("Compania LIKE '%{0}%'", txtBuscaOperadores.Text);
            }
            else if (cmbcriteriobusqueda.SelectedIndex == 3)
            {
                (dgvEquipos.DataSource as DataTable).DefaultView.RowFilter = string.Format("Estatus LIKE '%{0}%'", txtBuscaOperadores.Text);
            }
        }

        private void pbfotousuario_Click(object sender, EventArgs e)
        {
            FrmFotoDialog objmostrar = new FrmFotoDialog(imei, marca+" "+modelo, img);
            objmostrar.ShowDialog();
        }

        private void txtImei_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbCamara_MouseHover(object sender, EventArgs e)
        {
            pbCamara.Image = LosBucanerosApp.Properties.Resources.camara2;
        }

        private void dgvEquipos_SelectionChanged(object sender, EventArgs e)
        {
            dgvEquipos.ReadOnly = true;
            gbAltasEquipos.Enabled = false;
            if (dgvEquipos.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvEquipos.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvEquipos.Rows[selectedrowindex];

                idequipo = Convert.ToString(selectedRow.Cells["Id"].Value);
                imei = Convert.ToString(selectedRow.Cells["Imei"].Value);
                marca = Convert.ToString(selectedRow.Cells["Marca"].Value);
                modelo = Convert.ToString(selectedRow.Cells["Modelo"].Value);
                nombre = Convert.ToString(selectedRow.Cells["Nombre"].Value);
                compania = Convert.ToString(selectedRow.Cells["Compania"].Value);
                cargador = Convert.ToString(selectedRow.Cells["Cargador"].Value);
                cable = Convert.ToString(selectedRow.Cells["Cable"].Value);
                audifonos = Convert.ToString(selectedRow.Cells["Audifonos"].Value);
                protector = Convert.ToString(selectedRow.Cells["Protector"].Value);
                esnuevo = Convert.ToString(selectedRow.Cells["EsNuevo"].Value);
                nofactura = Convert.ToString(selectedRow.Cells["NoFactura"].Value);
                autoriza = Convert.ToString(selectedRow.Cells["Autoriza"].Value);
                preciopublico = Convert.ToString(selectedRow.Cells["PrecioPublico"].Value);
                preciobucaneros = Convert.ToString(selectedRow.Cells["PrecioBucaneros"].Value);
                comentarios = Convert.ToString(selectedRow.Cells["comentarios"].Value);
                estatus = Convert.ToString(selectedRow.Cells["Estatus"].Value);
                foto = Convert.ToString(selectedRow.Cells["Foto"].Value);
                pagomensual = Convert.ToString(selectedRow.Cells["Pagomensual"].Value);
                meses = Convert.ToString(selectedRow.Cells["Meses"].Value);
                equipopagado = Convert.ToString(selectedRow.Cells["Equipopagado"].Value);
              



                if (foto != "")
                {

                    GetFileFromS3();

                }
                else
                {
                    img = null;
                    pbfotousuario.Image = null;
                }


            }
        }

        private void pbmodificaciones_Click(object sender, EventArgs e)
        {
            lbltitulo.Text = "MODIFICACIONES - EQUIPOS";
            lbltitulo.ForeColor = Color.Green;
            limpiarcampos();
            pbCamara.Visible = true;
            gbAltasEquipos.Enabled = true;
            auxiliar = "update";
          

            int index = cmbCompania.FindString(compania);
            cmbCompania.SelectedIndex = index;

            int index2 = cmbMarca.FindString(marca);
            cmbMarca.SelectedIndex = index;



            txtImei.Text = imei;
            txtModelo.Text = modelo;
            txtNombre.Text = nombre;
            txtFactura.Text = nofactura;
            if (preciopublico.Length == 6)
            {
                preciopublico = "  " + preciopublico;
            }
            if (preciobucaneros.Length == 6)
            {
                preciobucaneros = "  " + preciobucaneros;
            }

            if (preciopublico.Length == 8)
            {
                preciopublico = " " + preciopublico;
            }
            if (preciobucaneros.Length == 8)
            {
                preciobucaneros = " " + preciobucaneros;
            }

            //preciopublico = preciopublico.Replace('$',' ');
            //preciopublico = preciopublico.Replace(',', ' ');


            string PP = "";
            for (int i = 0; i < preciopublico.Length; i++)
            {
                if (preciopublico[i] == ',')
                {
                    break;
                }
                else
                {
                    PP = PP + preciopublico[i];
                }
            }
            string BB = "";
            for (int i = 0; i < preciobucaneros.Length; i++)
            {
                if (preciobucaneros[i] == ',')
                {
                    break;
                }
                else
                {
                    BB = BB + preciobucaneros[i];
                }
            }
            
            

            txtPrecioPublico.Text = "$"+preciopublico;
            txtPrecioBucaneros.Text = "$"+preciobucaneros;
            txtComentarios.Text = comentarios;
            txtAutoriza.Text = autoriza;


            if (cargador == "SI")
            {
                chkCargador.Checked = true;
              
            }
            else
            {
                chkCargador.Checked = false;
               
            }

            if (cable == "SI")
            {
                chkCable.Checked = true;

            }
            else
            {
                chkCable.Checked = false;

            }

            if (audifonos == "SI")
            {
                chkAudifonos.Checked = true;

            }
            else
            {
                chkAudifonos.Checked = false;

            }
            Objequipos.Pagomensual = pagomensual;
            Objequipos.Meses = meses;
            Objequipos.Equipopagado = equipopagado;


            if (protector == "SI")
            {
                chkProtector.Checked = true;

            }
            else
            {
                chkProtector.Checked = false;

            }

            if (esnuevo == "SI")
            {
                chkEsNuevo.Checked = true;
                txtFactura.Enabled = true;
                txtAutoriza.Enabled = true;
                if (equipopagado == "FINANCIADO")
                {
                    chkfinanciado.Checked = true;
                    txtmeses.Enabled = true;
                    txtmeses.Text = meses;
                }
                else
                {
                    chkfinanciado.Checked = false;
                    txtmeses.Enabled = false;
                    txtmeses.Text = "";
                }
            }
            else
            {
                chkEsNuevo.Checked = false;
                txtFactura.Enabled = false;
                txtAutoriza.Enabled = false;

            }

            txtImei.Enabled = true;
            cmbMarca.Enabled = true;
            txtModelo.Enabled = true;
            txtNombre.Enabled = true;
            cmbCompania.Enabled = true;
            chkCable.Enabled = true;
            chkCargador.Enabled = true;
            chkAudifonos.Enabled = true;
            chkProtector.Enabled = true;
            chkEsNuevo.Enabled = true;
         
            txtPrecioBucaneros.Enabled = true;
            txtPrecioPublico.Enabled = true;
            label16.Text = "Comentarios: ";
   
            txtComentarios.Enabled = true;

        }

        Image img;
        ClsAlmacenEquipos Objequipos = new ClsAlmacenEquipos();

        string io;
        public FrmAjustesAlmacenEquipos()
        {
            InitializeComponent();
          
        }

        private void FrmAjustesAlmacen_Load(object sender, EventArgs e)
        {
            lblcont.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold);
            cmbcriteriobusqueda.SelectedIndex = 0;

            
                pbaltas.Image = LosBucanerosApp.Properties.Resources.alta;
                pbmodificaciones.Image = LosBucanerosApp.Properties.Resources.modificaciones;
                pbbajas.Visible = false;
                pbCamara.Image = LosBucanerosApp.Properties.Resources.camara;

                pbbajas.Visible = true;
                pbbajas.Image = LosBucanerosApp.Properties.Resources.baja;
                pbCamara.Image = LosBucanerosApp.Properties.Resources.camara;
            
            
         
            CargarGrid();
        }

        private void pbaltas_MouseHover(object sender, EventArgs e)
        {
            pbaltas.Image = LosBucanerosApp.Properties.Resources.alta2;
        }

        private void pbaltas_MouseLeave(object sender, EventArgs e)
        {
            pbaltas.Image = LosBucanerosApp.Properties.Resources.alta;
        }

        private void pbaltas_Click(object sender, EventArgs e)
        {
            lbltitulo.Text = "ALTAS - EQUIPOS";
            lbltitulo.ForeColor = Color.Blue;
            gbAltasEquipos.Enabled = true;
            auxiliar = "insert";


            txtImei.Enabled = true;
            cmbMarca.Enabled = true;
            txtModelo.Enabled = true;
            txtNombre.Enabled = true;
            cmbCompania.Enabled = true;
            chkCable.Enabled = true;
            chkCargador.Enabled = true;
            chkAudifonos.Enabled = true;
            chkProtector.Enabled = true;
            chkEsNuevo.Enabled = true;
            pbCamara.Enabled = true;
            txtPrecioBucaneros.Enabled = true;
            txtPrecioPublico.Enabled = true;
            label16.Text = "Comentarios: ";
            
            txtComentarios.Enabled = true;

            txtImei.Focus();
        }

        private void txtImei_Leave(object sender, EventArgs e)
        {
            if (txtImei.TextLength!=15)
            {
                txtImei.BackColor = Color.Red;
            }
            else
            {
                txtImei.BackColor = Color.White;
            }
        }

        private void txtImei_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void chkEsNuevo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEsNuevo.Checked)
            {
                txtFactura.Enabled = true;
                txtAutoriza.Enabled = true;
                chkfinanciado.Enabled = true;
            }
            else
            {
                txtFactura.Enabled = false;
                txtAutoriza.Enabled = false;
                txtFactura.Text = "";
                txtAutoriza.Text = "";
                chkfinanciado.Enabled = false;
                txtmeses.Text = "";
            }
        }

        private void btnCancelar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gbAltasEquipos.Enabled = false;
            limpiarcampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtImei.Text == "" || txtNombre.Text == "" || txtModelo.Text == "" || cmbMarca.SelectedIndex < 0 || cmbCompania.SelectedIndex < 0 || status == "" || txtImei.TextLength!=15||(chkfinanciado.Checked && txtmeses.Text == ""))
            {
                MessageBox.Show("No se Aceptan Campos Vacios", "Error de Validacion");
            }
            else
            {
                if (auxiliar == "insert")
                {
                    ClsAlmacenEquipos.existe = 0;
                    Objequipos.Imei = txtImei.Text;
                    Objequipos.Marca = cmbMarca.SelectedItem.ToString();
                    Objequipos.Modelo = txtModelo.Text;
                    Objequipos.Nombre = txtNombre.Text;
                    Objequipos.Compania = cmbCompania.SelectedItem.ToString();
                    if (chkCargador.Checked)
                    {
                        Objequipos.Cargador = "SI";
                    }
                    else
                    {
                        Objequipos.Cargador = "NO";
                    }

                    if (chkCable.Checked)
                    {
                        Objequipos.Cable = "SI";
                    }
                    else
                    {
                        Objequipos.Cable = "NO";
                    }

                    if (chkAudifonos.Checked)
                    {
                        Objequipos.Audifonos = "SI";
                    }
                    else
                    {
                        Objequipos.Audifonos = "NO";
                    }
                    if (chkProtector.Checked)
                    {
                        Objequipos.Protector = "SI";
                    }
                    else
                    {
                        Objequipos.Protector = "NO";
                    }
                    if (chkEsNuevo.Checked)
                    {
                        Objequipos.EsNuevo = "SI";
                    }
                    else
                    {
                        Objequipos.EsNuevo = "NO";
                    }
                    
                    Objequipos.NoFactura = txtFactura.Text;
                    Objequipos.Autorizo = txtAutoriza.Text;
                   // Objequipos.PrecioPublico = txtPrecioPublico.Text.Substring(1, txtPrecioPublico.TextLength - 1);

                    string rentaa;
                    string rentaaux1 = txtPrecioBucaneros.Text.Substring(2, 2);
                    if (rentaaux1==" " || rentaaux1=="00"|| rentaaux1 == "  ")
                    {
                        rentaa= txtPrecioBucaneros.Text.Substring(5, txtPrecioBucaneros.TextLength-5);
                        Objequipos.PrecioBucaneros = rentaa;
                    }
                                   
                    else if (rentaaux1 == "01" || rentaaux1 == "02"|| rentaaux1 == "03"|| rentaaux1 == "04"|| rentaaux1 == "05"|| rentaaux1 == "06"|| rentaaux1 == "07"|| rentaaux1 == "08"|| rentaaux1 == "09"|| rentaaux1 == " 1" || rentaaux1 == " 2" || rentaaux1 == " 3" || rentaaux1 == " 4" || rentaaux1 == " 5" || rentaaux1 == " 6" || rentaaux1 == " 7" || rentaaux1 == " 8" || rentaaux1 == " 9")
                    {
                        rentaa = txtPrecioBucaneros.Text.Substring(3, txtPrecioBucaneros.TextLength - 3);
                        Objequipos.PrecioBucaneros = rentaa;

                    }
                    else
                    {
                        rentaa = txtPrecioBucaneros.Text.Substring(1, txtPrecioBucaneros.TextLength - 1);
                        Objequipos.PrecioBucaneros = rentaa;

                    }

                    if (chkfinanciado.Checked)
                    {
                        Objequipos.Equipopagado = "FINANCIADO";
                        Objequipos.Meses = txtmeses.Text;
                        double financia= Convert.ToDouble(rentaa) / Convert.ToDouble(txtmeses.Text);
                        Objequipos.Pagomensual = Math.Round(financia, 2).ToString();

                    }
                    else
                    {
                        Objequipos.Equipopagado = "CONTADO";
                        Objequipos.Meses = "";
                        Objequipos.Pagomensual = "";
                    }
                    



                    string rentaa2;
                    string rentaaux2 = txtPrecioPublico.Text.Substring(2, 2);
                    if (rentaaux2 == " " || rentaaux2 == "00")
                    {
                        rentaa2 = txtPrecioPublico.Text.Substring(5, txtPrecioPublico.TextLength - 5);
                        Objequipos.PrecioPublico = rentaa2;
                    }

                    else if (rentaaux1 == "01" || rentaaux1 == "02" || rentaaux1 == "03" || rentaaux1 == "04" || rentaaux1 == "05" || rentaaux1 == "06" || rentaaux1 == "07" || rentaaux1 == "08" || rentaaux1 == "09" || rentaaux1 == " 1" || rentaaux1 == " 2" || rentaaux1 == " 3" || rentaaux1 == " 4" || rentaaux1 == " 5" || rentaaux1 == " 6" || rentaaux1 == " 7" || rentaaux1 == " 8" || rentaaux1 == " 9")
                    {
                        rentaa2 = txtPrecioPublico.Text.Substring(3, txtPrecioPublico.TextLength - 3);
                        Objequipos.PrecioPublico = rentaa2;
                    }
                    else
                    {
                        rentaa2 = txtPrecioPublico.Text.Substring(1, txtPrecioPublico.TextLength - 1);
                        Objequipos.PrecioPublico = rentaa2;

                    }

                    Objequipos.Comentarios = txtComentarios.Text;
                    Objequipos.Estatus = "Disponible";



                    //objcoordinador.Nombre = txtNombreCoordinador.Text;
                    //objcoordinador.Nombre2 = txtNombre2Coordinador.Text;
                    //objcoordinador.Apellido = txtApellidoCoordinador.Text;
                    //objcoordinador.Apellido2 = txtApellido2Coordinador.Text;
                    //objcoordinador.Uce = cmbUce.SelectedItem.ToString();
                    //objcoordinador.Estatus = status;



                    DialogResult res = MessageBox.Show("Desea tomar una foto al Equipo?: ", "Confirmacion de foto", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (res == DialogResult.Yes)
                    {

                        FrmFoto objmostrarfoto = new FrmFoto(Objequipos.Imei + "_" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString(), "imgEquipos");
                        objmostrarfoto.ShowDialog();
                        if (ClsAlmacenEquipos.existe == 1)
                        {
                            //manda llamar el metodo de la clase
                            Objequipos.Fotonombre = ClsAlmacenEquipos.fotoruta;
                            preciobucaneros = preciobucaneros.Trim(' ');
                            Objequipos.PrecioBucaneros = Objequipos.PrecioBucaneros.Trim(' ');
                            Objequipos.PrecioPublico = Objequipos.PrecioPublico.Trim(' ');
                            Objequipos.insertDevices();
                            if (Objequipos.resultado == 1)
                            {

                                MessageBox.Show("Registro Almacenado Con Exito", "Almacenamiento Exitoso");
                                dgvEquipos.DataSource = null;
                                CargarGrid();
                                limpiarcampos();
                            }
                            else if (Objequipos.resultado == 2)
                            {
                                MessageBox.Show("Error: IMEI ya existe", "Equipo Duplicado");
                                error = 1;
                            }
                            else if (Objequipos.resultado == 0)
                            {
                                MessageBox.Show("Error Al Registrar Equipo", "Error en Registro");
                                //CargarGrid();
                                error = 1;
                                limpiarcampos();
                            }

                        }
                        else
                        {
                            DialogResult res2 = MessageBox.Show("Desea guardar equipo sin foto?: ", "Confirmacion de foto", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (res2 == DialogResult.Yes)
                            {
                                Objequipos.Fotonombre = "";
                                Objequipos.insertDevices();
                                if (Objequipos.resultado == 1)
                                {

                                    MessageBox.Show("Registro Almacenado Con Exito", "Almacenamiento Exitoso");
                                    dgvEquipos.DataSource = null;
                                    CargarGrid();
                                    limpiarcampos();
                                }
                                else if (Objequipos.resultado == 2)
                                {
                                    MessageBox.Show("Error: IMEI de equipo ya existe", "Equipo Duplicado");
                                    error = 1;
                                }
                                else if (Objequipos.resultado == 0)
                                {
                                    MessageBox.Show("Error Al Registrar Equipo", "Error en Registro");
                                    //CargarGrid();
                                    error = 1;
                                    limpiarcampos();
                                }
                            }
                            else if (res2 == DialogResult.No)
                            {

                            }
                        }


                    }
                    else if (res == DialogResult.No)
                    {
                        Objequipos.Fotonombre = "";
                        Objequipos.insertDevices();
                        if (Objequipos.resultado == 1)
                        {

                            MessageBox.Show("Registro Almacenado Con Exito", "Almacenamiento Exitoso");
                            dgvEquipos.DataSource = null;
                            CargarGrid();
                            limpiarcampos();
                        }
                        else if (Objequipos.resultado == 2)
                        {
                            MessageBox.Show("Error: IMEI de equipo ya existe", "Equipo Duplicado");
                            error = 1;
                        }
                        else if (Objequipos.resultado == 0)
                        {
                            MessageBox.Show("Error Al Registrar Equipo", "Error en Registro");
                            //CargarGrid();
                            error = 1;
                            
                        }
                    }

                }
                else if (auxiliar == "update")
                {
                    //asignar valores a valariables de la clase
                    Objequipos.Imei = txtImei.Text;
                    Objequipos.Marca = cmbMarca.SelectedItem.ToString();
                    Objequipos.Modelo = txtModelo.Text;
                    Objequipos.Nombre = txtNombre.Text;
                    Objequipos.Compania = cmbCompania.SelectedItem.ToString();
                    if (chkCargador.Checked)
                    {
                        Objequipos.Cargador = "SI";
                    }
                    else
                    {
                        Objequipos.Cargador = "NO";
                    }

                    if (chkCable.Checked)
                    {
                        Objequipos.Cable = "SI";
                    }
                    else
                    {
                        Objequipos.Cable = "NO";
                    }

                    if (chkAudifonos.Checked)
                    {
                        Objequipos.Audifonos = "SI";
                    }
                    else
                    {
                        Objequipos.Audifonos = "NO";
                    }
                    if (chkProtector.Checked)
                    {
                        Objequipos.Protector = "SI";
                    }
                    else
                    {
                        Objequipos.Protector = "NO";
                    }
                    if (chkEsNuevo.Checked)
                    {
                        Objequipos.EsNuevo = "SI";
                    }
                    else
                    {
                        Objequipos.EsNuevo = "NO";
                    }
                    Objequipos.NoFactura = txtFactura.Text;
                    Objequipos.Autorizo = txtAutoriza.Text;
                    string rentaa;
                    string rentaaux1 = txtPrecioBucaneros.Text.Substring(2, 2);
                    if (rentaaux1 == " " || rentaaux1 == "00" || rentaaux1 == "  ")
                    {
                        rentaa = txtPrecioBucaneros.Text.Substring(5, txtPrecioBucaneros.TextLength - 5);
                        Objequipos.PrecioBucaneros = rentaa.Trim();
                    }

                    else if (rentaaux1 == "01" || rentaaux1 == "02" || rentaaux1 == "03" || rentaaux1 == "04" || rentaaux1 == "05" || rentaaux1 == "06" || rentaaux1 == "07" || rentaaux1 == "08" || rentaaux1 == "09" || rentaaux1 == " 1" || rentaaux1 == " 2" || rentaaux1 == " 3" || rentaaux1 == " 4" || rentaaux1 == " 5" || rentaaux1 == " 6" || rentaaux1 == " 7" || rentaaux1 == " 8" || rentaaux1 == " 9")
                    {
                        rentaa = txtPrecioBucaneros.Text.Substring(3, txtPrecioBucaneros.TextLength - 3);
                        Objequipos.PrecioBucaneros = rentaa.Trim();

                    }
                    else
                    {
                        rentaa = txtPrecioBucaneros.Text.Substring(1, txtPrecioBucaneros.TextLength - 1);
                        Objequipos.PrecioBucaneros = rentaa.Trim();

                    }




                    string rentaa2;
                    string rentaaux2 = txtPrecioPublico.Text.Substring(2, 2);
                    if (rentaaux2 == " " || rentaaux2 == "00")
                    {
                        rentaa2 = txtPrecioPublico.Text.Substring(5, txtPrecioPublico.TextLength - 5);
                        Objequipos.PrecioPublico = rentaa2.Trim();
                    }

                    else if (rentaaux2 == "01" || rentaaux2 == "02" || rentaaux2 == "03" || rentaaux2 == "04" || rentaaux2 == "05" || rentaaux2 == "06" || rentaaux2 == "07" || rentaaux2 == "08" || rentaaux2 == "09" || rentaaux2 == " 1" || rentaaux2 == " 2" || rentaaux2 == " 3" || rentaaux2 == " 4" || rentaaux2 == " 5" || rentaaux2 == " 6" || rentaaux2 == " 7" || rentaaux2 == " 8" || rentaaux2 == " 9")
                    {
                        rentaa2 = txtPrecioPublico.Text.Substring(3, txtPrecioPublico.TextLength - 3);
                        Objequipos.PrecioPublico = rentaa2.Trim();
                    }
                    else
                    {
                        rentaa2 = txtPrecioPublico.Text.Substring(1, txtPrecioPublico.TextLength - 1);
                        Objequipos.PrecioPublico = rentaa2.Trim();

                    }
                    Objequipos.Comentarios = txtComentarios.Text;
                    Objequipos.Estatus = "Disponible";
                    Objequipos.Id = Convert.ToInt32(idequipo);

                    //manda llamar el metodo de la clase
                    Objequipos.updateDevice();
                    //comprobamos si se realizo con exio
                    if (Objequipos.resultado == 1)
                    {
                        MessageBox.Show("Registro Actualizado Con Exito", "Actualizacion Exitosa");
                        dgvEquipos.DataSource = null;
                        CargarGrid();
                        limpiarcampos();
                    }
                    else if (Objequipos.resultado == 2)
                    {
                        MessageBox.Show("Error: Nombre de Equipo ya existe", "Equipo Duplicado");
                        //error = 1;
                    }
                    else if (Objequipos.resultado == 0)
                    {
                        MessageBox.Show("Error Al Actualizar Equipo", "Error en Actualizacion");
                        //CargarGrid();
                        //  error = 1;
                        
                    }
                    else
                    {
                        MessageBox.Show("Error: 1002, Error Al Actualizar: Enviar Captura de pantalla al correo: sistemas@losbucaneros.com ", "Error Fatal");
                    }
                }
                else if (auxiliar == "bajas")
                {
                    if (txtComentarios.Text == "")
                    {
                        MessageBox.Show("Es Necesario Indicar El Motivo de La Baja");
                        txtComentarios.Focus();
                    }
                    else
                    {


                        DialogResult res = MessageBox.Show("Esta Seguro que desea dar de baja el equipo Con: " + imei, "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (res == DialogResult.Yes)
                        {
                            Objequipos.Id = Convert.ToInt32(idequipo);
                            Objequipos.Comentarios = txtComentarios.Text;
                            Objequipos.deleteDevice();
                            if (Convert.ToInt32(Objequipos.resultado) == 1)
                            {
                                MessageBox.Show("Equipo dado de baja con exito", "EXITO");
                                DeleteFileFromS3();
                                CargarGrid();
                                limpiarcampos();
                            }
                            else
                            {
                                MessageBox.Show("Error: 2001  al dar de baja equipo, enviar captura de pantalla a sistemas@losbucaneros.com", "Error Fatal");

                            }

                            //Some task…  
                        }
                        if (res == DialogResult.No)
                        {
                            gbAltasEquipos.Enabled = false;
                            limpiarcampos();


                        }
                    }
                }
            }
        }






        public void CargarGrid()
        {
            dgvEquipos.DataSource = null; 
            Objequipos.populateGridDevices();
            dgvEquipos.DataSource = Objequipos.dt;
            DataGridViewCellStyle style = new DataGridViewCellStyle();

            //Font fuente = new Font(dgvCoordinador.Font, FontStyle.Bold);



            //dgvEquipos.Columns["Nombre"].DefaultCellStyle.ForeColor = Color.Blue;
            //dgvEquipos.Columns["Nombre"].DefaultCellStyle.Font = fuente;
            //dgvEquipos.Columns["Apellido"].DefaultCellStyle.ForeColor = Color.Blue;
            //dgvEquipos.Columns["Apellido"].DefaultCellStyle.Font = fuente;
            dgvEquipos.ClearSelection();

        }
        public void limpiarcampos()
        {
         
            gbAltasEquipos.Enabled = false;

            pbCamara.Visible = false;
            txtImei.Text = "";
            cmbMarca.SelectedIndex = -1;
            txtModelo.Text = "";
            txtNombre.Text = "";
            cmbCompania.SelectedIndex = -1;
            chkCargador.Checked = false;
            chkCable.Checked = false;
            chkAudifonos.Checked = false;
            chkProtector.Checked = false;
            chkEsNuevo.Checked = false;
            txtFactura.Text = "";
            txtAutoriza.Text = "";
            txtPrecioPublico.Text = "";
            txtPrecioBucaneros.Text = "";
            txtComentarios.Text="";


        }

        private void GetFileFromS3()
        {


            var awsAccessKey = "AKIAI5KHC3XKCDKYP3NQ";
            var awsSecretKey = "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";
            //  var existingBucketName = "losbucaneros";
            //var subDirectoryInBucket = "imgUsuarios";
            var client = Amazon.AWSClientFactory.CreateAmazonS3Client(awsAccessKey, awsSecretKey, RegionEndpoint.USEast1);


            try
            {
                GetObjectResponse getObjRespone = client.GetObject("losbucaneros/imgEquipos", foto);
                MemoryStream stream = new MemoryStream();
                getObjRespone.ResponseStream.CopyTo(stream);

                var image = Image.FromStream(stream);
                img = image;
                pbfotousuario.Image = image;
            }
            catch (Exception)
            {

                MessageBox.Show("Error:750 Error al mostrar imagen de Equipo con IMEI: " + imei, "Error Fatal");
            }



        }

        private void DeleteFileFromS3()
        {
            var awsAccessKey = "AKIAI5KHC3XKCDKYP3NQ";
            var awsSecretKey = "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";
            var existingBucketName = "losbucaneros/imgEquipos";
            // var subDirectoryInBucket = "imgUsuarios";
            var client = Amazon.AWSClientFactory.CreateAmazonS3Client(awsAccessKey, awsSecretKey, RegionEndpoint.USEast1);

            if (error == 0)
            {
                // Guarda la foto si no hay error en la base de datos
                DeleteObjectRequest deleteObjectRequest = new DeleteObjectRequest
                {

                    BucketName = existingBucketName,
                    Key = foto
                };
                try
                {
                    client.DeleteObject(deleteObjectRequest);

                }
                catch (AmazonS3Exception s3Exception)
                {

                }
            }
            else if (error == 1)
            {
                //elimina la imagen que se habia guardado, pero marco error al guardar en la base de datos
                DeleteObjectRequest deleteObjectRequest = new DeleteObjectRequest
                {

                    BucketName = existingBucketName,
                    Key = foto2
                };
                try
                {
                    client.DeleteObject(deleteObjectRequest);

                }
                catch (AmazonS3Exception s3Exception)
                {

                }

            }
            foto = "";
            foto2 = "";
            error = 0;





        }

        private void dgvEquipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPrecioPublico_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtPrecioPublico_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPrecioPublico_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void chkfinanciado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkfinanciado.Checked)
            {
                txtmeses.Enabled = true;
            }
            else
            {
                txtmeses.Text = "";
                txtmeses.Enabled = false;
            }
        }

        private void crystalReport21_InitReport(object sender, EventArgs e)
        {

        }
    }
}
