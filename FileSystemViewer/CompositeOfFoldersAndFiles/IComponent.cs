namespace FileSystemViewer.CompositeOfFoldersAndFiles
{
    internal interface IComponent
    {
        void Close();
        int CloseCertainComponent(int numberOfComponent);
        int GetCountOfElements();
        void Open();
        int OpenCertainComponent(int numberOfComponent);
        void ShowInfo();
        int Spacing { get; set; }

        IComponent GetDirectory(int index);
    }
}
