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

namespace DI_tema4_Ejercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string path = "";

            if (File.Exists("ruta"))
            {
                try
                {
                   //con BinaryStream
                }
                catch (Exception)
                {

                    throw;
                }
                
            }
            
        }

        private void GuardarArchivo(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Texto(*.txt)|*txt|Java(*.java)|*.java|Ini(*.ini)|*.ini|cs(*.cs)|*cs|Python(*.py)|*.py|Html(*.html)|*.html|" +
                    "Css(*.css)|*css|Xml(*.xml)|*.xml|Todos los archivos(*.*)|*.*";
            ofd.ShowDialog();

        }
    }
}
