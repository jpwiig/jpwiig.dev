using MudBlazor;

namespace BlazorApp1;

public class Theme
{
    private MudTheme? myTheme { get; set; }

    public MudTheme getTheme()
    {
        return myTheme = new MudTheme()
        {
            
            PaletteLight = new PaletteLight()
            {
                Primary = "#3D4552",
                Background = "#FFFFFF"
            },
            Typography = new Typography()
            {
                Default = new Default()
                {
                    FontFamily = new[]
                    {
                      "Poppins", "Sans Serif"
                    },
                    
                }
            }
        };
    }
}