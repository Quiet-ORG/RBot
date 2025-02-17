﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using RBot.Utils;

namespace RBot.Repos
{
    public class ScriptFetcher
    {
        public const string BaseUrl = "https://raw.githubusercontent.com/Quiet-ORG/rbot-scripts/master/repos";
        public const string DebugSource = "https://raw.githubusercontent.com/Quiet-ORG/rbot-scripts/master/DebugRepos";

        public static async Task<List<ScriptRepo>> GetRepos()
        {
            using (RBotWebClient wc = new RBotWebClient())
            {
                return (await wc.DownloadStringTaskAsync(DebugSource)).Split('\n').Select(l => l.Trim().Split('|')).Where(p => p.Length == 4).Select(p => new ScriptRepo()
                {
                    Username = p[0],
                    Name = p[1],
                    Extension = p[2],
                    Author = p[3]
                }).ToList();
            }
        }

        public static async Task<List<ScriptInfo>> GetScripts(ScriptRepo repo)
        {
            using (GHWebClient wc = new GHWebClient())
            {
                return JsonConvert.DeserializeObject<List<ScriptInfo>>(await wc.DownloadStringTaskAsync(repo.ContentsUrl)).Where(x => x.FileName.EndsWith(".cs") && (x.Parent = repo) != null).ToList();
            }
        }
    }
}
