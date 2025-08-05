using BlazorServerDemo2.Entities;

namespace BlazorServerDemo2.Components.Pages
{
    public partial class Cats
    {
        private IEnumerable<Cat> CatInfo { get; set; }
        public bool Loading { get; set; } = false;

        private string catName = "persian";

        private async Task GetCats()
        {
            Loading = true;
            CatInfo = await catService.GetCats(catName);
            Loading = false;
        }

    }
}