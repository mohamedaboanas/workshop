using System;

namespace Workflow_Engine_Exercise
{
    public class VideoUploader : ITask
    {
        public void Excute()
        {
            Console.WriteLine("Uploading Video.....");
        }
    }
}