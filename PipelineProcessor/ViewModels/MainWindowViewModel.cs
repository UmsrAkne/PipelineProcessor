using PipelineProcessor.Utils;
using Prism.Mvvm;

namespace PipelineProcessor.ViewModels;

public class MainWindowViewModel : BindableBase
{
    private string title = new AppVersionInfo().Title;

    public string Title
    {
        get => title;
        set => SetProperty(ref title, value);
    }
}