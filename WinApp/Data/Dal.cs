using Npgsql;
using System;
using System.Collections.Generic;

using WinApp.Model;

namespace WinApp.Data
{
    public class Dal
    {
        private readonly string connString = null;
        private string TABLE = "";

        public Dal()
        {
            connString = Config.GetConectionString();
        }

        private NpgsqlConnection GetConn()
        {
            return new NpgsqlConnection(connString);
        }

        #region Previsão do tempo

        #endregion


        public Prediction GetByDt(int cidadeCodigo)
        {
            NpgsqlConnection conexao = GetConn();
            Prediction objPrevisao = null;
            try
            {
                TABLE = "\"PREVISAODOTEMPO\" ";
                string sql = $@"SELECT *
                                        FROM public.{TABLE}
                                        WHERE cidade_codigo = {cidadeCodigo}";

                conexao.Open();
                NpgsqlCommand pgsqlcommand = new NpgsqlCommand(sql, conexao);
                NpgsqlDataReader dr = pgsqlcommand.ExecuteReader();

                //carrega objeto
                if (dr.HasRows)
                {
                    objPrevisao = new Prediction();
                    while (dr.Read())
                    {
                        objPrevisao.dt = Convert.ToInt32(dr["DT"].ToString());
                        objPrevisao.main.temp = Convert.ToInt32(dr["MAINTEMP"].ToString());
                        objPrevisao.main.temp_min = (float) dr["MAINTEMP_MIN"];
                        objPrevisao.main.temp_max = (float)dr["MAINTEMP_MAX"];
                        objPrevisao.main.pressure = (float)dr["MAINPRESSURE"];
                        objPrevisao.main.sea_level = (float)dr["MAINSEA_LEVEL"];
                        objPrevisao.main.grnd_level = (float)dr["MAINGRND_LEVEL"];
                        objPrevisao.main.humidity = Convert.ToInt32(dr["MAINHUMIDITY"]);
                        objPrevisao.main.temp_kf = (float)dr["MAINTEMP_KF"];
                        objPrevisao.weather[0].id = Convert.ToInt32(dr["weather0id"]);
                        objPrevisao.weather[0].main = dr["WEATHER0MAIN"].ToString();
                        objPrevisao.weather[0].description = dr["WEATHER0DESCRIPTION"].ToString();
                        objPrevisao.weather[0].icon = dr["weather0icon"].ToString();
                        objPrevisao.clouds.all = Convert.ToInt32(dr["CLOUDSALL"]);
                        objPrevisao.wind.speed = (float)dr[""];
                        objPrevisao.wind.deg = (float)dr["WINDSPEED"];
                        objPrevisao.sys.pod = dr["SYSPOD"].ToString();
                        objPrevisao.dt_txt = dr["dt_txt"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }

            return objPrevisao;

        }

        public int Exclude(int cidadeCodigo)
        {
            NpgsqlConnection conexao = GetConn();
            int rowsafcetd = 0;

            try
            {
                TABLE = "\"PREVISAODOTEMPO\" ";
                string sql = $@"DELETE FROM public.{TABLE}                                 
                                    WHERE CIDADE_CODIGO = {cidadeCodigo}";

                conexao.Open();
                NpgsqlCommand pgsqlcommand = new NpgsqlCommand(sql, conexao);
                rowsafcetd = pgsqlcommand.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                throw;
            }

            finally
            {
                conexao.Close();
            }

            return rowsafcetd;
        }

        public int Update(List<Prediction> predictions, out bool ErrorOcured)
        {
            NpgsqlConnection conexao = GetConn();
            NpgsqlTransaction transaction = null;
            int rowsAfcetd = 0;

            try
            {
                if (predictions != null)
                {
                    conexao.Open();
                    transaction = conexao.BeginTransaction();

                    foreach (Prediction prediction in predictions)
                    {
                        rowsAfcetd = ExecuteUpdate(prediction, conexao, transaction);
                        if (rowsAfcetd > 0)
                            continue;
                    }
                }

                ErrorOcured = false;
                transaction.Commit();
            }
            catch (Exception ex)
            {
                ErrorOcured = true;
                if (transaction != null) transaction.Rollback();
            }
            finally
            {
                conexao.Close();
            }

            return rowsAfcetd;
        }


        public int Insert(List<Previsao> previsoes, out bool ErrorOcured)
        {
            NpgsqlConnection conexao = GetConn();
            NpgsqlTransaction transaction = null;
            int rowsAfcetd = 0;

            try
            {
                if (previsoes != null)
                {
                    conexao.Open();
                    transaction = conexao.BeginTransaction();

                    foreach (Previsao previsao in previsoes)
                    {
                        rowsAfcetd = ExecuteInsert(previsao, conexao, transaction);
                        if (rowsAfcetd > 0)
                            continue;
                    }
                }

                ErrorOcured = false;
                transaction.Commit();
            }
            catch (Exception ex)
            {
                ErrorOcured = true;
                if (transaction != null) transaction.Rollback();
            }
            finally
            {
                conexao.Close();
            }

            return rowsAfcetd;
        }

        public int Insert(Previsao previsao)
        {
            NpgsqlConnection conexao = GetConn();
            return ExecuteInsert(previsao, conexao);
        }

        private int ExecuteUpdate(Prediction prediction, NpgsqlConnection conexao, NpgsqlTransaction transaction = null)
        {
            int rowsAfcetd = 0;

            try
            {
                TABLE = "\"PREVISAODOTEMPO\" ";
                string sql = $@"UPDATE public.{TABLE}(                                
                                    DT = {prediction.dt},
                                    TEMPERATURA =           {"\'"}{prediction.main.temp.ToString().Replace(",", ".")}{"\'"},              
                                    TEMPERATURA_MINIMA =    {"\'"}{prediction.main.temp_min.ToString().Replace(",", ".")}{"\'"},          
                                    TEMPERATURA_MAXIMA =    {"\'"}{prediction.main.temp_max.ToString().Replace(",", ".")}{"\'"},,          
                                    TEMPERATURA_PRESSAO =   {"\'"}{prediction.main.pressure.ToString().Replace(",", ".")}{"\'"},,          
                                    TEMPERATURA_NIVELMAR =  {"\'"}{prediction.main.sea_level.ToString().Replace(",", ".")}{"\'"},,         
                                    TEMPERATURA_NIVELSOLO = {"\'"}{prediction.main.grnd_level.ToString().Replace(",", ".")}{"\'"},,        
                                    TEMPERATURA_HUMIDADE =  {prediction.main.humidity},,          
                                    TEMPERATURA_KF =        {"\'"}{prediction.main.temp_kf.ToString().Replace(",", ".")}{"\'"},           
                                    CLIMA_ID =              {"\'"}{prediction.weather[0].id}{"\'"},,           
                                    CLIMA_PRINCIPAL =       {"\'"}{prediction.weather[0].main}{"\'"},,          
                                    CLIMA_DESCRICAO =       {"\'"}{prediction.weather[0].description}{"\'"},,   
                                    CLIMA_ICONE =           {"\'"}{prediction.weather[0].icon}{"\'"},,          
                                    NUVENS_TUDO =           {prediction.clouds.all},,             
                                    VENTO_VELOCIDADE =      {"\'"}{prediction.wind.speed.ToString().Replace(",", ".")}{"\'"},,             
                                    VENTO_DEG =             {"\'"}{prediction.wind.deg.ToString().Replace(",", ".")}{"\'"},,               
                                    CHUVA =                 {"\'"}{(prediction.rain != null ? prediction.rain._3h : 0)}{"\'"},,                
                                    SYS_POD =               {"\'"}{prediction.sys.pod}{"\'"},,                
                                    DT_TXT =                {"\'"}{prediction.dt_txt}{"\'"} 
                                WHERE DT = {prediction.dt}";

                conexao.Open();
                NpgsqlCommand pgsqlcommand = new NpgsqlCommand(sql, conexao);
                pgsqlcommand.Transaction = transaction;
                rowsAfcetd = pgsqlcommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw;
            }

            return rowsAfcetd;
        }


        /// <summary>
        /// Insere os dados da previsão do tempo de uma Cidade.
        /// </summary>
        /// <param name="previsao">Objeto com os dados da previsão do tempo</param>
        /// <returns></returns>
        private int ExecuteInsert(Previsao previsao, NpgsqlConnection conexao, NpgsqlTransaction transaction = null)
        {
            int rowsAfcetd = 0;

            try
            {
                TABLE = "\"PREVISAODOTEMPO\" ";
                string sql = $@"INSERT INTO public.{TABLE}(                                
                                DT,
                                CIDADE_CODIGO,
                                TEMPERATURA,              
                                TEMPERATURA_MINIMA,          
                                TEMPERATURA_MAXIMA,          
                                TEMPERATURA_PRESSAO,          
                                TEMPERATURA_NIVELMAR,         
                                TEMPERATURA_NIVELSOLO,        
                                TEMPERATURA_HUMIDADE,          
                                TEMPERATURA_KF,           
                                CLIMA_ID,           
                                CLIMA_PRINCIPAL,          
                                CLIMA_DESCRICAO,   
                                CLIMA_ICONE,          
                                NUVENS_TUDO,             
                                VENTO_VELOCIDADE,             
                                VENTO_DEG,               
                                CHUVA,                
                                SYS_POD,                
                                DT_TXT)
                            VALUES (
                                {previsao.dt},
                                {previsao.CidadeCodigo},
                                {"\'"}{previsao.main.temp.ToString().Replace(",", ".")}{"\'"},
                                {"\'"}{previsao.main.temp_min.ToString().Replace(",", ".")}{"\'"},
                                {"\'"}{previsao.main.temp_max.ToString().Replace(",", ".")}{"\'"},
                                {"\'"}{previsao.main.pressure.ToString().Replace(",", ".")}{"\'"},
                                {"\'"}{previsao.main.sea_level.ToString().Replace(",", ".")}{"\'"},
                                {"\'"}{previsao.main.grnd_level.ToString().Replace(",", ".")}{"\'"},
                                {previsao.main.humidity},
                                {"\'"}{previsao.main.temp_kf.ToString().Replace(",", ".")}{"\'"},
                                {"\'"}{previsao.weather[0].id}{"\'"},
                                {"\'"}{previsao.weather[0].main}{"\'"},
                                {"\'"}{previsao.weather[0].description}{"\'"},
                                {"\'"}{previsao.weather[0].icon}{"\'"},
                                {previsao.clouds.all},
                                {"\'"}{previsao.wind.speed.ToString().Replace(",", ".")}{"\'"},
                                {"\'"}{previsao.wind.deg.ToString().Replace(",", ".")}{"\'"},
                                {"\'"}{(previsao.rain != null ? previsao.rain._3h : 0)}{"\'"},
                                {"\'"}{previsao.sys.pod}{"\'"},
                                {"\'"}{previsao.dt_txt}{"\'"} 
                            )";

                NpgsqlCommand pgsqlcommand = new NpgsqlCommand(sql, conexao);
                pgsqlcommand.Transaction = transaction;
                rowsAfcetd = pgsqlcommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw;
            }

            return rowsAfcetd;
        }

        #region Cidade

        /// <summary>
        /// Insere os dados de um Cidade.
        /// </summary>
        /// <param name="city">Objeto Cidade</param>
        /// <returns>Retorna o número de linhas autalizadas.</returns>
        public int Insert(City city)
        {
            NpgsqlConnection conexao = GetConn();
            int rowsafcetd = 0;

            try
            {
                TABLE = "\"CIDADE\" ";
                string sql = $@"INSERT INTO public.{TABLE}(
                                    CODIGO, 
                                    NOME,
                                    POPULACAO,
                                    AMANHECER,
                                    ANOITECER,
                                    FUSOHORARIO )
                                VALUES (
                                    {city.id},
                                    {"\'"}{city.name}{"\'"},
                                    {"\'"}{city.population}{"\'"},
                                    {"\'"}{city.sunrise}{"\'"},
                                    {"\'"}{city.sunset}{"\'"},
                                    {"\'"}{city.timezone}{"\'"} )";

                conexao.Open();
                NpgsqlCommand pgsqlcommand = new NpgsqlCommand(sql, conexao);
                rowsafcetd = pgsqlcommand.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                throw;
            }

            finally
            {
                conexao.Close();
            }

            return rowsafcetd;
        }

        /// <summary>
        /// Atualiza os dados de uma Cidade
        /// </summary>
        /// <param name="prediction"></param>
        /// <returns></returns>
        public int Update(City city)
        {
            NpgsqlConnection conexao = GetConn();
            int rowsafcetd = 0;

            try
            {
                TABLE = "\"CIDADE\" ";
                string sql = $@"UPDATE public.{TABLE} SET                                
                                             NOME =   {"\'"}{city.name}{"\'"},
                                        POPULACAO =   {"\'"}{city.population}{"\'"},
                                        AMANHECER =   {"\'"}{city.sunrise}{"\'"},
                                        ANOITECER =   {"\'"}{city.sunset}{"\'"},
                                        FUSOHORARIO = {"\'"}{city.timezone}{"\'"}
                                    WHERE CODIGO = {city.id}";

                conexao.Open();
                NpgsqlCommand pgsqlcommand = new NpgsqlCommand(sql, conexao);
                rowsafcetd = pgsqlcommand.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                throw;
            }

            finally
            {
                conexao.Close();
            }

            return rowsafcetd;
        }

        /// <summary>
        /// Consulta e carrega uma Cidade pelo seu ID.
        /// </summary>
        /// <param name="Id">Id da Cidade</param>
        /// <returns>Retorna um Objeto do tipo Cidade</returns>
        public Cidade GetById(int Id)
        {
            NpgsqlConnection conexao = GetConn();
            Cidade objCidade = null;
            try
            {
                TABLE = "\"CIDADE\" ";
                string sql = $@"SELECT *
                                        FROM public.{TABLE}
                                        WHERE Codigo = {Id}";

                conexao.Open();
                NpgsqlCommand pgsqlcommand = new NpgsqlCommand(sql, conexao);
                NpgsqlDataReader dr = pgsqlcommand.ExecuteReader();

                //carrega objeto
                if (dr.HasRows)
                {
                    objCidade = new Cidade();
                    while (dr.Read())
                    {
                        objCidade.id = Convert.ToInt32(dr["CODIGO"].ToString());
                        objCidade.name = dr["NOME"].ToString();
                        objCidade.sunrise = Convert.ToInt32(dr["AMANHECER"].ToString());
                        objCidade.sunset = Convert.ToInt32(dr["ANOITECER"].ToString());
                        objCidade.timezone = Convert.ToInt32(dr["FUSOHORARIO"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }

            return objCidade;

        }

        #endregion
    }
}
