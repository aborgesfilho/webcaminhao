using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebCaminhao.Models;

namespace WebCaminhao.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Dropdownlist multi_Dropdownlist = new Dropdownlist
            //{
            //    tipoModelos = GetTipoModeloList(),
            //    tiposAnoModelo = GetTipoAnoModeloList(),
            //    tiposAnoFabricacao = GetTipoAnoFabricaoList()
            //};
            //return View(multi_Dropdownlist);
            return View();
        }


        public List<TipoModelo> GetTipoModeloList()
        {
            var connection = GetConnection().GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("Select Modelo From TipoModelo", con);
            con.Open();
            SqlDataReader idr = cmd.ExecuteReader();
            List<TipoModelo> tiposModelos = new List<TipoModelo>();

            if (idr.HasRows)
            {
                while (idr.Read())
                {
                    tiposModelos.Add(new TipoModelo
                    {
                        Modelo = idr["Modelo"].ToString()
                    });
                }
            }

            con.Close();
            return tiposModelos;
        }

        public List<TipoAnoModelo> GetTipoAnoModeloList()
        {
            var connection = GetConnection().GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("Select AnoModelo From TipoAnoModelo", con);
            con.Open();
            SqlDataReader idr = cmd.ExecuteReader();
            List<TipoAnoModelo> tiposAnoModelos = new List<TipoAnoModelo>();

            if (idr.HasRows)
            {
                while (idr.Read())
                {
                    tiposAnoModelos.Add(new TipoAnoModelo
                    {
                        AnoModelo = idr["AnoModelo"].ToString()
                    });
                }
            }

            con.Close();
            return tiposAnoModelos;
        }

        public List<TipoAnoFabricacao> GetTipoAnoFabricaoList()
        {
            var connection = GetConnection().GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("Select AnoFabricacao From TipoAnoFabricacao", con);
            con.Open();
            SqlDataReader idr = cmd.ExecuteReader();
            List<TipoAnoFabricacao> tiposAnoFabricacao = new List<TipoAnoFabricacao>();

            if (idr.HasRows)
            {
                while (idr.Read())
                {
                    tiposAnoFabricacao.Add(new TipoAnoFabricacao
                    {
                        AnoFabricacao = idr["AnoFabricacao"].ToString()
                    });
                }
            }

            con.Close();
            return tiposAnoFabricacao;
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IConfigurationRoot GetConnection()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json").Build();
            return builder;
        }

    }
}
