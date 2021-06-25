using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Reflection;
using System.Text.Json;

//using Newtonsoft.Json;
using Leaf.xNet;

using LCU.Helper;

namespace LCU {
    public static class gameLCU {


        private static string urlBase = @"https://127.0.0.1:" + 2999 + "/liveclientdata/";

        private static string activePlayerUrl => urlBase + "activeplayer";
        private static string gameStatsUrl => urlBase + "gamestats";
        private static string allGameDataUrl => urlBase + "allgamedata";

        public static bool IsApiReady() {
            HttpResponse res;
            try {
                HttpRequest req = clientLCU.CreateRequest();
                res = req.Get(gameStatsUrl);
                return res.StatusCode == HttpStatusCode.OK;
            } catch {
                return false;
            }
        }

        public static bool IsPlayerDead() {
            return GetStats().currentHealth == 0;
        }

        public static AllGameData GetAllGameData() {
            HttpRequest req = clientLCU.CreateRequest();
            HttpResponse res = req.Get(allGameDataUrl);

            if(res.StatusCode == HttpStatusCode.OK) {
                return JsonSerializer.Deserialize<AllGameData>(res.ToString());
            } else {
                return null;
            }
        }

        public static dynamic GetStats() {
            using(HttpRequest req = clientLCU.CreateRequest()) {
                HttpResponse res = req.Get(activePlayerUrl);
                dynamic dyn = JsonSerializer.Deserialize<dynamic>(res.ToString());
                return dyn.championStats;
            }
        }
    }
}
