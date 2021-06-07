using AgeOfKarten.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AgeOfKarten.Data
{
    public class MainService
    {
        public NavigationManager MyNavigationManager { get; set; }

        private stringtable stringtable;

        public static Dictionary<string, string> Civs = new Dictionary<string, string>()
        {
            {"homecityamericans.xml", "America" },
            {"homecitybritish.xml", "British" },
        };

        public async Task<homecity> ReadHomeCity(string name)
        {
            homecity hc = null;
            string path = MyNavigationManager.BaseUri + "gamefiles/nations/" + name;
            var httpClient = new System.Net.Http.HttpClient();
            var stream = await httpClient.GetStreamAsync(path);
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(homecity));

            hc = (homecity)serializer.Deserialize(stream);
            return hc;
        }

        public async Task<List<InfoItem>> GetCardsOfNation(string nation, string language)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var hcTask = await ReadHomeCity(nation);
            Console.WriteLine("ReadHomeCity: " + stopWatch.ElapsedMilliseconds.ToString());
            stopWatch.Restart();
            var ttTask = await ReadTechTree();
            Console.WriteLine("ReadHomeCity: " + stopWatch.ElapsedMilliseconds.ToString());

            var items = from card in hcTask.cards
                        join techt in ttTask.tech on card.name equals techt.name
                        join strName in stringtable.language.entries on techt.displaynameid equals strName._locid
                        select new InfoItem()
                        {
                            Age = card.age,
                            ImageName = techt.icon,
                            Name = strName.Value,
                            DisplayUnitCount = card.displayunitcount
                        };
            return items.ToList();
        }

        public async Task LoadStringTable(string language)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            stringtable table = null;
            string path = MyNavigationManager.BaseUri + "gamefiles/strings/" + language + "/stringtabley.xml";

            var httpClient = new System.Net.Http.HttpClient();
            var stream = await httpClient.GetStreamAsync(path);
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(stringtable));
                table = (stringtable)serializer.Deserialize(stream);

            stringtable = table;
            stopwatch.Stop();
            Console.WriteLine($"String Table loaded in: {stopwatch.ElapsedMilliseconds} Milliseconds");
        }

        public async Task<techtree> ReadTechTree()
        {
            techtree tt = null;
            string path = MyNavigationManager.BaseUri + "gamefiles/techtree/Data/techtreey.xml";
            var httpClient = new System.Net.Http.HttpClient();
            var stream = await httpClient.GetStreamAsync(path);
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(techtree));
            tt = (techtree)serializer.Deserialize(stream);
            return tt;
        }

        public MainService(NavigationManager navManager)
        {
            Console.WriteLine("MainService Created!");
            this.MyNavigationManager = navManager;
            LoadStringTable("English").ConfigureAwait(false);
        }
    }
}
