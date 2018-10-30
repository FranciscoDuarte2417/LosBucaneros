using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace LosBucanerosApp
{
    public partial class FrmReposiva : Form
    {
        string Nombre, Apellido, Permiso;
        public FrmReposiva(string nombre, string apellido, string permiso)
        {
            InitializeComponent();
            Nombre = nombre;
            Apellido = apellido;
            Permiso = permiso;
        }
        string id,marca, modelo, nombre, imei, companiaequipo, telefono, sim, companialinea, cargador, cable, audifonos, protector, esnuevo,comentarios, operador, totalconletra, descuentos, importedescuento, usuario,Tipoempleado;
        ClsRutas correo = new ClsRutas();
        private void rptResponsivaDescuento_InitReport(object sender, EventArgs e)
        {

        }
        ClsResponsivas objresponsiva = new ClsResponsivas();
        private void FrmReposiva_Load(object sender, EventArgs e)
        {
            lblusuario.Text = "Bienvenido: " + Nombre + " " + Apellido;
            pbaltas.Image = LosBucanerosApp.Properties.Resources.alta;
            pbBuscar.Image = LosBucanerosApp.Properties.Resources.buscar;
            CargarComboOperadores();
            CargarComboAsignaciones();
            CargarComboEquipos();
            cmbasignacion.SelectedIndex = -1;
            cmbequipo.SelectedIndex = -1;
            cmbOperador.SelectedIndex = -1;
            cmbtipo.SelectedIndex = 0;
        }
        AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
        AutoCompleteStringCollection coleccion2 = new AutoCompleteStringCollection();
        AutoCompleteStringCollection coleccion3 = new AutoCompleteStringCollection();
        private string auxiliar;

        public void CargarComboOperadores()
        {
            cmbOperador.DataSource = null;
            objresponsiva.populateComboOperadores();
            cmbOperador.DataSource = objresponsiva.dt;
            cmbOperador.ValueMember = "Id";
            cmbOperador.DisplayMember = "Nombre";


            foreach (DataRow row in objresponsiva.dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["Nombre"]));
            }
            cmbOperador.AutoCompleteCustomSource = coleccion;
            cmbOperador.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbOperador.AutoCompleteSource = AutoCompleteSource.CustomSource;


        }

        public void CargarComboAdministrativos()
        {
            cmbOperador.DataSource = null;
            objresponsiva.CargarComboAdministradores();
            cmbOperador.DataSource = objresponsiva.dt;
            cmbOperador.ValueMember = "Id";
            cmbOperador.DisplayMember = "Nombre";


            foreach (DataRow row in objresponsiva.dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["Nombre"]));
            }
            cmbOperador.AutoCompleteCustomSource = coleccion;
            cmbOperador.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbOperador.AutoCompleteSource = AutoCompleteSource.CustomSource;


        }
        public void CargarComboAsignaciones()
        {
            cmbasignacion.DataSource = null;
            objresponsiva.populateComboAsignaciones();
            cmbasignacion.DataSource = objresponsiva.dt;
            cmbasignacion.ValueMember = "Id";
            cmbasignacion.DisplayMember = "Sim";


            foreach (DataRow row in objresponsiva.dt.Rows)
            {
                coleccion2.Add(Convert.ToString(row["Sim"]));
            }
            cmbasignacion.AutoCompleteCustomSource = coleccion2;
            cmbasignacion.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbasignacion.AutoCompleteSource = AutoCompleteSource.CustomSource;


        }

        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbequipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pbBuscar_MouseHover(object sender, EventArgs e)
        {
            pbBuscar.Image = LosBucanerosApp.Properties.Resources.buscar2;
        }

        private void pbBuscar_MouseLeave(object sender, EventArgs e)
        {
            pbBuscar.Image = LosBucanerosApp.Properties.Resources.buscar;
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            FrmResponsivas2 objmostrar;
            if (rbOperador.Checked == true)
            {
                objmostrar = new FrmResponsivas2(Nombre, Apellido, Permiso,"Operador");
            }
            else
            {
                objmostrar = new FrmResponsivas2(Nombre, Apellido, Permiso, "Administrador");
            }
            objmostrar.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CargarComboEquipos()
        {
            cmbequipo.DataSource = null;
            objresponsiva.populateComboEquipos();
            cmbequipo.DataSource = objresponsiva.dt;
            cmbequipo.ValueMember = "Id";
            cmbequipo.DisplayMember = "Imei";


            foreach (DataRow row in objresponsiva.dt.Rows)
            {
                coleccion3.Add(Convert.ToString(row["Imei"]));
            }
            cmbequipo.AutoCompleteCustomSource = coleccion3;
            cmbequipo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbequipo.AutoCompleteSource = AutoCompleteSource.CustomSource;


        }

        private void pbaltas_Click(object sender, EventArgs e)
        {
            gbResponsiva.Enabled = true;
            auxiliar = "insert";

            rbOperador.Enabled = true;
            rbAdministrativo.Enabled = true;
            rbOperador.Checked = true;
            lbltitulo.ForeColor = Color.Blue;
            cmbOperador.Focus();
            CargarComboOperadores();
            CargarComboAsignaciones();
            CargarComboEquipos();
            cmbasignacion.SelectedIndex = -1;
            cmbequipo.SelectedIndex = -1;
            cmbOperador.SelectedIndex = -1;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public void limpiarcampos()
        {
            gbResponsiva.Enabled = false;

            cmbOperador.SelectedIndex = -1;
            cmbequipo.SelectedIndex = -1;
            cmbasignacion.SelectedIndex = -1;
            txtComentarios.Text = "";
            txtdescuentos.Text = "";
            dgvequipos.DataSource = null;
            dgvlineas.DataSource = null;
            dgvOperadores.DataSource = null;
            lblprecio.Text = "...";
            lblprecioletras.Text = "...";
            lblcantidaddescuentos.Text = "...";
            lbldescuentosletra.Text = "...";

            lbldescuentosemanal.Text = "...";
            lbldescuentosemanalletra.Text = "...";

        }

        private void btnCancelar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            limpiarcampos();
        }

        private void cmbOperador_Leave(object sender, EventArgs e)
        {
            int index = cmbOperador.FindString(cmbOperador.Text);

            if (index>=0)
            {
                cmbOperador.SelectedIndex = index;
                cmbOperador.BackColor = Color.White;
                CargarGridOperadores();
            }
            else
            {
                cmbOperador.BackColor = Color.Red;
                dgvOperadores.DataSource = null;
            }
            
        }

        private void cmbasignacion_Leave(object sender, EventArgs e)
        {
            int index = cmbasignacion.FindString(cmbasignacion.Text);

            if (index >= 0)
            {
                cmbasignacion.SelectedIndex = index;
                cmbasignacion.BackColor = Color.White;
                CargarGriAsignaciones();
            }
            else
            {
                cmbasignacion.BackColor = Color.Red;
                dgvlineas.DataSource = null;
            }
        }
        
        private void cmbequipo_Leave(object sender, EventArgs e)
        {
            if (cmbequipo.Text!="")
            {

            int index = cmbequipo.FindString(cmbequipo.Text);

            if (index >= 0)
            {
                cmbequipo.SelectedIndex = index;
                cmbequipo.BackColor = Color.White;
                CargarGridEquipos();
                lblprecio.Text = "$ "+ dgvequipos["PrecioPublico", 0].Value.ToString();
                lblprecioletras.Text = enletras(dgvequipos["PrecioPublico", 0].Value.ToString());
                    //Convert.ToString(selectedRow.Cells["Id"].Value);
            }
            else
            {
                cmbequipo.BackColor = Color.White;
                dgvequipos.DataSource = null;
                lblprecio.Text = "Sin Equipo";
            }
            }
            else
            {
                cmbequipo.BackColor = Color.Red;
            }

        }

        private void cmbtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbtipo.SelectedIndex==1)
            {
                txtdescuentos.Enabled = false;
                txtdescuentos.Text = "";
                
            }
            else
            {
                txtdescuentos.Enabled = true;
               // txtdescuentos.Text = "";
            }
        }
        public void CargarGridOperadores()
        {
            //cuando esta disponible
            dgvOperadores.DataSource = null;
            objresponsiva.IdOperador =Convert.ToInt32(cmbOperador.SelectedValue);
            if (rbOperador.Checked == true)
            {
                objresponsiva.populateGridOperadores();
            }
            else
            {
                objresponsiva.populateGridAdministrativos();
            }
            
            dgvOperadores.DataSource = objresponsiva.dt;
          
            dgvOperadores.ClearSelection();
          

    }
        public void CargarGridEquipos()
        {
            //cuando esta disponible
            dgvequipos.DataSource = null;
            objresponsiva.IdEquipo = Convert.ToInt32(cmbequipo.SelectedValue);
            objresponsiva.populateGridEquipos();
            dgvequipos.DataSource = objresponsiva.dt;

        //    dgvequipos.ClearSelection();

        }
    public void CargarGriAsignaciones()
    {
        //cuando esta disponible
        dgvlineas.DataSource = null;
        objresponsiva.IdAsignacion = Convert.ToInt32(cmbasignacion.SelectedValue);
        objresponsiva.populateGridAsignaciones();
            dgvlineas.DataSource = objresponsiva.dt;

            dgvlineas.ClearSelection();

    }

        private void txtdescuentos_KeyPress(object sender, KeyPressEventArgs e)
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void gbGridOperadores_Enter(object sender, EventArgs e)
        {

        }

        private void txtdescuentos_TextChanged(object sender, EventArgs e)
        {
           
            if (cmbequipo.Text!="" && txtdescuentos.Text!="")
                {
                lblcantidaddescuentos.Text = txtdescuentos.Text;
               
                lbldescuentosemanal.Text = "$ " + (Convert.ToDouble(dgvequipos["PrecioPublico", 0].Value.ToString()) / Convert.ToDouble(txtdescuentos.Text)).ToString();
                string auxenletras = (Convert.ToDouble(dgvequipos["PrecioPublico", 0].Value.ToString()) / Convert.ToDouble(txtdescuentos.Text)).ToString();
                lbldescuentosletra.Text = enletras(txtdescuentos.Text);
                lbldescuentosemanalletra.Text = enletras(auxenletras);
                txtdescuentos.BackColor = Color.White;
            }
            else
            {
                
                txtdescuentos.BackColor = Color.Red;
            }
           
            
        }

        public string enletras(string num)


        {


            string res, dec = "";


            Int64 entero;


            int decimales;


            double nro;


            try


            {


                nro = Convert.ToDouble(num);


            }


            catch


            {


                return "";


            }


            entero = Convert.ToInt64(Math.Truncate(nro));


            decimales = Convert.ToInt32(Math.Round((nro -entero) * 100, 2));


            if (decimales > 0)


            {


                dec = " CON " +decimales.ToString() + "/ 100";


            }


            res = toText(Convert.ToDouble(entero)) + dec;


            return res;


        }


        private string toText(double value)


        {


            string Num2Text = "";


            value = Math.Truncate(value);


            if (value == 0) Num2Text = "CERO";


           else if (value == 1) Num2Text = "UNO";


           else if (value == 2) Num2Text = "DOS";


           else if (value == 3) Num2Text = "TRES";


           else if (value == 4) Num2Text = "CUATRO";


           else if (value == 5) Num2Text = "CINCO";


           else if (value == 6) Num2Text = "SEIS";


           else if (value == 7) Num2Text = "SIETE";


           else if (value == 8) Num2Text = "OCHO";


           else if (value == 9) Num2Text = "NUEVE";


           else if (value == 10) Num2Text = "DIEZ";


           else if (value == 11) Num2Text = "ONCE";


           else if (value == 12) Num2Text = "DOCE";


           else if (value == 13) Num2Text = "TRECE";


           else if (value == 14) Num2Text = "CATORCE";


           else if (value == 15) Num2Text = "QUINCE";


           else if (value < 20) Num2Text = "DIECI" +toText(value -10);


           else if (value == 20) Num2Text = "VEINTE";


           else if (value < 30) Num2Text = "VEINTI" +toText(value - 20);


           else if (value == 30) Num2Text = "TREINTA";


           else if (value == 40) Num2Text = "CUARENTA";


           else if (value == 50) Num2Text = "CINCUENTA";


           else if (value == 60) Num2Text = "SESENTA";


           else if (value == 70) Num2Text = "SETENTA";


           else if (value == 80) Num2Text = "OCHENTA";


           else if (value == 90) Num2Text = "NOVENTA";


           else if (value < 100) Num2Text = toText(Math.Truncate(value / 10) * 10) + " Y " +toText(value % 10);


           else if (value == 100) Num2Text = "CIEN";


           else if (value < 200) Num2Text = "CIENTO " +toText(value -100);


           else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2Text = toText(Math.Truncate(value / 100)) + "CIENTOS";


           else if (value == 500) Num2Text = "QUINIENTOS";


           else if (value == 700) Num2Text = "SETECIENTOS";


           else if (value == 900) Num2Text = "NOVECIENTOS";


           else if (value < 1000) Num2Text = toText(Math.Truncate(value / 100) * 100) + " " +toText(value % 100);


           else if (value == 1000) Num2Text = "MIL";


           else if (value < 2000) Num2Text = "MIL " +toText(value % 1000);


           else if (value < 1000000)


            {


                Num2Text = toText(Math.Truncate(value / 1000)) + " MIL";


                if ((value % 1000) > 0) Num2Text = Num2Text + " " +toText(value % 1000);


            }


            else if (value == 1000000) Num2Text = "UN MILLON";


           else if (value < 2000000) Num2Text = "UN MILLON " +toText(value % 1000000);


           else if (value < 1000000000000)


            {


                Num2Text = toText(Math.Truncate(value / 1000000)) + " MILLONES ";


                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) Num2Text = Num2Text + " " +toText(value - Math.Truncate(value / 1000000) * 1000000);


            }


            else if (value == 1000000000000) Num2Text = "UN BILLON";


           else if (value < 2000000000000) Num2Text = "UN BILLON " +toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);


           else


           {


                Num2Text = toText(Math.Truncate(value / 1000000000000)) + " BILLONES";


                if ((value -Math.Truncate(value / 1000000000000) * 1000000000000) > 0) Num2Text = Num2Text + " " +toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);


            }


            return Num2Text;


        }

        private void txtdescuentos_Leave(object sender, EventArgs e)
        {
            if (txtdescuentos.Text!="")
            {

                txtdescuentos.BackColor = Color.White;
                if (Convert.ToInt32(txtdescuentos.Text)>0)
            {
                txtdescuentos.BackColor = Color.White;
            }
            else
            {
                txtdescuentos.BackColor = Color.Red;

            }
            }
            else
            {
                txtdescuentos.BackColor = Color.Red;
            }
        }
       

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbtipo.SelectedIndex==0)
            {
                if (rbOperador.Checked == true)
                {
                    objresponsiva.TipoEmpleado = "Operador";
                    Tipoempleado = "Operador";
                }
                else
                {
                    objresponsiva.TipoEmpleado = "Administrativo";
                    Tipoempleado = "Administrativo";
                }
                if (cmbasignacion.BackColor==Color.White && cmbasignacion.BackColor == Color.White && txtdescuentos.Text!="")
                {
                    if (auxiliar == "insert")
                    {
                        if (cmbequipo.SelectedIndex == -1)
                        {
                            objresponsiva.Total = "0";
                            objresponsiva.IdEquipo = 0;
                            objresponsiva.Descuentos = "0";
                            objresponsiva.TipoResponsiva = "SIM";
                        }
                        else
                        {
                            objresponsiva.Total = dgvequipos["PrecioPublico", 0].Value.ToString();
                            objresponsiva.IdEquipo = Convert.ToInt32(cmbequipo.SelectedValue);
                            objresponsiva.Descuentos = txtdescuentos.Text;
                            objresponsiva.TipoResponsiva = cmbtipo.SelectedItem.ToString();
                        }
                        objresponsiva.IdAsignacion = Convert.ToInt32(cmbasignacion.SelectedValue);
                        
                        objresponsiva.IdOperador = Convert.ToInt32(cmbOperador.SelectedValue);


                        
                        objresponsiva.Fecha = DateTime.Now.ToShortDateString();
                        objresponsiva.Estatus = "Activo";
                        objresponsiva.Comentarios = txtComentarios.Text;
                        


                        objresponsiva.insertResponsiva();
                        objresponsiva.IdResponsiva();
                        

                        if (objresponsiva.resultado == 1)
                        {

                            MessageBox.Show("Registro Actualizado Con Exito", "Actualizacion Exitosa");

                            objresponsiva.UpdateDeviceStatus();
                            objresponsiva.UpdateAsignacionStatus();

                            

                            

                            id = objresponsiva.Id.ToString();
                            if (cmbequipo.SelectedIndex == -1)
                            {
                                marca = "N/A";
                                modelo = "N/A";
                                nombre = "N/A";
                                imei = "N/A";
                                companiaequipo = "N/A";
                                cargador = "N/A";
                                cable = "N/A";
                                audifonos = "N/A";
                                protector = "N/A";
                                esnuevo = "N/A";
                                companialinea = "TELCEL";
                            }
                            else
                            {
                                marca = dgvequipos["Marca", 0].Value.ToString();
                                modelo = dgvequipos["Modelo", 0].Value.ToString();
                                nombre = dgvequipos["Nombre", 0].Value.ToString();
                                imei = dgvequipos["Imei", 0].Value.ToString();
                                companiaequipo = dgvequipos["Compania", 0].Value.ToString();
                                companialinea = "TELCEL";
                                cargador = dgvequipos["Cargador", 0].Value.ToString();
                                cable = dgvequipos["Cable", 0].Value.ToString();
                                audifonos = dgvequipos["Audifonos", 0].Value.ToString();
                                protector = dgvequipos["Protector", 0].Value.ToString();
                                esnuevo = dgvequipos["EsNuevo", 0].Value.ToString();
                            }
                            
                            telefono = dgvlineas["Telefono", 0].Value.ToString();
                            sim = dgvlineas["Sim", 0].Value.ToString();
                            comentarios = txtComentarios.Text;
                            operador = dgvOperadores["Nombre", 0].Value.ToString() + " " + dgvOperadores["Nombre2", 0].Value.ToString() + " " + dgvOperadores["Apellido", 0].Value.ToString() + " " + dgvOperadores["Apellido2", 0].Value.ToString();
                            totalconletra = lblprecio.Text + " " + lblprecioletras.Text;
                            descuentos = lblcantidaddescuentos.Text;
                            importedescuento = lbldescuentosemanal.Text + " " + lbldescuentosemanalletra.Text;
                            usuario = Nombre.ToUpper() + " " + Apellido.ToUpper();

                            

                            if (objresponsiva.TipoResponsiva == "SIM")
                            {
                                
                                FrmReporteador objmostrar = new FrmReporteador(id, marca, modelo, nombre, imei, companiaequipo, telefono, sim, companialinea, cargador, cable, audifonos, protector, esnuevo, comentarios, operador, totalconletra, descuentos, importedescuento, usuario, "SIM");
                                objmostrar.Show();
                            }
                            else
                            {
                               
                                FrmReporteador objmostrar = new FrmReporteador(id, marca, modelo, nombre, imei, companiaequipo, telefono, sim, companialinea, cargador, cable, audifonos, protector, esnuevo, comentarios, operador, totalconletra, descuentos, importedescuento, usuario, "DESCUENTO");
                                objmostrar.Show();
                            }

                            
                        }
                        else if (objresponsiva.resultado == 2)
                        {
                            MessageBox.Show("Error: ya existe responsiva para este operador", "Responsiva Error");
                            //  error = 1;
                            limpiarcampos();
                            //error = 1;
                        }
                        else if (objresponsiva.resultado == 0)
                        {
                            MessageBox.Show("Error Al Actualizar Linea", "Error en Actualizacion");
                            //CargarGrid();
                            //  error = 1;
                            limpiarcampos();
                        }
                        else
                        {
                            MessageBox.Show("Error: 5002, Error Al Actualizar Linea: Enviar Captura de pantalla al correo: sistemas@losbucaneros.com ", "Error Fatal");

                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se admiten campos nulos");
                }               
            }
            else if (cmbtipo.SelectedIndex == 1)
            {
                if (rbOperador.Checked == true)
                {
                    objresponsiva.TipoEmpleado = "Operador";
                    Tipoempleado = "Operador";
                }
                else
                {
                    objresponsiva.TipoEmpleado = "Administrativo";
                    Tipoempleado = "Administrativo";
                }
                if (cmbasignacion.BackColor == Color.White && cmbasignacion.BackColor == Color.White)
                {
                    if (auxiliar == "insert")
                    {
                        if (cmbequipo.SelectedIndex == -1)
                        {
                            objresponsiva.Total = "0";
                            objresponsiva.IdEquipo = 0;
                            objresponsiva.Descuentos = "0";
                            objresponsiva.TipoResponsiva = "SIM"; ;
                        }
                        else
                        {
                            objresponsiva.Descuentos = "0";
                            objresponsiva.Total = dgvequipos["PrecioPublico", 0].Value.ToString();
                            objresponsiva.IdEquipo = Convert.ToInt32(cmbequipo.SelectedValue);
                            objresponsiva.TipoResponsiva = cmbtipo.SelectedItem.ToString();
                        }
                        objresponsiva.IdAsignacion = Convert.ToInt32(cmbasignacion.SelectedValue);
                        
                        objresponsiva.IdOperador = Convert.ToInt32(cmbOperador.SelectedValue);
                        
                        
                        
                        objresponsiva.Fecha = DateTime.Now.ToShortDateString();
                        objresponsiva.Estatus = "Activo";
                        objresponsiva.Comentarios = txtComentarios.Text;
                        


                        objresponsiva.insertResponsiva();
                        objresponsiva.IdResponsiva();

                        if (objresponsiva.resultado == 1)
                        {

                            MessageBox.Show("Registro Actualizado Con Exito", "Actualizacion Exitosa");

                            objresponsiva.UpdateDeviceStatus();
                            objresponsiva.UpdateAsignacionStatus();

                            

                            id = objresponsiva.Id.ToString();
                            if (cmbequipo.SelectedIndex == -1)
                            {
                                marca = "N/A";
                                modelo = "N/A";
                                nombre = "N/A";
                                imei = "N/A";
                                companiaequipo = "N/A";
                                cargador = "N/A";
                                cable = "N/A";
                                audifonos = "N/A";
                                protector = "N/A";
                                esnuevo = "N/A";
                            }
                            else
                            {
                                marca = dgvequipos["Marca", 0].Value.ToString();
                                modelo = dgvequipos["Modelo", 0].Value.ToString();
                                nombre = dgvequipos["Nombre", 0].Value.ToString();
                                imei = dgvequipos["Imei", 0].Value.ToString();
                                companiaequipo = dgvequipos["Compania", 0].Value.ToString();
                                cargador = dgvequipos["Cargador", 0].Value.ToString();
                                cable = dgvequipos["Cable", 0].Value.ToString();
                                audifonos = dgvequipos["Audifonos", 0].Value.ToString();
                                protector = dgvequipos["Protector", 0].Value.ToString();
                                esnuevo = dgvequipos["EsNuevo", 0].Value.ToString();
                            }
                            companialinea = dgvequipos["Compania", 0].Value.ToString();
                            telefono = dgvlineas["Telefono", 0].Value.ToString();
                            sim = dgvlineas["Sim", 0].Value.ToString();
                            comentarios = txtComentarios.Text;
                            operador = dgvOperadores["Nombre", 0].Value.ToString() + " " + dgvOperadores["Nombre2", 0].Value.ToString() + " " + dgvOperadores["Apellido", 0].Value.ToString() + " " + dgvOperadores["Apellido2", 0].Value.ToString();
                            totalconletra = lblprecio.Text + " " + lblprecioletras.Text;
                            descuentos = lblcantidaddescuentos.Text;
                            importedescuento = lbldescuentosemanal.Text + " " + lbldescuentosemanalletra.Text;
                            if (cmbtipo.SelectedIndex == 1)
                            {
                                importedescuento = "0";
                                descuentos = "0";
                            }
                            usuario = Nombre.ToUpper() + " " + Apellido.ToUpper();

                            if (objresponsiva.TipoResponsiva == "SIM")
                            {
                                
                                FrmReporteador objmostrar = new FrmReporteador(id, marca, modelo, nombre, imei, companiaequipo, telefono, sim, companialinea, cargador, cable, audifonos, protector, esnuevo, comentarios, operador, totalconletra, descuentos, importedescuento, usuario, "SIM");
                                objmostrar.Show();
                            }
                            else
                            {
                                
                                FrmReporteador objmostrar = new FrmReporteador(id, marca, modelo, nombre, imei, companiaequipo, telefono, sim, companialinea, cargador, cable, audifonos, protector, esnuevo, comentarios, operador, totalconletra, descuentos, importedescuento, usuario, "PRESTAMO");
                                objmostrar.Show();
                            }


                            
                        }
                        else if (objresponsiva.resultado == 2)
                        {
                            MessageBox.Show("Error: ya existe responsiva para este operador", "Responsiva Error");
                            //  error = 1;
                            limpiarcampos();
                            //error = 1;
                        }
                        else if (objresponsiva.resultado == 0)
                        {
                            MessageBox.Show("Error Al Actualizar Linea", "Error en Actualizacion");
                            //CargarGrid();
                            //  error = 1;
                            limpiarcampos();
                        }
                        else
                        {
                            MessageBox.Show("Error: 5002, Error Al Actualizar Linea: Enviar Captura de pantalla al correo: sistemas@losbucaneros.com ", "Error Fatal");

                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se admiten campos nulos");
                }
            }

            CargarComboAsignaciones();
            CargarComboEquipos();
            CargarComboOperadores();
            limpiarcampos();
        }
        

        private void cmbasignacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblcantidaddescuentos_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void gbResponsiva_Enter(object sender, EventArgs e)
        {

        }

        private void rbOperador_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOperador.Checked == true)
            {
                label2.Text = "Datos Operador";
                CargarComboOperadores();
                cmbOperador.SelectedIndex = -1;
                label11.Text = "Operador:";
            }
        }

        private void rbAdministrativo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAdministrativo.Checked == true)
            {
                label2.Text = "Datos Administrativo";
                CargarComboAdministrativos();
                cmbOperador.SelectedIndex = -1;
                label11.Text = "Administrativo:";

            }
        }
    }
}
