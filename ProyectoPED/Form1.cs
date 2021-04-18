using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Crear variables globales tipo String para guardar los titulos o nombres de las canciones
        String[] paths, files;

        private void button1_Click(object sender, EventArgs e)
        {
            //codigo para seleccionar caciones
            OpenFileDialog ofd = new OpenFileDialog();
            //codigo para seleccionar varias canciones
            
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                files = ofd.SafeFileNames; // Guarda los nombres de los archivos
                paths = ofd.FileNames;//Guarda las rutas de los  de las caciones
                //Muesta los totulos de las canciones de en la lista

                for(int i = 0;i < files.Length; i++)
                {
                    Playlist.Items.Add(files[i]); //muestra las canciones en la lista
                }
            }

        }

        private void Playlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            //codigo para reproducir musica
            Playermusic.URL = paths[Playlist.SelectedIndex];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
