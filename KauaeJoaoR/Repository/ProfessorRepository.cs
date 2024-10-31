using KauaeJoaoR.Models;
using KauaeJoaoR.Repository.Contract;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Data;

namespace KauaeJoaoR.Repository
{
    public class ProfessorRepository : IProfessorRepository
    {
        private readonly string _Conexao;

        public ProfessorRepository(IConfiguration conf)
        {
            _Conexao = conf.GetConnectionString("ConexaoMySQL");
        }

        public void Cadastrar(Professor professor)
        {
            using (var conexao = new MySqlConnection(_Conexao))
            {
                conexao.Open();

                MySqlCommand cmd = new MySqlCommand("insert into Professor(Nome, CPF, RG, Telefone, Data_Nasc) values (@Nome, @CPF, @RG, @Telefone, @Data_nasc);", conexao);

                cmd.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = professor.Nome;
                cmd.Parameters.Add("@CPF", MySqlDbType.VarChar).Value = professor.CPF;
                cmd.Parameters.Add("@RG", MySqlDbType.VarChar).Value = professor.RG;
                cmd.Parameters.Add("@Telefone", MySqlDbType.Int32).Value = professor.Telefone;
                cmd.Parameters.Add("@Data_Nasc", MySqlDbType.DateTime).Value = professor.Nascimento.ToString("yyyy/MM/dd");

                cmd.ExecuteNonQuery();
                conexao.Close();
            }
        }

        public IEnumerable<Professor> ObterProfessor()
        {
            List<Professor> Plist = new List<Professor>();
            using (var conexao = new MySqlConnection(_Conexao))
            {
                conexao.Open();

                MySqlCommand cmd = new MySqlCommand("select * from Professor;", conexao);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                conexao.Clone();

                foreach (DataRow dr in dt.Rows)
                {
                    Plist.Add(
                        new Professor
                        {
                            Id = Convert.ToInt32(dr["IdProfessor"]),
                            Nome = (string)dr["Nome"],
                            CPF = (String)dr["CPF"],
                            RG = (String)dr["RG"],
                            Telefone = (String)dr["Telefone"],
                            Nascimento = Convert.ToDateTime(dr["DataNasc"])
                        });
                }

                return Plist;

            }
        }

    }
}

 