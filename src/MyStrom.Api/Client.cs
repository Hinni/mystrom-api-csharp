using MyStrom.Api.Helpers;
using MyStrom.Api.Models;
using System;
using System.Collections.Generic;
using System.Net;

namespace MyStrom.Api
{
    public class Client
    {
        public string BaseHost { get; private set; }

        public Info Info { get; private set; }
        public Dictionary<string, Network> Networks { get; private set; }
        public Report Report { get; private set; }
        public Temp Temp { get; private set; }
        public Rest Rest { get; private set; }
        public Panel Panel { get; private set; }

        public Client(Uri baseHost)
        {
            BaseHost = baseHost.AbsoluteUri;
        }

        public void RefreshAll()
        {
            LoadInfo();
            LoadNetworks();
            LoadReport();
            LoadTemp();
            LoadRest();
            LoadPanel();
        }

        public void SetState(bool state)
        {
            using (var client = new WebClient())
            {
                client.DownloadString(GetUri($"relay?state={(state ? 1 : 0)}"));
            }
        }

        public void ToggleState()
        {
            using (var client = new WebClient())
            {
                client.DownloadString(GetUri($"toggle"));
            }
        }

        public void LoadInfo()
        {
            Info = Reader<Info>.ReadObject(GetUri("info.json"));
        }

        public void LoadNetworks()
        {
            Networks = Reader<Dictionary<string, Network>>.ReadObject(GetUri("networks.json"));
        }

        public void LoadReport()
        {
            Report = Reader<Report>.ReadObject(GetUri("report"));
        }

        public void LoadTemp()
        {
            Temp = Reader<Temp>.ReadObject(GetUri("temp"));
        }

        public void LoadRest()
        {
            Rest = Reader<Rest>.ReadObject(GetUri("rest"));
        }

        public void LoadPanel()
        {
            Panel = Reader<Panel>.ReadObject(GetUri("panel"));
        }

        private Uri GetUri(string path)
        {
            return new Uri($"{BaseHost}{path}");
        }
    }
}