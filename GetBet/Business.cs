using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;

namespace GetBet
{
    public  class Business
    {
        public async void GetBulten()
        {

            ResponseModel responseModel = new ResponseModel();
            List<PlayModel> playModels = new List<PlayModel>();
            string json = "";

            json = SendRequest();

           

            if (string.IsNullOrEmpty(json))
            {
                SendEmail("Dataya ulaşılmadı.");
            }
            else
            {
                responseModel = JsonConvert.DeserializeObject<ResponseModel>(json);

                var maclar = responseModel.sg.EA.Where(x => x.TYPE >= 1 && x.MA.Any(z => z.MTID == 43)).ToList();

                foreach (var mac in maclar)
                {
                    PlayModel playModel = new PlayModel();

                    playModel.Team1 = mac.HN;
                    playModel.Team2 = mac.AN;
                    playModel.ScoreTwoAndTwo = mac.MA.FirstOrDefault(x => x.MTID == 205)?.OCA.FirstOrDefault(z => z.N == 15)?.O;
                    playModel.SixGoal = mac.MA.FirstOrDefault(x => x.MTID == 43)?.OCA.FirstOrDefault(z => z.N == 4)?.O;
                    playModel.Date = $"{mac.DAY}-{mac.T}";
                    if (playModel.ScoreTwoAndTwo != null && playModel.SixGoal != null)
                    {
                        var fark = playModel.ScoreTwoAndTwo.Value - playModel.SixGoal.Value;

                        if (fark <= 1 && fark >= -1)
                        {
                            playModels.Add(playModel);
                        }
                    }

                }

                string jsonPlayModels = JsonConvert.SerializeObject(playModels);
                DataTable dt = (DataTable)JsonConvert.DeserializeObject(jsonPlayModels, (typeof(DataTable)));
                var a =ConvertDataTableToHTML(dt);
                if (!string.IsNullOrEmpty(a))
                {
                    SendEmail(a);
                }
            }

            

        }

        public string  SendRequest()
        {
            var handler = new HttpClientHandler();

            handler.AutomaticDecompression = ~DecompressionMethods.None;

            using (var httpClient = new HttpClient(handler))
            {
                using (var request = new HttpRequestMessage(new HttpMethod("GET"), "https://cdnbulten.nesine.com/api/bulten/getprebultenfull"))
                {
                    var response = httpClient.SendAsync(request).Result.Content.ReadAsStringAsync();
                    return response.Result;
                }
            }
           
        }
        public void SendEmail(string data)
        {

            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            mail.To.Add("oguzhanyklmz27@gmail.com");
            mail.From = new MailAddress("oguzhanyklmz27@gmail.com", "Oguzhan", System.Text.Encoding.UTF8);
            mail.Subject = "Oynanabilecek Maçlar";
            mail.SubjectEncoding = System.Text.Encoding.UTF8;
            mail.Body = data;
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("oguzhanyklmz27@gmail.com", "ienrmlcfghxujkdq");
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            try
            {
                client.Send(mail);
            }
            catch (Exception ex)
            {
                Exception ex2 = ex;
                string errorMessage = string.Empty;
                while (ex2 != null)
                {
                    errorMessage += ex2.ToString();
                    ex2 = ex2.InnerException;
                }
            }
        }
        public static string ConvertDataTableToHTML(DataTable dt)
        {
            string html = "<table>";
            //add header row
            html += "<tr>";
            for (int i = 0; i < dt.Columns.Count; i++)
                html += "<td>" + dt.Columns[i].ColumnName + "</td>";
            html += "</tr>";
            //add rows
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                html += "<tr>";
                for (int j = 0; j < dt.Columns.Count; j++)
                    html += "<td>" + dt.Rows[i][j].ToString() + "</td>";
                html += "</tr>";
            }
            html += "</table>";
            return html;
        }
    }
}
