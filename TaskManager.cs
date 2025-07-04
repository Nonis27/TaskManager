using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace TaskManager
{
    public class TaskManagerData
    {
        int NextId;
        string filename = "Tasks.json";

        public struct TaskInfo
        {
            public string Title { get; set; }
            public string Details { get; set; }
            public int InitializeDetails { get; set; } // More than 1 means that details have been initialized
            public DateTime TaskDueDate { get; set; }
            public TaskInfo(string title, string details, DateTime taskDueDate)
            {
                Title = title;
                Details = details;
                TaskDueDate = taskDueDate;
            }
        }

        public static Dictionary<int, TaskInfo> TaskDictionary { get; set; } = new();

        public TaskManagerData(int nextId = 0)
        {
            NextId = nextId;
        }

        public void AddTaskToList(string title, ListBox listBox, DateTime taskDueDate)
        {
            // Add task title to Dictionary
            NextId++;
            TaskDictionary[NextId] = new TaskInfo(title, "", taskDueDate);

            // Return the value for the list
            var pair = new KeyValuePair<int, string>(NextId, title);
            listBox.Items.Add(pair);
        }

        public void SaveTasks()
        {
            string jsonString = JsonSerializer.Serialize(TaskDictionary);
            File.WriteAllText(filename, jsonString);
        }

        public void LoadTasks()
        {
            if (!File.Exists(filename)) return;

            string jsonString = File.ReadAllText(filename);

            var loadedDict = JsonSerializer.Deserialize<Dictionary<int, TaskInfo>>(jsonString);

           if (loadedDict != null)
           {
                TaskDictionary.Clear();

                foreach(var kvp in loadedDict)
                {
                    TaskDictionary[kvp.Key] = kvp.Value;
                }

                if (TaskDictionary.Count > 0)
                {
                    NextId = Math.Max(NextId, MaxKey(TaskDictionary));
                }
           }
        }

        public int MaxKey(Dictionary<int, TaskInfo> dict)
        {
            int max = 0;
            foreach (var key in dict.Keys)
            {
                if (key > max) max = key;
            }

            return max;
        }
    }
}
