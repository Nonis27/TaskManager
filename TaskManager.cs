using System;
using System.Collections.Generic;

namespace TaskManager
{
    public class TaskManagerData
    {
        int NextId;

        public struct TaskInfo
        {
            public string Title;
            public string Details;

            public TaskInfo(string title, string details)
            {
                Title = title;
                Details = details;
            }
        }

        public static Dictionary<int, TaskInfo> taskDictionary = new Dictionary<int, TaskInfo>();

        public TaskManagerData(int nextId = 0)
        {
            NextId = nextId;
        }

        public void AddTaskToList(string title, ListBox listBox)
        {
            // Add task title to Dictionary
            NextId++;
            taskDictionary[NextId] = new TaskInfo(title, "");

            // Return the value for the list
            var pair = new KeyValuePair<int, string>(NextId, title);
            listBox.Items.Add(pair);
        }
    }
}
