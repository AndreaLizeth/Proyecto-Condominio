﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace proyecto_condominios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ACCEDER_Click(object sender, EventArgs e)
        {

        }

        private void TxtBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            if (TxtUsuario.Text =="USUARIO") {
                TxtUsuario.Text = "";
                TxtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            //cuando el cursor del moyse sale del cuadro de texto
            if (TxtUsuario.Text=="") {
                TxtUsuario.Text = "USUARIO";
                TxtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void TxtContraseña_Enter(object sender, EventArgs e)
        {
            if (TxtContraseña.Text == "CONTRASEÑA")
            {
                TxtContraseña.Text = "";
                TxtContraseña.ForeColor = Color.LightGray;
                TxtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void TxtContraseña_Leave(object sender, EventArgs e)
        {
            //cuando el cursor del mouse sale del cuadro de texto
            if (TxtContraseña.Text == "")
            {
                TxtContraseña.Text = "CONTRASEÑA";
                TxtContraseña.ForeColor = Color.DimGray;
                TxtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TxtContraseña_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
