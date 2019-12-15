﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_iDental.Entities;
using System.Net.Http;

namespace WF_iDental.UserControls
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
        }
        public string baseAddress = "http://localhost:55965/api/";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public List<AppointmentShow> GetAll()
        {
            IEnumerable<AppointmentShow> lichhen = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("LoadHome");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<AppointmentShow>>();
                    readTask.Wait();

                    lichhen = readTask.Result;
                }
                else
                {
                    lichhen = Enumerable.Empty<AppointmentShow>();

                }
            }
            return lichhen.ToList();
        }
        public List<AppointmentShow> GetLHCuaBacSy()
        {
            IEnumerable<AppointmentShow> lichhen = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync($"LoadHome?employeeID"+5);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<AppointmentShow>>();
                    readTask.Wait();

                    lichhen = readTask.Result;
                }
                else
                {
                    lichhen = Enumerable.Empty<AppointmentShow>();

                }
            }
            return lichhen.ToList();
        }
        private void UC_Home_Load(object sender, EventArgs e)
        {
            dgvLichHenHome.DataSource = GetAll();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void palLeft_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
