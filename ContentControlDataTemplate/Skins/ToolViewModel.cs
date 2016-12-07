namespace ContentControlDataTemplate.Skins
{
    internal class ToolViewModel
    {
        public ToolViewModel(string displayName)
        {
            DisplayName = displayName;
        }

        public string DisplayName { get; set; }
    }
}