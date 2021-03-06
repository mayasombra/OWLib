﻿using System;
using System.IO;
using DataTool.JSON;
using DataTool.Flag;
using DataTool.ToolLogic.Extract;
using DataTool.ToolLogic.List;
using DataTool.ToolLogic.List.Misc;

namespace DataTool.ToolLogic.Dump {
    [Tool("dump-all-stuff", CustomFlags = typeof(ExtractFlags), IsSensitive = true)]
    public class DumpAllTheStuff : JSONTool, ITool {
        public void Parse(ICLIFlags toolFlags) {          
            var flags = (ExtractFlags) toolFlags;
            if (flags.OutputPath == null)
                throw new Exception("no output path");

            new ListAchievements().Parse(GetFlagsForCommand(flags, "achievements"));
            new ListArcadeModes().Parse(GetFlagsForCommand(flags, "arcade-modes"));
            new ListChatSettings().Parse(GetFlagsForCommand(flags, "chat-settings"));
            new ListEsportTeams().Parse(GetFlagsForCommand(flags, "esport-teams"));
            new ListGameModes().Parse(GetFlagsForCommand(flags, "gamemodes"));
            new ListGameParams().Parse(GetFlagsForCommand(flags, "game-rulesets"));
            new ListGeneralUnlocks().Parse(GetFlagsForCommand(flags, "general-unlocks"));
            new ListHeroes().Parse(GetFlagsForCommand(flags, "heroes"));
            new ListLootbox().Parse(GetFlagsForCommand(flags, "lootboxes"));
            new ListMaps().Parse(GetFlagsForCommand(flags, "maps"));
            new ListReportResponses().Parse(GetFlagsForCommand(flags, "report-responses"));
            new DumpStrings().Parse(GetFlagsForCommand(flags, "strings", true));
            new ListSubtitles().Parse(GetFlagsForCommand(flags, "subtitles"));
            new ListHeroUnlocks().Parse(GetFlagsForCommand(flags, "unlocks"));
            //new ListRankedSeasons().Parse(GetFlagsForCommand(flags, "ranked-seasons"));
            new ListBrawls().Parse(GetFlagsForCommand(flags, "brawls"));
            new ListLogicalButtonMapping().Parse(GetFlagsForCommand(flags, "button-mapping"));
            new ListChatReplacements().Parse(GetFlagsForCommand(flags, "chat-replacements"));
            new ListProfanityFilters().Parse(GetFlagsForCommand(flags, "profanity-filters"));
            new ListBrawlName().Parse(GetFlagsForCommand(flags, "brawl-names"));
            new ListConversations().Parse(GetFlagsForCommand(flags, "conversations"));
            new ListUxStringsOrSomething().Parse(GetFlagsForCommand(flags, "ux-strings"));
            new DumpFileLists().Parse(toolFlags);
        }
        
        private static ListFlags GetFlagsForCommand(ExtractFlags flags, string output, bool useDumpFlags = false) {
            if (useDumpFlags)
                return new DumpFlags {
                    JSON = true,
                    Output = $"{Path.Combine(flags.OutputPath, output)}.json"
                };

            return new ListFlags {
                JSON = true,
                Output = $"{Path.Combine(flags.OutputPath, output)}.json"
            };
        }
    }
}