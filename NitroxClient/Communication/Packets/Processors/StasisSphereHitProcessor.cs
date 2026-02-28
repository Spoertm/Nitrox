using Nitrox.Model.Subnautica.Packets;
using NitroxClient.Communication.Packets.Processors.Core;
using NitroxClient.GameLogic;

namespace NitroxClient.Communication.Packets.Processors;

internal sealed class StasisSphereHitProcessor(BulletManager bulletManager) : IClientPacketProcessor<StasisSphereHit>
{
    public Task Process(ClientProcessorContext context, StasisSphereHit packet)
    {
        bulletManager.StasisSphereHit(packet.SessionId, packet.Position.ToUnity(), packet.Rotation.ToUnity(), packet.ChargeNormalized, packet.Consumption);
        return Task.CompletedTask;
    }
}
