using System;
using Avalonia.Svg.Skia;
using CommunityToolkit.Mvvm.ComponentModel;
namespace LearnAvalonia.ViewModels;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
public partial class MainViewModel : ViewModelsBase
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(SideMenuImage))]
    private bool _sideMenuExpaned = true;   
    // public SvgImage SideMenuImage => new SvgImage{Source = SvgSource.Load($"avares://{nameof(LearnAvalonia)}/Assets/Images/Icons/{(SideMenuExpaned ? "logo-icon":"logo")}.svg")};
    // public Bitmap SideMenuImage => new Bitmap($"avares://{nameof(LearnAvalonia)}/Assets/Images/Icons/{(SideMenuExpaned ? "logo" : "logo-icon")}.png");
    public Bitmap SideMenuImage => new Bitmap(
        AssetLoader.Open(new Uri($"avares://{nameof(LearnAvalonia)}/Assets/Images/Icons/{(SideMenuExpaned ? "logo-icon" : "logo")}.png"))
    );
}