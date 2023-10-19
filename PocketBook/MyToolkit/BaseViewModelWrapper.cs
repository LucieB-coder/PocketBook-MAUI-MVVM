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
