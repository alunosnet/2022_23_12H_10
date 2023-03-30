using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace GYMdoJime2_Modulo17E.Data
{
    public class AppRoleProvider : RoleProvider
    {
        private GYMdoJime2_Modulo17EContext db = new GYMdoJime2_Modulo17EContext();
        public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            try
            {
                var utilizador = db.Utilizadores.Where(u => u.nome == username).First();
                if (utilizador == null)
                {
                    throw new Exception();
                }
                if (utilizador.perfil == 0)
                {
                    return new string[] { "Administrador" };

                }
                else if(utilizador.perfil == 1)
                {
                    return new string[] { "Treinador" };
                }else
                {
                    return new string[] { "Utilizador" };
                }

            }
            catch
            {
                return new string[] { "" };
            }
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            try
            {
                var utilizadores = db.Utilizadores.Where(u => u.nome == username).First();
                if (utilizadores.perfil == 0 && roleName != "Administrador")
                {
                    throw new Exception();
                }
                if (utilizadores.perfil == 1 && roleName != "Treinador")
                {
                    throw new Exception();
                }
                if(utilizadores.perfil == 2 && roleName != "Utilizador")
                {
                    throw new Exception();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            return roleName == "Administrador" || roleName == "Treinador" || roleName =="Utilizador";
        }
    }
}