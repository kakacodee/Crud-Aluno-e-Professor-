using KauaeJoaoR.Models;
using KauaeJoaoR.Repository.Contract;
using MySql.Data.MySqlClient;
using System.Data;

namespace KauaeJoaoR.Repository
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly string _Conexao;

        public AlunoRepository(IConfiguration conf)
        {   
            _Conexao = conf.GetConnectionString("ConexaoMySQL");
        }
        public void Cadastrar(Aluno aluno)
        {
            using (var conexao = new MySqlConnection(_Conexao))
            {
                conexao.Open();

                MySqlCommand cmd = new MySqlCommand("insert into Aluno(Nome, Email, Telefone, Serie, Turma, Data_Nasc) values (@Nome, @Email, @Telefone, @Serie, @Turma, @Data_nasc)",
                    conexao);

                cmd.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = aluno.Nome;
                cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = aluno.Email;
                cmd.Parameters.Add("@Telefone", MySqlDbType.Int32).Value = aluno.Telefone;
                cmd.Parameters.Add("@Serie", MySqlDbType.VarChar).Value = aluno.Serie;
                cmd.Parameters.Add("@Turma", MySqlDbType.VarChar).Value = aluno.Turma;
                cmd.Parameters.Add("@Data_Nasc", MySqlDbType.DateTime).Value = aluno.Nascimento;

                cmd.ExecuteNonQuery();
                conexao.Close();
            }
        }

        public IEnumerable<Aluno> ObterAluno()
        {
            List<Aluno> Alist = new List<Aluno>();
            using (var conexao = new MySqlConnection(_Conexao))
            {
                conexao.Open();

                MySqlCommand cmd = new MySqlCommand("select * from Aluno;", conexao);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                conexao.Clone();

                foreach (DataRow dr in dt.Rows)
                {
                    Alist.Add(
                        new Aluno
                        {
                            Id = Convert.ToInt32(dr["IdProfessor"]),
                            Nome = (string)dr["Nome"],
                            Email = (string)dr["Email"],
                            Telefone = (string)dr["Telefone"],
                            Serie = (string)dr["Serie"],
                            Turma = (string)dr["Turma"],
                            Nascimento = Convert.ToDateTime(dr["DataNasc"])
                        });
                }
                return Alist;
            }

        }
    }
}
