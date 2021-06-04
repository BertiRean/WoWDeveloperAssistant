﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoWDeveloperAssistant.Database_Advisor
{
    public static class AddonsHelper
    {
        public static void GetAddonsFromSql(string fileName, TextBox textBox)
        {
            if (textBox.Text == "")
                return;

            string[] lines = File.ReadAllLines(fileName);
            List<string> creatureLinkedIds = new List<string>();
            List<string> gameobjectLinkedIds = new List<string>();
            Dictionary<string, string> creatureAddons = new Dictionary<string, string>();
            Dictionary<string, string> gameobjectAddons = new Dictionary<string, string>();
            string output = "";

            for (int i = 0; i < lines.Count(); i++)
            {
                if (lines[i].Contains("INSERT INTO `creature_addon`"))
                {
                    i++;

                    do
                    {
                        creatureAddons.Add(GetLinkedIdFromLine(lines[i]), lines[i]);
                        i++;
                    } while (lines[i] != "");
                }
                else if (lines[i].Contains("INSERT INTO `gameobject_addon`"))
                {
                    i++;

                    do
                    {
                        gameobjectAddons.Add(GetLinkedIdFromLine(lines[i]), lines[i]);
                        i++;
                    } while (lines[i] != "");
                }
            }

            foreach (string line in textBox.Text.Split('\n'))
            {
                string linkedId = GetLinkedIdFromLine(line);

                if (creatureAddons.ContainsKey(linkedId))
                {
                    creatureLinkedIds.Add(linkedId);
                }
                else if (gameobjectAddons.ContainsKey(linkedId))
                {
                    gameobjectLinkedIds.Add(linkedId);
                }
            }

            if (creatureAddons.Keys.Intersect(creatureLinkedIds).Count() != 0)
            {
                List<string> intersectedLinkedIds = creatureAddons.Keys.Intersect(creatureLinkedIds).ToList();

                output += "INSERT INTO `creature_addon` (`linked_id`, `path_id`, `mount`, `bytes1`, `bytes2`, `emote`, `aiAnimKit`, `movementAnimKit`, `meleeAnimKit`, `auras`, `VerifiedBuild`) VALUES" + "\r\n";

                for (int i = 0; i < creatureLinkedIds.Count; i++)
                {
                    if (!intersectedLinkedIds.Contains(creatureLinkedIds[i]))
                        continue;

                    if (i + 1 < creatureLinkedIds.Count)
                    {
                        output += creatureAddons[creatureLinkedIds[i]].Replace(");", "),") + "\r\n";
                    }
                    else
                    {
                        output += creatureAddons[creatureLinkedIds[i]].Replace("),", ");");
                    }
                }
            }

            if (gameobjectAddons.Keys.Intersect(gameobjectLinkedIds).Count() != 0)
            {
                List<string> intersectedLinkedIds = gameobjectAddons.Keys.Intersect(gameobjectLinkedIds).ToList();

                if (output != "")
                {
                    output += "\r\n";
                }

                output += "INSERT INTO `gameobject_addon` (`linked_id`, `parent_rotation0`, `parent_rotation1`, `parent_rotation2`, `parent_rotation3`, `WorldEffectID`, `VerifiedBuild`) VALUES" + "\r\n";

                for (int i = 0; i < gameobjectLinkedIds.Count; i++)
                {
                    if (!intersectedLinkedIds.Contains(gameobjectLinkedIds[i]))
                        continue;

                    if (i + 1 < gameobjectLinkedIds.Count)
                    {
                        output += gameobjectAddons[gameobjectLinkedIds[i]].Replace(");", "),") + "\r\n";
                    }
                    else
                    {
                        output += gameobjectAddons[gameobjectLinkedIds[i]].Replace("),", ");");
                    }
                }
            }

            textBox.Text = output;
        }

        private static string GetLinkedIdFromLine(string line)
        {
            if (line.Contains("('"))
                return line.Split(',')[0].Replace("(", "");
            else
                return "";
        }

        public static void OpenFileDialog(OpenFileDialog fileDialog)
        {
            fileDialog.Title = "Open File";
            fileDialog.Filter = "Sql File (*.sql)|*.sql";
            fileDialog.FileName = "";
            fileDialog.FilterIndex = 1;
            fileDialog.ShowReadOnly = false;
            fileDialog.Multiselect = false;
            fileDialog.CheckFileExists = true;
        }
    }
}
