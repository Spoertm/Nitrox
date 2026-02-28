using System.ComponentModel;
using Nitrox.Model.DataStructures.GameLogic;
using Nitrox.Server.Subnautica.Models.Commands.Core;

namespace Nitrox.Server.Subnautica.Models.Commands;

[RequiresPermission(Perms.HOST)]
internal sealed class ChangeAdminPasswordCommand(IOptions<SubnauticaServerOptions> options, ILogger<ChangeAdminPasswordCommand> logger) : ICommandHandler<string>
{
    [Description("Changes admin password")]
    public Task Execute(ICommandContext context, string newPassword)
    {
        options.Value.AdminPassword = newPassword;
        logger.ZLogInformation($"Admin password changed to '{newPassword:@Password}'");
        return Task.CompletedTask;
    }
}
