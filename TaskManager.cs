using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace TaskManager
{
    public class TaskManagerData
    {
        int NextId;

        public struct TaskInfo
        {
            public string Title;
            public string Details;
            public int InitializeDetails; // More than 1 means that details have been initialized

            public TaskInfo(string title, string details, int initDetails)
            {
                Title = title;
                Details = details;
                InitializeDetails = initDetails;
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
            taskDictionary[NextId] = new TaskInfo(title, "", 0);

            // Return the value for the list
            var pair = new KeyValuePair<int, string>(NextId, title);
            listBox.Items.Add(pair);
        }
    }
}
