namespace BlazorApp_Game.Models
{
    public class AppStyle
    {
        public string Color { get; set; } = "green";
        public string Size { get; set; } = "65px";

        public List<string> WitcherWords { get; set; } = new List<string>()
        {
            new string("Garten ist mein Hobby "),
            new string("Radfahren ist mein Hobby "),
            new string("Reisen ist mein Hobby ")
        };

        public List<TableListModel> TableStyle { get; set; } = new List<TableListModel>()
        {
            new TableListModel(){Text="Table Dark" , Value="table-dark"},
            new TableListModel(){Text="Table Striped" , Value="table-striped"},
            new TableListModel(){Text="Table Secondary" , Value="table-secondary"},
            new TableListModel(){Text="Table Info" , Value="table-info"}
        };


    }
}
