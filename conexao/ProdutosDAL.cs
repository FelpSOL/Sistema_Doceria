using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using maridoces.DTOs;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static maridoces.DTOs.ProdutoDTO;

namespace maridoces.conexao
{
    internal class ProdutosDAL
    {
        public static List<ProdutoDTO> ListarTodosOsProdutos()
        {
            // Instância da nossa classe de conexao
            Conexao minhaConexao = new Conexao();

            // String que recebera a consulta realizada pelo usuario
            string query = $"" +
                $"SELECT tb_produtos.*, tb_categorias.nome_categoria, tb_sabores.nome_sabor FROM tb_produtos " +
                $"INNER JOIN tb_categorias ON tb_produtos.id_categoria = tb_categorias.id_categoria " +
                $"INNER JOIN tb_sabores ON tb_produtos.id_sabor = tb_sabores.id_sabor;";
            

            // Adaptador de rede do MySQL para realizar a conexão ao banco de dados
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, minhaConexao.Start());

            // Tente
            try
            {
                // Criar uma variavel do tipo tabela de dados (que é a isntância de uma classe)
                DataTable tabela = new DataTable();
                // Preencher a tabela com o retorno da consulta do adaptador
                dataAdapter.Fill(tabela);
                // Zerando a lista para receber os valores
                List<ProdutoDTO> listaDeProdutos = new List<ProdutoDTO>();
                // Preenchendo a lista com os valores recebidos do banco de dados
                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    listaDeProdutos.Add(
                        new ProdutoDTO(
                            (int)tabela.Rows[i]["id_produto"],
                            (string)tabela.Rows[i]["nome"],
                            (string)tabela.Rows[i]["descricao"],
                            (decimal)tabela.Rows[i]["valor"],
                            (int)tabela.Rows[i]["id_categoria"],
                            (int)tabela.Rows[i]["id_sabor"],
                            (string)tabela.Rows[i]["imagem"],
                            (string)tabela.Rows[i]["nome_categoria"],
                            (string)tabela.Rows[i]["nome_sabor"],
                            (bool)tabela.Rows[i]["promocao"]
                           // (int)tabela.Rows[i]["ID"]

                        )
                    );
                }

                return listaDeProdutos;
            }
            // Em caso de erro
            catch (Exception error)
            {
                //captura o erro e mostra a mensagem
                throw new Exception(error.Message);
            }
            // Apos sucesso/erro 
            finally
            {
                // Chame a função de fechar a conexao do objeto minhaConexao
                minhaConexao.Close();
            }
        }

        public static DataTable ListarTodosOsProdutosDataTable()
        {
            // Instância da nossa classe de conexao
            Conexao minhaConexao = new Conexao();

            // String que recebera a consulta realizada pelo usuario
            string query = $"" +
                $"SELECT tb_produtos.*, tb_categorias.nome_categoria FROM tb_produtos " +
                $"INNER JOIN tb_categorias ON tb_produtos.id_categoria = tb_categorias.id_categoria ORDER BY id_produto;";

            // Adaptador de rede do MySQL para realizar a conexão ao banco de dados
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, minhaConexao.Start());

            // Tente
            try
            {
                // Criar uma variavel do tipo tabela de dados (que é a isntância de uma classe)
                DataTable tabela = new DataTable();
                // Preencher a tabela com o retorno da consulta do adaptador
                dataAdapter.Fill(tabela);                

                return tabela;
            }
            // Em caso de erro
            catch (Exception error)
            {
                //captura o erro e mostra a mensagem
                throw new Exception(error.Message);
            }
            // Apos sucesso/erro 
            finally
            {
                // Chame a função de fechar a conexao do objeto minhaConexao
                minhaConexao.Close();
            }
        }

        public static void DeletarProduto(int ID)
        {
            Conexao minhaConexao = new Conexao();

            string query = $"DELETE FROM tb_produtos WHERE id_produto = {ID};";

            MySqlCommand mySqlCommand = new MySqlCommand(query, minhaConexao.Start());

            try
            {
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
            finally
            {
                minhaConexao.Close();
            }
        }

        public static void AdicionarProduto(string nome, string descricao,string valor, int id_categoria, int id_sabor, string imagem, bool promocao)
        {
            Conexao minhaConexao = new Conexao();

            string query = $"INSERT INTO tb_produtos( nome, descricao, valor, id_categoria, id_sabor, imagem, promocao) VALUES " +
                $"('{nome}', " +
                $"'{descricao}', " +
                $"{valor}, " +
                $"{id_categoria}, " +
                $"{id_sabor}, " +
                $"'{imagem}', " +
                $"{promocao});";

            MySqlCommand mySqlCommand = new MySqlCommand(query, minhaConexao.Start());

            try
            {
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
            finally
            {
                minhaConexao.Close();
            }
        }
        public static void EditarProduto(string nome, string descricao, string valor, int id_categoria, int id_sabor, string imagem, int ID, bool promocao)
        {
            Conexao minhaConexao = new Conexao();

            string query = $" UPDATE tb_produtos SET " +
                $"imagem = '{imagem}', " +
                $"nome = '{nome}', " +
                $"descricao = '{descricao}'," +
                $"valor = {valor}, " +
                $"id_categoria = {id_categoria}, " +
                $"id_sabor = {id_sabor}, " +
                $"promocao = {promocao} " +
                $"WHERE id_produto = {ID};"; 
               

            MySqlCommand mySqlCommand = new MySqlCommand(query, minhaConexao.Start());

            try
            {
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
            finally
            {
                minhaConexao.Close();
            }
        }

        public static List<ProdutoDTO> LowCarb(int ID)
        {
            // Instância da nossa classe de conexao
            Conexao minhaConexao = new Conexao();

            // String que recebera a consulta realizada pelo usuario
            string query = $"" +
                $"SELECT tb_produtos.*, tb_categorias.nome_categoria, tb_sabores.nome_sabor FROM tb_produtos " +
                $"INNER JOIN tb_categorias ON tb_produtos.id_categoria = tb_categorias.id_categoria " +
                $"INNER JOIN tb_sabores ON tb_produtos.id_sabor = tb_sabores.id_sabor " +
                $"WHERE tb_produtos.id_categoria = {ID} AND descricao LIKE '%Low Carb%';";


            // Adaptador de rede do MySQL para realizar a conexão ao banco de dados
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, minhaConexao.Start());

            // Tente
            try
            {
                // Criar uma variavel do tipo tabela de dados (que é a isntância de uma classe)
                DataTable tabela = new DataTable();
                // Preencher a tabela com o retorno da consulta do adaptador
                dataAdapter.Fill(tabela);
                // Zerando a lista para receber os valores
                List<ProdutoDTO> listaDeProdutos = new List<ProdutoDTO>();
                // Preenchendo a lista com os valores recebidos do banco de dados
                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    listaDeProdutos.Add(
                        new ProdutoDTO(
                            (int)tabela.Rows[i]["id_produto"],
                            (string)tabela.Rows[i]["nome"],
                            (string)tabela.Rows[i]["descricao"],
                            (decimal)tabela.Rows[i]["valor"],
                            (int)tabela.Rows[i]["id_categoria"],
                            (int)tabela.Rows[i]["id_sabor"],
                            (string)tabela.Rows[i]["imagem"],
                            (string)tabela.Rows[i]["nome_categoria"],
                            (string)tabela.Rows[i]["nome_sabor"],
                            (bool)tabela.Rows[i]["promocao"]
                        // (int)tabela.Rows[i]["ID"]

                        )
                    );
                }

                return listaDeProdutos;
            }
            // Em caso de erro
            catch (Exception error)
            {
                //captura o erro e mostra a mensagem
                throw new Exception(error.Message);
            }
            // Apos sucesso/erro 
            finally
            {
                // Chame a função de fechar a conexao do objeto minhaConexao
                minhaConexao.Close();
            }
        }
        public static List<ProdutoDTO> Todos(int ID)
        {
            // Instância da nossa classe de conexao
            Conexao minhaConexao = new Conexao();

            // String que recebera a consulta realizada pelo usuario
            string query = $"" +
                $"SELECT tb_produtos.*, tb_categorias.nome_categoria, tb_sabores.nome_sabor FROM tb_produtos " +
                $"INNER JOIN tb_categorias ON tb_produtos.id_categoria = tb_categorias.id_categoria " +
                $"INNER JOIN tb_sabores ON tb_produtos.id_sabor = tb_sabores.id_sabor " +
                $"WHERE tb_produtos.id_categoria = {ID};";


            // Adaptador de rede do MySQL para realizar a conexão ao banco de dados
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, minhaConexao.Start());

            // Tente
            try
            {
                // Criar uma variavel do tipo tabela de dados (que é a isntância de uma classe)
                DataTable tabela = new DataTable();
                // Preencher a tabela com o retorno da consulta do adaptador
                dataAdapter.Fill(tabela);
                // Zerando a lista para receber os valores
                List<ProdutoDTO> listaDeProdutos = new List<ProdutoDTO>();
                // Preenchendo a lista com os valores recebidos do banco de dados
                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    listaDeProdutos.Add(
                        new ProdutoDTO(
                            (int)tabela.Rows[i]["id_produto"],
                            (string)tabela.Rows[i]["nome"],
                            (string)tabela.Rows[i]["descricao"],
                            (decimal)tabela.Rows[i]["valor"],
                            (int)tabela.Rows[i]["id_categoria"],
                            (int)tabela.Rows[i]["id_sabor"],
                            (string)tabela.Rows[i]["imagem"],
                            (string)tabela.Rows[i]["nome_categoria"],
                            (string)tabela.Rows[i]["nome_sabor"],
                            (bool)tabela.Rows[i]["promocao"]
                        // (int)tabela.Rows[i]["ID"]

                        )
                    );
                }

                return listaDeProdutos;
            }
            // Em caso de erro
            catch (Exception error)
            {
                //captura o erro e mostra a mensagem
                throw new Exception(error.Message);
            }
            // Apos sucesso/erro 
            finally
            {
                // Chame a função de fechar a conexao do objeto minhaConexao
                minhaConexao.Close();
            }

        }
        public static List<ProdutoDTO> MassaBranca(int ID)
        {
            // Instância da nossa classe de conexao
            Conexao minhaConexao = new Conexao();

            // String que recebera a consulta realizada pelo usuario
            string query = $"" +
                $"SELECT tb_produtos.*, tb_categorias.nome_categoria, tb_sabores.nome_sabor FROM tb_produtos " +
                $"INNER JOIN tb_categorias ON tb_produtos.id_categoria = tb_categorias.id_categoria " +
                $"INNER JOIN tb_sabores ON tb_produtos.id_sabor = tb_sabores.id_sabor " +
                $"WHERE tb_produtos.id_categoria = {ID} AND descricao LIKE '%Massa Branca%';";


            // Adaptador de rede do MySQL para realizar a conexão ao banco de dados
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, minhaConexao.Start());

            // Tente
            try
            {
                // Criar uma variavel do tipo tabela de dados (que é a isntância de uma classe)
                DataTable tabela = new DataTable();
                // Preencher a tabela com o retorno da consulta do adaptador
                dataAdapter.Fill(tabela);
                // Zerando a lista para receber os valores
                List<ProdutoDTO> listaDeProdutos = new List<ProdutoDTO>();
                // Preenchendo a lista com os valores recebidos do banco de dados
                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    listaDeProdutos.Add(
                        new ProdutoDTO(
                            (int)tabela.Rows[i]["id_produto"],
                            (string)tabela.Rows[i]["nome"],
                            (string)tabela.Rows[i]["descricao"],
                            (decimal)tabela.Rows[i]["valor"],
                            (int)tabela.Rows[i]["id_categoria"],
                            (int)tabela.Rows[i]["id_sabor"],
                            (string)tabela.Rows[i]["imagem"],
                            (string)tabela.Rows[i]["nome_categoria"],
                            (string)tabela.Rows[i]["nome_sabor"],
                            (bool)tabela.Rows[i]["promocao"]
                        // (int)tabela.Rows[i]["ID"]

                        )
                    );
                }

                return listaDeProdutos;
            }
            // Em caso de erro
            catch (Exception error)
            {
                //captura o erro e mostra a mensagem
                throw new Exception(error.Message);
            }
            // Apos sucesso/erro 
            finally
            {
                // Chame a função de fechar a conexao do objeto minhaConexao
                minhaConexao.Close();
            }
        }
        public static List<ProdutoDTO> Massadechocolate(int ID)
        {
            // Instância da nossa classe de conexao
            Conexao minhaConexao = new Conexao();

            // String que recebera a consulta realizada pelo usuario
            string query = $"" +
                $"SELECT tb_produtos.*, tb_categorias.nome_categoria, tb_sabores.nome_sabor FROM tb_produtos " +
                $"INNER JOIN tb_categorias ON tb_produtos.id_categoria = tb_categorias.id_categoria " +
                $"INNER JOIN tb_sabores ON tb_produtos.id_sabor = tb_sabores.id_sabor " +
                $"WHERE tb_produtos.id_categoria = {ID} AND descricao LIKE '%Massa de Chocolate%';";


            // Adaptador de rede do MySQL para realizar a conexão ao banco de dados
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, minhaConexao.Start());

            // Tente
            try
            {
                // Criar uma variavel do tipo tabela de dados (que é a isntância de uma classe)
                DataTable tabela = new DataTable();
                // Preencher a tabela com o retorno da consulta do adaptador
                dataAdapter.Fill(tabela);
                // Zerando a lista para receber os valores
                List<ProdutoDTO> listaDeProdutos = new List<ProdutoDTO>();
                // Preenchendo a lista com os valores recebidos do banco de dados
                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    listaDeProdutos.Add(
                        new ProdutoDTO(
                            (int)tabela.Rows[i]["id_produto"],
                            (string)tabela.Rows[i]["nome"],
                            (string)tabela.Rows[i]["descricao"],
                            (decimal)tabela.Rows[i]["valor"],
                            (int)tabela.Rows[i]["id_categoria"],
                            (int)tabela.Rows[i]["id_sabor"],
                            (string)tabela.Rows[i]["imagem"],
                            (string)tabela.Rows[i]["nome_categoria"],
                            (string)tabela.Rows[i]["nome_sabor"],
                            (bool)tabela.Rows[i]["promocao"]
                        // (int)tabela.Rows[i]["ID"]

                        )
                    );
                }

                return listaDeProdutos;
            }
            // Em caso de erro
            catch (Exception error)
            {
                //captura o erro e mostra a mensagem
                throw new Exception(error.Message);
            }
            // Apos sucesso/erro 
            finally
            {
                // Chame a função de fechar a conexao do objeto minhaConexao
                minhaConexao.Close();
            }
        }

    }
}

