using System;

namespace Workflow_Engine_Exercise
{
    public class WorkflowEngine
    {
        public void Run(IWorkflow workflow)
        {
            foreach (ITask itask in workflow.GeTasks())
            {
                try
                {
                    itask.Excute();
                }
                catch (Exception e)
                {
                    //Logging
                    //Terminate and persist the state  of workflow

                    Console.WriteLine(e);
                    throw;
                }
                
                
            }
            
        }
    }
}