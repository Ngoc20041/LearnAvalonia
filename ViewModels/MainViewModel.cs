using Avalonia.Svg.Skia;
using CommunityToolkit.Mvvm.ComponentModel;
using Avalonia.Media.Imaging;
namespace LearnAvalonia.ViewModels;

public partial class MainViewModel : ViewModelsBase
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(SideMenuImage))]
    private bool _SideMenuExpaned = true;
    // public SvgImage SideMenuImage => new SvgImage{Source = SvgSource.Load($"avares://{nameof(LearnAvalonia)}/Assets/Images/Icons/{(SideMenuExpaned ? "logo-icon":"logo")}.svg")};
    // public Bitmap SideMenuImage => new Bitmap($"avares://{nameof(LearnAvalonia)}/Assets/Images/Icons/{(SideMenuExpaned ? "logo" : "logo-icon")}.png");
    
    
    
    
    public Bitmap SideMenuImage => new Bitmap("Assets/Images/Icons/logo-icon.png");
}