using MudBlazor;

namespace BlazorApp1;

public class Theme
{
    private MudTheme myTheme { get; set; }

    public MudTheme getTheme()
    {
        return myTheme = new MudTheme()
        {
            Typography = new Typography()
            {
                Default = new Default()
                {
                    FontFamily = new []{"MS Comic Sans", "Sans Serif"}
                }
            }
        }; 
    }
}