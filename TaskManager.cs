using System;
using System.Collections.Generic;

namespace TaskManager
{
    internal class TaskManager
    {
        struct TaskStruct
        {
            public string taskTitle;
            public string taskDescription;
            public int priorityLevel; // 1 = high, 2 = medium, 3 low
            public bool completionStatus;
            public int id;
        }

        static Dictionary<int, TaskStruct> TaskDict = new Dictionary<int, TaskStruct>();

        TaskStruct taskStruct = new TaskStruct();

        public void AddTask(string title)
        {
            taskStruct.id += 1;
            taskStruct.taskTitle = title;
            TaskDict[taskStruct.id] = taskStruct;
        }
        
    }
}
