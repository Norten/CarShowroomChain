using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShowroomChain
{
    public partial class FormReports : Form
    {
        List<string[]> listSalonRanking = new List<string[]>();
        List<string[]> listOrdersInProgres = new List<string[]>();
        List<string[]> listCohCarSell = new List<string[]>();
        public FormReports()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData ()
        {
            DatabaseModel dbModel = new DatabaseModel();
            var salonRanking = dbModel.salon_ranking.SqlQuery("SELECT * FROM salon_ranking;").ToList();
            var ordersInProgres = dbModel.orders_in_progres.SqlQuery("SELECT * FROM orders_in_progres;").ToList();
            var cohCarRes = dbModel.client_order_history_car_res.SqlQuery("SELECT * FROM client_order_history_car_res;").ToList();
            var cohCarSell = dbModel.client_order_history_car_sell.SqlQuery("SELECT * FROM client_order_history_car_sell;").ToList();
            var cohService = dbModel.client_order_history_service.SqlQuery("SELECT * FROM client_order_history_service;").ToList();
            //var listSalonRanking = new List<string[]>();
            //var listOrdersInProgres = new List<string[]>();
            //var listCohCarRes = new List<string[]>();
            //var listCohCarSell = new List<string[]>();
            //var listCohService = new List<string[]>();
            //var listCoh = new List<string[]>();
            listSalonRanking.Add(new string[] { "Nazwa salonu", "Adres salonu", "Telefon", "Strona www", "Ilość sprzedanych samochodów" });
            listOrdersInProgres.Add(new string[] { "Numer porządkowy zamówienia", "Data rezerwacji", "Data wygaśnięcia rezerwacji", "Model samochodu", "Kolor samochodu", "Silnik samochodu", 
                "Skrzynia biegów samochodu", "Paliwo samochodu", "Nadwozie samochodu", "Koszt samochodu", "Adres sklepu w którym jest samochód", "Imię klienta", "Nazwisko klienta", "Adres klienta", 
                "Telefon klienta", "E-mail klienta", "Imię sprzedawcy", "Nazwisko sprzedawcy", "Telefon sprzedawcy", "E-mail sprzedawcy", "Miejce pracy sprzedawcy", "Czy zatrudniony" }); 
            listCohCarSell.Add(new string[] { "Numer porządkowy", "Imię", "Nazwisko", "Adres", "Telefon", "E-mail", "Data sprzedania", "Cena", "Model samochodu", "Kolor samochodu" }); 
            //listCohCarRes.Add(new string[] { item.first_name, item.last_name, item.address, item.phone, item.email, String.Format("{0:dd.MM.yyyy HH:mm}", item.date_reservation), String.Format("{0:dd.MM.yyyy HH:mm}", item.date_reservation_expired), item.car_model, item.car_color }); 
            //listCohService.Add(new string[] { item.first_name, item.last_name, item.address, item.phone, item.email, String.Format("{0:dd.MM.yyyy HH:mm}", item.date_order), item.cost, item.service, item.comment }); ; 
            foreach (salon_ranking item in salonRanking) 
            { 
                listSalonRanking.Add(new string[] { item.name, item.address, item.phone, item.www, item.cars.ToString() }); 
            }
            foreach (orders_in_progres item in ordersInProgres) 
            { 
                listOrdersInProgres.Add(new string[] { item.order_id.ToString(), String.Format("{0:dd.MM.yyyy}", item.date_reservation), String.Format("{0:dd.MM.yyyy}", 
                    item.date_reservation_expired), item.car_model, item.car_color, item.car_engine, item.car_gearbox, item.car_fuel, item.car_body, item.car_cost, item.shop_address_with_car, 
                    item.client_first_name, item.client_last_name, item.client_address, item.client_phone, item.client_email, item.user_first_name, item.user_last_name, item.user_phone, 
                    item.user_email, item.shop_address_with_seller, item.user_is_active.ToString() }); 
            }
            foreach (client_order_history_car_sell item in cohCarSell) 
            { 
                listCohCarSell.Add(new string[] { item.id.ToString(), item.first_name, item.last_name, item.address, item.phone, item.email, String.Format("{0:dd.MM.yyyy}", 
                    item.sell_date), item.cost, item.car_model, item.car_color }); 
            }
            /*foreach (client_order_history_car_res item in cohCarRes) 
            {
                listCohCarRes.Add(new string[] { item.first_name, item.last_name, item.address, item.phone, item.email, String.Format("{0:dd.MM.yyyy}", item.date_reservation), 
                    String.Format("{0:dd.MM.yyyy}", item.date_reservation_expired), item.car_model, item.car_color }); 
            }
            foreach (client_order_history_service item in cohService) 
            {
                listCohService.Add(new string[] { item.first_name, item.last_name, item.address, item.phone, item.email, String.Format("{0:dd.MM.yyyy}", item.date_order), 
                    item.cost, item.service, item.comment }); ; 
            }*/
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxQuestionMark_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wybierz z listy rozwijanej raport, kliknij 'Generuj raport' i zapisz wygenerowany raport w odpowiadającej Ci lokalizacji.");
        }

        public void createReport(List<string[]> output, string filePath)
        {

            string delimter = ";";

            int length = output.Count;

            using (TextWriter writer = File.CreateText(filePath))
            {

                for (int index = 0; index < length; index++)
                {
                    writer.WriteLine(string.Join(delimter, output[index]));
                }
            }
        }

        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            var report = this.comboBoxReport.Text;
            string path;
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.DefaultExt = ".csv";
            dialog.FileName = "Raport";
            dialog.ShowDialog();
            path = dialog.FileName;
            if (dialog.FileName != "")
                switch (report)
                {
                    case "Ranking salonów":                        
                            createReport(listSalonRanking, path);
                        break;
                    case "Realizowane zamówienia":
                            createReport(listOrdersInProgres, path);
                        break;
                    case "Historia zamówień klienta":
                            createReport(listCohCarSell, path);
                        break;
                }

        }
    }
}
