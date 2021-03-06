﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public partial class Mensajes : Form
    {
        Conexion cn = new Conexion();
        string user = "";
        string todo = "";
        string noleido = " and estado='No leido'";
        string leido = " and estado='leido'";
        public Mensajes(string id)
        {
            InitializeComponent();
            user = id;
            cargar(todo);
            rbtodo.Checked = true;
            dgmensajes.ClearSelection();
        }

        private void Mensajes_Load(object sender, EventArgs e)
        {
            
        }

        void cargar(string p)
        {
            dgmensajes.DataSource = null;
            dgmensajes.DataSource = cn.verMensajes(user,p).Tables["mensajes"];
            dgmensajes.ClearSelection();
        }

        private void rbtodo_CheckedChanged(object sender, EventArgs e)
        {
            cargar(todo);
        }

        private void rbleido_CheckedChanged(object sender, EventArgs e)
        {
            cargar(leido);
        }

        private void rbnoleido_CheckedChanged(object sender, EventArgs e)
        {
            cargar(noleido);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgmensajes.CurrentRow != null) 
            {
                int idmensaje = int.Parse(dgmensajes.CurrentRow.Cells[0].FormattedValue.ToString());
                if (idmensaje != -1)
                {
                    //MessageBox.Show(idmensaje.ToString());
                    if (MessageBox.Show("Esta acción no puede deshacerse. ¿Desea Continuar?",
                        "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (cn.eliminarMensaje(idmensaje))
                        {

                            MessageBox.Show("Mensaje Eliminado", "Éxito", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                            cargar(todo);
                            rbtodo.Checked = true;
                        }
                        else
                        {
                            MessageBox.Show("Hubo un error");
                        }
                    }
                }
            }
                          
            else
            {
                
            }
        }

        private void Mensajes_Shown(object sender, EventArgs e)
        {
            dgmensajes.ClearSelection();
        }

        private void btnresponder_Click(object sender, EventArgs e)
        {
            if (dgmensajes.CurrentRow != null)
            {
                string destino = dgmensajes.CurrentRow.Cells[1].FormattedValue.ToString();
                string nombre = dgmensajes.CurrentRow.Cells[2].FormattedValue.ToString();
                Respuesta resp = new Respuesta(user, destino, nombre);
                resp.ShowDialog();
            }
            else
            {

            }
                
        }

        private void dgmensajes_DoubleClick(object sender, EventArgs e)
        {
            if (dgmensajes.CurrentRow!= null)
            {
                int idm = int.Parse(dgmensajes.CurrentRow.Cells[0].FormattedValue.ToString());
                string m = dgmensajes.CurrentRow.Cells[3].FormattedValue.ToString();
                MessageBox.Show(m, "Mensaje", MessageBoxButtons.OK);
                cn.cambiarEstadoMensaje(idm);
                rbnoleido.Checked = true;
                cargar(noleido);
            }
            else
            {
                
            }
        }
    }
}
