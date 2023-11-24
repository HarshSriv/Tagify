using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;

namespace tagify
{
    internal class tagInterface : mainWindow
    {
        internal static string getTags(string filePath)
        {
            return tagsParse(getAds(filePath));
        }

        internal static void setTags(string filePath, string inputTags)
        {
            inputTags = tagsStringify(inputTags);

            setAds(filePath, inputTags);
        }

        internal static void setBatchTags(ListView.SelectedListViewItemCollection items, string inputTags)
        {
            inputTags = tagsStringify(inputTags);

            foreach(ListViewItem item in items)
            {
                bool isFile = item.Tag is FileInfo;

                if(isFile)
                {
                    FileInfo currentFile = item.Tag as FileInfo;
                    string filePath = currentFile.FullName;

                    string oldTags = getAds(filePath);
                    string newTags = inputTags;

                    newTags += "," + oldTags;
                    newTags = tagsStringify(newTags);

                    setAds(filePath, newTags);
                }
            }
        }

        internal static void deleteBatchTags(ListView.SelectedListViewItemCollection items, string inputTags)
        {
            inputTags = tagsStringify(inputTags);
            SortedSet<string> tagsToRemove = stringToSet(inputTags);

            foreach(ListViewItem item in items)
            {
                bool isFile = item.Tag is FileInfo;

                if(isFile)
                {
                    FileInfo currentFile = item.Tag as FileInfo;
                    string filePath = currentFile.FullName;

                    if(inputTags == "cheat:idontliketags")
                        setAds(filePath, "");
                    else
                    {
                        string currentTags = getAds(filePath);
                        SortedSet<string> oldTags = stringToSet(currentTags);

                        List<string> newTags = oldTags.Except(tagsToRemove).ToList();
                        currentTags = setToString(newTags);

                        setAds(filePath, currentTags);
                    }
                }
            }
        }

        internal static string getAds(string filePath)
        {
            filePath += ":tagifyTags";
            string adsTags = "";

            try
            {
                adsTags = File.ReadAllText(filePath);
            }
            catch(Exception e)
            {
                // exception when stream is not present
            }

            return adsTags; 
        }

        internal static void setAds(string filePath, string inputAds)
        {
            if(File.Exists(filePath))
            {
                filePath += ":tagifyTags";
                File.WriteAllText(filePath, inputAds);
            }
        }

        internal static string tagsParse(string inputTags)
        {
            string parsedTags = "";
            for (int i = 0; i < inputTags.Length; i++)
            {
                parsedTags += inputTags[i];
                if(inputTags[i] == ',') parsedTags += " ";
            }

            return parsedTags;
        }

        internal static string tagsStringify(string inputTags)
        {
            SortedSet<string> uniqueTags = stringToSet(inputTags);

            string stringifiedTags = setToString(uniqueTags);

            return stringifiedTags;
        }

        internal static SortedSet<string> stringToSet(string inputTags)
        {
            SortedSet<string> uniqueTags = new SortedSet<string>();

            string[] tags = inputTags.Split(",");
            for (int i = 0; i < tags.Length; i++)
            {
                tags[i] = tags[i].Trim(' ').ToLower();
                uniqueTags.Add(tags[i]);
            }

            return uniqueTags;
        }

        internal static string setToString(dynamic uniqueTags)
        {
            string stringifiedTags = "";

            foreach (string tag in uniqueTags)
            {
                if (tag != "")
                {
                    stringifiedTags += tag + ",";
                }
            }
            if (stringifiedTags.Length > 0)
                stringifiedTags = stringifiedTags.Substring(0, stringifiedTags.Length - 1);

            return stringifiedTags;
        }
    }
}
