using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApSocial.Entidades;
using ApSocial.DAO.BaseDeDatos;
using ApSocial.Controladora.Usuarios;
using ApSocial.Controladora.Amistades;

namespace ApSocial.Controladora.Comentario
{
    public class ComentariosController
    {
        DAOComentarios dataComentarios = DAOComentarios.Instance();

        UsuarioController usuariosController = new UsuarioController();
        AmistadesController amistadesController = new AmistadesController();

        public void nuevoComentario(int idUsuario, string mensaje, int idPub)
        {
            Comentarios comentario;
            try {
                if (mensaje == "") {
                    throw new Exception("Debe ingresar un mensaje");
                }
                comentario = new Comentarios(mensaje, idUsuario, idPub);
                dataComentarios.add(comentario);
            } catch (Exception ex) {
                throw ex;
            }

        }

        public List<Comentarios> getComentariosByPublicacion(int pubId, int userId)
        {
            List<Comentarios> comentarios = new List<Comentarios>();
            try {
                foreach (Comentarios comentario in dataComentarios.searchByPublicacionId(pubId).OrderBy(p => p.Fecha_creacion).ToList()) {
                    //Solo muestra los comentarios de gente que es amiga del que consulta (userId)
                    if (amistadesController.verificaAmistadExistente(comentario.UsuarioId, userId) || comentario.UsuarioId == userId) {
                        comentarios.Add(comentario);
                    }
                }
                return this.stringifyUserList(comentarios);
            } catch (Exception ex) {
                throw new Exception("No se pudieron recuperar los estados del usuario ID " + userId, ex);
            }
        }

        private List<Comentarios> stringifyUserList(List<Comentarios> lista)
        {
            List<Comentarios> comentarios = new List<Comentarios>();
            foreach (Comentarios pub in lista) {
                comentarios.Add(this.stringifyUser(pub));
            }
            return comentarios;
        }

        private Comentarios stringifyUser(Comentarios comentario)
        {
            try {
                comentario.Usuario = usuariosController.getUsuarioById(comentario.UsuarioId).ToString();
                return comentario;
            } catch (Exception ex) {
                throw new Exception("No se pudo obtener el string del usuario para el estado ID: " + comentario.Id, ex);
            }
        }

    }

}
