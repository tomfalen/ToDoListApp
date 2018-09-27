namespace ToDoList
{
    public class HomeViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Home Page";
            }
        }
    }
}
