using System.Collections.Generic;
using System.Windows;

namespace TreeViewSample
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new List<TreeViewItemViewModel>
            {
                new TreeViewItemViewModel
                {
                    Header = "Item1",
                    Children = new List<TreeViewItemViewModel> { new TreeViewItemViewModel { Header = "Item1-1", IsSelected = true} }
                },
                new TreeViewItemViewModel { Header = "Item2" }
            };
        }
    }
}
