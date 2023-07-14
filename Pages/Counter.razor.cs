using BlazorApp_Game.Models;
using Microsoft.AspNetCore.Components;
namespace BlazorApp_Game.Pages
{
    public partial class Counter
    {
        [Inject] SingletonService singleton { get; set; }
        [Inject] TransientService transient { get; set; }

        [CascadingParameter] public AppStyle Styles { get; set; }

        private int currentCount = 0;
        private void IncrementCount()
        {
            currentCount++;
            singleton.Value = currentCount;
            transient.Value = currentCount;
        }
    }
}
