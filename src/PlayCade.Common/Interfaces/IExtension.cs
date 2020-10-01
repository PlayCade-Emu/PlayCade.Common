namespace PlayCade.Common.Interfaces
{
    public interface IExtension
    {
        /// <summary>
        /// Name of the extension
        /// </summary>
        string Name { get; set; }
        
        /// <summary>
        /// Description of the extension's functionality
        /// </summary>
        string Description { get; set; }
        
        /// <summary>
        /// The platform that the extension has been developed to emulate
        /// </summary>
        string Platform { get; set; }
        
        /// <summary>
        /// The description about the platform that the extension has been developed to emulate
        /// </summary>
        string PlatformDescription { get; set; }

        /// <summary>
        /// OnStart is called when the extension is initially loaded.
        /// </summary>
        void OnStart();
        
        /// <summary>
        /// OnRun is called when the extension starts running it's content
        /// </summary>
        void OnRun(string contentLocation);

        /// <summary>
        /// OnStop is called when the extension stops running it's content
        /// </summary>
        void OnStop();
        
        /// <summary>
        /// OnFinish is called when the extension is closing
        /// </summary>
        void OnFinish();
    }
}