using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace WindowsFormsAppUsuario
{
    public class Usuario
    {
        //Atributos
        int id_usuario;
        string nomeCompleto;
        string email;

        //Construtor
        public Usuario(int id_usuario, string nomeCompleto, string email)
        {
            this.id_usuario = id_usuario;
            this.nomeCompleto = nomeCompleto;
            this.email = email;
        }

        public int Id_Usuario { get => id_usuario; set => id_usuario = value; }
        public string NomeCompleto { get => nomeCompleto; set => nomeCompleto = value; }
        
        public bool GravarUsuario()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into Usuario values (@id_usuario, @nomeCompleto, @email);";
            command.Parameters.Add("@id_usuario", SqlDbType.Int);
            command.Parameters.Add("@nomeCompleto", SqlDbType.VarChar);
            command.Parameters.Add("@email", SqlDbType.VarChar);
            command.Parameters[0].Value = this.id_usuario;
            command.Parameters[1].Value = this.nomeCompleto;
            string[] vetorDados = this.nomeCompleto.Split(' ');
            this.email = vetorDados[vetorDados.Length - 1] + "." + vetorDados[0] + "@ufn.edu.br";
            this.email = this.email.ToLower();
            command.Parameters[2].Value = this.email; 

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                banco.FecharConexao();
            }
        }

        private void GerarEmail()
        {
            string[] vetorDados = this.nomeCompleto.Split(' ');
            this.email = vetorDados[vetorDados.Length - 1] + "." + vetorDados[0] + "@ufn.edu.br";
            this.email = this.email.ToLower();
        }

        //construtor usado no cadastro de um usuario
        public Usuario(string nomeCompleto)
        {
            this.nomeCompleto = nomeCompleto;
            this.GerarEmail();
        }

        //construtor usado para popular a lista a partir do arquivo (banco)
        public Usuario(string nomecompleto, string email)
        {
            this.nomeCompleto = nomeCompleto;
            this.email = email;
            GravarUsuario();
        }
    }
}
