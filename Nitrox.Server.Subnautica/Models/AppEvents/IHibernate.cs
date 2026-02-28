using Nitrox.Server.Subnautica.Models.AppEvents.Core;
using Nitrox.Server.Subnautica.Models.AppEvents.Triggers;

namespace Nitrox.Server.Subnautica.Models.AppEvents;

internal interface IHibernate : IEvent<IHibernate.SleepArgs>, IEvent<IHibernate.WakeArgs>
{
    public sealed record SleepArgs;

    public sealed record WakeArgs;

    public sealed class SleepTrigger(Func<IEvent<SleepArgs>[]> lazyHandlersProvider) : SequentialEmptyArgsTrigger<SleepArgs>(lazyHandlersProvider);

    public sealed class WakeTrigger(Func<IEvent<WakeArgs>[]> lazyHandlersProvider) : SequentialEmptyArgsTrigger<WakeArgs>(lazyHandlersProvider);
}
