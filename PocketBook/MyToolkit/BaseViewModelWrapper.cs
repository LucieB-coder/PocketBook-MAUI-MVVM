using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToolkit
{
    public class BaseViewModelWrapper<TModel> : ObservableObject
    {
        private TModel model;

        public TModel Model
        { 
            get => model; 
            set => SetProperty(ref model,value);
        }

        public BaseViewModelWrapper(TModel model)
        {
            Model = model;
        }
        public BaseViewModelWrapper() { }

    }
}
