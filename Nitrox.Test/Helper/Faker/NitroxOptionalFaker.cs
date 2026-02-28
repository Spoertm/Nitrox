using Nitrox.Model.DataStructures;

namespace Nitrox.Test.Helper.Faker;

public sealed class NitroxOptionalFaker : NitroxFaker, INitroxFaker
{
    private readonly Func<HashSet<Type>, object> generateAction;

    public NitroxOptionalFaker(Type type)
    {
        OutputType = type.GenericTypeArguments[0];
        generateAction = (typeTree) =>
        {
            MethodInfo castMethod = CastMethodBase.MakeGenericMethod(OutputType);
            object castedObject = castMethod.Invoke(null, [GetOrCreateFaker(OutputType).GenerateUnsafe(typeTree)]);

            Type optionalType = typeof(Optional<>).MakeGenericType(OutputType);
            return Activator.CreateInstance(optionalType, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.CreateInstance, null, [castedObject], null);
        };
    }

    public INitroxFaker[] GetSubFakers() => [GetOrCreateFaker(OutputType)];

    public object GenerateUnsafe(HashSet<Type> typeTree) => generateAction.Invoke(typeTree);
}
