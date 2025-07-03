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
            public DateTime TaskDueDate;
            public TaskInfo(string title, string details, DateTime taskDueDate)
            {
                Title = title;
                Details = details;
                TaskDueDate = taskDueDate;
            }
        }

        public static Dictionary<int, TaskInfo> taskDictionary = new Dictionary<int, TaskInfo>();

        public TaskManagerData(int nextId = 0)
        {
            NextId = nextId;
        }

        public void AddTaskToList(string title, ListBox listBox, DateTime taskDueDate)
        {
            // Add task title to Dictionary
            NextId++;
            taskDictionary[NextId] = new TaskInfo(title, "", taskDueDate);

            // Return the value for the list
            var pair = new KeyValuePair<int, string>(NextId, title);
            listBox.Items.Add(pair);
        }
    }
}
