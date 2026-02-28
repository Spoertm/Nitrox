using System;

namespace Nitrox.Launcher.Models.Exceptions;

public sealed class DuplicateSingularApplicationException(string applicationName) : Exception($"An instance of {applicationName} is already running");
