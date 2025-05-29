using System;
using System.Collections.Generic;

namespace TaskManager
{
    public class TaskManagerData
    {
        int NextId;

        public static Dictionary<int, string> taskList = new Dictionary<int, string>();

        public TaskManagerData(int nextId = 0)
        {
            NextId = nextId;
        }

        public string AddTask(string title)
        {
            // Add task title to Dictionary
            NextId++;
            taskList[NextId] = title;

            // Return the value for the list
            return taskList[NextId];
        }
    }
}
