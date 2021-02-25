using System.Windows;


namespace WpfMailSender.Controls
{
    /// <summary>
    /// Interaction logic for ItemsPanel.xaml
    /// </summary>
    public partial class ItemsPanel
    {
        public static readonly DependencyProperty TitleProperty = 
            DependencyProperty.Register(
            nameof(Title),
            typeof(string),
            typeof(ItemsPanel),
            //new PropertyMetadata(default(string)));
            new PropertyMetadata("Название"));

        public string Title
        {
            get => (string)GetValue(TitleProperty); 
            set => SetValue(TitleProperty, value);
        }

        public ItemsPanel() => InitializeComponent();
    }
}
