using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workflow_Engine_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
           workflow.Add(new VideoUploader());

            var engine = new WorkflowEngine();
            engine.Run(workflow);


        }
    }
}
