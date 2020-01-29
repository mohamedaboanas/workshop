using System;
using System.Collections.Generic;

namespace Workflow_Engine_Exercise
{
    public class Workflow : IWorkflow
    {
        private readonly List<ITask> _tasks;

        public Workflow()
        {
            _tasks = new List<ITask>();
        }


        public void Add(ITask task)
        {
            _tasks.Add(task);
        }


        public void Remove(ITask task)
        {
            _tasks.Remove(task);
        }

        public IEnumerable<ITask> GeTasks()
        {
            return _tasks;
        }
    }
}