using System;
using System.Collections.Generic;

namespace TaskManager
{
    public class TaskManagerData
    {
        int NextId;

        private static Dictionary<int, string> taskList = new Dictionary<int, string>();

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
            string line = $"{NextId}. {taskList[NextId]}";
            return line;
        }
    }
}
