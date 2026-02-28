using Nitrox.Model.Subnautica.Packets;
using NitroxClient.Communication.Packets.Processors.Core;
using NitroxClient.GameLogic;

namespace NitroxClient.Communication.Packets.Processors;

internal sealed class KeepInventoryChangedProcessor(LocalPlayer localPlayer) : IClientPacketProcessor<KeepInventoryChanged>
{
    public Task Process(ClientProcessorContext context, KeepInventoryChanged packet)
    {
        localPlayer.KeepInventoryOnDeath = packet.KeepInventoryOnDeath;
        return Task.CompletedTask;
    }
}
