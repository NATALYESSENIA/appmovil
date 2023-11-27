using appmovil;
using appmovil.Models;
using appmovil;
namespace appmovil.Views;

public partial class FlyoutMenu : FlyoutPage
{
    public FlyoutMenu()
    {
        InitializeComponent();
        //menus.
        //menus.collectionView.SelectionChanged += OnSelectionChanged;
    }

    void OnSelectionChanged(object Sender, SelectionChangedEventArgs e)
    {
        var item = e.CurrentSelection.FirstOrDefault() as FlyoutPageItem;
        if (item != null)
        {
            Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
            IsPresented = false;
        }

    }
}