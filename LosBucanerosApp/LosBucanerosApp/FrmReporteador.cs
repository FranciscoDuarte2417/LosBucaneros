using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LosBucanerosApp
{
    public partial class FrmReporteador : Form
    {
        string Id, Marca, Modelo, Nombre, Imei, CompaniaEquipo, Telefono, Sim, CompaniaLinea, Cargador, Cable, Audifonos, Protector, EsNuevo, Comentarios, Operador, TotalConLetra, Descuentos, ImporteDescuento, Usuario,TipoResponsiva;
        public FrmReporteador(string id,string marca, string modelo, string nombre, string imei, string companiaEquipo, string telefono, string sim, string companiaLinea, string cargador, string cable, string audifonos, string protector, string esNuevo, string comentarios, string operador, string totalConLetra, string descuentos, string importeDescuento, string usuario,string tiporesponsiva)
        {
            //string marca, string modelo, string nombre, string imei, string companiaEquipo, string telefono, string sim, string companiaLinea, string cargador, string cable, string audifonos, string protector, string esNuevo, string comentarios, string operador, string totalConLetra, string descuentos, string importeDescuento, string usuario
            InitializeComponent();
            TipoResponsiva = tiporesponsiva;
            Marca = marca;
            Modelo = modelo;
            Nombre = nombre;
            Imei = imei;
            CompaniaEquipo = companiaEquipo;
            Telefono = telefono;
            Sim = sim;
            CompaniaLinea = companiaLinea;
            Cargador = cargador;
            Cable = cable;
            Audifonos = audifonos;
            Protector = protector;
            EsNuevo = esNuevo;
            Comentarios = comentarios;
            Operador = operador;
            TotalConLetra = totalConLetra;
            Descuentos = descuentos;
            ImporteDescuento = importeDescuento;
            Usuario = usuario;
            Id = id;
        }

        private void FrmReporteador_Load(object sender, EventArgs e)
        {
            if (TipoResponsiva == "DESCUENTO")
            {
                CrystalReport1 reporte = new CrystalReport1();
                reporte.SetParameterValue("id", Id);
                reporte.SetParameterValue("marca", Marca);
                reporte.SetParameterValue("modelo", Modelo);
                reporte.SetParameterValue("nombre", Nombre);
                reporte.SetParameterValue("imei", Imei);
                reporte.SetParameterValue("companiaequipo", CompaniaEquipo);
                reporte.SetParameterValue("telefono", Telefono);
                reporte.SetParameterValue("sim", Sim);
                reporte.SetParameterValue("companialinea", CompaniaLinea);
                reporte.SetParameterValue("cargador", Cargador);
                reporte.SetParameterValue("cable", Cable);
                reporte.SetParameterValue("audifonos", Audifonos);
                reporte.SetParameterValue("protector", Protector);
                reporte.SetParameterValue("esnuevo", EsNuevo);
                reporte.SetParameterValue("comentarios", Comentarios);
                reporte.SetParameterValue("operador", Operador);
                reporte.SetParameterValue("totalconletra", TotalConLetra);
                reporte.SetParameterValue("descuentos", Descuentos);
                reporte.SetParameterValue("importedescuento", ImporteDescuento);
                reporte.SetParameterValue("usuario", Usuario);

                //aqui indicamos el reporte
                crystalReportViewer1.ReportSource = reporte;
                crystalReportViewer1.Refresh();    
            }
            if (TipoResponsiva == "PRESTAMO")
            {
                CrystalReport2 reporte = new CrystalReport2();
                reporte.SetParameterValue("id", Id);
                reporte.SetParameterValue("marca", Marca);
                reporte.SetParameterValue("modelo", Modelo);
                reporte.SetParameterValue("nombre", Nombre);
                reporte.SetParameterValue("imei", Imei);
                reporte.SetParameterValue("companiaequipo", CompaniaEquipo);
                reporte.SetParameterValue("telefono", Telefono);
                reporte.SetParameterValue("sim", Sim);
                reporte.SetParameterValue("companialinea", CompaniaLinea);
                reporte.SetParameterValue("cargador", Cargador);
                reporte.SetParameterValue("cable", Cable);
                reporte.SetParameterValue("audifonos", Audifonos);
                reporte.SetParameterValue("protector", Protector);
                reporte.SetParameterValue("esnuevo", EsNuevo);
                reporte.SetParameterValue("comentarios", Comentarios);
                reporte.SetParameterValue("operador", Operador);
                reporte.SetParameterValue("totalconletra", TotalConLetra);
                reporte.SetParameterValue("descuentos", Descuentos);
                ImporteDescuento = "";
                reporte.SetParameterValue("importedescuento", ImporteDescuento);
                reporte.SetParameterValue("usuario", Usuario);

                //aqui indicamos el reporte
                crystalReportViewer1.ReportSource = reporte;
                crystalReportViewer1.Refresh();
            }
            if (TipoResponsiva == "SIM")
            {
                CrystalReport3 reporte = new CrystalReport3();
                reporte.SetParameterValue("id", Id);
                reporte.SetParameterValue("marca", Marca);
                reporte.SetParameterValue("modelo", Modelo);
                reporte.SetParameterValue("nombre", Nombre);
                reporte.SetParameterValue("imei", Imei);
                reporte.SetParameterValue("companiaequipo", CompaniaEquipo);
                reporte.SetParameterValue("telefono", Telefono);
                reporte.SetParameterValue("sim", Sim);
                reporte.SetParameterValue("companialinea", CompaniaLinea);
                reporte.SetParameterValue("cargador", Cargador);
                reporte.SetParameterValue("cable", Cable);
                reporte.SetParameterValue("audifonos", Audifonos);
                reporte.SetParameterValue("protector", Protector);
                reporte.SetParameterValue("esnuevo", EsNuevo);
                reporte.SetParameterValue("comentarios", Comentarios);
                reporte.SetParameterValue("operador", Operador);
                reporte.SetParameterValue("totalconletra", TotalConLetra);
                reporte.SetParameterValue("descuentos", Descuentos);
                ImporteDescuento = "";
                reporte.SetParameterValue("importedescuento", ImporteDescuento);
                reporte.SetParameterValue("usuario", Usuario);

                //aqui indicamos el reporte
                crystalReportViewer1.ReportSource = reporte;
                crystalReportViewer1.Refresh();
            }
            
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
