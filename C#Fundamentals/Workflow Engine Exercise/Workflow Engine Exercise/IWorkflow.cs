using System.Collections.Generic;

namespace Workflow_Engine_Exercise
{
    public interface IWorkflow
    {
        void Add(ITask task);
        void Remove(ITask task);
        IEnumerable<ITask> GeTasks();
    }
}