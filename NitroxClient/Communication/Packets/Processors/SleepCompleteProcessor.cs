using Nitrox.Model.Subnautica.Packets;
using NitroxClient.Communication.Packets.Processors.Core;
using NitroxClient.GameLogic;

namespace NitroxClient.Communication.Packets.Processors;

internal sealed class SleepCompleteProcessor(SleepManager sleepManager) : IClientPacketProcessor<SleepComplete>
{
    public Task Process(ClientProcessorContext context, SleepComplete packet)
    {
        sleepManager.OnSleepComplete();
        return Task.CompletedTask;
    }
}
