using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinApp.Controler;
using WinApp.Model;

namespace WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var cidadeNome = txtCidade.Text;
            int? rowwsAfected = null;

            if (cidadeNome != "")
            {
                var Controler = new Contoler();
                var json = Controler.Process(cidadeNome);
                if (Controler.IsSuccess)
                {
                    Rootobject obj = Controler.Deserialaized(json);

                    var Cidade = new Cidade();

                    rowwsAfected = Cidade.Exist(obj.city.id) ? Cidade.Update(obj.city) : Cidade.Insert(obj.city);

                    //List<Prediction> lista = new List<Prediction>(obj.list);

                    var listaPrevisoes = new List<Previsao>();
                    for (int i = 0; i < obj.list.Length; i++)
                    {
                        listaPrevisoes.Add(new Previsao()
                        {
                            dt = obj.list[i].dt,
                            CidadeCodigo = obj.city.id,
                            main = obj.list[i].main,
                            weather = obj.list[i].weather,
                            clouds = obj.list[i].clouds,
                            wind = obj.list[i].wind,
                            rain = obj.list[i].rain,
                            sys = obj.list[i].sys,
                            dt_txt = obj.list[i].dt_txt
                        });
                    }

                    var Previsao = new Previsao();

                    if (Previsao.Exist(obj.city.id))
                        rowwsAfected = Previsao.Exclude(obj.city.id);

                    rowwsAfected = Previsao.Insert(listaPrevisoes);
                    if (rowwsAfected > 0)
                    {
                        MostrarDados(obj.city);
                        Log("Os dados da Cidade foram atualizados", listaPrevisoes);
                    }
                    else
                    {
                        Log("Não fois possível atualizar os dados da Cidade");
                    }
                    
                }
            }
        }

        private void MostrarDados(City obj)
        {
            lblNome.Text = obj.name;
            lblPopulacao.Text = obj.population.ToString();
            lblAmanhecer.Text = obj.sunrise.ToString();
            lblpordosol.Text = obj.sunset.ToString();
            lblfusohorario.Text = obj.timezone.ToString();

            pnlCidade.Visible = true;
        }


        private void Log(string ResultProcess, List<Previsao> ListaPrevisoes = null)
        {
            listaLog.Items.Add(ResultProcess);


            foreach (Prediction previsao in ListaPrevisoes)
            {
                DateTime convertedDate = DateTime.Parse(previsao.dt_txt);
                listaLog.Items.Add(convertedDate);
                listaLog.Items.Add($"Clima:{ previsao.weather[0].main}");

                pnlPrevisao.Visible = true;

                //listaLog.Items.Add($"Nuvens: {previsao.clouds}"); //Identificar
                //listaLog.Items.Add($"Chuva: {previsao.rain}"); // Identificar

            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //private void MostrarDados(Prediction obj)
        //{

        //}
    }
}
