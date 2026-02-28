namespace Nitrox.Test.Helper.Faker;

public sealed class NitroxNullableFaker : NitroxFaker, INitroxFaker
{
    private readonly Func<HashSet<Type>, object> generateAction;

    public NitroxNullableFaker(Type type)
    {
        OutputType = type.GenericTypeArguments[0];
        generateAction = (typeTree) =>
        {
            MethodInfo castMethod = CastMethodBase.MakeGenericMethod(OutputType);
            object castedObject = castMethod.Invoke(null, [GetOrCreateFaker(OutputType).GenerateUnsafe(typeTree)]);

            Type nullableType = typeof(Nullable<>).MakeGenericType(OutputType);
            return Activator.CreateInstance(nullableType, castedObject);
        };
    }

    public INitroxFaker[] GetSubFakers() => [GetOrCreateFaker(OutputType)];

    public object GenerateUnsafe(HashSet<Type> typeTree) => generateAction.Invoke(typeTree);
}
