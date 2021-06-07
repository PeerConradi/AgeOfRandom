using AgeOfKarten.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AgeOfKarten.Data
{
    public class MainService
    {
        public NavigationManager MyNavigationManager { get; set; }

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
            var stringTableTask = await LoadStringTable(language);
            var hcTask = await ReadHomeCity(nation);
            var ttTask = await ReadTechTree();

            var items = from card in hcTask.cards
                        join techt in ttTask.tech on card.name equals techt.name
                        join strName in stringTableTask.language.entries on techt.displaynameid equals strName._locid
                        select new InfoItem()
                        {
                            Age = card.age,
                            ImageName = techt.icon,
                            Name = strName.Value,
                            DisplayUnitCount = card.displayunitcount
                        };
            return items.ToList();
        }

        public async Task<stringtable> LoadStringTable(string language)
        {
            stringtable table = null;
            string path = MyNavigationManager.BaseUri + "/gamefiles/strings/" + language + "/stringtabley.xml";
            Console.WriteLine("Pfad: " + path);

            var httpClient = new System.Net.Http.HttpClient();
            var stream = await httpClient.GetStreamAsync(path);
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(stringtable));
                table = (stringtable)serializer.Deserialize(stream);

            return table;
        }

        public async Task<techtree> ReadTechTree()
        {
            techtree tt = null;
            string path = MyNavigationManager.BaseUri + "/gamefiles/techtree/Data/techtreey.xml";
            var httpClient = new System.Net.Http.HttpClient();
            var stream = await httpClient.GetStreamAsync(path);
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(techtree));
            tt = (techtree)serializer.Deserialize(stream);
            return tt;
        }

        public MainService(NavigationManager navManager)
        {
            this.MyNavigationManager = navManager;
        }
    }
}
