using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;


namespace Blazor.AdminPanel.Test.EndPoint.Components.Comps
{
    public partial class RandomNumber
    {
        //[Inject]
        //protected Randomizer? RandomNumberGenerator { get; set; }

        [Inject]
        protected IJSRuntime JsRuntime { get; set; }
        protected IJSObjectReference _jSObjectReference;

        protected string? GetRandomNumber() => 2342.ToString(); // RandomNumberGenerator?.RendomNumber(1231, 341234) ?? throw new NotImplementedException(nameof(Randomizer));


        //protected async override Task OnAfterRenderAsync(bool firstRender)
        //{
        //    if (firstRender)
        //    {
        //       _jSObjectReference = await JsRuntime.InvokeAsync<IJSObjectReference>("import", "./scripts/comps/random-number.js");
        //    }
        //}

        public async Task ShowAlert()
        {
            await _jSObjectReference.InvokeVoidAsync("displayAlertMessage", 450);
            //var count = RandomNumberGenerator?.RendomNumber(1231, 341234);
            //await _jSObjectReference.InvokeVoidAsync("displayAlertMessage", count);
        }

    }
}