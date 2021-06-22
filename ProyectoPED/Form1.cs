using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PVS.MediaPlayer;

namespace ProyectoPED
{
    public partial class Form1 : Form
    {

        Player myPlayer;

        public Form1()
        {
            InitializeComponent();
            myPlayer = new Player();
            myPlayer.Events.MediaEnded += MyPlayer_MediaEnded;
        }
        //Crear variables globales tipo String para guardar los titulos o nombres de las canciones
        void MyPlayer_MediaEnded(object sender, EndedEventArgs e)
        {
            switch (e.StopReason)
            {
                case StopReason.Finished:
                    // media has finished playing
                    break;

                case StopReason.AutoStop:
                    // media is stopped by the player to play next media
                    break;

                case StopReason.UserStop:
                    // media is stopped with the Player.Stop method
                    break;

                case StopReason.Error:
                    // media has stopped because an error has occurred
                    break;
            }
        }
    }
}

