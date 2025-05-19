using System.Collections.Generic;
using System.Linq;

public class GerenciaLogin
{
    private List<Usuario> usuarios = new List<Usuario>();

    public void AddUsuario(Usuario usuario)
    {
        usuarios.Add(usuario);
    }

    public Usuario BuscarUsuario(long matricula)
    {
        return usuarios.FirstOrDefault(u => u.Matricula == matricula);
    }
}
