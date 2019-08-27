namespace Installer
{
    public class PrerequisiteViewModel
    {
        // This property contains the prerequisite's text.
        public string Name { set; get; }

        // This property determines the prerequisite's status on the system.
        public bool Status { set; get; }

        // This property explains about the status of the prerequisite.
        public string Description { set; get; }
    }
}
