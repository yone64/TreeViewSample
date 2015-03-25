using System.Collections.Generic;

namespace TreeViewSample
{
    public class TreeViewItemViewModel
    {
        public string Header { get; set; }

        public List<TreeViewItemViewModel> Children { get; set; }

        public bool IsSelected { get; set; }
    }
}
