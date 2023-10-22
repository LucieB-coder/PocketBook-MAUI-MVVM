using MyToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModelWrapper
{
    public class FilterViewModel: BaseViewModelWrapper<FilterViewModel>
    {
        public string Type { get => type; set => SetProperty(ref type, value, () => { type = value; }); }
        private string type;
        public string Content { get => content; set => SetProperty(ref content, value, () => { content = value; }); }
        private string content;
        public FilterViewModel(string _type, string _content)
        {
            Type = _type;
            Content = _content;
        }
    }
}
