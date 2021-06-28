using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace PR
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            using var client = new HttpClient();

            client.DefaultRequestHeaders.Add("Cookie", "_ga=GA1.2.221135562.1624701188; _gid=GA1.2.1385425427.1624701188; e572d25e2f77b01121404f0eef127450=9bc049bdb4429808830937c27178a858; _gat_gtag_UA_132313057_1=1; XSRF-TOKEN=eyJpdiI6ImwrdWxNY2RPenRSWFwvMDQ1dEdlbk9RPT0iLCJ2YWx1ZSI6InJlNG5Db3BWWDlHZStBQVQ3N0lBc2dFZFU3dU1tVGkranJoc0ZyQXVuWFRqMkhVUUwwQXI3TTBOeG93SVplS0UiLCJtYWMiOiJlYjYyZDQyZjFlMTRhMmQ0NWUxZGRmZjczNDQ4YTRjNWNlOTcwZjBmNjRiN2QxZjJjNTM4N2ZmNTcwYTc5MWZiIn0%3D; laravel_session=eyJpdiI6InA5K1VNTDVJb3lrT3BmMThSbExkbFE9PSIsInZhbHVlIjoiUHM0QmliRFwvVmcwZkFaKytZcm9aVkZCRms1SThibHNsb3JpTnIzTjIxdTdZNWlcLzNVRVVOTHZcL0JcLzhyb2xJMEciLCJtYWMiOiIxOWE0ZjYzYTViNDQxM2Y3NGM3YTAxZTFmZjRmM2ZiZWU5MzFkOGQ4NDRkNTVmNTk1ZDM1YzczYmZiMWI1MmQ2In0%3D"
            );
            var content = client.GetAsync("https://mojegs1.pl/moje-produkty/sortowanie/nazwa/kierunek/rosnaco/1?amountPerPage=154&searchText=pan").Result;
            var result = content.Content.ReadAsStringAsync().Result;
            HtmlAgilityPack.HtmlDocument web = new HtmlAgilityPack.HtmlDocument();
            //web.head
            web.LoadHtml(result);
            #region
            /*"/a[@'ekoTuptusie']";*/
            //var xpath = "//*[contains(text(), 'ekoTuptusie')]";
            var xpath = "//table[@class='table table-hover table-striped table-responsive']";
            #endregion
            //var xpath = "//*[contains(text(), '59')]";

            var gting = new List<string>();
            foreach (var item in web.DocumentNode.SelectNodes(xpath))
            {
                Console.WriteLine(item.InnerText);
                //gting.Add(item.InnerText);

            }
            #region
            //using (var numb = new WebClient())
            //{
            //    //foreach (var item in gting)
            //    //{
            //    //    //numb.DownloadFile($"http://example.com{item}/file/song/a.pdf", $"{item}.pdf");
            //    //    numb.DownloadFile($"https://mojegs1.pl/moje-produkty/pobierz-etykiete?gtin={item}&label_text=ekoTuptusie+APLIKACJA+PAN+SAMOCHODZIK+CLASSIC+rozm.+32&size=1&extension=pdf", $"PdfCodes/{item}.pdf");
            //    //}
            #endregion\

            #region
            //}
            //foreach (var item in gting)
            //{

            //    WebClient webClient = new WebClient();
            //    webClient.DownloadFile("https://mojegs1.pl/moje-produkty/pobierz-etykiete?gtin={item}&label_text=ekoTuptusie+APLIKACJA+PAN+SAMOCHODZIK+CLASSIC+rozm.+32&size=1&extension=pdf", $"PdfCodes/{item}.pdf");
            //}

            //foreach (var item in gting)
            //{
            //    using (WebClient wc = new WebClient())
            //    {
            //        wc.DownloadFile(
            //   // Param1 = Link of file
            //   new Uri($"https://mojegs1.pl/moje-produkty/pobierz-etykiete?gtin={item}&label_text=ekoTuptusie+APLIKACJA+PAN+SAMOCHODZIK+CLASSIC+rozm.+32&size=1&extension=pdf"),
            //   $"PdfCodes/{item}.pdf");
            //    }

            //}



            //}

            //foreach (var item in gting)
            //{
            //    using (HttpClient cl = new HttpClient())
            //    {
            //        string url = ($"https://mojegs1.pl/moje-produkty/pobierz-etykiete?gtin={item}&label_text=ekoTuptusie+APLIKACJA+PAN+SAMOCHODZIK+CLASSIC+rozm.+32&size=1&extension=pdf");
            //        using (HttpResponseMessage response = await cl.GetAsync(url))
            //        using (Stream streamToReadFrom = await response.Content.ReadAsStreamAsync())
            //        {
            //            string fileToWriteTo = Path.GetFullPath($"PdfCodes/{item}.pdf");
            //            using (Stream streamToWriteTo = File.Open(fileToWriteTo, FileMode.Create))
            //            {
            //                await streamToReadFrom.CopyToAsync(streamToWriteTo);
            //            }

            //            response.Content = null;
            //        }
            //    }
            //}
            #endregion

            #region DOWNLOADING CODES
            //foreach (var item in gting)
            //{
            //    using (HttpClient cl = new HttpClient())
            //    {
                    
            //        cl.DefaultRequestHeaders.Add("Cookie", "_ga=GA1.2.221135562.1624701188; _gid=GA1.2.1385425427.1624701188; e572d25e2f77b01121404f0eef127450=9bc049bdb4429808830937c27178a858; _gat_gtag_UA_132313057_1=1; XSRF-TOKEN=eyJpdiI6ImwrdWxNY2RPenRSWFwvMDQ1dEdlbk9RPT0iLCJ2YWx1ZSI6InJlNG5Db3BWWDlHZStBQVQ3N0lBc2dFZFU3dU1tVGkranJoc0ZyQXVuWFRqMkhVUUwwQXI3TTBOeG93SVplS0UiLCJtYWMiOiJlYjYyZDQyZjFlMTRhMmQ0NWUxZGRmZjczNDQ4YTRjNWNlOTcwZjBmNjRiN2QxZjJjNTM4N2ZmNTcwYTc5MWZiIn0%3D; laravel_session=eyJpdiI6InA5K1VNTDVJb3lrT3BmMThSbExkbFE9PSIsInZhbHVlIjoiUHM0QmliRFwvVmcwZkFaKytZcm9aVkZCRms1SThibHNsb3JpTnIzTjIxdTdZNWlcLzNVRVVOTHZcL0JcLzhyb2xJMEciLCJtYWMiOiIxOWE0ZjYzYTViNDQxM2Y3NGM3YTAxZTFmZjRmM2ZiZWU5MzFkOGQ4NDRkNTVmNTk1ZDM1YzczYmZiMWI1MmQ2In0%3D"
            //        );
            //        string url = ($"https://mojegs1.pl/moje-produkty/pobierz-etykiete?gtin={item}&label_text=ekoTuptusie+APLIKACJA+PAN+SAMOCHODZIK+CLASSIC+rozm.+32&size=1&extension=png");
            //        using (HttpResponseMessage response = await cl.GetAsync(url))
            //        using (Stream streamToReadFrom = await response.Content.ReadAsStreamAsync())
            //        {
            //            string fileToWriteTo = Path.GetFullPath($"PdfCodes/{item}.png");
            //            using (Stream streamToWriteTo = File.Open(fileToWriteTo, FileMode.Create))
            //            {
            //                await streamToReadFrom.CopyToAsync(streamToWriteTo);
            //            }
                       
            //        }

            //    }
            //}
            #endregion
        }

    }
}
