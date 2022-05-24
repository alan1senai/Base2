using DAL;
using Model;
<<<<<<< HEAD
using System;
using System.Collections.Generic;
=======
>>>>>>> b3d02c4ca63dc653997a22b8de78c1bd35634eb3
using System.Data;

namespace BLL
{
    public class UsuarioBLL
    {
        public Usuario Inserir(Usuario _usuario)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.Inserir(_usuario);
        }
<<<<<<< HEAD
        public void Excluir(int _id)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Excluir(_id);
=======
        public DataTable Buscar(string _filtro)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.Buscar(_filtro);
>>>>>>> b3d02c4ca63dc653997a22b8de78c1bd35634eb3
        }
        public Usuario Alterar(Usuario _usuario)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.Alterar(_usuario);
        }
<<<<<<< HEAD
        public DataTable  Buscar(string _filtro)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.Buscar(_filtro);           
        }

        public void Buscar(object text)
        {
            throw new NotImplementedException();
=======
        public void Excluir(int _id)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Excluir(_id);
>>>>>>> b3d02c4ca63dc653997a22b8de78c1bd35634eb3
        }
    }
}