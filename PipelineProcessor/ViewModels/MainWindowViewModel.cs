using System.Collections.ObjectModel;
using System.Diagnostics;
using PipelineProcessor.Models;
using PipelineProcessor.Utils;
using Prism.Mvvm;

namespace PipelineProcessor.ViewModels;

public class MainWindowViewModel : BindableBase
{
    private string title = new AppVersionInfo().Title;
    private TextFile selectedItem;
    private string textFileDetail;

    public MainWindowViewModel()
    {
        InjectDummies();
    }

    public ObservableCollection<TextFile> TextFiles { get; set; } = new ();

    public ObservableCollection<ProcessorUnit> ProcessorUnits { get; set; } = new ();

    public TextFile SelectedItem
    {
        get => selectedItem;
        set
        {
            SetProperty(ref selectedItem, value);
            TextFileDetail = selectedItem?.Value;
        }
    }

    public string TextFileDetail { get => textFileDetail; set => SetProperty(ref textFileDetail, value); }

    public string Title
    {
        get => title;
        set => SetProperty(ref title, value);
    }

    [Conditional("DEBUG")]
    private void InjectDummies()
    {
        TextFiles.Add(new TextFile("a.txt", "test contents1"));
        TextFiles.Add(new TextFile("b.txt", "test contents2"));
        TextFiles.Add(new TextFile("c.txt", "test contents3"));
        TextFiles.Add(new TextFile("d.txt", "test contents4"));

        ProcessorUnits.Add(new ProcessorUnit(ProcessType.Replace));
        ProcessorUnits.Add(new ProcessorUnit(ProcessType.Replace));
        ProcessorUnits.Add(new ProcessorUnit(ProcessType.Extract));
        ProcessorUnits.Add(new ProcessorUnit(ProcessType.Extract));
    }
}