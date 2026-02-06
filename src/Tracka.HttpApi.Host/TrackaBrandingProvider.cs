using Microsoft.Extensions.Localization;
using Tracka.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Tracka;

[Dependency(ReplaceServices = true)]
public class TrackaBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<TrackaResource> _localizer;

    public TrackaBrandingProvider(IStringLocalizer<TrackaResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
