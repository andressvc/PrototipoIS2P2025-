using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Cuentas_Corrientes
{
    public partial class Nav_Proveedores : Form
    {
        public Nav_Proveedores()
        {
            InitializeComponent();
            string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();

            string[] alias = { "idPeliculas", "Nombre", "Clasificación", "Genero", "Subtitulado", "Idioma", "precio", "estado" };
            navegador1.AsignarAlias(alias); // ← Corregido aquí
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.FromArgb(218, 247, 245));
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("Peliculas");
            navegador1.ObtenerIdAplicacion("1001");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("2");
            navegador1.AsignarNombreForm("Películas");
        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }
    }
}
