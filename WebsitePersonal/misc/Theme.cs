using MudBlazor;

namespace BlazorApp1;

public class Theme
{
    private MudTheme myTheme { get; set; }

    public MudTheme getTheme()
    {
        return myTheme = new MudTheme()
        {
            Palette = new PaletteLight()
            {
                Background = Colors.Blue.Default
            },
            Typography = new Typography()
            {
                Default = new Default()
                {
                    FontFamily = new[]
                    {
                      "Poppins", "Sans Serif"
                    }
                }
            }
        };
    }
}